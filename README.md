# STL-Sharp
easy read stl Binary file

# HOW TO USE 

 1. download STL.cs and copy into your project. 
 2. using following lines to create an readable obj

```C#
    string fileName = @"D:\xxx\xxx\sample.stl";
    using(var fs = System.IO.File.OpenRead(fileName)
    {
      var stl = STL.CreateFromBinary(fs);
      //do something you want.
    }
```

 3. create save an stl file. 

```C#
    var stl = STL.CreateEmpty();
    stl.header = new STL_Header("hinx_test_stl");
    stl.triangles = new STL_Triangle[] { new STL_Triangle {
       Normal = new float[]{ 0,1,0},
       Vertex1 = new float[]{ 0,0,0},
       Vertex2 = new float[]{ 1,0,0},
       Vertex3 = new float[]{ 0,0,1},
       AttrData = 0
    } };
    stl.TriangleCount = 1;
    using (var fs = System.IO.File.Create("triangle.stl"))
       stl.SaveToBinary(fs);
```

 4. enjoy.


# Docoments

 [FDD000505](https://www.loc.gov/preservation/digital/formats/fdd/fdd000505.shtml) from LOC.GOV
 
 [STL Format](https://en.wikipedia.org/wiki/STL_(file_format)) from WIKI
