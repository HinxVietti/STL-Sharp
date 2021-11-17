using System;
using System.Text;

public class STL
{
    public const int TriangleCountRawDataLength = 4;
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



    public static STL CreateEmpty()
    {
        return new STL();
    }

    public static STL CreateFromBinary(System.IO.Stream stream)
    {
        try
        {
            // header 80 + count 4 + (Triangle 50) * count
            int minSize = STL_Header.STL_HEADER_SIZE + TriangleCountRawDataLength + STL_Triangle.TriangleRawDataLength;
            if (stream == null || stream.Length < minSize)
                throw new STLStreamNotLegalException($"NOT AN LEGAL STL , STREAM SIZE Lessthan {minSize}");

            var header = new byte[STL_Header.STL_HEADER_SIZE];
            var count = new byte[TriangleCountRawDataLength];
            var triArr = new byte[STL_Triangle.TriangleRawDataLength];

            stream.Position = 0;
            stream.Read(header, 0, header.Length);
            stream.Read(count, 0, count.Length);

            int numbers = BitConverter.ToInt32(count, 0);
            var preferSize = numbers * STL_Triangle.TriangleRawDataLength + TriangleCountRawDataLength + STL_Header.STL_HEADER_SIZE;// 4 : int -> byte[4]
            if (preferSize != stream.Length)
                throw new STLStreamNotLegalException("NOT AN LEGAL STL SIZE STREAM (stream.Length must equals 84+50*N , N Means triangle count)");

            var tar = new STL();
            tar.header = new STL_Header(header);
            tar.TriangleCount = numbers;
            tar.triangles = new STL_Triangle[numbers];

            for (int i = 0; i < numbers; i++)
            {
                stream.Read(triArr, 0, STL_Triangle.TriangleRawDataLength);
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

    public bool VerifyData()
    {
        if (header == null)
            header = new STL_Header("stl_file_default_title");
        if (triangles == null)
            return false;
        if (triangles.Length != this.TriangleCount)
            return false;
        return true;
    }
}


public class STL_Header
{
    public const int STL_HEADER_SIZE = 80;
    public byte[] data;

    public STL_Header(byte[] data)
    {
        this.data = data;
    }

    public STL_Header(string v)
    {
        data = new byte[STL_HEADER_SIZE];
        if (!string.IsNullOrEmpty(v))
        {
            var dat = Encoding.UTF8.GetBytes(v);
            if (dat.Length > STL_HEADER_SIZE)
            {
                for (int i = 0; i < STL_HEADER_SIZE; i++)
                    data[i] = dat[i];
            }
            else
                dat.CopyTo(data, 0);
        }
    }

    public byte[] GetVerifiedData()
    {
        if (data != null)
        {
            if (data.Length == STL_HEADER_SIZE)
                return data;
        }
        return new byte[STL_HEADER_SIZE];
    }

    public override string ToString()
    {
        return Encoding.Default.GetString(data);
    }
}



public class STL_Triangle
{
    public const int TriangleRawDataLength = 50;

    public float[] Normal;
    public float[] Vertex1;
    public float[] Vertex2;
    public float[] Vertex3;
    public ushort AttrData;


    public STL_Triangle()
    {
        Normal = new float[3];
        Vertex1 = new float[3];
        Vertex2 = new float[3];
        Vertex3 = new float[3];
    }

    internal byte[] GetRawData()
    {
        var data = new byte[TriangleRawDataLength];
        Func<float, byte[]> _toBytes = val => BitConverter.GetBytes(val);
        Func<float[], byte[]> _vectorToBytes = v =>
        {
            var arr = new byte[12];
            _toBytes(v[0]).CopyTo(arr, 0);
            _toBytes(v[1]).CopyTo(arr, 4);
            _toBytes(v[2]).CopyTo(arr, 8);
            return arr;
        };
        _vectorToBytes(Normal).CopyTo(data, 0);
        _vectorToBytes(Vertex1).CopyTo(data, 12);
        _vectorToBytes(Vertex2).CopyTo(data, 24);
        _vectorToBytes(Vertex3).CopyTo(data, 36);
        BitConverter.GetBytes(AttrData).CopyTo(data, 48);
        return data;
    }

    public static STL_Triangle Create(byte[] data)
    {
        if (data != null && data.Length == TriangleRawDataLength)
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
