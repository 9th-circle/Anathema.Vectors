using System;
using System.Collections.Generic;
using System.Text;

namespace Anathema.Vectors.Core
{
    public partial class dvec3
    {
#if INTERPOLATION_ENABLED
        public static dvec3 linearInterpolate(dvec3 a, dvec3 b, double position)
        {
            return (a * (1 - position)) + (b * position);
        }
        public dvec3 linearInterpolateTo(dvec3 b, double position)
        {
            return linearInterpolate(this, b, position);
        }
        public static dvec3 quadraticBezierInterpolate(dvec3 a, dvec3 b, dvec3 c, double position)
        {
            return linearInterpolate(
                linearInterpolate(a, b, position),
                linearInterpolate(b, c, position),
                position);
        }
        public dvec3 quadraticBezierInterpolateTo(dvec3 b, dvec3 c, double position)
        {
            return quadraticBezierInterpolate(this, b, c, position);
        }


        //todo: validate this
        public static dvec3 cubicBezierInterpolate(dvec3 a, dvec3 b, dvec3 c, dvec3 d, double position)
        {
            return linearInterpolate(
                quadraticBezierInterpolate(a, b, c, position),
                quadraticBezierInterpolate(b, c, d, position),
                position);
        }
        public dvec3 cubicBezierInterpolateTo(dvec3 b, dvec3 c, dvec3 d, double position)
        {
            return cubicBezierInterpolate(this, b, c, d, position);
        }




        //todo: rational bezier interpolation (ie with weights)

#endif
    }
}
