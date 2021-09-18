# STL (file format)

From Wikipedia, the free encyclopedia

[Jump to navigation](https://en.wikipedia.org/wiki/STL_(file_format)#mw-head)[Jump to search](https://en.wikipedia.org/wiki/STL_(file_format)#searchInput)

For other uses, see [STL](https://en.wikipedia.org/wiki/STL_(disambiguation)).

| [![The differences between CAD and STL Models.svg](https://upload.wikimedia.org/wikipedia/commons/thumb/a/a6/The_differences_between_CAD_and_STL_Models.svg/300px-The_differences_between_CAD_and_STL_Models.svg.png)](https://en.wikipedia.org/wiki/File:The_differences_between_CAD_and_STL_Models.svg)A CAD representation of a [torus](https://en.wikipedia.org/wiki/Torus) (shown as two concentric red circles) and an STL approximation of the same shape (composed of triangular planes) |                                                              |
| :----------------------------------------------------------- | ------------------------------------------------------------ |
| [Filename extension](https://en.wikipedia.org/wiki/Filename_extension) | .stl                                                         |
| [Internet media type](https://en.wikipedia.org/wiki/Media_type) | `model/stl``model/x.stl-ascii``model/x.stl-binary`           |
| Developed by                                                 | [3D Systems](https://en.wikipedia.org/wiki/3D_Systems)       |
| Initial release                                              | 1987                                                         |
| Type of format                                               | [Stereolithography](https://en.wikipedia.org/wiki/Stereolithography) |

**STL** is a [file format](https://en.wikipedia.org/wiki/File_format) native to the [stereolithography](https://en.wikipedia.org/wiki/Stereolithography) [CAD](https://en.wikipedia.org/wiki/Computer-aided_design) software created by [3D Systems](https://en.wikipedia.org/wiki/3D_Systems).[[1\]](https://en.wikipedia.org/wiki/STL_(file_format)#cite_note-1)[[2\]](https://en.wikipedia.org/wiki/STL_(file_format)#cite_note-2)[[3\]](https://en.wikipedia.org/wiki/STL_(file_format)#cite_note-3) STL has several [backronyms](https://en.wikipedia.org/wiki/Backronym) such as "Standard Triangle Language" and "Standard [Tessellation](https://en.wikipedia.org/wiki/Tessellation) Language".[[4\]](https://en.wikipedia.org/wiki/STL_(file_format)#cite_note-4) This file format is supported by many other software packages; it is widely used for [rapid prototyping](https://en.wikipedia.org/wiki/Rapid_prototyping), [3D printing](https://en.wikipedia.org/wiki/3D_printing) and [computer-aided manufacturing](https://en.wikipedia.org/wiki/Computer-aided_manufacturing).[[5\]](https://en.wikipedia.org/wiki/STL_(file_format)#cite_note-5) STL files describe only the surface geometry of a three-dimensional object without any representation of color, texture or other common CAD model attributes. The STL format specifies both [ASCII](https://en.wikipedia.org/wiki/ASCII) and [binary](https://en.wikipedia.org/wiki/Binary_file) representations. Binary files are more common, since they are more compact.[[6\]](https://en.wikipedia.org/wiki/STL_(file_format)#cite_note-burns-6)

An STL file describes a raw, unstructured [triangulated](https://en.wikipedia.org/wiki/Triangulation_(geometry)) surface by the [unit](https://en.wikipedia.org/wiki/Unit_vector) [normal](https://en.wikipedia.org/wiki/Surface_normal) and vertices (ordered by the [right-hand rule](https://en.wikipedia.org/wiki/Right-hand_rule)) of the triangles using a three-dimensional [Cartesian coordinate system](https://en.wikipedia.org/wiki/Cartesian_coordinate_system). In the original specification, all STL coordinates were required to be positive numbers, but this restriction is no longer enforced and negative coordinates are commonly encountered in STL files today. STL files contain no scale information, and the units are arbitrary.[[7\]](https://en.wikipedia.org/wiki/STL_(file_format)#cite_note-7)

## Contents



- [1ASCII STL](https://en.wikipedia.org/wiki/STL_(file_format)#ASCII_STL)
- [2Binary STL](https://en.wikipedia.org/wiki/STL_(file_format)#Binary_STL)
- [3Color in binary STL](https://en.wikipedia.org/wiki/STL_(file_format)#Color_in_binary_STL)
- [4The facet normal](https://en.wikipedia.org/wiki/STL_(file_format)#The_facet_normal)
- [5Use in 3D printing](https://en.wikipedia.org/wiki/STL_(file_format)#Use_in_3D_printing)
- [6Use in other fields](https://en.wikipedia.org/wiki/STL_(file_format)#Use_in_other_fields)
- [7Representation of curved surfaces](https://en.wikipedia.org/wiki/STL_(file_format)#Representation_of_curved_surfaces)
- [8History](https://en.wikipedia.org/wiki/STL_(file_format)#History)
- [9See also](https://en.wikipedia.org/wiki/STL_(file_format)#See_also)
- [10References](https://en.wikipedia.org/wiki/STL_(file_format)#References)
- [11External links](https://en.wikipedia.org/wiki/STL_(file_format)#External_links)

## ASCII STL[[edit](https://en.wikipedia.org/w/index.php?title=STL_(file_format)&action=edit&section=1)]

An ASCII STL file begins with the line

```
solid name
```

where *name* is an optional string (though if *name* is omitted there must still be a space after solid). The file continues with any number of triangles, each represented as follows:

```
facet normal ni nj nk
    outer loop
        vertex v1x v1y v1z
        vertex v2x v2y v2z
        vertex v3x v3y v3z
    endloop
endfacet
```

where each *n* or *v* is a [floating-point number](https://en.wikipedia.org/wiki/Floating-point_number) in sign-[mantissa](https://en.wikipedia.org/wiki/Significand)-"e"-sign-[exponent](https://en.wikipedia.org/wiki/Exponent) format, e.g., "2.648000e-002". The file concludes with

```
endsolid name
```

[![img](https://upload.wikimedia.org/wikipedia/commons/thumb/b/b1/Sphericon.stl/220px-Sphericon.stl.png)](https://en.wikipedia.org/wiki/File:Sphericon.stl)

An example [ASCII STL](https://upload.wikimedia.org/wikipedia/commons/b/b1/Sphericon.stl) of a [sphericon](https://en.wikipedia.org/wiki/Sphericon)

The structure of the format suggests that other possibilities exist (e.g., facets with more than one "loop", or loops with more than three vertices). In practice, however, all facets are simple triangles.

White space (spaces, tabs, newlines) may be used anywhere in the file except within numbers or words. The spaces between "facet" and "normal" and between "outer" and "loop" are required.[[6\]](https://en.wikipedia.org/wiki/STL_(file_format)#cite_note-burns-6)

## Binary STL[[edit](https://en.wikipedia.org/w/index.php?title=STL_(file_format)&action=edit&section=2)]

Because ASCII STL files can be very large, a binary version of STL exists. A binary STL file has an 80-character header (which is generally ignored, but should never begin with "solid" because that may lead some software to assume that this is an ASCII STL file). Following the header is a 4-byte [little-endian](https://en.wikipedia.org/wiki/Little-endian) unsigned integer indicating the number of triangular facets in the file. Following that is data describing each triangle in turn. The file simply ends after the last triangle.

Each triangle is described by twelve 32-bit floating-point numbers: three for the normal and then three for the X/Y/Z coordinate of each vertex – just as with the ASCII version of STL. After these follows a 2-byte ("short") unsigned integer that is the "attribute byte count" – in the standard format, this should be zero because most software does not understand anything else.[[6\]](https://en.wikipedia.org/wiki/STL_(file_format)#cite_note-burns-6)

Floating-point numbers are represented as [IEEE floating-point](https://en.wikipedia.org/wiki/IEEE_floating-point) numbers and are assumed to be [little-endian](https://en.wikipedia.org/wiki/Little-endian), although this is not stated in documentation.

```
UINT8[80]    – Header                 -     80 bytes                           
UINT32       – Number of triangles    -      4 bytes

foreach triangle                      - 50 bytes:
    REAL32[3] – Normal vector             - 12 bytes
    REAL32[3] – Vertex 1                  - 12 bytes
    REAL32[3] – Vertex 2                  - 12 bytes
    REAL32[3] – Vertex 3                  - 12 bytes
    UINT16    – Attribute byte count      -  2 bytes
end
```

## Color in binary STL[[edit](https://en.wikipedia.org/w/index.php?title=STL_(file_format)&action=edit&section=3)]

There are at least two non-standard variations on the binary STL format for adding color information:

- The VisCAM and SolidView software packages use the two "attribute byte count" bytes at the end of every triangle to store a 15-bit

   

  RGB

   

  color:

  - bits 0 to 4 are the intensity level for blue (0 to 31),
  - bits 5 to 9 are the intensity level for green (0 to 31),
  - bits 10 to 14 are the intensity level for red (0 to 31),
  - bit 15 is 1 if the color is valid, or 0 if the color is not valid (as with normal STL files).

- The Materialise Magics software uses the 80-byte header at the top of the file to represent the overall color of the entire part. If color is used, then somewhere in the header should be the

   

  ASCII

   

  string "COLOR=" followed by four bytes representing red, green, blue and

   

  alpha channel

   

  (transparency) in the range 0–255. This is the color of the entire object, unless overridden at each facet. Magics also recognizes a material description; a more detailed surface characteristic. Just after "COLOR=RGBA" specification should be another ASCII string ",MATERIAL=" followed by three colors (3×4 bytes): first is a color of

   

  diffuse reflection

  , second is a color of

   

  specular highlight

  , and third is an

   

  ambient light

  . Material settings are preferred over color. The per-facet color is represented in the two "attribute byte count" bytes as follows:

  - bits 0 to 4 are the intensity level for red (0 to 31),
  - bits 5 to 9 are the intensity level for green (0 to 31),
  - bits 10 to 14 are the intensity level for blue (0 to 31),
  - bit 15 is 0 if this facet has its own unique color, or 1 if the per-object color is to be used.

The red/green/blue ordering within those two bytes is reversed in these two approaches – so while these formats could easily have been compatible, the reversal of the order of the colors means that they are not – and worse still, a generic STL file reader cannot automatically distinguish between them. There is also no way to have facets be selectively transparent because there is no per-facet alpha value – although in the context of current rapid prototyping machinery, this is not important.

## The facet normal[[edit](https://en.wikipedia.org/w/index.php?title=STL_(file_format)&action=edit&section=4)]

In both ASCII and binary versions of STL, the [facet normal](https://en.wikipedia.org/wiki/Normal_(geometry)) should be a [unit vector](https://en.wikipedia.org/wiki/Unit_vector) pointing outwards from the solid object.[[8\]](https://en.wikipedia.org/wiki/STL_(file_format)#cite_note-8) In most software this may be set to (0,0,0), and the software will automatically calculate a normal based on the order of the triangle vertices using the "[right-hand rule](https://en.wikipedia.org/wiki/Right-hand_rule)", i.e. the vertices are listed in counter-clock-wise order from outside. Some STL loaders (e.g. the STL plugin for Art of Illusion) check that the normal in the file agrees with the normal they calculate using the right-hand rule and warn the user when it does not. Other software may ignore the facet normal entirely and use only the right-hand rule. Although it is rare to specify a normal that cannot be calculated using the right-hand rule, in order to be entirely portable, a file should both provide the facet normal and order the vertices appropriately. A notable exception is [SolidWorks](https://en.wikipedia.org/wiki/SolidWorks), which uses the normal for [shading effects](https://en.wikipedia.org/wiki/Shading).

## Use in 3D printing[[edit](https://en.wikipedia.org/w/index.php?title=STL_(file_format)&action=edit&section=5)]

[![img](https://upload.wikimedia.org/wikipedia/commons/thumb/b/b7/Wikipedia_puzzle_globe_3D_render.stl/220px-Wikipedia_puzzle_globe_3D_render.stl.png)](https://en.wikipedia.org/wiki/File:Wikipedia_puzzle_globe_3D_render.stl)

Wikipedia logo

[3D printers](https://en.wikipedia.org/wiki/3D_printing) build objects by solidifying (SLA, SLS, SHS, DMLS, EBM, DLP) or printing (3DP, MJM, FDM, FFF, PJP, MJS)[[9\]](https://en.wikipedia.org/wiki/STL_(file_format)#cite_note-9) one layer at a time. This requires a series of closed 2D contours (horizontal layers) that are filled in with solidified material as the layers are fused together. A natural file format for such a machine would be a series of closed polygons (layers or slices) corresponding to different Z-values. However, since it is possible to vary the layer thicknesses for a faster though less precise build, it was easier to define the model to be built as a closed [polyhedron](https://en.wikipedia.org/wiki/Polyhedron) that can be sliced at the necessary horizontal levels. An incorrect facet normal can affect the way a file is sliced and filled. A slice at a different Z-value can be chosen to miss a bad facet or the file must be returned to CAD program to make corrections and then regenerate the STL file.

The STL file format appears capable of defining a polyhedron with any polygonal facet, but in practice it is only ever used for triangles, which means that much of the syntax of the ASCII protocol is superfluous.

To properly form a 3D volume, the surface represented by any STL files must be closed (no holes or reversed vector normal) and connected, where every edge is part of exactly two triangles, and not self-intersecting. Since the STL syntax does not enforce this property, it can be ignored for applications where the void does not matter. The missing surface only matters insofar as the software that slices the triangles requires it to ensure that the resulting 2D polygons are closed. Sometimes such software can be written to clean up small discrepancies by moving vertices that are close together so that they coincide. The results are not predictable, may be sufficient of the surface must be repaired using another program. Vector 3D printers require a clean .STL file and printing a bad data file will either fail to fill or may stop printing.

## Use in other fields[[edit](https://en.wikipedia.org/w/index.php?title=STL_(file_format)&action=edit&section=6)]

[![img](https://upload.wikimedia.org/wikipedia/commons/thumb/9/93/Utah_teapot_%28solid%29.stl/250px-Utah_teapot_%28solid%29.stl.png)](https://en.wikipedia.org/wiki/File:Utah_teapot_(solid).stl)

[STL model](https://upload.wikimedia.org/wikipedia/commons/9/93/Utah_teapot_(solid).stl) of the [Utah teapot](https://en.wikipedia.org/wiki/Utah_teapot) viewed in the [MediaWiki 3D extension](https://mediawiki.org/wiki/Extension:3D)

STL file format is simple and easy to output. Consequently, many [computer-aided design](https://en.wikipedia.org/wiki/Computer-aided_design) systems can output the STL file format. Although the output is simple to produce, mesh connectivity information is discarded because the identity of shared vertices is lost.

Many [computer-aided manufacturing](https://en.wikipedia.org/wiki/Computer-aided_manufacturing) systems require triangulated models. STL format is not the most memory- and computationally efficient method for transferring this data, but STL is often used to import the triangulated geometry into the [CAM](https://en.wikipedia.org/wiki/Computer-aided_manufacturing) system. The format is commonly available, so the CAM system will use it. In order to use the data, the CAM system may have to reconstruct the connectivity. As STL files do not save the physical dimension of a unit, a CAM system will ask for it. Typical units are mm and inch.

STL can also be used for interchanging data between CAD/CAM systems and computational environments such as [Mathematica](https://en.wikipedia.org/wiki/Mathematica).

## Representation of curved surfaces[[edit](https://en.wikipedia.org/w/index.php?title=STL_(file_format)&action=edit&section=7)]

It is not possible to use triangles to perfectly represent curved surfaces. To compensate, users often save enormous STL files to reduce the inaccuracy. However, native formats associated with many 3D design software use [mathematical surfaces](https://en.wikipedia.org/wiki/Surface_(topology)) to preserve detail losslessly in small files. For example, [Rhino 3D](https://en.wikipedia.org/wiki/Rhino_3d)[[10\]](https://en.wikipedia.org/wiki/STL_(file_format)#cite_note-10) and [Blender](https://en.wikipedia.org/wiki/Blender_(software))[[11\]](https://en.wikipedia.org/wiki/STL_(file_format)#cite_note-11) implement [NURBS](https://en.wikipedia.org/wiki/Nurbs) to create true curved surfaces and store them in their respective native file formats, but must generate a triangle mesh when exporting a model to the STL format.

## History[[edit](https://en.wikipedia.org/w/index.php?title=STL_(file_format)&action=edit&section=8)]

STL was invented by the Albert Consulting Group for [3D Systems](https://en.wikipedia.org/wiki/3D_Systems) in 1987.[[12\]](https://en.wikipedia.org/wiki/STL_(file_format)#cite_note-All3DP-12) The format was developed for 3D Systems' first commercial 3D printers. Since its initial release, the format remained relatively unchanged for 22 years.[[13\]](https://en.wikipedia.org/wiki/STL_(file_format)#cite_note-stl2-13)

In 2009, an update to the format, dubbed STL 2.0, was proposed. It evolved into the [Additive manufacturing file format](https://en.wikipedia.org/wiki/Additive_manufacturing_file_format).[[13\]](https://en.wikipedia.org/wiki/STL_(file_format)#cite_note-stl2-13)[[14\]](https://en.wikipedia.org/wiki/STL_(file_format)#cite_note-14)

## See also[[edit](https://en.wikipedia.org/w/index.php?title=STL_(file_format)&action=edit&section=9)]

- [3D Manufacturing Format](https://en.wikipedia.org/wiki/3D_Manufacturing_Format) (3MF), a standard for 3D file manufacturing
- [Additive Manufacturing File Format](https://en.wikipedia.org/wiki/Additive_Manufacturing_File_Format) (AMF), a standard with support for color, multiple materials, and constellations
- [PLY (file format)](https://en.wikipedia.org/wiki/PLY_(file_format)), an alternative file format
- [Voxel](https://en.wikipedia.org/wiki/Voxel)
- [Wavefront .obj file](https://en.wikipedia.org/wiki/Wavefront_.obj_file), a 3D geometry definition file format with ***.obj*** file extension
- [X3D](https://en.wikipedia.org/wiki/X3D), a royalty-free ISO standard for 3D computer graphics

## References[[edit](https://en.wikipedia.org/w/index.php?title=STL_(file_format)&action=edit&section=10)]

1. **[^](https://en.wikipedia.org/wiki/STL_(file_format)#cite_ref-1)** *StereoLithography Interface Specification*, 3D Systems, Inc., July 1988
2. **[^](https://en.wikipedia.org/wiki/STL_(file_format)#cite_ref-2)** *StereoLithography Interface Specification*, 3D Systems, Inc., October 1989
3. **[^](https://en.wikipedia.org/wiki/STL_(file_format)#cite_ref-3)** *SLC File Specification*, 3D Systems, Inc., 1994
4. **[^](https://en.wikipedia.org/wiki/STL_(file_format)#cite_ref-4)** Grimm, Todd (2004), [*User's Guide to Rapid Prototyping*](https://books.google.com/books?id=o2B7OmABPNUC&pg=PA55), [Society of Manufacturing Engineers](https://en.wikipedia.org/wiki/Society_of_Manufacturing_Engineers), p. 55, [ISBN](https://en.wikipedia.org/wiki/ISBN_(identifier)) [0-87263-697-6](https://en.wikipedia.org/wiki/Special:BookSources/0-87263-697-6). Many names are used for the format: for example, "standard triangle language", "stereolithography language", and "stereolithography tesselation language". Page 55 states, "[Chuck Hull](https://en.wikipedia.org/wiki/Chuck_Hull), the inventor of stereolithography and 3D Systems' founder, reports that the file extension is for stereolithography."
5. **[^](https://en.wikipedia.org/wiki/STL_(file_format)#cite_ref-5)** Chua, C. K; Leong, K. F.; Lim, C. S. (2003), *Rapid Prototyping: Principles and Applications*(2nd ed.), World Scientific Publishing Co, [ISBN](https://en.wikipedia.org/wiki/ISBN_(identifier)) [981-238-117-1](https://en.wikipedia.org/wiki/Special:BookSources/981-238-117-1) Chapter 6, Rapid Prototyping Formats. Page 237, "The STL (STeroLithography) file, as the de facto standard, has been used in many, if not all, rapid prototyping systems." Section 6.2 STL File Problems. Section 6.4 STL File Repair.
6. ^ [Jump up to:***a***](https://en.wikipedia.org/wiki/STL_(file_format)#cite_ref-burns_6-0) [***b***](https://en.wikipedia.org/wiki/STL_(file_format)#cite_ref-burns_6-1) [***c***](https://en.wikipedia.org/wiki/STL_(file_format)#cite_ref-burns_6-2) Burns, Marshall (1993). *Automated Fabrication*. Prentice Hall. [ISBN](https://en.wikipedia.org/wiki/ISBN_(identifier)) [978-0-13-119462-5](https://en.wikipedia.org/wiki/Special:BookSources/978-0-13-119462-5).
7. **[^](https://en.wikipedia.org/wiki/STL_(file_format)#cite_ref-7)** fabbers.com Historical resource on 3D printing, The StL Format: Standard Data Format for Fabbers, reprinted from Marshall Burns, Automated Fabrication, http://www.ennex.com/~fabbers/StL.asp stating, "The object represented must be located in the all-positive octant. In other words, all vertex coordinates must be positive-definite (nonnegative and nonzero) numbers. The StL file does not contain any scale information; the coordinates are in arbitrary units."
8. **[^](https://en.wikipedia.org/wiki/STL_(file_format)#cite_ref-8)** Peddie, Jon. (2013). [*The history of visual magic in computers : how beautiful images are made in CAD, 3D, VR and AR*](https://www.worldcat.org/oclc/849634980). London: Springer. pp. 54–57. [ISBN](https://en.wikipedia.org/wiki/ISBN_(identifier)) [978-1-4471-4932-3](https://en.wikipedia.org/wiki/Special:BookSources/978-1-4471-4932-3). [OCLC](https://en.wikipedia.org/wiki/OCLC_(identifier)) [849634980](https://www.worldcat.org/oclc/849634980).
9. **[^](https://en.wikipedia.org/wiki/STL_(file_format)#cite_ref-9)** Barnatt, Christopher, 1967- (2013). [*3D printing : the next industrial revolution*](https://www.worldcat.org/oclc/854672031). [Nottingham, England?]: ExplainingTheFuture.com. pp. 26–71. [ISBN](https://en.wikipedia.org/wiki/ISBN_(identifier)) [978-1-4841-8176-8](https://en.wikipedia.org/wiki/Special:BookSources/978-1-4841-8176-8). [OCLC](https://en.wikipedia.org/wiki/OCLC_(identifier)) [854672031](https://www.worldcat.org/oclc/854672031).
10. **[^](https://en.wikipedia.org/wiki/STL_(file_format)#cite_ref-10)** ["What are NURBS?"](https://www.rhino3d.com/features/nurbs/). *www.rhino3d.com*. Retrieved 2021-06-25.
11. **[^](https://en.wikipedia.org/wiki/STL_(file_format)#cite_ref-11)** ["Structure — Blender Manual"](https://docs.blender.org/manual/en/latest/modeling/surfaces/structure.html). *docs.blender.org*. Retrieved 2021-06-25.
12. **[^](https://en.wikipedia.org/wiki/STL_(file_format)#cite_ref-All3DP_12-0)** ["STL File Format for 3D Printing - Explained in Simple Terms"](https://all3dp.com/what-is-stl-file-format-extension-3d-printing/). *All3DP*. 17 November 2016. Retrieved 5 May 2017.
13. ^ [Jump up to:***a***](https://en.wikipedia.org/wiki/STL_(file_format)#cite_ref-stl2_13-0) [***b***](https://en.wikipedia.org/wiki/STL_(file_format)#cite_ref-stl2_13-1) ["STL 2.0 May Replace Old, Limited File Format"](http://www.rapidtoday.com/stl-file-format.html). *RapidToday*. Retrieved 5 May 2017.
14. **[^](https://en.wikipedia.org/wiki/STL_(file_format)#cite_ref-14)** Hiller, Jonathan D.; Lipson, Hod (2009). [*STL 2.0: A Proposal for a Universal Multi-Material Additive Manufacturing File Format*](https://web.archive.org/web/20200611234339/https://sffsymposium.engr.utexas.edu/Manuscripts/2009/2009-23-Hiller.pdf) (PDF). Solid Freeform Fabrication Symposium (SFF'09). Austin, TX, USA: Cornell University. Archived from [the original](https://sffsymposium.engr.utexas.edu/Manuscripts/2009/2009-23-Hiller.pdf) (PDF) on 2020-06-11. Retrieved 5 May 2017.
