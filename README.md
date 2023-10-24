![](https://github.com/9th-circle/Anathema.Meta/blob/main/Anathema%20Icon%20Small.png?raw=true)

# Anathema Vectors

Basic linear algebra, mostly for computer graphics.

## Why?

System.Numerics contains a native SIMD-enabled Vector class. It's extremely fast and is what most developers would expect. Why not just use that?

Anathema Vectors has a few benefits:

- **Rich feature set**: Broad support for a wide range of features.
- **Dependency-free**: Builds with nothing more than .NET Fx 2.0 - compatible with any platform newer than that (including transpilers).
- **Convenience**: Swizzles and easy interoperation between types.
- **Modularity**: Compile time preprocessor directives allow you to chop the library down to the features you're using, and nothing more. 
- **Interoperability**: Aliases for many System.Numerics members, so code can be swapped over with minimal changes.
- **Familiarity**: Syntax is as close to that of GLSL as practical.
- **Full test suite**: 100% test coverage.

## Approach

- The notation is terse and annotations are minimal. The assumption is that you either have a decent understanding of basic linear algebra, or that you are willing to learn it on your own.
  - I acknowledge that this is a major structural problem in maths. "It's not my job to teach you how to understand this" becomes quite toxic when the entire field takes that attitude for almost everything. However, this is not the problem I'm trying to solve right now.
  - I intend on making the annotations more helpful -- give some explanation of what the members actually do. But the actual names of properties/methods will have to remain terse.

## Notation

`d` = double precision floating point data type

`f` = single precision floating point data type

`t` = generic (template) defined data type

`mat` = matrix

`vec` = vector

`quat` = quaternion

Number at end = number of components (per row/column for matrices).



So, for example, `dmat2` = double precision floating point 2x2 matrix.

Or, `tvec3<int>`  = 32-bit integer 3-component vector.

## Nested Template Vectors

- One quirk of the use of templates which are *not* constrained to numeric values is that a template vector can use another vector as its template type.
  - I am aware that .NET 7 allows the use of an `INumeric<T>` constraint on template types, obviating the need for explicit conversions. This project is not targeting .NET 7.

- This means that you can construct a matrix out of template vectors
- You can even take it further and create a tensor if you're feeling keen
- I do not know that this is actually a useful feature but it's kind of a cool emergent property we get mostly for free
- It has the interesting property that if we access vector.x.y, we get row 0 column 1 of the matrix - which is of course the mapping of x to y when you multiply a vector with that matrix. Might be a useful/interesting educational tool.

## Swizzles

- This idea is implemented almost exactly like GLSL. If you have a vec3 with components x, y and z, you can mix and match different components in different orders as needed - for example, fvec3.zxy.
- Similar to GLSL, there are swizzle aliases for rgba -> xyzw. 
- A nice property of this is that if you ask for a 2-vector out of a larger one, you can trivially convert the output to polar notation to turn it into an angle. This means that you can go fvec3.xz.angle and get a useful number.

## Gotchas/Limitations

- Matrices and vectors (except 2) are subclasses of the rank lower than it (ie a vec4 is a subclass of vec3 which is a subclass of vec2). This cuts out a lot of redundant code, and makes porting data between them easier, but it also means that if a method asks for a vec2 you can pass it a vec4 instead. Which will work in a sense, but could cause problems later.
- Performance is pretty lousy, both from the extensive use of object oriented language features, and the lack of SIMD vector CPU extension usage.
- Interactions between the various entities are extensive (you can usually mix and match types), but not exhaustive (there will still be times where you have to do intermediate steps to get it done).
- The folders inside Vector.Core do not reflect the namespaces the classes are in. **<u>This is deliberate.</u>** The proliferation of partial classes mean there is a large volume of files which need to be rationalised, but the namespace needs to be flat for usability reasons.
- Unlike GLSL, you cannot use a swizzle value more than once (ie vec3.xyy). This is out of simple pragmatism, as there would be a large number of permutations.
- No native support for non-square matrices (ie mat4x2), though you can construct those out of nested template vectors if you really need them.
- No template matrices. Narrow use case and a giant can of worms implementation-wise.

## Complex Numbers and Quaternions

Todo: fill out

## Compile-Time Flags

##### FLOATS_ENABLED

- Everything to do with single precision floating point

##### DOUBLES_ENABLED

- Everything to do with double precision floating point

##### NESTING_ENABLED

- Template vectors which contain other template vectors (used to create effective matrices)

##### TEMPLATES_ENABLED

- Template vectors (vectors which can have any other type of components)

##### SWIZZLES_ENABLED

- Combining different subsets of a vector's components, possibly out of order, ie vec3.xy
- When combined with THREED_ENABLED, significantly increases binary size.

##### COLOURS_ENABLED

- Scalar and swizzle aliases for RGBA in the place of XYZW.
- When combined with THREED_ENABLED, significantly increases binary size.

##### COMPLEX_ENABLED

- Complex numbers and quaternion support

##### CONVERSIONS_ENABLED

- Conversions between single and double precision floating point types

##### INTERPOLATION_ENABLED

- Linear and Bezier interpolation of vectors

##### THREED_ENABLED

- Three dimensional vectors, and the matrices and quaternions used to support them.

##### TEMPLATE_OPERATIONS_ENABLED

- Arithmetic operators (+-/*) of template vectors.
- Because of the lack of INumeric support, this significantly increases binary size.

##### TEMPLATE_DIVISION_ENABLED

- Division of template vectors, which might have integer components. This is to preclude the possibility of zero divides.
- Note: this does disable division for `tvec<float>` and `tvec<double>`, but of course you can just convert them to fvecs and dvecs.
  - The logic is that it's better to simply remove the option to divide tvecs than it is to throw a *different* exception if you try to do so for an integral type.

##### CAPITALS_ENABLED

- Capital letter versions of the components (XYZW and RGBA) as well as Length and LengthSquared for compatibility with System.Numerics.Vectors.

# Special Thanks

- Arran Ubels for reviewing the code (and suggesting partial classes)
- Peter Berlin for reviewing the code (and suggesting joining #ifs with Boolean operators)
- Matthew Mack for reviewing some of the maths
