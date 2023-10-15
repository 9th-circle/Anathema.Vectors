
#if FLOATS_ENABLED
using System;
namespace Anathema.Vectors.Core
{
    public partial class fvec2
    {
        public static fvec2 fromAngleRadians(float angle)
        {
            return new fvec2((float)Math.Cos(angle - (Math.PI / 2)), (float)Math.Sin(angle - (Math.PI / 2)));
        }
        public static fvec2 fromAngleRadiansAndLength(float angle, float length)
        {
            return fromAngleRadians(angle) * length;
        }
        public static fvec2 fromAngleDegrees(float angle)
        {
            return fromAngleRadians(angle * (float)(Math.PI / 180.0f));
        }
        public static fvec2 fromAngleDegreesAndLength(float angle, float length)
        {
            return fromAngleRadiansAndLength(angle * (float)(Math.PI / 180.0f), length);
        }

        /// <summary>
        /// Returns a vector facing the same direction as this one, but with a length of 1.0.
        /// </summary>
        public virtual void normalise()
        {
            float f = length;
            x /= f;
            y /= f;
        }

        public float angleRadians
        {
            get
            {
                return (float)(Math.Atan2(y, x) + (Math.PI / 2));
            }
        }
        public float angleDegrees
        {
            get
            {
                return angleRadians * (180.0f / (float)Math.PI);
            }
        }

        public virtual float length
        {
            get
            {
                return (float)Math.Sqrt((x * x) + (y * y));
            }
        }

        /// <summary>
        /// Preserves this vector's direction, but sets its length to 1.0.
        /// </summary>
        public fvec2 normalised
        {
            get
            {
                return this / length;
            }
        }
    }
}
#endif