using System;
#if DOUBLES_ENABLED

namespace Anathema.Vectors.Core
{
    public partial class dvec2
    {

        public dvec2(vec2 xy)
        {
            x = xy.x;
            y = xy.y;
        }
        public static dvec2 fromAngleRadians(double angle)
        {
            return new dvec2(Math.Cos(angle - (Math.PI / 2)), Math.Sin(angle - (Math.PI / 2)));
        }
        public static dvec2 fromAngleRadiansAndLength(double angle, double length)
        {
            return new dvec2(fromAngleRadians(angle) * length);
        }
        public static dvec2 fromAngleDegrees(double angle)
        {
            return fromAngleRadians(angle * (Math.PI / 180.0f));
        }
        public static dvec2 fromAngleDegreesAndLength(double angle, double length)
        {
            return fromAngleRadiansAndLength(angle * (Math.PI / 180.0f), length);
        }

#if CONVERSIONS_ENABLED
#if TEMPLATES_ENABLED
        public tvec2<double> toTVec2()
        {
            return new tvec2<double>(x, y);
        }
#endif
#endif
    }
}
#endif