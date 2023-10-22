- Swizzles allowing repetition of values (ie vec4.xzzz)
  - Lots of permutations for not much gain
- Compile time constrain to members available on System.Numerics vectors, allowing for transitioning back and forth trivially
  - Given that core implementation is lowercase this will mean structural changes
- Template matrices
  - Can't imagine a use case which wouldn't be horribly slow and janky, and implementing this would be a nightmare anyway
- Native integer types
  - Implementation straightforward, but is it really needed?

- Swizzle extensions on native scalar types (ie float.xxxx)
  - Almost completely pointless, apart from copying GLSL

