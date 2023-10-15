#if FLOATS_ENABLED
#if THREED_ENABLED
using System;

namespace Anathema.Vectors.Core
{
    /// <summary>
    /// A single-precision floating point, 3-component vector.
    /// </summary>
    public partial class fvec3 : fvec2
    {
        ///////////////////////////
        //        Members        //
        ///////////////////////////

        public float z { get; set; }


        ///////////////////////////
        //     Constructors      //
        ///////////////////////////

        public fvec3()
        {
        }
        public fvec3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public fvec3(fvec3 xyz)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }
        public fvec3(float[] xyz)
        {
            this[0] = xyz[0];
            this[1] = xyz[1];
            this[2] = xyz[2];
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
                throw new IndexOutOfRangeException();
            }
        }

        public override float[] ToArray()
        {
            return new float[] { x, y, z};
        }
    }
}
#endif
#endif