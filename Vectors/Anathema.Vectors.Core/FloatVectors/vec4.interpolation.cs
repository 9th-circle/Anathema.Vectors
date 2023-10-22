
#if FLOATS_ENABLED && THREED_ENABLED
namespace Anathema.Vectors.Core
{
    public partial class vec4
    {

#if INTERPOLATION_ENABLED
        public static vec4 linearInterpolate(vec4 a, vec4 b, float position)
        {
            return (a * (1 - position)) + (b * position);
        }
        public vec4 linearInterpolateTo(vec4 b, float position)
        {
            return linearInterpolate(this, b, position);
        }


        public static vec4 quadraticBezierInterpolate(vec4 a, vec4 b, vec4 c, float position)
        {
            return linearInterpolate(
                linearInterpolate(a, b, position),
                linearInterpolate(b, c, position),
                position);
        }
        public vec4 quadraticBezierInterpolateTo(vec4 b, vec4 c, float position)
        {
            return quadraticBezierInterpolate(this, b, c, position);
        }


        //todo: validate this
        public static vec4 cubicBezierInterpolate(vec4 a, vec4 b, vec4 c, vec4 d, float position)
        {
            return linearInterpolate(
                quadraticBezierInterpolate(a, b, c, position),
                quadraticBezierInterpolate(b, c, d, position),
                position);
        }
        public vec4 cubicBezierInterpolateTo(vec4 b, vec4 c, vec4 d, float position)
        {
            return cubicBezierInterpolate(this, b, c, d, position);
        }
        //todo: rational bezier interpolation (ie with weights)

#endif
    }
}
#endif