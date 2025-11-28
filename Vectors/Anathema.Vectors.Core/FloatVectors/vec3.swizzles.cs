
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
#if SWIZZLE_DUPLICATES_ENABLED
        public vec2 zz
        {
            get
            {
                return new vec2(z, z);
            }
            set
            {
                z = value.x;
                z = value.y;
            }
        }
#endif
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
#if SWIZZLE_DUPLICATES_ENABLED
        public vec3 xxx
        {
            get { return new vec3(x, x, x); }
            set { x = value.x; x = value.y; x = value.z; }
        }
        public vec3 xxy
        {
            get { return new vec3(x, x, y); }
            set { x = value.x; x = value.y; y = value.z; }
        }
        public vec3 xxz
        {
            get { return new vec3(x, x, z); }
            set { x = value.x; x = value.y; z = value.z; }
        }
        public vec3 xyx
        {
            get { return new vec3(x, y, x); }
            set { x = value.x; y = value.y; x = value.z; }
        }
        public vec3 xyy
        {
            get { return new vec3(x, y, y); }
            set { x = value.x; y = value.y; y = value.z; }
        }
        public vec3 xzx
        {
            get { return new vec3(x, z, x); }
            set { x = value.x; z = value.y; x = value.z; }
        }
        public vec3 xzz
        {
            get { return new vec3(x, z, z); }
            set { x = value.x; z = value.y; z = value.z; }
        }
#endif


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
#if SWIZZLE_DUPLICATES_ENABLED
        public vec3 yxx
        {
            get { return new vec3(y, x, x); }
            set { y = value.x; x = value.y; x = value.z; }
        }
        public vec3 yxy
        {
            get { return new vec3(y, x, y); }
            set { y = value.x; x = value.y; y = value.z; }
        }
        public vec3 yyx
        {
            get { return new vec3(y, y, x); }
            set { y = value.x; y = value.y; x = value.z; }
        }
        public vec3 yyy
        {
            get { return new vec3(y, y, y); }
            set { y = value.x; y = value.y; y = value.z; }
        }
        public vec3 yyz
        {
            get { return new vec3(y, y, z); }
            set { y = value.x; y = value.y; z = value.z; }
        }
        public vec3 yzy
        {
            get { return new vec3(y, z, y); }
            set { y = value.x; z = value.y; y = value.z; }
        }
        public vec3 yzz
        {
            get { return new vec3(y, z, z); }
            set { y = value.x; z = value.y; z = value.z; }
        }
#endif


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
#if SWIZZLE_DUPLICATES_ENABLED
        public vec3 zxx
        {
            get { return new vec3(z, x, x); }
            set { z = value.x; x = value.y; x = value.z; }
        }
        public vec3 zxz
        {
            get { return new vec3(z, x, z); }
            set { z = value.x; x = value.y; z = value.z; }
        }
        public vec3 zyy
        {
            get { return new vec3(z, y, y); }
            set { z = value.x; y = value.y; y = value.z; }
        }
        public vec3 zyz
        {
            get { return new vec3(z, y, z); }
            set { z = value.x; y = value.y; z = value.z; }
        }
        public vec3 zzx
        {
            get { return new vec3(z, z, x); }
            set { z = value.x; z = value.y; x = value.z; }
        }
        public vec3 zzy
        {
            get { return new vec3(z, z, y); }
            set { z = value.x; z = value.y; y = value.z; }
        }
        public vec3 zzz
        {
            get { return new vec3(z, z, z); }
            set { z = value.x; z = value.y; z = value.z; }
        }
#endif
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



#if SWIZZLE_DUPLICATES_ENABLED
        // vec2 color duplicate
        public vec2 bb
        {
            get { return new vec2(b, b); }
            set { b = value.r; b = value.g; }
        }

        // vec3 color duplicates
        public vec3 rrr { get { return new vec3(r, r, r); } set { r = value.r; r = value.g; r = value.b; } }
        public vec3 rrg { get { return new vec3(r, r, g); } set { r = value.r; r = value.g; g = value.b; } }
        public vec3 rrb { get { return new vec3(r, r, b); } set { r = value.r; r = value.g; b = value.b; } }
        public vec3 rgr { get { return new vec3(r, g, r); } set { r = value.r; g = value.g; r = value.b; } }
        public vec3 rgg { get { return new vec3(r, g, g); } set { r = value.r; g = value.g; g = value.b; } }
        public vec3 rbr { get { return new vec3(r, b, r); } set { r = value.r; b = value.g; r = value.b; } }
        public vec3 rbb { get { return new vec3(r, b, b); } set { r = value.r; b = value.g; b = value.b; } }
        public vec3 grr { get { return new vec3(g, r, r); } set { g = value.r; r = value.g; r = value.b; } }
        public vec3 grg { get { return new vec3(g, r, g); } set { g = value.r; r = value.g; g = value.b; } }
        public vec3 ggr { get { return new vec3(g, g, r); } set { g = value.r; g = value.g; r = value.b; } }
        public vec3 ggg { get { return new vec3(g, g, g); } set { g = value.r; g = value.g; g = value.b; } }
        public vec3 ggb { get { return new vec3(g, g, b); } set { g = value.r; g = value.g; b = value.b; } }
        public vec3 gbg { get { return new vec3(g, b, g); } set { g = value.r; b = value.g; g = value.b; } }
        public vec3 gbb { get { return new vec3(g, b, b); } set { g = value.r; b = value.g; b = value.b; } }
        public vec3 brr { get { return new vec3(b, r, r); } set { b = value.r; r = value.g; r = value.b; } }
        public vec3 brb { get { return new vec3(b, r, b); } set { b = value.r; r = value.g; b = value.b; } }
        public vec3 bgg { get { return new vec3(b, g, g); } set { b = value.r; g = value.g; g = value.b; } }
        public vec3 bgb { get { return new vec3(b, g, b); } set { b = value.r; g = value.g; b = value.b; } }
        public vec3 bbr { get { return new vec3(b, b, r); } set { b = value.r; b = value.g; r = value.b; } }
        public vec3 bbg { get { return new vec3(b, b, g); } set { b = value.r; b = value.g; g = value.b; } }
        public vec3 bbb { get { return new vec3(b, b, b); } set { b = value.r; b = value.g; b = value.b; } }
#endif

#endif
    }
}
#endif
#endif