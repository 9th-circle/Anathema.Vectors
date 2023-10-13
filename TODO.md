## To Do

- Move operators/conversions into separate files via partial classes
  - fmat2/3/4
  - dmat2/3/4
- Tests + Correction
  - Literally everything except fvec2 and dvec2
  - Check a mat4 with a mat2 reference can access correct rows/cols
- Commenting
- Documenting
  - README
- Benchmarking
  - Everything
- Demos
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
