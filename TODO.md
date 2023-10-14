## To Do

- Tests + Correction
  - Finish fvec3 tests
  - Literally everything except fvec2 and dvec2
  - Check a mat4 with a mat2 reference can access correct rows/cols
- Commenting
- Documenting
  - README
- Benchmarking
  - Everything
- Demos
  - Bezier curves
  - 2D particle FX
  - 3D bezier curves (needs projection matrix)
  - 3D boxes (needs projection matrix)
  - 3D particles (fireworks?) (needs projection matrix)
  - Euler rotation
  - Quaternion rotation
- Double check permutations of removed preprocessor directives are sensible

## Outsourced

- Matrix-matrix multiplication
  - Basic use case
  - Of different data types (float/double/T) #if CONVERSIONS_ENABLED
  - Of different order (2/3/4)
  - Don't bother with mixed data type+order difference
- Quaternions
  - There is no implementation yet
  - Do not use an existing imaginary arithmetic library - should be self contained
  - Slerp - spherical linear interpolation is the main reason we want this
- Interpolation
  - Rational Bezier
  - Hermite
- Projection matrix
