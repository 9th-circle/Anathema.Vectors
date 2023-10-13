using System;
using System.Collections.Generic;
using System.Text;

namespace Anathema.Vectors.Core
{
    public partial class fvec4
    {
        public fvec3 scaledToFVec3()
        {
            return new fvec3(x / w, y / w, z / w);
        }

        public override float length
        {
            get
            {
                return (float)Math.Sqrt((x * x) + (y * y) + (z * z) + (w * w));
            }
        }
        public new fvec4 normalised
        {
            get
            {
                return this / length;
            }
        }
    }
}
