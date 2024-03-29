﻿using System;
#if DOUBLES_ENABLED

namespace Anathema.Vectors.Core
{
    public partial class dvec2
    {
        public double angleRadians
        {
            get
            {
                return Math.Atan2(y, x) + (Math.PI / 2);
            }
        }
        public double angleDegrees
        {
            get
            {
                return angleRadians * (180.0f / Math.PI);
            }
        }

#if CAPITALS_ENABLED
        public double Length
        {
            get
            {
                return length;
            }
        }
        public double LengthSquared
        {
            get
            {
                return length * length;
            }
        }
#endif

        public virtual double length
        {
            get
            {
                return Math.Sqrt((x * x) + (y * y));
            }
        }
        public dvec2 normalised
        {
            get
            {
                return this / length;
            }
        }
        public virtual void normalise()
        {
            double f = length;
            x /= f;
            y /= f;
        }
    }
}
#endif