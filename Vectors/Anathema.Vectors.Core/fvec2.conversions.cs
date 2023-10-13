using System;
using System.Collections.Generic;
using System.Text;

namespace Anathema.Vectors.Core
{
    public partial class fvec2
    {
#if CONVERSIONS_ENABLED
        public fvec2(dvec2 xy)
        {
            x = (float)xy.x;
            y = (float)xy.y;
        }
#if TEMPLATES_ENABLED
        public tvec2<float> toTVec2()
        {
            return new tvec2<float>(x, y);
        }
#endif
#endif
    }
}
