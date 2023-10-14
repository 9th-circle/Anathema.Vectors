using System;
using System.Collections.Generic;
using System.Text;

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
            z /= f;
        }
    }
}
