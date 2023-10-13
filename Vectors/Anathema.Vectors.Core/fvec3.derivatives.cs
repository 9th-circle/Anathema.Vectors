using System;
using System.Collections.Generic;
using System.Text;

namespace Anathema.Vectors.Core
{
    public partial class fvec3
    {
        public override float length
        {
            get
            {
                return (float)Math.Sqrt((x * x) + (y * y) + (z * z));
            }
        }
        public new fvec3 normalised
        {
            get
            {
                return this / length;
            }
        }
        public override void normalise()
        {
            float f = length;
            x /= f;
            y /= f;
        }

    }
}
