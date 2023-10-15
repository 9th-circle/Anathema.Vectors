#if FLOATS_ENABLED
using System;

namespace Anathema.Vectors.Core
{
    /// <summary>
    /// A single-precision floating point, 2-component vector.
    /// </summary>
    public partial class fvec2
    {
        public float x { get; set; }
        public float y { get; set; }

        public fvec2()
        {
        }

        public fvec2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public fvec2(float[] xy)
        {
            this[0] = xy[0];
            this[1] = xy[1];
        }
        public fvec2(fvec2 xy)
        {
            x = xy.x;
            y = xy.y;
        }

        public virtual float[] ToArray()
        {
            return new float[] { x, y };
        }

    }
}
#endif