using System;
using System.Collections.Generic;
using System.Text;

namespace Anathema.Vectors.Core
{
    public partial class dvec2
    {

#if INTERPOLATION_ENABLED
        public static dvec2 linearInterpolate(dvec2 a, dvec2 b, double position)
        {
            return (a * (1 - position)) + (b * position);
        }
        public dvec2 linearInterpolateTo(dvec2 b, double position)
        {
            return linearInterpolate(this, b, position);
        }
        public static dvec2 quadraticBezierInterpolate(dvec2 a, dvec2 b, dvec2 c, double position)
        {
            return linearInterpolate(
                linearInterpolate(a, b, position),
                linearInterpolate(b, c, position),
                position);
        }
        public dvec2 quadraticBezierInterpolateTo(dvec2 b, dvec2 c, double position)
        {
            return quadraticBezierInterpolate(this, b, c, position);
        }


        //todo: validate this
        public static dvec2 cubicBezierInterpolate(dvec2 a, dvec2 b, dvec2 c, dvec2 d, double position)
        {
            return linearInterpolate(
                quadraticBezierInterpolate(a, b, c, position),
                quadraticBezierInterpolate(b, c, d, position),
                position);
        }
        public dvec2 cubicBezierInterpolateTo(dvec2 b, dvec2 c, dvec2 d, double position)
        {
            return cubicBezierInterpolate(this, b, c, d, position);
        }



        //todo: rational bezier interpolation (ie with weights)

#endif
    }
}
