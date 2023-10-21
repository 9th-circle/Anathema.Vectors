
#if FLOATS_ENABLED && THREED_ENABLED
namespace Anathema.Vectors.Core
{
    public partial class fvec4
    {

#if INTERPOLATION_ENABLED
        public static fvec4 linearInterpolate(fvec4 a, fvec4 b, float position)
        {
            return (a * (1 - position)) + (b * position);
        }
        public fvec4 linearInterpolateTo(fvec4 b, float position)
        {
            return linearInterpolate(this, b, position);
        }


        public static fvec4 quadraticBezierInterpolate(fvec4 a, fvec4 b, fvec4 c, float position)
        {
            return linearInterpolate(
                linearInterpolate(a, b, position),
                linearInterpolate(b, c, position),
                position);
        }
        public fvec4 quadraticBezierInterpolateTo(fvec4 b, fvec4 c, float position)
        {
            return quadraticBezierInterpolate(this, b, c, position);
        }


        //todo: validate this
        public static fvec4 cubicBezierInterpolate(fvec4 a, fvec4 b, fvec4 c, fvec4 d, float position)
        {
            return linearInterpolate(
                quadraticBezierInterpolate(a, b, c, position),
                quadraticBezierInterpolate(b, c, d, position),
                position);
        }
        public fvec4 cubicBezierInterpolateTo(fvec4 b, fvec4 c, fvec4 d, float position)
        {
            return cubicBezierInterpolate(this, b, c, d, position);
        }
        //todo: rational bezier interpolation (ie with weights)

#endif
    }
}
#endif