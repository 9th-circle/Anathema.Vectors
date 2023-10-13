using System;
using System.Collections.Generic;
using System.Text;

namespace Anathema.Vectors.Core
{
    public partial class dvec4
    {

#if INTERPOLATION_ENABLED
        public static dvec4 linearInterpolate(dvec4 a, dvec4 b, double position)
        {
            return (a * (1 - position)) + (b * position);
        }
        public dvec4 linearInterpolateTo(dvec4 b, double position)
        {
            return linearInterpolate(this, b, position);
        }


        public static dvec4 quadraticBezierInterpolate(dvec4 a, dvec4 b, dvec4 c, double position)
        {
            return linearInterpolate(
                linearInterpolate(a, b, position),
                linearInterpolate(b, c, position),
                position);
        }
        public dvec4 quadraticBezierInterpolateTo(dvec4 b, dvec4 c, double position)
        {
            return quadraticBezierInterpolate(this, b, c, position);
        }


        //todo: validate this
        public static dvec4 cubicBezierInterpolate(dvec4 a, dvec4 b, dvec4 c, dvec4 d, double position)
        {
            return linearInterpolate(
                quadraticBezierInterpolate(a, b, c, position),
                quadraticBezierInterpolate(b, c, d, position),
                position);
        }
        public dvec4 cubicBezierInterpolateTo(dvec4 b, dvec4 c, dvec4 d, double position)
        {
            return cubicBezierInterpolate(this, b, c, d, position);
        }



        //todo: rational bezier interpolation (ie with weights)

#endif
    }
}
