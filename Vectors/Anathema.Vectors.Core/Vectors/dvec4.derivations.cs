using System;
using System.Collections.Generic;
using System.Text;

#if THREED_ENABLED
#if DOUBLES_ENABLED
namespace Anathema.Vectors.Core
{
    public partial class dvec4
    {
        public dvec3 scaledToDVec3()
        {
            return new dvec3(x / w, y / w, z / w);
        }

        public override double length
        {
            get
            {
                return Math.Sqrt((x * x) + (y * y) + (z * z) + (w * w));
            }
        }
        public new dvec4 normalised
        {
            get
            {
                return this / length;
            }
        }
    }
}
#endif
#endif