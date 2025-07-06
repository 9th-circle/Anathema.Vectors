#if FLOATS_ENABLED
namespace Anathema.Vectors.Core
{
    public partial class vec2
    {

#if INTERPOLATION_ENABLED
        public static vec2 linearInterpolate(vec2 a, vec2 b, float position)
        {
            return (a * (1 - position)) + (b * position);
        }
        public vec2 linearInterpolateTo(vec2 b, float position)
        {
            return linearInterpolate(this, b, position);
        }
        public static vec2 quadraticBezierInterpolate(vec2 a, vec2 b, vec2 c, float position)
        {
            return linearInterpolate(
                linearInterpolate(a, b, position),
                linearInterpolate(b, c, position),
                position);
        }
        public vec2 quadraticBezierInterpolateTo(vec2 b, vec2 c, float position)
        {
            return quadraticBezierInterpolate(this, b, c, position);
        }

        public static vec2 cubicBezierInterpolate(vec2 a, vec2 b, vec2 c, vec2 d, float position)
        {
            return linearInterpolate(
                quadraticBezierInterpolate(a, b, c, position),
                quadraticBezierInterpolate(b, c, d, position),
                position);
        }
        public vec2 cubicBezierInterpolateTo(vec2 b, vec2 c, vec2 d, float position)
        {
            return cubicBezierInterpolate(this, b, c, d, position);
        }

        //todo: rational bezier interpolation (ie with weights)

#endif
    }
}
#endif