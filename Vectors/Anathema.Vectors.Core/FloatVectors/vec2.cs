#if FLOATS_ENABLED
using System;

namespace Anathema.Vectors.Core
{
    /// <summary>
    /// A single-precision floating point, 2-component vector.
    /// </summary>
    public partial class vec2
    {
        public float x { get; set; }
        public float y { get; set; }

        public vec2()
        {
        }

        public vec2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public vec2(float[] xy)
        {
            this[0] = xy[0];
            this[1] = xy[1];
        }
        public vec2(vec2 xy)
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