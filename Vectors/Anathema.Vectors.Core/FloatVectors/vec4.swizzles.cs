﻿
#if FLOATS_ENABLED
#if THREED_ENABLED
namespace Anathema.Vectors.Core
{
    public partial class vec4 : vec3
    {

#if CAPITALS_ENABLED
        public float W
        {
            get
            {
                return w;
            }
            set
            {
                w = value;
            }
        }
#endif
        // 4! = 4 * 3 * 2 * 1 = 24
        // There are 24 swizzles, in 4 groups of 6

        //Starting with X (6)

#if SWIZZLES_ENABLED

        public vec4 xyzw
        {
            get
            {
                return new vec4(x, y, z, w);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
                w = value.w;
            }
        }
        public vec4 xwzy
        {
            get
            {
                return new vec4(x, w, z, y);
            }
            set
            {
                x = value.x;
                w = value.y;
                z = value.z;
                y = value.w;
            }
        }
        public vec4 xwyz
        {
            get
            {
                return new vec4(x, w, y, z);
            }
            set
            {
                x = value.x;
                w = value.y;
                y = value.z;
                z = value.w;
            }
        }
        public vec4 xywz
        {
            get
            {
                return new vec4(x, y, w, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                w = value.z;
                z = value.w;
            }
        }
        public vec4 xzyw
        {
            get
            {
                return new vec4(x, z, y, w);
            }
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
                w = value.w;
            }
        }
        public vec4 xzwy
        {
            get
            {
                return new vec4(x, z, w, y);
            }
            set
            {
                x = value.x;
                z = value.y;
                w = value.z;
                y = value.w;
            }
        }





        //Starting with Y (6)

        public vec4 yxzw
        {
            get
            {
                return new vec4(y, x, z, w);
            }
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
                w = value.w;
            }
        }
        public vec4 yxwz
        {
            get
            {
                return new vec4(y, x, w, z);
            }
            set
            {
                y = value.x;
                x = value.y;
                w = value.z;
                z = value.w;
            }
        }
        public vec4 yzxw
        {
            get
            {
                return new vec4(y, z, x, w);
            }
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
                w = value.w;
            }
        }
        public vec4 yzwx
        {
            get
            {
                return new vec4(y, z, w, x);
            }
            set
            {
                y = value.x;
                z = value.y;
                w = value.z;
                x = value.w;
            }
        }
        public vec4 ywzx
        {
            get
            {
                return new vec4(y, w, z, x);
            }
            set
            {
                y = value.x;
                w = value.y;
                z = value.z;
                x = value.w;
            }
        }
        public vec4 ywxz
        {
            get
            {
                return new vec4(y, w, x, z);
            }
            set
            {
                y = value.x;
                w = value.y;
                x = value.z;
                z = value.w;
            }
        }



        //Starting with Z (6)

        public vec4 zxyw
        {
            get
            {
                return new vec4(z, x, y, w);
            }
            set
            {
                z = value.x;
                x = value.y;
                y = value.z;
                w = value.w;
            }
        }
        public vec4 zyxw
        {
            get
            {
                return new vec4(z, y, x, w);
            }
            set
            {
                z = value.x;
                y = value.y;
                x = value.z;
                w = value.w;
            }
        }
        public vec4 zywx
        {
            get
            {
                return new vec4(z, y, w, x);
            }
            set
            {
                z = value.x;
                y = value.y;
                w = value.z;
                x = value.w;
            }
        }
        public vec4 zxwy
        {
            get
            {
                return new vec4(z, x, w, y);
            }
            set
            {
                z = value.x;
                x = value.y;
                w = value.z;
                y = value.w;
            }
        }
        public vec4 zwxy
        {
            get
            {
                return new vec4(z, w, x, y);
            }
            set
            {
                z = value.x;
                w = value.y;
                x = value.z;
                y = value.w;
            }
        }
        public vec4 zwyx
        {
            get
            {
                return new vec4(z, w, y, x);
            }
            set
            {
                z = value.x;
                w = value.y;
                y = value.z;
                x = value.w;
            }
        }



        //Starting with W (6)

        public vec4 wxyz
        {
            get
            {
                return new vec4(w, x, y, z);
            }
            set
            {
                w = value.x;
                x = value.y;
                y = value.z;
                z = value.w;
            }
        }

        public vec4 wxzy
        {
            get
            {
                return new vec4(w, x, z, y);
            }
            set
            {
                w = value.x;
                x = value.y;
                z = value.z;
                y = value.w;
            }
        }
        public vec4 wyxz
        {
            get
            {
                return new vec4(w, y, x, z);
            }
            set
            {
                w = value.x;
                y = value.y;
                x = value.z;
                z = value.w;
            }
        }
        public vec4 wyzx
        {
            get
            {
                return new vec4(w, y, z, x);
            }
            set
            {
                w = value.x;
                y = value.y;
                z = value.z;
                x = value.w;
            }
        }
        public vec4 wzxy
        {
            get
            {
                return new vec4(w, z, x, y);
            }
            set
            {
                w = value.x;
                z = value.y;
                x = value.z;
                y = value.w;
            }
        }
        public vec4 wzyx
        {
            get
            {
                return new vec4(w, z, y, x);
            }
            set
            {
                w = value.x;
                z = value.y;
                y = value.z;
                x = value.w;
            }
        }

#endif
#if COLOURS_ENABLED
#if CAPITALS_ENABLED
        public float A
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
        public float a
        {
            get
            {
                return w;
            }
            set
            {
                w = value;
            }
        }

        // Starting with r

        public vec4 rgba
        {
            get
            {
                return new vec4(r, g, b, a);
            }
            set
            {
                r = value.r;
                g = value.g;
                b = value.b;
                a = value.a;
            }
        }
        public vec4 rabg
        {
            get
            {
                return new vec4(r, a, b, g);
            }
            set
            {
                r = value.r;
                a = value.g;
                b = value.b;
                g = value.a;
            }
        }
        public vec4 ragb
        {
            get
            {
                return new vec4(r, a, g, b);
            }
            set
            {
                r = value.r;
                a = value.g;
                g = value.b;
                b = value.a;
            }
        }
        public vec4 rgab
        {
            get
            {
                return new vec4(r, g, a, b);
            }
            set
            {
                r = value.r;
                g = value.g;
                a = value.b;
                b = value.a;
            }
        }
        public vec4 rbga
        {
            get
            {
                return new vec4(r, b, g, a);
            }
            set
            {
                r = value.r;
                b = value.g;
                g = value.b;
                a = value.a;
            }
        }
        public vec4 rbag
        {
            get
            {
                return new vec4(r, b, a, g);
            }
            set
            {
                r = value.r;
                b = value.g;
                a = value.b;
                g = value.a;
            }
        }





        //Starting with g (6)

        public vec4 grba
        {
            get
            {
                return new vec4(g, r, b, a);
            }
            set
            {
                g = value.r;
                r = value.g;
                b = value.b;
                a = value.a;
            }
        }
        public vec4 grab
        {
            get
            {
                return new vec4(g, r, a, b);
            }
            set
            {
                g = value.r;
                r = value.g;
                a = value.b;
                b = value.a;
            }
        }
        public vec4 gbra
        {
            get
            {
                return new vec4(g, b, r, a);
            }
            set
            {
                g = value.r;
                b = value.g;
                r = value.b;
                a = value.a;
            }
        }
        public vec4 gbar
        {
            get
            {
                return new vec4(g, b, a, r);
            }
            set
            {
                g = value.r;
                b = value.g;
                a = value.b;
                r = value.a;
            }
        }
        public vec4 gabr
        {
            get
            {
                return new vec4(g, a, b, r);
            }
            set
            {
                g = value.r;
                a = value.g;
                b = value.b;
                r = value.a;
            }
        }
        public vec4 garb
        {
            get
            {
                return new vec4(g, a, r, b);
            }
            set
            {
                g = value.r;
                a = value.g;
                r = value.b;
                b = value.a;
            }
        }



        //Starting with b (6)

        public vec4 brga
        {
            get
            {
                return new vec4(b, r, g, a);
            }
            set
            {
                b = value.r;
                r = value.g;
                g = value.b;
                a = value.a;
            }
        }
        public vec4 bgra
        {
            get
            {
                return new vec4(b, g, r, a);
            }
            set
            {
                b = value.r;
                g = value.g;
                r = value.b;
                a = value.a;
            }
        }
        public vec4 bgar
        {
            get
            {
                return new vec4(b, g, a, r);
            }
            set
            {
                b = value.r;
                g = value.g;
                a = value.b;
                r = value.a;
            }
        }
        public vec4 brag
        {
            get
            {
                return new vec4(b, r, a, g);
            }
            set
            {
                b = value.r;
                r = value.g;
                a = value.b;
                g = value.a;
            }
        }
        public vec4 barg
        {
            get
            {
                return new vec4(b, a, r, g);
            }
            set
            {
                b = value.r;
                a = value.g;
                r = value.b;
                g = value.a;
            }
        }
        public vec4 bagr
        {
            get
            {
                return new vec4(b, a, g, r);
            }
            set
            {
                b = value.r;
                a = value.g;
                g = value.b;
                r = value.a;
            }
        }



        //Starting with a (6)

        public vec4 argb
        {
            get
            {
                return new vec4(a, r, g, b);
            }
            set
            {
                a = value.r;
                r = value.g;
                g = value.b;
                b = value.a;
            }
        }

        public vec4 arbg
        {
            get
            {
                return new vec4(a, r, b, g);
            }
            set
            {
                a = value.r;
                r = value.g;
                b = value.b;
                g = value.a;
            }
        }
        public vec4 agrb
        {
            get
            {
                return new vec4(a, g, r, b);
            }
            set
            {
                a = value.r;
                g = value.g;
                r = value.b;
                b = value.a;
            }
        }
        public vec4 agbr
        {
            get
            {
                return new vec4(a, g, b, r);
            }
            set
            {
                a = value.r;
                g = value.g;
                b = value.b;
                r = value.a;
            }
        }
        public vec4 abrg
        {
            get
            {
                return new vec4(a, b, r, g);
            }
            set
            {
                a = value.r;
                b = value.g;
                r = value.b;
                g = value.a;
            }
        }
        public vec4 abgr
        {
            get
            {
                return new vec4(a, b, g, r);
            }
            set
            {
                a = value.r;
                b = value.g;
                g = value.b;
                r = value.a;
            }
        }

#endif
    }
}
#endif
#endif