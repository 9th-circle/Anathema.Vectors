#if FLOATS_ENABLED
#if THREED_ENABLED
using System;

namespace Anathema.Vectors.Core
{
    /// <summary>
    /// A single-precision floating point, 4-component vector.
    /// </summary>
    public partial class fvec4 : fvec3
    {
        public float w { get; set; }

        public fvec4()
        {
        }
        public fvec4(fvec4 xyzw)
        {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }
        public fvec4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public fvec4(float[] xyzw)
        {
            this[0] = xyzw[0];
            this[1] = xyzw[1];
            this[2] = xyzw[2];
            this[3] = xyzw[3];
        }


        public new float this[int i]
        {
            get
            {
                if (i == 0)
                    return x;
                if (i == 1)
                    return y;
                if (i == 2)
                    return z;
                if (i == 3)
                    return w;
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (i == 0)
                { x = value; return; }
                if (i == 1)
                { y = value; return; }
                if (i == 2)
                { z = value; return; }
                if (i == 3)
                { w = value; return; }
                throw new IndexOutOfRangeException();
            }
        }


        public override float[] ToArray()
        {
            return new float[] { x, y, z, w};
        }

    }
}
#endif
#endif