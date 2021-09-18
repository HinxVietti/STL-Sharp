using System;



public class STL
{
    public STL_Header header;
    public int TriangleCount;
    public STL_Triangle[] triangles;



    public class STLStreamNotLegalException : Exception
    {
        private string txt;
        public override string Message => txt;

        public STLStreamNotLegalException(string message = "")
        {
            txt = message;
        }
    }

    private STL()
    { }

    public static STL CreateFromBinary(System.IO.Stream stream)
    {
        try
        {
            int minSize = 80 + 4 + 50;
            if (stream == null || stream.Length < minSize)
                throw new STLStreamNotLegalException($"NOT AN LEGAL STL , STREAM SIZE Lessthan {minSize}");

            var header = new byte[80];
            var count = new byte[4];
            var triArr = new byte[50];

            stream.Position = 0;
            stream.Read(header, 0, header.Length);
            stream.Read(count, 0, count.Length);

            int numbers = BitConverter.ToInt32(count, 0);
            var preferSize = numbers * 50 + 84;
            if (preferSize != stream.Length)
                throw new STLStreamNotLegalException("NOT AN LEGAL STL SIZE STREAM (stream.Length must equals 84+50*N , N Means triangle count)");

            var tar = new STL();
            tar.header = new STL_Header(header);
            tar.TriangleCount = numbers;
            tar.triangles = new STL_Triangle[numbers];

            for (int i = 0; i < numbers; i++)
            {
                stream.Read(triArr, 0, 50);
                tar.triangles[i] = STL_Triangle.Create(triArr);
                //yield
            }
            return tar;
        }
        catch (Exception e)
        {
            //return null;
            throw e;
        }
    }

}


public class STL_Header
{
    public byte[] data;

    public STL_Header(byte[] data)
    {
        this.data = data;
    }

    public override string ToString()
    {
        return System.Text.Encoding.Default.GetString(data);
    }
}



public class STL_Triangle
{
    public float[] Normal;
    public float[] Vertex1;
    public float[] Vertex2;
    public float[] Vertex3;
    public ushort AttrData;


    private STL_Triangle()
    {
        Normal =  new float[3];
        Vertex1 = new float[3];
        Vertex2 = new float[3];
        Vertex3 = new float[3];
    }

    public static STL_Triangle Create(byte[] data)
    {
        if (data != null && data.Length == 50)
        {
            int position = 0;

            Func</*byte[], */float> _readFloat = () =>
            {
                position += 4;
                return BitConverter.ToSingle(data, position - 4);
            };

            var tar = new STL_Triangle();

            for (int i = 0; i < 3; i++)
                tar.Normal[i] = _readFloat();
            for (int i = 0; i < 3; i++)
                tar.Vertex1[i] = _readFloat();
            for (int i = 0; i < 3; i++)
                tar.Vertex2[i] = _readFloat();
            for (int i = 0; i < 3; i++)
                tar.Vertex3[i] = _readFloat();

            tar.AttrData = BitConverter.ToUInt16(data, 48);
            return tar;
        }
        return null;
    }
}
