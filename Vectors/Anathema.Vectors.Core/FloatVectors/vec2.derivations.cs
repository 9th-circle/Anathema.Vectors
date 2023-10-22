
#if FLOATS_ENABLED
using System;
namespace Anathema.Vectors.Core
{
    public partial class vec2
    {
        public static vec2 fromAngleRadians(float angle)
        {
            return new vec2((float)Math.Cos(angle - (Math.PI / 2)), (float)Math.Sin(angle - (Math.PI / 2)));
        }
        public static vec2 fromAngleRadiansAndLength(float angle, float length)
        {
            return fromAngleRadians(angle) * length;
        }
        public static vec2 fromAngleDegrees(float angle)
        {
            return fromAngleRadians(angle * (float)(Math.PI / 180.0f));
        }
        public static vec2 fromAngleDegreesAndLength(float angle, float length)
        {
            return fromAngleRadiansAndLength(angle * (float)(Math.PI / 180.0f), length);
        }

#if CAPITALS_ENABLED

        public float Length
        {
            get
            {
                return length;
            }
        }
        public float LengthSquared
        {
            get
            {
                return length * length;
            }
        }

#endif

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
        /// Returns another vector facing the same direction with length = 1
        /// </summary>
        public vec2 normalised
        {
            get
            {
                return this / length;
            }
        }
    }
}
#endif