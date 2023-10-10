#if FLOATS_ENABLED
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.Vectors.Core
{
    /// <summary>
    /// A single-precision floating point, 4-component vector.
    /// </summary>
    public class fvec4 : fvec3
    {
        ///////////////////////////
        //        Members        //
        ///////////////////////////

        public float w { get; set; }

        ///////////////////////////
        //     Constructors      //
        ///////////////////////////

        public fvec4()
        {
        }
        public fvec4(fvec3 xyz, float w)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }
#if CONVERSIONS_ENABLED
        public fvec4(float x, fvec3 yzw)
        {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }
        public fvec4(fvec2 xy, fvec2 zw)
        {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }
        public fvec4(float x, float y, fvec2 zw)
        {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }
        public fvec4(float x, fvec2 yz, float w)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }
        public fvec4(fvec2 xy, float z, float w)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }
        public fvec4(dvec4 xyzw)
        {
            x = (float)xyzw.x;
            y = (float)xyzw.y;
            z = (float)xyzw.z;
            w = (float)xyzw.w;
        }
#endif
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

        ///////////////////////////
        //      Derivations      //
        ///////////////////////////

        public fvec3 scaledToFVec3()
        {
            return new fvec3(x / w, y / w, z / w);
        }

        ///////////////////////////
        //        Swizzles       //
        ///////////////////////////

        // 4! = 4 * 3 * 2 * 1 = 24
        // There are 24 swizzles, in 4 groups of 6

        //Starting with X (6)

#if SWIZZLES_ENABLED

        public fvec4 xyzw
        {
            get
            {
                return new fvec4(x, y, z, w);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
                w = value.w;
            }
        }
        public fvec4 xwzy
        {
            get
            {
                return new fvec4(x, w, z, y);
            }
            set
            {
                x = value.x;
                w = value.y;
                z = value.z;
                y = value.w;
            }
        }
        public fvec4 xwyz
        {
            get
            {
                return new fvec4(x, w, y, z);
            }
            set
            {
                x = value.x;
                w = value.y;
                y = value.z;
                z = value.w;
            }
        }
        public fvec4 xywz
        {
            get
            {
                return new fvec4(x, y, w, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                w = value.z;
                z = value.w;
            }
        }
        public fvec4 xzyw
        {
            get
            {
                return new fvec4(x, z, y, w);
            }
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
                w = value.w;
            }
        }
        public fvec4 xzwy
        {
            get
            {
                return new fvec4(x, z, w, y);
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

        public fvec4 yxzw
        {
            get
            {
                return new fvec4(y, x, z, w);
            }
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
                w = value.w;
            }
        }
        public fvec4 yxwz
        {
            get
            {
                return new fvec4(y, x, w, z);
            }
            set
            {
                y = value.x;
                x = value.y;
                w = value.z;
                z = value.w;
            }
        }
        public fvec4 yzxw
        {
            get
            {
                return new fvec4(y, z, x, w);
            }
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
                w = value.w;
            }
        }
        public fvec4 yzwx
        {
            get
            {
                return new fvec4(y, z, w, x);
            }
            set
            {
                y = value.x;
                z = value.y;
                w = value.z;
                x = value.w;
            }
        }
        public fvec4 ywzx
        {
            get
            {
                return new fvec4(y, w, z, x);
            }
            set
            {
                y = value.x;
                w = value.y;
                z = value.z;
                x = value.w;
            }
        }
        public fvec4 ywxz
        {
            get
            {
                return new fvec4(y, w, x, z);
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

        public fvec4 zxyw
        {
            get
            {
                return new fvec4(z, x, y, w);
            }
            set
            {
                z = value.x;
                x = value.y;
                y = value.z;
                w = value.w;
            }
        }
        public fvec4 zyxw
        {
            get
            {
                return new fvec4(z, y, x, w);
            }
            set
            {
                z = value.x;
                y = value.y;
                x = value.z;
                w = value.w;
            }
        }
        public fvec4 zywx
        {
            get
            {
                return new fvec4(z, y, w, x);
            }
            set
            {
                z = value.x;
                y = value.y;
                w = value.z;
                x = value.w;
            }
        }
        public fvec4 zxwy
        {
            get
            {
                return new fvec4(z, x, w, y);
            }
            set
            {
                z = value.x;
                x = value.y;
                w = value.z;
                y = value.w;
            }
        }
        public fvec4 zwxy
        {
            get
            {
                return new fvec4(z, w, x, y);
            }
            set
            {
                z = value.x;
                w = value.y;
                x = value.z;
                y = value.w;
            }
        }
        public fvec4 zwyx
        {
            get
            {
                return new fvec4(z, w, y, x);
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

        public fvec4 wxyz
        {
            get
            {
                return new fvec4(w, x, y, z);
            }
            set
            {
                w = value.x;
                x = value.y;
                y = value.z;
                z = value.w;
            }
        }

        public fvec4 wxzy
        {
            get
            {
                return new fvec4(w, x, z, y);
            }
            set
            {
                w = value.x;
                x = value.y;
                z = value.z;
                y = value.w;
            }
        }
        public fvec4 wyxz
        {
            get
            {
                return new fvec4(w, y, x, z);
            }
            set
            {
                w = value.x;
                y = value.y;
                x = value.z;
                z = value.w;
            }
        }
        public fvec4 wyzx
        {
            get
            {
                return new fvec4(w, y, z, x);
            }
            set
            {
                w = value.x;
                y = value.y;
                z = value.z;
                x = value.w;
            }
        }
        public fvec4 wzxy
        {
            get
            {
                return new fvec4(w, z, x, y);
            }
            set
            {
                w = value.x;
                z = value.y;
                x = value.z;
                y = value.w;
            }
        }
        public fvec4 wzyx
        {
            get
            {
                return new fvec4(w, z, y, x);
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

        public fvec4 rgba
        {
            get
            {
                return new fvec4(r, g, b, a);
            }
            set
            {
                r = value.r;
                g = value.g;
                b = value.b;
                a = value.a;
            }
        }
        public fvec4 rabg
        {
            get
            {
                return new fvec4(r, a, b, g);
            }
            set
            {
                r = value.r;
                a = value.g;
                b = value.b;
                g = value.a;
            }
        }
        public fvec4 ragb
        {
            get
            {
                return new fvec4(r, a, g, b);
            }
            set
            {
                r = value.r;
                a = value.g;
                g = value.b;
                b = value.a;
            }
        }
        public fvec4 rgab
        {
            get
            {
                return new fvec4(r, g, a, b);
            }
            set
            {
                r = value.r;
                g = value.g;
                a = value.b;
                b = value.a;
            }
        }
        public fvec4 rbga
        {
            get
            {
                return new fvec4(r, b, g, a);
            }
            set
            {
                r = value.r;
                b = value.g;
                g = value.b;
                a = value.a;
            }
        }
        public fvec4 rbag
        {
            get
            {
                return new fvec4(r, b, a, g);
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

        public fvec4 grba
        {
            get
            {
                return new fvec4(g, r, b, a);
            }
            set
            {
                g = value.r;
                r = value.g;
                b = value.b;
                a = value.a;
            }
        }
        public fvec4 grab
        {
            get
            {
                return new fvec4(g, r, a, b);
            }
            set
            {
                g = value.r;
                r = value.g;
                a = value.b;
                b = value.a;
            }
        }
        public fvec4 gbra
        {
            get
            {
                return new fvec4(g, b, r, a);
            }
            set
            {
                g = value.r;
                b = value.g;
                r = value.b;
                a = value.a;
            }
        }
        public fvec4 gbar
        {
            get
            {
                return new fvec4(g, b, a, r);
            }
            set
            {
                g = value.r;
                b = value.g;
                a = value.b;
                r = value.a;
            }
        }
        public fvec4 gabr
        {
            get
            {
                return new fvec4(g, a, b, r);
            }
            set
            {
                g = value.r;
                a = value.g;
                b = value.b;
                r = value.a;
            }
        }
        public fvec4 garb
        {
            get
            {
                return new fvec4(g, a, r, b);
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

        public fvec4 brga
        {
            get
            {
                return new fvec4(b, r, g, a);
            }
            set
            {
                b = value.r;
                r = value.g;
                g = value.b;
                a = value.a;
            }
        }
        public fvec4 bgra
        {
            get
            {
                return new fvec4(b, g, r, a);
            }
            set
            {
                b = value.r;
                g = value.g;
                r = value.b;
                a = value.a;
            }
        }
        public fvec4 bgar
        {
            get
            {
                return new fvec4(b, g, a, r);
            }
            set
            {
                b = value.r;
                g = value.g;
                a = value.b;
                r = value.a;
            }
        }
        public fvec4 brag
        {
            get
            {
                return new fvec4(b, r, a, g);
            }
            set
            {
                b = value.r;
                r = value.g;
                a = value.b;
                g = value.a;
            }
        }
        public fvec4 barg
        {
            get
            {
                return new fvec4(b, a, r, g);
            }
            set
            {
                b = value.r;
                a = value.g;
                r = value.b;
                g = value.a;
            }
        }
        public fvec4 bagr
        {
            get
            {
                return new fvec4(b, a, g, r);
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

        public fvec4 argb
        {
            get
            {
                return new fvec4(a, r, g, b);
            }
            set
            {
                a = value.r;
                r = value.g;
                g = value.b;
                b = value.a;
            }
        }

        public fvec4 arbg
        {
            get
            {
                return new fvec4(a, r, b, g);
            }
            set
            {
                a = value.r;
                r = value.g;
                b = value.b;
                g = value.a;
            }
        }
        public fvec4 agrb
        {
            get
            {
                return new fvec4(a, g, r, b);
            }
            set
            {
                a = value.r;
                g = value.g;
                r = value.b;
                b = value.a;
            }
        }
        public fvec4 agbr
        {
            get
            {
                return new fvec4(a, g, b, r);
            }
            set
            {
                a = value.r;
                g = value.g;
                b = value.b;
                r = value.a;
            }
        }
        public fvec4 abrg
        {
            get
            {
                return new fvec4(a, b, r, g);
            }
            set
            {
                a = value.r;
                b = value.g;
                r = value.b;
                g = value.a;
            }
        }
        public fvec4 abgr
        {
            get
            {
                return new fvec4(a, b, g, r);
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
        ///////////////////////////
        //       Operators       //
        ///////////////////////////


        public fvec4 dot(fvec4 b)
        {
            return dot(this, b);
        }
        public static fvec4 dot(fvec4 a, fvec4 b)
        {
            return a * b;
        }

        public static bool operator !=(fvec4 a, fvec4 b)
        {
            return !(a == b);
        }
        public static bool operator ==(fvec4 a, fvec4 b)
        {
            return scalar.isClose(a.x, b.x) && scalar.isClose(a.y, b.y) && scalar.isClose(a.z, b.z) && scalar.isClose(a.w, b.w);
        }


        public static fvec4 operator *(fvec4 a, fvec4 b)
        {
            return new fvec4(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
        }
        public static fvec4 operator /(fvec4 a, fvec4 b)
        {
            return new fvec4(a.x / b.x, a.y / b.y, a.z / b.z, a.w / b.w);
        }
        public static fvec4 operator +(fvec4 a, fvec4 b)
        {
            return new fvec4(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
        }
        public static fvec4 operator -(fvec4 a, fvec4 b)
        {
            return new fvec4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
        }



        public static fvec4 operator *(fvec2 a, fvec4 b)
        {
            return new fvec4(a.x * b.x, a.y * b.y, b.z, b.w);
        }
        public static fvec4 operator /(fvec2 a, fvec4 b)
        {
            return new fvec4(a.x / b.x, a.y / b.y, b.z, b.w);
        }
        public static fvec4 operator +(fvec2 a, fvec4 b)
        {
            return new fvec4(a.x + b.x, a.y + b.y, b.z, b.w);
        }
        public static fvec4 operator -(fvec2 a, fvec4 b)
        {
            return new fvec4(a.x - b.x, a.y - b.y, b.z, b.w);
        }



        public static fvec4 operator *(fvec4 a, fvec2 b)
        {
            return new fvec4(a.x * b.x, a.y * b.y, a.z, a.w);
        }
        public static fvec4 operator /(fvec4 a, fvec2 b)
        {
            return new fvec4(a.x / b.x, a.y / b.y, a.z, a.w);
        }
        public static fvec4 operator +(fvec4 a, fvec2 b)
        {
            return new fvec4(a.x + b.x, a.y + b.y, a.z, a.w);
        }
        public static fvec4 operator -(fvec4 a, fvec2 b)
        {
            return new fvec4(a.x - b.x, a.y - b.y, a.z, a.w);
        }



        public static fvec4 operator *(fvec3 a, fvec4 b)
        {
            return new fvec4(a.x * b.x, a.y * b.y, a.z * b.z, b.w);
        }
        public static fvec4 operator /(fvec3 a, fvec4 b)
        {
            return new fvec4(a.x / b.x, a.y / b.y, a.z / b.z, b.w);
        }
        public static fvec4 operator +(fvec3 a, fvec4 b)
        {
            return new fvec4(a.x + b.x, a.y + b.y, a.z + b.z, b.w);
        }
        public static fvec4 operator -(fvec3 a, fvec4 b)
        {
            return new fvec4(a.x - b.x, a.y - b.y, a.z - b.z, b.w);
        }



        public static fvec4 operator *(fvec4 a, fvec3 b)
        {
            return new fvec4(a.x * b.x, a.y * b.y, a.z * b.z, a.w);
        }
        public static fvec4 operator /(fvec4 a, fvec3 b)
        {
            return new fvec4(a.x / b.x, a.y / b.y, a.z / b.z, a.w);
        }
        public static fvec4 operator +(fvec4 a, fvec3 b)
        {
            return new fvec4(a.x + b.x, a.y + b.y, a.z + b.z, a.w);
        }
        public static fvec4 operator -(fvec4 a, fvec3 b)
        {
            return new fvec4(a.x - b.x, a.y - b.y, a.z - b.z, a.w);
        }





        public static fvec4 operator *(fvec4 a, float b)
        {
            return new fvec4(a.x * b, a.y * b, a.z * b, a.w * b);
        }
        public static fvec4 operator /(fvec4 a, float b)
        {
            return new fvec4(a.x / b, a.y / b, a.z / b, a.w / b);
        }
        public static fvec4 operator +(fvec4 a, float b)
        {
            return new fvec4(a.x + b, a.y + b, a.z + b, a.w + b);
        }
        public static fvec4 operator -(fvec4 a, float b)
        {
            return new fvec4(a.x - b, a.y - b, a.z - b, a.w - b);
        }


        public static fvec4 operator *(float b, fvec4 a)
        {
            return new fvec4(a.x * b, a.y * b, a.z * b, a.w * b);
        }
        public static fvec4 operator /(float b, fvec4 a)
        {
            return new fvec4(a.x / b, a.y / b, a.z / b, a.w / b);
        }
        public static fvec4 operator +(float b, fvec4 a)
        {
            return new fvec4(a.x + b, a.y + b, a.z + b, a.w + b);
        }
        public static fvec4 operator -(float b, fvec4 a)
        {
            return new fvec4(a.x - b, a.y - b, a.z - b, a.w + b);
        }
        public static fvec4 operator -(fvec4 a)
        {
            return new fvec4(-a.x, -a.y, -a.z, -a.w);
        }

        public static fvec4 operator *(fvec4 a, fmat4 b)
        {
            return new fvec4(    (a.x * b.getValue(0, 0)) + (a.y * b.getValue(0, 1)) + (a.z * b.getValue(0, 2)) + (a.w * b.getValue(0, 3)),
                                 (a.x * b.getValue(1, 0)) + (a.y * b.getValue(1, 1)) + (a.z * b.getValue(1, 2)) + (a.w * b.getValue(1, 3)),
                                 (a.x * b.getValue(2, 0)) + (a.y * b.getValue(2, 1)) + (a.z * b.getValue(2, 2)) + (a.w * b.getValue(2, 3)),
                                 (a.x * b.getValue(3, 0)) + (a.y * b.getValue(3, 1)) + (a.z * b.getValue(3, 2)) + (a.w * b.getValue(3, 3))
                                 );
        }
        public static fvec4 operator *(fmat4 b, fvec4 a)
        {
            return a * b.transposed;
        }


#if CONVERSIONS_ENABLED
        public static dvec4 operator *(fvec4 a, dmat4 b)
        {
            return new dvec4((a.x * b.getValue(0, 0)) + (a.y * b.getValue(0, 1)) + (a.z * b.getValue(0, 2)) + (a.w * b.getValue(0, 3)),
                                 (a.x * b.getValue(1, 0)) + (a.y * b.getValue(1, 1)) + (a.z * b.getValue(1, 2)) + (a.w * b.getValue(1, 3)),
                                 (a.x * b.getValue(2, 0)) + (a.y * b.getValue(2, 1)) + (a.z * b.getValue(2, 2)) + (a.w * b.getValue(2, 3)),
                                 (a.x * b.getValue(3, 0)) + (a.y * b.getValue(3, 1)) + (a.z * b.getValue(3, 2)) + (a.w * b.getValue(3, 3))
                                 );
        }
        public static dvec4 operator *(dmat4 b, fvec4 a)
        {
            return a * b.transposed;
        }
#endif
#if NESTING_ENABLED
        public static fvec4 operator *(fvec4 a, tvec4<tvec4<float>> b)
        {
            fmat4 matrix = fmat4.fromNestedVector(b);

            return a * matrix;
        }
        public static fvec4 operator *(tvec4<tvec4<float>> b, fvec4 a)
        {
            fmat4 matrix = fmat4.fromNestedVector(b);

            return a * matrix.transposed;
        }

#endif

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

        ///////////////////////////
        //     Interpolation     //
        ///////////////////////////
#if INTERPOLATION_ENABLED
        public static fvec4 linearInterpolate(fvec4 a, fvec4 b, float position)
        {
            return (a * (1 - position)) + (b * position);
        }
        public fvec4 linearInterpolateTo(fvec4 b, float position)
        {
            return linearInterpolate(this, b, position);
        }


        public static fvec4 quadraticBezierInterpolate(fvec4 a, fvec4 b, fvec4 c, float position)
        {
            return linearInterpolate(
                linearInterpolate(a, b, position),
                linearInterpolate(b, c, position),
                position);
        }
        public fvec4 quadraticBezierInterpolateTo(fvec4 b, fvec4 c, float position)
        {
            return quadraticBezierInterpolate(this, b, c, position);
        }


#endif
    }
}
#endif