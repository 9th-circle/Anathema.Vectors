- Swizzles allowing repetition of values (ie vec4.xzzz)
  - Lots of permutations for not much gain
  - Could automate generation process, but large binary size for no real reason
- Mixed chromatic/Cartesian swizzles (ie vec3.xgb)
  - Extremely large amount of work and almost completely useless
  - Could automate generation process, but large binary size for no real reason

- Swizzle extensions on native scalar types (ie float.xxxx)
  - Almost completely pointless, apart from copying GLSL
- Compile time constrain to members available on System.Numerics vectors, allowing for transitioning back and forth trivially
  - Given that core implementation is lowercase this will mean structural changes
- Template matrices
  - Can't imagine a use case which wouldn't be horribly slow and janky, and implementing this would be a nightmare anyway
- Native integer types
  - Implementation straightforward, but is it really needed?
- Tensors

- Full aliases for System.Numerics equivalents (under their own preprocessor directive, say #NUMERICS_ENABLED)
  - Probably an acceptable amount of work for non-trivial benefit
- Fixed-point implementation using integers for extremely resource constrained applications (eg JavaCards)
