using System;
using System.Collections.Generic;
using System.Text;

namespace Anathema.Vectors.Core
{
    public partial class dvec3
    {
        public override double length
        {
            get
            {
                return Math.Sqrt((x * x) + (y * y) + (z * z));
            }
        }
        public new dvec3 normalised
        {
            get
            {
                return this / length;
            }
        }
        public override void normalise()
        {
            double f = length;
            x /= f;
            y /= f;
        }


    }
}
