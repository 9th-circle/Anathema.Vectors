
#if FLOATS_ENABLED
#if THREED_ENABLED

namespace Anathema.Vectors.Core
{
    public partial class fvec3 : fvec2
    {
        
        // 3! = 3 * 2 * 1 = 6
        // There are 6 swizzles, in 3 groups of 2

        //Starting with X (2)

#if SWIZZLES_ENABLED
        public fvec3 xyz
        {
            get
            {
                return new fvec3(x, y, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }
        public fvec3 xzy
        {
            get
            {
                return new fvec3(x, z, y);
            }
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
            }
        }


        //Starting with Y (2)


        public fvec3 yxz
        {
            get
            {
                return new fvec3(y, x, z);
            }
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
            }
        }
        public fvec3 yzx
        {
            get
            {
                return new fvec3(y, z, x);
            }
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
            }
        }


        //Starting with Z (2)


        public fvec3 zxy
        {
            get
            {
                return new fvec3(z, x, y);
            }
            set
            {
                z = value.x;
                x = value.y;
                y = value.z;
            }
        }
        public fvec3 zyx
        {
            get
            {
                return new fvec3(z, y, x);
            }
            set
            {
                z = value.x;
                y = value.y;
                x = value.z;
            }
        }
#endif

#if COLOURS_ENABLED
        public float b
        {
            get
            {
                return z;
            }
            set
            {
                z = value;
            }
        }
        public fvec3 rgb
        {
            get
            {
                return new fvec3(x, y, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }
        public fvec3 rbg
        {
            get
            {
                return new fvec3(x, z, y);
            }
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
            }
        }
        public fvec3 grb
        {
            get
            {
                return new fvec3(y, x, z);
            }
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
            }
        }
        public fvec3 gbr
        {
            get
            {
                return new fvec3(y, z, x);
            }
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
            }
        }
        public fvec3 bgr
        {
            get
            {
                return new fvec3(z, y, x);
            }
            set
            {
                z = value.x;
                y = value.y;
                x = value.z;
            }
        }
        public fvec3 brg
        {
            get
            {
                return new fvec3(z, x, y);
            }
            set
            {
                z = value.x;
                x = value.y;
                y = value.z;
            }
        }



#endif
    }
}
#endif
#endif