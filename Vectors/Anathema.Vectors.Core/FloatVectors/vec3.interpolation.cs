
#if THREED_ENABLED
#if FLOATS_ENABLED
namespace Anathema.Vectors.Core
{
    public partial class vec3
    {

        ///////////////////////////
        //     Interpolation     //
        ///////////////////////////
#if INTERPOLATION_ENABLED
        public static vec3 linearInterpolate(vec3 a, vec3 b, float position)
        {
            return (a * (1 - position)) + (b * position);
        }
        public vec3 linearInterpolateTo(vec3 b, float position)
        {
            return linearInterpolate(this, b, position);
        }
        public static vec3 quadraticBezierInterpolate(vec3 a, vec3 b, vec3 c, float position)
        {
            return linearInterpolate(
                linearInterpolate(a, b, position),
                linearInterpolate(b, c, position),
                position);
        }
        public vec3 quadraticBezierInterpolateTo(vec3 b, vec3 c, float position)
        {
            return quadraticBezierInterpolate(this, b, c, position);
        }

        //todo: validate this
        public static vec3 cubicBezierInterpolate(vec3 a, vec3 b, vec3 c, vec3 d, float position)
        {
            return linearInterpolate(
                quadraticBezierInterpolate(a, b, c, position),
                quadraticBezierInterpolate(b, c, d, position),
                position);
        }
        public vec3 cubicBezierInterpolateTo(vec3 b, vec3 c, vec3 d, float position)
        {
            return cubicBezierInterpolate(this, b, c, d, position);
        }
        //todo: rational bezier interpolation (ie with weights)

#endif
    }
}
#endif
#endif