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
 3. enjoy.


# Docoments

 [FDD000505](https://www.loc.gov/preservation/digital/formats/fdd/fdd000505.shtml) from LOC.GOV
 
 [STL Format](https://en.wikipedia.org/wiki/STL_(file_format)) from WIKI
