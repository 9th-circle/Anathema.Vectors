# Anathema Vectors

Basic linear algebra, mostly for computer graphics.

## Status

- The output of this project has not been tested or validated yet - the code has been written but undeniably makes mistakes in calculations. This is a work in progress right now.

## Approach

- The notation is terse and annotations are minimal. The assumption is that you either have a decent understanding of basic linear algebra, or that you are willing to learn it on your own.
  - I acknowledge that this is a major structural problem in maths. "It's not my job to teach you how to understand this" becomes quite toxic when the entire field takes that attitude for almost everything. However, this is not the problem I'm trying to solve right now.

- You can compile it with as much or as little functionality as you like. You only need to build in the parts you're actually using, so it can be extremely lightweight if you need that.

- Interactions between the various entities are extensive (you can usually mix and match types), but not exhaustive (there will still be times where you have to do intermediate steps to get it done).
- Performance is pretty lousy, both from the extensive use of object oriented language features, and the lack of SIMD vector CPU extension usage.
- Core codebase builds against .NET Framework 2.0 and up, so it can be compiled against any runtime you're likely to come across.
- No external dependencies whatsoever (apart from test infrastructure etc) - maximise portability.

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

## Gotchas

- Matrices and vectors (except 2) are subclasses of the rank lower than it (ie a vec4 is a subclass of vec3 which is a subclass of vec2). This cuts out a lot of redundant code, and makes porting data between them easier, but it also means that if a method asks for a vec2 you can pass it a vec4 instead. Which will work in a sense, but could cause problems later.

## Complex Numbers and Quaternions

Todo: fill out

## Interpolation

Todo: fill out

## Compile-Time Flags

Todo: finish explaining the flags

##### FLOATS_ENABLED

##### DOUBLES_ENABLED

##### NESTING_ENABLED

##### TEMPLATES_ENABLED

##### SWIZZLES_ENABLED

- Combining different subsets of a vector's components, possibly out of order, ie vec3.xy

##### COLOURS_ENABLED

- Scalar and swizzle aliases for RGBA in the place of XYZW

##### COMPLEX_ENABLED

- Complex numbers and quaternion support

##### CONVERSIONS_ENABLED

##### INTERPOLATION_ENABLED

##### THREED_ENABLED

- Three dimensional vectors, and the matrices and quaternions used to support them.
