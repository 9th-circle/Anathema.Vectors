namespace Anathema.Vectors.Core
{
    public partial class fvec3
    {

        ///////////////////////////
        //     Interpolation     //
        ///////////////////////////
#if INTERPOLATION_ENABLED
        public static fvec3 linearInterpolate(fvec3 a, fvec3 b, float position)
        {
            return (a * (1 - position)) + (b * position);
        }
        public fvec3 linearInterpolateTo(fvec3 b, float position)
        {
            return linearInterpolate(this, b, position);
        }
        public static fvec3 quadraticBezierInterpolate(fvec3 a, fvec3 b, fvec3 c, float position)
        {
            return linearInterpolate(
                linearInterpolate(a, b, position),
                linearInterpolate(b, c, position),
                position);
        }
        public fvec3 quadraticBezierInterpolateTo(fvec3 b, fvec3 c, float position)
        {
            return quadraticBezierInterpolate(this, b, c, position);
        }

        //todo: validate this
        public static fvec3 cubicBezierInterpolate(fvec3 a, fvec3 b, fvec3 c, fvec3 d, float position)
        {
            return linearInterpolate(
                quadraticBezierInterpolate(a, b, c, position),
                quadraticBezierInterpolate(b, c, d, position),
                position);
        }
        public fvec3 cubicBezierInterpolateTo(fvec3 b, fvec3 c, fvec3 d, float position)
        {
            return cubicBezierInterpolate(this, b, c, d, position);
        }
        //todo: rational bezier interpolation (ie with weights)

#endif
    }
}
