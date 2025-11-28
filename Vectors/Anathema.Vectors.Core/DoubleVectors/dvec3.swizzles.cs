#if DOUBLES_ENABLED
#if THREED_ENABLED
namespace Anathema.Vectors.Core
{
    public partial class dvec3
    {


#if CAPITALS_ENABLED
        public double Z
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

        public dvec2 xz
        {
            get
            {
                return new dvec2(x, z);
            }
            set
            {
                x = value.x;
                z = value.y;
            }
        }
        public dvec2 zx
        {
            get
            {
                return new dvec2(z, x);
            }
            set
            {
                z = value.x;
                x = value.y;
            }
        }
        public dvec3 xyz
        {
            get
            {
                return new dvec3(x, y, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }
        public dvec3 xzy
        {
            get
            {
                return new dvec3(x, z, y);
            }
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
            }
        }


        //Starting with Y (2)


        public dvec3 yxz
        {
            get
            {
                return new dvec3(y, x, z);
            }
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
            }
        }
        public dvec3 yzx
        {
            get
            {
                return new dvec3(y, z, x);
            }
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
            }
        }


        //Starting with Z (2)


        public dvec3 zxy
        {
            get
            {
                return new dvec3(z, x, y);
            }
            set
            {
                z = value.x;
                x = value.y;
                y = value.z;
            }
        }
        public dvec3 zyx
        {
            get
            {
                return new dvec3(z, y, x);
            }
            set
            {
                z = value.x;
                y = value.y;
                x = value.z;
            }
        }
#if SWIZZLE_DUPLICATES_ENABLED
        // vec2 duplicate
        public dvec2 zz
        {
            get { return new dvec2(z, z); }
            set { z = value.x; z = value.y; }
        }

        // dvec3 duplicates
        public dvec3 xxx { get { return new dvec3(x, x, x); } set { x = value.x; x = value.y; x = value.z; } }
        public dvec3 xxy { get { return new dvec3(x, x, y); } set { x = value.x; x = value.y; y = value.z; } }
        public dvec3 xxz { get { return new dvec3(x, x, z); } set { x = value.x; x = value.y; z = value.z; } }
        public dvec3 xyx { get { return new dvec3(x, y, x); } set { x = value.x; y = value.y; x = value.z; } }
        public dvec3 xyy { get { return new dvec3(x, y, y); } set { x = value.x; y = value.y; y = value.z; } }
        public dvec3 xzx { get { return new dvec3(x, z, x); } set { x = value.x; z = value.y; x = value.z; } }
        public dvec3 xzz { get { return new dvec3(x, z, z); } set { x = value.x; z = value.y; z = value.z; } }
        public dvec3 yxx { get { return new dvec3(y, x, x); } set { y = value.x; x = value.y; x = value.z; } }
        public dvec3 yxy { get { return new dvec3(y, x, y); } set { y = value.x; x = value.y; y = value.z; } }
        public dvec3 yyx { get { return new dvec3(y, y, x); } set { y = value.x; y = value.y; x = value.z; } }
        public dvec3 yyy { get { return new dvec3(y, y, y); } set { y = value.x; y = value.y; y = value.z; } }
        public dvec3 yyz { get { return new dvec3(y, y, z); } set { y = value.x; y = value.y; z = value.z; } }
        public dvec3 yzy { get { return new dvec3(y, z, y); } set { y = value.x; z = value.y; y = value.z; } }
        public dvec3 yzz { get { return new dvec3(y, z, z); } set { y = value.x; z = value.y; z = value.z; } }
        public dvec3 zxx { get { return new dvec3(z, x, x); } set { z = value.x; x = value.y; x = value.z; } }
        public dvec3 zxz { get { return new dvec3(z, x, z); } set { z = value.x; x = value.y; z = value.z; } }
        public dvec3 zyy { get { return new dvec3(z, y, y); } set { z = value.x; y = value.y; y = value.z; } }
        public dvec3 zyz { get { return new dvec3(z, y, z); } set { z = value.x; y = value.y; z = value.z; } }
        public dvec3 zzx { get { return new dvec3(z, z, x); } set { z = value.x; z = value.y; x = value.z; } }
        public dvec3 zzy { get { return new dvec3(z, z, y); } set { z = value.x; z = value.y; y = value.z; } }
        public dvec3 zzz { get { return new dvec3(z, z, z); } set { z = value.x; z = value.y; z = value.z; } }
#endif

#endif

#if COLOURS_ENABLED
#if CAPITALS_ENABLED
        public double B
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
        public double b
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
        public dvec2 rb
        {
            get
            {
                return new dvec2(x, z);
            }
            set
            {
                x = value.x;
                z = value.y;
            }
        }
        public dvec2 br
        {
            get
            {
                return new dvec2(z, x);
            }
            set
            {
                z = value.x;
                x = value.y;
            }
        }
        public dvec3 rgb
        {
            get
            {
                return new dvec3(x, y, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }
        public dvec3 rbg
        {
            get
            {
                return new dvec3(x, z, y);
            }
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
            }
        }
        public dvec3 grb
        {
            get
            {
                return new dvec3(y, x, z);
            }
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
            }
        }
        public dvec3 gbr
        {
            get
            {
                return new dvec3(y, z, x);
            }
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
            }
        }
        public dvec3 bgr
        {
            get
            {
                return new dvec3(z, y, x);
            }
            set
            {
                z = value.x;
                y = value.y;
                x = value.z;
            }
        }
        public dvec3 brg
        {
            get
            {
                return new dvec3(z, x, y);
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
        public dvec2 bb
        {
            get { return new dvec2(b, b); }
            set { b = value.r; b = value.g; }
        }

        // dvec3 color duplicates
        public dvec3 rrr { get { return new dvec3(r, r, r); } set { r = value.r; r = value.g; r = value.b; } }
        public dvec3 rrg { get { return new dvec3(r, r, g); } set { r = value.r; r = value.g; g = value.b; } }
        public dvec3 rrb { get { return new dvec3(r, r, b); } set { r = value.r; r = value.g; b = value.b; } }
        public dvec3 rgr { get { return new dvec3(r, g, r); } set { r = value.r; g = value.g; r = value.b; } }
        public dvec3 rgg { get { return new dvec3(r, g, g); } set { r = value.r; g = value.g; g = value.b; } }
        public dvec3 rbr { get { return new dvec3(r, b, r); } set { r = value.r; b = value.g; r = value.b; } }
        public dvec3 rbb { get { return new dvec3(r, b, b); } set { r = value.r; b = value.g; b = value.b; } }
        public dvec3 grr { get { return new dvec3(g, r, r); } set { g = value.r; r = value.g; r = value.b; } }
        public dvec3 grg { get { return new dvec3(g, r, g); } set { g = value.r; r = value.g; g = value.b; } }
        public dvec3 ggr { get { return new dvec3(g, g, r); } set { g = value.r; g = value.g; r = value.b; } }
        public dvec3 ggg { get { return new dvec3(g, g, g); } set { g = value.r; g = value.g; g = value.b; } }
        public dvec3 ggb { get { return new dvec3(g, g, b); } set { g = value.r; g = value.g; b = value.b; } }
        public dvec3 gbg { get { return new dvec3(g, b, g); } set { g = value.r; b = value.g; g = value.b; } }
        public dvec3 gbb { get { return new dvec3(g, b, b); } set { g = value.r; b = value.g; b = value.b; } }
        public dvec3 brr { get { return new dvec3(b, r, r); } set { b = value.r; r = value.g; r = value.b; } }
        public dvec3 brb { get { return new dvec3(b, r, b); } set { b = value.r; r = value.g; b = value.b; } }
        public dvec3 bgg { get { return new dvec3(b, g, g); } set { b = value.r; g = value.g; g = value.b; } }
        public dvec3 bgb { get { return new dvec3(b, g, b); } set { b = value.r; g = value.g; b = value.b; } }
        public dvec3 bbr { get { return new dvec3(b, b, r); } set { b = value.r; b = value.g; r = value.b; } }
        public dvec3 bbg { get { return new dvec3(b, b, g); } set { b = value.r; b = value.g; g = value.b; } }
        public dvec3 bbb { get { return new dvec3(b, b, b); } set { b = value.r; b = value.g; b = value.b; } }
#endif
#endif
    }
}
#endif
#endif