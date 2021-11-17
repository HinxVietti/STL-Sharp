using System;

static class STLUTil
{
    public static void SaveToBinary(this STL vol, System.IO.Stream stream)
    {
        try
        {
            if (vol == null)
                return;
            if (stream == null)
                return;
            if (!vol.VerifyData())
                return;

            stream.Position = 0;

            var head = vol.header;
            stream.Write(head.data, 0, head.data.Length);
            int count = vol.TriangleCount;
            var countData = BitConverter.GetBytes(count);
            stream.Write(countData, 0, 4);

            for (int i = 0; i < count; i++)
            {
                var triangle = vol.triangles[i];
                var data = triangle.GetRawData();
                stream.Write(data, 0, STL_Triangle.TriangleRawDataLength);
            }
            stream.Flush();
        }
        catch (Exception e)
        {
            //return null;
            throw e;
        }
    }
}
