using System;
using System.Collections.Generic;
using System.Text;

namespace Anathema.Vectors.Core
{
    public partial class fvec3
    {
#if CONVERSIONS_ENABLED
        public fvec3(fvec2 a, float z)
        {
            x = a.x;
            y = a.y;
            this.z = z;
        }
        public fvec3(float x, fvec2 yz)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }
        public fvec3(dvec3 xyz)
        {
            x = (float)xyz.x;
            y = (float)xyz.y;
            z = (float)xyz.z;
        }
#if TEMPLATES_ENABLED
        public tvec3<float> toTVec3()
        {
            return new tvec3<float>(x, y, z);
        }
#endif
#endif
    }
}
