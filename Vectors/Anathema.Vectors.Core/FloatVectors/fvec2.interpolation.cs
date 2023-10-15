#if FLOATS_ENABLED
namespace Anathema.Vectors.Core
{
    public partial class fvec2
    {

#if INTERPOLATION_ENABLED
        public static fvec2 linearInterpolate(fvec2 a, fvec2 b, float position)
        {
            return (a * (1 - position)) + (b * position);
        }
        public fvec2 linearInterpolateTo(fvec2 b, float position)
        {
            return linearInterpolate(this, b, position);
        }
        public static fvec2 quadraticBezierInterpolate(fvec2 a, fvec2 b, fvec2 c, float position)
        {
            return linearInterpolate(
                linearInterpolate(a, b, position),
                linearInterpolate(b, c, position),
                position);
        }
        public fvec2 quadraticBezierInterpolateTo(fvec2 b, fvec2 c, float position)
        {
            return quadraticBezierInterpolate(this, b, c, position);
        }

        //todo: validate this
        public static fvec2 cubicBezierInterpolate(fvec2 a, fvec2 b, fvec2 c, fvec2 d, float position)
        {
            return linearInterpolate(
                quadraticBezierInterpolate(a, b, c, position),
                quadraticBezierInterpolate(b, c, d, position),
                position);
        }
        public fvec2 cubicBezierInterpolateTo(fvec2 b, fvec2 c, fvec2 d, float position)
        {
            return cubicBezierInterpolate(this, b, c, d, position);
        }

        //todo: rational bezier interpolation (ie with weights)

#endif
    }
}
#endif