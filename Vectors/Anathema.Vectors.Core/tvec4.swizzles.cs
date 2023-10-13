#if TEMPLATES_ENABLED
#if SWIZZLES_ENABLED

using System;
using System.Collections.Generic;
using System.Text;

namespace Anathema.Vectors.Core
{
    public partial class tvec4<T> : tvec3<T>
    {
        // 4! = 4 * 3 * 2 * 1 = 24
        // There are 24 swizzles, in 4 groups of 6

        //Starting with X (6)

        public tvec4<T> xyzw
        {
            get
            {
                return new tvec4<T>(x, y, z, w);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
                w = value.w;
            }
        }
        public tvec4<T> xwzy
        {
            get
            {
                return new tvec4<T>(x, w, z, y);
            }
            set
            {
                x = value.x;
                w = value.y;
                z = value.z;
                y = value.w;
            }
        }
        public tvec4<T> xwyz
        {
            get
            {
                return new tvec4<T>(x, w, y, z);
            }
            set
            {
                x = value.x;
                w = value.y;
                y = value.z;
                z = value.w;
            }
        }
        public tvec4<T> xywz
        {
            get
            {
                return new tvec4<T>(x, y, w, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                w = value.z;
                z = value.w;
            }
        }
        public tvec4<T> xzyw
        {
            get
            {
                return new tvec4<T>(x, z, y, w);
            }
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
                w = value.w;
            }
        }
        public tvec4<T> xzwy
        {
            get
            {
                return new tvec4<T>(x, z, w, y);
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

        public tvec4<T> yxzw
        {
            get
            {
                return new tvec4<T>(y, x, z, w);
            }
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
                w = value.w;
            }
        }
        public tvec4<T> yxwz
        {
            get
            {
                return new tvec4<T>(y, x, w, z);
            }
            set
            {
                y = value.x;
                x = value.y;
                w = value.z;
                z = value.w;
            }
        }
        public tvec4<T> yzxw
        {
            get
            {
                return new tvec4<T>(y, z, x, w);
            }
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
                w = value.w;
            }
        }
        public tvec4<T> yzwx
        {
            get
            {
                return new tvec4<T>(y, z, w, x);
            }
            set
            {
                y = value.x;
                z = value.y;
                w = value.z;
                x = value.w;
            }
        }
        public tvec4<T> ywzx
        {
            get
            {
                return new tvec4<T>(y, w, z, x);
            }
            set
            {
                y = value.x;
                w = value.y;
                z = value.z;
                x = value.w;
            }
        }
        public tvec4<T> ywxz
        {
            get
            {
                return new tvec4<T>(y, w, x, z);
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

        public tvec4<T> zxyw
        {
            get
            {
                return new tvec4<T>(z, x, y, w);
            }
            set
            {
                z = value.x;
                x = value.y;
                y = value.z;
                w = value.w;
            }
        }
        public tvec4<T> zyxw
        {
            get
            {
                return new tvec4<T>(z, y, x, w);
            }
            set
            {
                z = value.x;
                y = value.y;
                x = value.z;
                w = value.w;
            }
        }
        public tvec4<T> zywx
        {
            get
            {
                return new tvec4<T>(z, y, w, x);
            }
            set
            {
                z = value.x;
                y = value.y;
                w = value.z;
                x = value.w;
            }
        }
        public tvec4<T> zxwy
        {
            get
            {
                return new tvec4<T>(z, x, w, y);
            }
            set
            {
                z = value.x;
                x = value.y;
                w = value.z;
                y = value.w;
            }
        }
        public tvec4<T> zwxy
        {
            get
            {
                return new tvec4<T>(z, w, x, y);
            }
            set
            {
                z = value.x;
                w = value.y;
                x = value.z;
                y = value.w;
            }
        }
        public tvec4<T> zwyx
        {
            get
            {
                return new tvec4<T>(z, w, y, x);
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

        public tvec4<T> wxyz
        {
            get
            {
                return new tvec4<T>(w, x, y, z);
            }
            set
            {
                w = value.x;
                x = value.y;
                y = value.z;
                z = value.w;
            }
        }

        public tvec4<T> wxzy
        {
            get
            {
                return new tvec4<T>(w, x, z, y);
            }
            set
            {
                w = value.x;
                x = value.y;
                z = value.z;
                y = value.w;
            }
        }
        public tvec4<T> wyxz
        {
            get
            {
                return new tvec4<T>(w, y, x, z);
            }
            set
            {
                w = value.x;
                y = value.y;
                x = value.z;
                z = value.w;
            }
        }
        public tvec4<T> wyzx
        {
            get
            {
                return new tvec4<T>(w, y, z, x);
            }
            set
            {
                w = value.x;
                y = value.y;
                z = value.z;
                x = value.w;
            }
        }
        public tvec4<T> wzxy
        {
            get
            {
                return new tvec4<T>(w, z, x, y);
            }
            set
            {
                w = value.x;
                z = value.y;
                x = value.z;
                y = value.w;
            }
        }
        public tvec4<T> wzyx
        {
            get
            {
                return new tvec4<T>(w, z, y, x);
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
        public T a
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

        public tvec4<T> rgba
        {
            get
            {
                return new tvec4<T>(r, g, b, a);
            }
            set
            {
                r = value.r;
                g = value.g;
                b = value.b;
                a = value.a;
            }
        }
        public tvec4<T> rabg
        {
            get
            {
                return new tvec4<T>(r, a, b, g);
            }
            set
            {
                r = value.r;
                a = value.g;
                b = value.b;
                g = value.a;
            }
        }
        public tvec4<T> ragb
        {
            get
            {
                return new tvec4<T>(r, a, g, b);
            }
            set
            {
                r = value.r;
                a = value.g;
                g = value.b;
                b = value.a;
            }
        }
        public tvec4<T> rgab
        {
            get
            {
                return new tvec4<T>(r, g, a, b);
            }
            set
            {
                r = value.r;
                g = value.g;
                a = value.b;
                b = value.a;
            }
        }
        public tvec4<T> rbga
        {
            get
            {
                return new tvec4<T>(r, b, g, a);
            }
            set
            {
                r = value.r;
                b = value.g;
                g = value.b;
                a = value.a;
            }
        }
        public tvec4<T> rbag
        {
            get
            {
                return new tvec4<T>(r, b, a, g);
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

        public tvec4<T> grba
        {
            get
            {
                return new tvec4<T>(g, r, b, a);
            }
            set
            {
                g = value.r;
                r = value.g;
                b = value.b;
                a = value.a;
            }
        }
        public tvec4<T> grab
        {
            get
            {
                return new tvec4<T>(g, r, a, b);
            }
            set
            {
                g = value.r;
                r = value.g;
                a = value.b;
                b = value.a;
            }
        }
        public tvec4<T> gbra
        {
            get
            {
                return new tvec4<T>(g, b, r, a);
            }
            set
            {
                g = value.r;
                b = value.g;
                r = value.b;
                a = value.a;
            }
        }
        public tvec4<T> gbar
        {
            get
            {
                return new tvec4<T>(g, b, a, r);
            }
            set
            {
                g = value.r;
                b = value.g;
                a = value.b;
                r = value.a;
            }
        }
        public tvec4<T> gabr
        {
            get
            {
                return new tvec4<T>(g, a, b, r);
            }
            set
            {
                g = value.r;
                a = value.g;
                b = value.b;
                r = value.a;
            }
        }
        public tvec4<T> garb
        {
            get
            {
                return new tvec4<T>(g, a, r, b);
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

        public tvec4<T> brga
        {
            get
            {
                return new tvec4<T>(b, r, g, a);
            }
            set
            {
                b = value.r;
                r = value.g;
                g = value.b;
                a = value.a;
            }
        }
        public tvec4<T> bgra
        {
            get
            {
                return new tvec4<T>(b, g, r, a);
            }
            set
            {
                b = value.r;
                g = value.g;
                r = value.b;
                a = value.a;
            }
        }
        public tvec4<T> bgar
        {
            get
            {
                return new tvec4<T>(b, g, a, r);
            }
            set
            {
                b = value.r;
                g = value.g;
                a = value.b;
                r = value.a;
            }
        }
        public tvec4<T> brag
        {
            get
            {
                return new tvec4<T>(b, r, a, g);
            }
            set
            {
                b = value.r;
                r = value.g;
                a = value.b;
                g = value.a;
            }
        }
        public tvec4<T> barg
        {
            get
            {
                return new tvec4<T>(b, a, r, g);
            }
            set
            {
                b = value.r;
                a = value.g;
                r = value.b;
                g = value.a;
            }
        }
        public tvec4<T> bagr
        {
            get
            {
                return new tvec4<T>(b, a, g, r);
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

        public tvec4<T> argb
        {
            get
            {
                return new tvec4<T>(a, r, g, b);
            }
            set
            {
                a = value.r;
                r = value.g;
                g = value.b;
                b = value.a;
            }
        }

        public tvec4<T> arbg
        {
            get
            {
                return new tvec4<T>(a, r, b, g);
            }
            set
            {
                a = value.r;
                r = value.g;
                b = value.b;
                g = value.a;
            }
        }
        public tvec4<T> agrb
        {
            get
            {
                return new tvec4<T>(a, g, r, b);
            }
            set
            {
                a = value.r;
                g = value.g;
                r = value.b;
                b = value.a;
            }
        }
        public tvec4<T> agbr
        {
            get
            {
                return new tvec4<T>(a, g, b, r);
            }
            set
            {
                a = value.r;
                g = value.g;
                b = value.b;
                r = value.a;
            }
        }
        public tvec4<T> abrg
        {
            get
            {
                return new tvec4<T>(a, b, r, g);
            }
            set
            {
                a = value.r;
                b = value.g;
                r = value.b;
                g = value.a;
            }
        }
        public tvec4<T> abgr
        {
            get
            {
                return new tvec4<T>(a, b, g, r);
            }
            set
            {
                a = value.r;
                b = value.g;
                g = value.b;
                r = value.a;
            }
        }

    }
}

#endif
#endif