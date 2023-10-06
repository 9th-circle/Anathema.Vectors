

- Matrix-matrix multiplication
  - Basic use case
  - Of different data types (float/double/T)
  - Of different order (2/3/4)
  - Don't bother with mixed data type+order difference

- Quaternions
  - There is no implementation yet
  - Do not use an existing imaginary arithmetic library - should be self contained
  - Slerp - spherical linear interpolation is the main reason we want this
- Templates
  - Conversions to normal vectors - this has been started
  - Operations between template vectors of the same type
- Matrix generators (3x3/4x4)
  - Rotate in 3d (axis-angle and Euler angle - 4x4 implementation mostly copy from 3x3)
  - Translate
- Investigate whether template vectors can be used to create functional tensors
- Double check all the matrix code doesn't transpose when it shouldn't
- Tests
  - Literally everything
  - Check a mat4 with a mat2 reference can access correct rows/cols
- Commenting
- Documenting
  - README
- Benchmarking
  - Everything

