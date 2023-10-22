
#if FLOATS_ENABLED
#if THREED_ENABLED

namespace Anathema.Vectors.Core
{
    public partial class vec3 : vec2
    {
#if CAPITALS_ENABLED
        public float Z
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
#endif
        // 3! = 3 * 2 * 1 = 6
        // There are 6 swizzles, in 3 groups of 2

        //Starting with X (2)

#if SWIZZLES_ENABLED
        public vec2 xz
        {
            get
            {
                return new vec2(x, z);
            }
            set
            {
                x = value.x;
                z = value.y;
            }
        }
        public vec2 zx
        {
            get
            {
                return new vec2(z, x);
            }
            set
            {
                z = value.x;
                x = value.y;
            }
        }
        public vec3 xyz
        {
            get
            {
                return new vec3(x, y, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }
        public vec3 xzy
        {
            get
            {
                return new vec3(x, z, y);
            }
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
            }
        }


        //Starting with Y (2)


        public vec3 yxz
        {
            get
            {
                return new vec3(y, x, z);
            }
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
            }
        }
        public vec3 yzx
        {
            get
            {
                return new vec3(y, z, x);
            }
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
            }
        }


        //Starting with Z (2)


        public vec3 zxy
        {
            get
            {
                return new vec3(z, x, y);
            }
            set
            {
                z = value.x;
                x = value.y;
                y = value.z;
            }
        }
        public vec3 zyx
        {
            get
            {
                return new vec3(z, y, x);
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
#if CAPITALS_ENABLED

        public float B
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

#endif
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
        public vec2 rb
        {
            get
            {
                return new vec2(x, z);
            }
            set
            {
                x = value.x;
                z = value.y;
            }
        }
        public vec2 br
        {
            get
            {
                return new vec2(z, x);
            }
            set
            {
                z = value.x;
                x = value.y;
            }
        }
        public vec3 rgb
        {
            get
            {
                return new vec3(x, y, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }
        public vec3 rbg
        {
            get
            {
                return new vec3(x, z, y);
            }
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
            }
        }
        public vec3 grb
        {
            get
            {
                return new vec3(y, x, z);
            }
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
            }
        }
        public vec3 gbr
        {
            get
            {
                return new vec3(y, z, x);
            }
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
            }
        }
        public vec3 bgr
        {
            get
            {
                return new vec3(z, y, x);
            }
            set
            {
                z = value.x;
                y = value.y;
                x = value.z;
            }
        }
        public vec3 brg
        {
            get
            {
                return new vec3(z, x, y);
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