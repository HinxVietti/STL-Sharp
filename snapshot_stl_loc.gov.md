## STL (STereoLithography) File Format, Binary

[>> Back](javascript:history.back())

**Table of Contents**

- [Identification and description](https://www.loc.gov/preservation/digital/formats/fdd/fdd000505.shtml#identification)
- [Local use](https://www.loc.gov/preservation/digital/formats/fdd/fdd000505.shtml#local)
- [Sustainability factors](https://www.loc.gov/preservation/digital/formats/fdd/fdd000505.shtml#sustainability)
- [Quality and functionality factors](https://www.loc.gov/preservation/digital/formats/fdd/fdd000505.shtml#factors)
- [File type signifiers](https://www.loc.gov/preservation/digital/formats/fdd/fdd000505.shtml#sign)
- [Notes](https://www.loc.gov/preservation/digital/formats/fdd/fdd000505.shtml#notes)
- [Format specifications](https://www.loc.gov/preservation/digital/formats/fdd/fdd000505.shtml#specs)
- [Useful references](https://www.loc.gov/preservation/digital/formats/fdd/fdd000505.shtml#useful)

**Format Description Properties [![Explanation of format description terms](https://www.loc.gov/preservation/digital/formats/fdd/info.gif)](https://www.loc.gov/preservation/digital/formats/fdd/fdd_explanation.shtml)**

- ID: fdd000505
- Short name: STL_binary
- Content categories: model
- Format Category: file-format, encoding
- Other facets: unitary, binary, structured, symbolic
- Last significant FDD update: 2019-09-17
- Draft status: Preliminary



### Identification and description [![Explanation of format description terms](https://www.loc.gov/preservation/digital/formats/fdd/info.gif)](https://www.loc.gov/preservation/digital/formats/fdd/fdd_explanation.shtml#identification)

| Full name                     | STL (STereoLithography) File Format, Binary.                 |
| :---------------------------- | ------------------------------------------------------------ |
| Description                   | The binary representation of the [STL (STereoLithography) file format](https://www.loc.gov/preservation/digital/formats/fdd/fdd000504.shtml) is a simple, openly documented format for describing the surface of an object as a triangular mesh. Since its introduction in the late 1980s, STL has become a de facto standard for [rapid prototyping](https://en.wikipedia.org/wiki/Rapid_prototyping) and [3D printing](https://en.wikipedia.org/wiki/3D_printing). For practical use, since its files are more compact, the binary variant is more common.See the format description for [STL_family](https://www.loc.gov/preservation/digital/formats/fdd/fdd000504.shtml) for general background and context for the STL format. This document focuses on details applicable only to the binary variant of STL.An STL_binary file consists of an 80 character header that can be used as a comment; the number of triangles as a 32-bit little-endian integer; and 50 bytes for each triangular facet. A facet is defined in twelve 32-bit floating-point numbers (little-endian): three for the unit normal vector, and three for the (X,Y,Z) coordinates of each vertex. For each triangle, these 48 bytes are followed by a 2-byte unsigned integer, apparently described in the original documentation as the *attribute byte count*. According to the [Wikipedia entry for the STL file format](https://en.wikipedia.org/wiki/STL_(file_format)#Binary_STL), the value for the *attribute byte count* "should be zero because most software does not understand anything else." The syntax of the binary variant is described in succinct tabular form at [StL Binary Format](https://www.fabbers.com/tech/STL_Format#Sct_binary) at fabbers.com; it also indicates that the *attribute byte count* should be zero. Formal machine-readable specifications of the STL_binary syntax are available at [stl grammar](https://github.com/synalysis/Grammars/blob/master/stl.grammar), in an XML-based form compatible with [Synalyze It!](http://www.synalysis.net/formats.xml) and [.stl file format](http://formats.kaitai.io/stl/index.html), in the [Kaitai Struct](http://kaitai.io/) language.The original specification for STL had no support for color; however, attempts have been made to extend the binary variant of STL to specify colors for triangles. The Wikipedia entry for the STL file format has a section with heading [Color in binary STL](https://en.wikipedia.org/wiki/STL_(file_format)#Color_in_binary_STL). It describes two conventions that employ the two *attribute byte count* bytes at the end of every triangle to encode the color for the triangle. Unfortunately, the convention reported as in use in VisCAM and SolidView software uses a different order for the red, blue, and green color components than the convention reported as used by the [Materialise Magics](https://www.loc.gov/preservation/digital/formats/fdd/fdd000505.shtml) 3D printing products and services. There is no way to determine automatically which convention has been used. Judging from questions asked on online forums related to 3D printing, color in STL files is a source of frustration. Responses usually recommend using a format that has a standardized method for encoding colors. See [Useful References](https://www.loc.gov/preservation/digital/formats/fdd/fdd000505.shtml#useful) below for a selection of other resources that mention the two options for color support in STL_binary.Compared with more recent formats for 3D models, STL has limited functionality. See [STL_family](https://www.loc.gov/preservation/digital/formats/fdd/fdd000504.shtml) for information on shortcomings of the STL format that apply to both variants of the STL file format. |
| Production phase              | See [STL_family](https://www.loc.gov/preservation/digital/formats/fdd/fdd000504.shtml). |
| Relationship to other formats |                                                              |
| Subtype of                    | [STL_family](https://www.loc.gov/preservation/digital/formats/fdd/fdd000504.shtml), STL (STereoLithography) File Format Family |
| Affinity to                   | [STL_ASCII](https://www.loc.gov/preservation/digital/formats/fdd/fdd000504.shtml), STL (STereoLithography) File Format, ASCII |



### Local use [![Explanation of format description terms](https://www.loc.gov/preservation/digital/formats/fdd/info.gif)](https://www.loc.gov/preservation/digital/formats/fdd/fdd_explanation.shtml#local)

| LC experience or existing holdings | See [STL_family](https://www.loc.gov/preservation/digital/formats/fdd/fdd000504.shtml). |
| :--------------------------------- | ------------------------------------------------------------ |
| LC preference                      | See [STL_family](https://www.loc.gov/preservation/digital/formats/fdd/fdd000504.shtml). |



### Sustainability factors [![Explanation of format description terms](https://www.loc.gov/preservation/digital/formats/fdd/info.gif)](https://www.loc.gov/preservation/digital/formats/fdd/fdd_explanation.shtml#sustainability)

| Disclosure                          | The STL file format was openly documented by its originator, Charles Hull of 3D Systems, Inc. Although STL can be considered proprietary, 3D Systems has encouraged its use. The format has not been maintained through a formal governance structure. |
| :---------------------------------- | ------------------------------------------------------------ |
| Documentation                       | Originally documented in *StereoLithography Interface Specification* in 1988 by 3D Systems, Inc. The compilers of this resource have been unable to locate a copy of the original specification and have relied on other descriptions of the format. Listed below (see [Useful References](https://www.loc.gov/preservation/digital/formats/fdd/fdd000505.shtml#useful)) are a number of sources with information about the format. [Comments welcome](https://www.loc.gov/preservation/digital/formats/contact_format.shtml). |
| Adoption                            | See [STL_family](https://www.loc.gov/preservation/digital/formats/fdd/fdd000504.shtml) on adoption of the STL format including both variants.Because many STL files would be unmanageably large in the ASCII variant of the format, most use of STL is in [STL_binary](https://www.loc.gov/preservation/digital/formats/fdd/fdd000505.shtml). However most software that can handle STL files can import or render models in both STL variants.In 2018, [Working Group 17](https://www.dicomstandard.org/wgs/wg-17/) for the Digital Imaging and Communications in Medicine ([DICOM](https://www.dicomstandard.org/wgs/wg-17/)) standard published [Supplement 205, DICOM Encapsulation of STL Models for 3D Manufacturing](ftp://medical.nema.org/medical/dicom/final/sup205_ft_DICOM_Encapsulation_of_STL_Models_for_3D_Manufacturing.pdf), which allows for the wrapping of a binary STL file in the standard DICOM container used for the communication and management of medical imaging information and related data. The supplement states, "The goal of encapsulating a Stereolithography (STL) 3D manufacturing model file inside a DICOM instance rather than transforming the data into a different representation is to facilitate preservation of the STL file in the exact form that it is used with extant manufacturing devices, while at the same time unambiguously associating it with the patient for whose care the model was created and the images from which the model was derived." |
| Licensing and patents               | There are no concerns about patents or licensing associated with the STL format. |
| Transparency                        | Files in the STL_binary format cannot be usefully studied or manipulated with a text editor. However, software to read and write its very simple structure would be straightforward to develop, for example, by taking advantage of the formal [specification of the .stl file format](http://formats.kaitai.io/stl/index.html) in the Kaitai Struct language, which can be used to generate a parsing libary in a variety of programming languages.Unfortunately, as shown in [Analysis of STL files](https://doi.org/10.1016/S0895-7177(03)90079-3) by M. Szilvśi-Nagy and Gy. Mátyási in 2003, the surface tessellation performed in CAD modelling software "frequently ends with errors in the [STL] data structure as gaps and holes leading to open loops in the cross-sections that cannot be manufactured as layers." Although an STL_binary file may be easy to read or manipulate as a sequence of numbers, that does not mean that it can be used for 3D printing without using a more sophisticated software tool to check the file and repair it if needed. There are many tools that offer to repair STL files; see [18 Best STL Repair Software Tools in 2019](https://all3dp.com/1/stl-repair-stl-file-online-checker-fix-3d-model/). |
| Self-documentation                  | The format provides no standard support for descriptive metadata. The format begins with an 80 character line that is sometimes used for a textual description of the model and its context. |
| External dependencies               | None                                                         |
| Technical protection considerations | None                                                         |



### Quality and functionality factors [![Explanation of format description terms](https://www.loc.gov/preservation/digital/formats/fdd/info.gif)](https://www.loc.gov/preservation/digital/formats/fdd/fdd_explanation.shtml#factors)

| Other               |                                                              |
| :------------------ | ------------------------------------------------------------ |
| 3D Model Geometry   | See [STL_family](https://www.loc.gov/preservation/digital/formats/fdd/fdd000504.shtml). |
| 3D Model Appearance | The documented specification for STL has no support for color, texture, or other appearance characteristics. As described in [Color in binary STL](https://en.wikipedia.org/wiki/STL_(file_format)#Color_in_binary_STL), two incompatible extensions to the format are in use to attach colors to triangular facets. See also [Description](https://www.loc.gov/preservation/digital/formats/fdd/fdd000505.shtml#identification) above and [Useful References](https://www.loc.gov/preservation/digital/formats/fdd/fdd000505.shtml#useful) below. |
| 3D Model Scene      | See [STL_family](https://www.loc.gov/preservation/digital/formats/fdd/fdd000504.shtml). |
| 3D Model Animation  | See [STL_family](https://www.loc.gov/preservation/digital/formats/fdd/fdd000504.shtml). |



### File type signifiers and format identifiers [![Explanation of format description terms](https://www.loc.gov/preservation/digital/formats/fdd/info.gif)](https://www.loc.gov/preservation/digital/formats/fdd/fdd_explanation.shtml#sign)

| Tag                 | Value                     | Note                                                         |
| :------------------ | :------------------------ | :----------------------------------------------------------- |
| Filename extension  | stl                       | This file extension is found in practice, and listed in many file format resources. Is also used for the [ASCII variant of STL](https://www.loc.gov/preservation/digital/formats/fdd/fdd000504.shtml). |
| Internet Media Type | model/stl application/sla | model/stl was registered as an Internet media type in March 2018 with IANA on behalf of the [Digital Imaging and Communications in Medicine (DICOM) Standards Committee](https://www.dicomstandard.org/current/) in preparation of [Supplement 205: DICOM Encapsulation of STL Models for 3D Manufacturing](https://www.dicomstandard.org/News/ftsup/docs/sups/sup205.pdf). See https://www.iana.org/assignments/media-types/model/stl. Prior to that, application/sla had been used by [Wolfram](https://reference.wolfram.com/language/ref/format/STL.html) for Mathematica and other products. Both media types apply to both ASCII and binary versions of STL. |
| Pronom PUID         | fmt/865                   | See [http://www.nationalarchives.gov.uk/PRONOM/fmt/865](http://www.nationalarchives.gov.uk/PRONOM/x-fmt/108). |
| Wikidata Title ID   | Q1238229                  | See https://www.wikidata.org/wiki/Q1238229. Covers ASCII and binary variants of STL. |



### Notes [![Explanation of format description terms](https://www.loc.gov/preservation/digital/formats/fdd/info.gif)](https://www.loc.gov/preservation/digital/formats/fdd/fdd_explanation.shtml#notes)

| General | See [STL_family](https://www.loc.gov/preservation/digital/formats/fdd/fdd000504.shtml). |
| :------ | ------------------------------------------------------------ |
| History | See [STL_family](https://www.loc.gov/preservation/digital/formats/fdd/fdd000504.shtml). |



### Format specifications [![Explanation of format description terms](https://www.loc.gov/preservation/digital/formats/fdd/info.gif)](https://www.loc.gov/preservation/digital/formats/fdd/fdd_explanation.shtml#specs)

- StereoLithography Interface Specification, 3D Systems, Inc., October 1989
- The compilers of this resource have not been able to locate a copy of the original specification from 3D Systems, Inc. See [Useful References](https://www.loc.gov/preservation/digital/formats/fdd/fdd000505.shtml#useful), immediately below, for sources with documentation for the format.



### Useful references

**URLs**

- The syntax of the binary STL format is described in a number of resources.
  - [The StL Format: StL Binary Format | by Marshall Burns](https://www.fabbers.com/tech/STL_Format#Sct_binary) (https://www.fabbers.com/tech/STL_Format#Sct_binary). Reprinted from Section 6.5 of Automated Fabrication by Marshall Burns, Ph.D. Used with permission.
  - [Wikipedia entry for STL (file format): Binary STL](https://en.wikipedia.org/wiki/STL_(file_format)#Binary_STL) (https://en.wikipedia.org/wiki/STL_(file_format)#Binary_STL).
  - [stl.grammar | from Grammars for Synalyze It! and Hexinator](https://github.com/synalysis/Grammars/blob/master/stl.grammar) (https://github.com/synalysis/Grammars/blob/master/stl.grammar). A formal grammar for the syntax of the binary variant of STL
  - [Kaitai Struct: .stl file format](http://formats.kaitai.io/stl/index.html) (http://formats.kaitai.io/stl/index.html). Formal specification in Kaitai Struct, a declarative language designed to describe binary data structures
- Resources with information specifically about the options for color support in the binary variant of STL.
  - [STL File Format (3D Printing) – Simply Explained | All3DP](https://all3dp.com/what-is-stl-file-format-extension-3d-printing/) (https://all3dp.com/what-is-stl-file-format-extension-3d-printing/). Has section on two incompatible ways color support has been added to the binary variant of STL.
  - [Meshmixer Import Formats | Autodesk](https://help.autodesk.com/view/MSHMXR/2019/ENU/?guid=GUID-D11FDE6E-0279-4909-9B9C-1E115506ED9B) (https://help.autodesk.com/view/MSHMXR/2019/ENU/?guid=GUID-D11FDE6E-0279-4909-9B9C-1E115506ED9B). Mentions the two conventions in use for color support. Meshmixer only supports one of them, although this page does not specify which. Meshmixer does not export STL files with color..
  - [Re: STL-color file format specification | message from Marcus Joppe in thread from rp-ml list from October 2001](http://www.rp-ml.org/rp-ml-2001/2598.html) (http://www.rp-ml.org/rp-ml-2001/2598.html). Describes extension to binary STL used by Marcam Engineering for their VisCAM rapid prototyping software.
  - [Re: STL-color file format specification | message from Pieter Bourgaux in thread from rp-ml list from October 2001](http://www.rp-ml.org/rp-ml-2001/2603.html) (http://www.rp-ml.org/rp-ml-2001/2603.html). Had link to specification for extension to binary STL introduced by Materialise with Magics around 2000. In September 2019, link does not function.
  - [ZBrush Plugins: 3D Print Hub | from ZBrush User Guide](http://docs.pixologic.com/user-guide/zbrush-plugins/3d-print-hub/) (http://docs.pixologic.com/user-guide/zbrush-plugins/3d-print-hub/). This plug-in for ZBrush offers the option on STL export for Magics or Solidview color encoding
  - [stlwrite - write ASCII or Binary STL files | MathWorks](https://www.mathworks.com/matlabcentral/fileexchange/20922-stlwrite-write-ascii-or-binary-stl-files) (https://www.mathworks.com/matlabcentral/fileexchange/20922-stlwrite-write-ascii-or-binary-stl-files). This MathWorks function can generate a file using the VisCAM/SolidView convention for colors
  - [STL import options | Alias from Autodesk](https://knowledge.autodesk.com/support/alias-products/learn-explore/caas/CloudHelp/cloudhelp/2020/ENU/Alias-Reference/files/GUID-B7BF855B-724D-46E4-8FE3-185737BB9D31-htm.html) (https://knowledge.autodesk.com/support/alias-products/learn-explore/caas/CloudHelp/cloudhelp/2020/ENU/Alias-Reference/files/GUID-B7BF855B-724D-46E4-8FE3-185737BB9D31-htm.html). Indicates that either convention can be specified for input.
  - http://www.realtimerendering.com/erich/minecraft/public/mineways/mineways.html This exporter offers Materialise Magics or VisCAM encoding for colors in STL. Recommends VisCAM as compatible with MeshLab.
- [PRONOM entry for fmt/865](http://www.nationalarchives.gov.uk/PRONOM/fmt/865) (http://www.nationalarchives.gov.uk/PRONOM/fmt/865). Information in PRONOM on STL binary format. PUID: fmt/865.
- [Wikidata entry for Q1238229](https://www.wikidata.org/wiki/Q1238229) (https://www.wikidata.org/wiki/Q1238229). Information in WikiData about STL format. Covers ASCII and binary variants. WikiData Title ID: Q1238229
- See also [STL_family](https://www.loc.gov/preservation/digital/formats/fdd/fdd000504.shtml).



Last Updated: 09/18/2019
