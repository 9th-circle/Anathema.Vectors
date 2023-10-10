#if DOUBLES_ENABLED
#if THREED_ENABLED

using System;
using System.Collections.Generic;

using System.Text;



namespace Anathema.Vectors.Core
{
    /// <summary>
    /// A double precision floating point, 4-component vector.
    /// </summary>
    public class dvec4 : dvec3
    {
        ///////////////////////////
        //        Members        //
        ///////////////////////////

        public double w { get; set; }

        ///////////////////////////
        //     Constructors      //
        ///////////////////////////

        public dvec4()
        {
        }
        public dvec4(dvec3 xyz, double w)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }
        public dvec4(double x, dvec3 yzw)
        {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }
        public dvec4(dvec2 xy, dvec2 zw)
        {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }
        public dvec4(double x, double y, dvec2 zw)
        {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }
        public dvec4(double x, dvec2 yz, double w)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }
        public dvec4(dvec2 xy, double z, double w)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }
        public dvec4(double x, double y, double z, double w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        public dvec4(dvec4 xyzw)
        {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }
        public dvec4(fvec4 xyzw)
        {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        ///////////////////////////
        //      Derivations      //
        ///////////////////////////

        public dvec3 scaledToDVec3()
        {
            return new dvec3(x / w, y / w, z / w);
        }



        ///////////////////////////
        //        Swizzles       //
        ///////////////////////////

// 4! = 4 * 3 * 2 * 1 = 24
// There are 24 swizzles, in 4 groups of 6

//Starting with X (6)
#if SWIZZLES_ENABLED
        public dvec4 xyzw
        {
            get
            {
                return new dvec4(x, y, z, w);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
                w = value.w;
            }
        }
        public dvec4 xwzy
        {
            get
            {
                return new dvec4(x, w, z, y);
            }
            set
            {
                x = value.x;
                w = value.y;
                z = value.z;
                y = value.w;
            }
        }
        public dvec4 xwyz
        {
            get
            {
                return new dvec4(x, w, y, z);
            }
            set
            {
                x = value.x;
                w = value.y;
                y = value.z;
                z = value.w;
            }
        }
        public dvec4 xywz
        {
            get
            {
                return new dvec4(x, y, w, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                w = value.z;
                z = value.w;
            }
        }
        public dvec4 xzyw
        {
            get
            {
                return new dvec4(x, z, y, w);
            }
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
                w = value.w;
            }
        }
        public dvec4 xzwy
        {
            get
            {
                return new dvec4(x, z, w, y);
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

        public dvec4 yxzw
        {
            get
            {
                return new dvec4(y, x, z, w);
            }
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
                w = value.w;
            }
        }
        public dvec4 yxwz
        {
            get
            {
                return new dvec4(y, x, w, z);
            }
            set
            {
                y = value.x;
                x = value.y;
                w = value.z;
                z = value.w;
            }
        }
        public dvec4 yzxw
        {
            get
            {
                return new dvec4(y, z, x, w);
            }
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
                w = value.w;
            }
        }
        public dvec4 yzwx
        {
            get
            {
                return new dvec4(y, z, w, x);
            }
            set
            {
                y = value.x;
                z = value.y;
                w = value.z;
                x = value.w;
            }
        }
        public dvec4 ywzx
        {
            get
            {
                return new dvec4(y, w, z, x);
            }
            set
            {
                y = value.x;
                w = value.y;
                z = value.z;
                x = value.w;
            }
        }
        public dvec4 ywxz
        {
            get
            {
                return new dvec4(y, w, x, z);
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

        public dvec4 zxyw
        {
            get
            {
                return new dvec4(z, x, y, w);
            }
            set
            {
                z = value.x;
                x = value.y;
                y = value.z;
                w = value.w;
            }
        }
        public dvec4 zyxw
        {
            get
            {
                return new dvec4(z, y, x, w);
            }
            set
            {
                z = value.x;
                y = value.y;
                x = value.z;
                w = value.w;
            }
        }
        public dvec4 zywx
        {
            get
            {
                return new dvec4(z, y, w, x);
            }
            set
            {
                z = value.x;
                y = value.y;
                w = value.z;
                x = value.w;
            }
        }
        public dvec4 zxwy
        {
            get
            {
                return new dvec4(z, x, w, y);
            }
            set
            {
                z = value.x;
                x = value.y;
                w = value.z;
                y = value.w;
            }
        }
        public dvec4 zwxy
        {
            get
            {
                return new dvec4(z, w, x, y);
            }
            set
            {
                z = value.x;
                w = value.y;
                x = value.z;
                y = value.w;
            }
        }
        public dvec4 zwyx
        {
            get
            {
                return new dvec4(z, w, y, x);
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

        public dvec4 wxyz
        {
            get
            {
                return new dvec4(w, x, y, z);
            }
            set
            {
                w = value.x;
                x = value.y;
                y = value.z;
                z = value.w;
            }
        }

        public dvec4 wxzy
        {
            get
            {
                return new dvec4(w, x, z, y);
            }
            set
            {
                w = value.x;
                x = value.y;
                z = value.z;
                y = value.w;
            }
        }
        public dvec4 wyxz
        {
            get
            {
                return new dvec4(w, y, x, z);
            }
            set
            {
                w = value.x;
                y = value.y;
                x = value.z;
                z = value.w;
            }
        }
        public dvec4 wyzx
        {
            get
            {
                return new dvec4(w, y, z, x);
            }
            set
            {
                w = value.x;
                y = value.y;
                z = value.z;
                x = value.w;
            }
        }
        public dvec4 wzxy
        {
            get
            {
                return new dvec4(w, z, x, y);
            }
            set
            {
                w = value.x;
                z = value.y;
                x = value.z;
                y = value.w;
            }
        }
        public dvec4 wzyx
        {
            get
            {
                return new dvec4(w, z, y, x);
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
        public double a
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

        public dvec4 rgba
        {
            get
            {
                return new dvec4(r, g, b, a);
            }
            set
            {
                r = value.r;
                g = value.g;
                b = value.b;
                a = value.a;
            }
        }
        public dvec4 rabg
        {
            get
            {
                return new dvec4(r, a, b, g);
            }
            set
            {
                r = value.r;
                a = value.g;
                b = value.b;
                g = value.a;
            }
        }
        public dvec4 ragb
        {
            get
            {
                return new dvec4(r, a, g, b);
            }
            set
            {
                r = value.r;
                a = value.g;
                g = value.b;
                b = value.a;
            }
        }
        public dvec4 rgab
        {
            get
            {
                return new dvec4(r, g, a, b);
            }
            set
            {
                r = value.r;
                g = value.g;
                a = value.b;
                b = value.a;
            }
        }
        public dvec4 rbga
        {
            get
            {
                return new dvec4(r, b, g, a);
            }
            set
            {
                r = value.r;
                b = value.g;
                g = value.b;
                a = value.a;
            }
        }
        public dvec4 rbag
        {
            get
            {
                return new dvec4(r, b, a, g);
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

        public dvec4 grba
        {
            get
            {
                return new dvec4(g, r, b, a);
            }
            set
            {
                g = value.r;
                r = value.g;
                b = value.b;
                a = value.a;
            }
        }
        public dvec4 grab
        {
            get
            {
                return new dvec4(g, r, a, b);
            }
            set
            {
                g = value.r;
                r = value.g;
                a = value.b;
                b = value.a;
            }
        }
        public dvec4 gbra
        {
            get
            {
                return new dvec4(g, b, r, a);
            }
            set
            {
                g = value.r;
                b = value.g;
                r = value.b;
                a = value.a;
            }
        }
        public dvec4 gbar
        {
            get
            {
                return new dvec4(g, b, a, r);
            }
            set
            {
                g = value.r;
                b = value.g;
                a = value.b;
                r = value.a;
            }
        }
        public dvec4 gabr
        {
            get
            {
                return new dvec4(g, a, b, r);
            }
            set
            {
                g = value.r;
                a = value.g;
                b = value.b;
                r = value.a;
            }
        }
        public dvec4 garb
        {
            get
            {
                return new dvec4(g, a, r, b);
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

        public dvec4 brga
        {
            get
            {
                return new dvec4(b, r, g, a);
            }
            set
            {
                b = value.r;
                r = value.g;
                g = value.b;
                a = value.a;
            }
        }
        public dvec4 bgra
        {
            get
            {
                return new dvec4(b, g, r, a);
            }
            set
            {
                b = value.r;
                g = value.g;
                r = value.b;
                a = value.a;
            }
        }
        public dvec4 bgar
        {
            get
            {
                return new dvec4(b, g, a, r);
            }
            set
            {
                b = value.r;
                g = value.g;
                a = value.b;
                r = value.a;
            }
        }
        public dvec4 brag
        {
            get
            {
                return new dvec4(b, r, a, g);
            }
            set
            {
                b = value.r;
                r = value.g;
                a = value.b;
                g = value.a;
            }
        }
        public dvec4 barg
        {
            get
            {
                return new dvec4(b, a, r, g);
            }
            set
            {
                b = value.r;
                a = value.g;
                r = value.b;
                g = value.a;
            }
        }
        public dvec4 bagr
        {
            get
            {
                return new dvec4(b, a, g, r);
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

        public dvec4 argb
        {
            get
            {
                return new dvec4(a, r, g, b);
            }
            set
            {
                a = value.r;
                r = value.g;
                g = value.b;
                b = value.a;
            }
        }

        public dvec4 arbg
        {
            get
            {
                return new dvec4(a, r, b, g);
            }
            set
            {
                a = value.r;
                r = value.g;
                b = value.b;
                g = value.a;
            }
        }
        public dvec4 agrb
        {
            get
            {
                return new dvec4(a, g, r, b);
            }
            set
            {
                a = value.r;
                g = value.g;
                r = value.b;
                b = value.a;
            }
        }
        public dvec4 agbr
        {
            get
            {
                return new dvec4(a, g, b, r);
            }
            set
            {
                a = value.r;
                g = value.g;
                b = value.b;
                r = value.a;
            }
        }
        public dvec4 abrg
        {
            get
            {
                return new dvec4(a, b, r, g);
            }
            set
            {
                a = value.r;
                b = value.g;
                r = value.b;
                g = value.a;
            }
        }
        public dvec4 abgr
        {
            get
            {
                return new dvec4(a, b, g, r);
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


        public dvec4 dot(dvec4 b)
        {
            return dot(this, b);
        }
        public static dvec4 dot(dvec4 a, dvec4 b)
        {
            return a * b;
        }



        public static bool operator !=(dvec4 a, dvec4 b)
        {
            return !(a == b);
        }
        public static bool operator ==(dvec4 a, dvec4 b)
        {
            return scalar.isClose(a.x, b.x) && scalar.isClose(a.y, b.y) && scalar.isClose(a.z, b.z) && scalar.isClose(a.w, b.w);
        }




        public static dvec4 operator *(dvec4 a, dvec4 b)
        {
            return new dvec4(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
        }
        public static dvec4 operator /(dvec4 a, dvec4 b)
        {
            return new dvec4(a.x / b.x, a.y / b.y, a.z / b.z, a.w / b.w);
        }
        public static dvec4 operator +(dvec4 a, dvec4 b)
        {
            return new dvec4(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
        }
        public static dvec4 operator -(dvec4 a, dvec4 b)
        {
            return new dvec4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
        }



#if CONVERSIONS_ENABLED

        public static dvec4 operator *(fvec4 a, dvec4 b)
        {
            return new dvec4(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
        }
        public static dvec4 operator /(fvec4 a, dvec4 b)
        {
            return new dvec4(a.x / b.x, a.y / b.y, a.z / b.z, a.w / b.w);
        }
        public static dvec4 operator +(fvec4 a, dvec4 b)
        {
            return new dvec4(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
        }
        public static dvec4 operator -(fvec4 a, dvec4 b)
        {
            return new dvec4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
        }





        public static dvec4 operator *(dvec4 a, fvec4 b)
        {
            return new dvec4(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
        }
        public static dvec4 operator /(dvec4 a, fvec4 b)
        {
            return new dvec4(a.x / b.x, a.y / b.y, a.z / b.z, a.w / b.w);
        }
        public static dvec4 operator +(dvec4 a, fvec4 b)
        {
            return new dvec4(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
        }
        public static dvec4 operator -(dvec4 a, fvec4 b)
        {
            return new dvec4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
        }



        public static dvec4 operator *(dvec2 a, dvec4 b)
        {
            return new dvec4(a.x * b.x, a.y * b.y, b.z, b.w);
        }
        public static dvec4 operator /(dvec2 a, dvec4 b)
        {
            return new dvec4(a.x / b.x, a.y / b.y, b.z, b.w);
        }
        public static dvec4 operator +(dvec2 a, dvec4 b)
        {
            return new dvec4(a.x + b.x, a.y + b.y, b.z, b.w);
        }
        public static dvec4 operator -(dvec2 a, dvec4 b)
        {
            return new dvec4(a.x - b.x, a.y - b.y, b.z, b.w);
        }



        public static dvec4 operator *(dvec4 a, dvec2 b)
        {
            return new dvec4(a.x * b.x, a.y * b.y, a.z, a.w);
        }
        public static dvec4 operator /(dvec4 a, dvec2 b)
        {
            return new dvec4(a.x / b.x, a.y / b.y, a.z, a.w);
        }
        public static dvec4 operator +(dvec4 a, dvec2 b)
        {
            return new dvec4(a.x + b.x, a.y + b.y, a.z, a.w);
        }
        public static dvec4 operator -(dvec4 a, dvec2 b)
        {
            return new dvec4(a.x - b.x, a.y - b.y, a.z, a.w);
        }



        public static dvec4 operator *(dvec3 a, dvec4 b)
        {
            return new dvec4(a.x * b.x, a.y * b.y, a.z * b.z, b.w);
        }
        public static dvec4 operator /(dvec3 a, dvec4 b)
        {
            return new dvec4(a.x / b.x, a.y / b.y, a.z / b.z, b.w);
        }
        public static dvec4 operator +(dvec3 a, dvec4 b)
        {
            return new dvec4(a.x + b.x, a.y + b.y, a.z + b.z, b.w);
        }
        public static dvec4 operator -(dvec3 a, dvec4 b)
        {
            return new dvec4(a.x - b.x, a.y - b.y, a.z - b.z, b.w);
        }



        public static dvec4 operator *(dvec4 a, dvec3 b)
        {
            return new dvec4(a.x * b.x, a.y * b.y, a.z * b.z, a.w);
        }
        public static dvec4 operator /(dvec4 a, dvec3 b)
        {
            return new dvec4(a.x / b.x, a.y / b.y, a.z / b.z, a.w);
        }
        public static dvec4 operator +(dvec4 a, dvec3 b)
        {
            return new dvec4(a.x + b.x, a.y + b.y, a.z + b.z, a.w);
        }
        public static dvec4 operator -(dvec4 a, dvec3 b)
        {
            return new dvec4(a.x - b.x, a.y - b.y, a.z - b.z, a.w);
        }
#endif





        public static dvec4 operator *(dvec4 a, double b)
        {
            return new dvec4(a.x * b, a.y * b, a.z * b, a.w * b);
        }
        public static dvec4 operator /(dvec4 a, double b)
        {
            return new dvec4(a.x / b, a.y / b, a.z / b, a.w / b);
        }
        public static dvec4 operator +(dvec4 a, double b)
        {
            return new dvec4(a.x + b, a.y + b, a.z + b, a.w + b);
        }
        public static dvec4 operator -(dvec4 a, double b)
        {
            return new dvec4(a.x - b, a.y - b, a.z - b, a.w - b);
        }


        public static dvec4 operator *(double b, dvec4 a)
        {
            return new dvec4(a.x * b, a.y * b, a.z * b, a.w * b);
        }
        public static dvec4 operator /(double b, dvec4 a)
        {
            return new dvec4(a.x / b, a.y / b, a.z / b, a.w / b);
        }
        public static dvec4 operator +(double b, dvec4 a)
        {
            return new dvec4(a.x + b, a.y + b, a.z + b, a.w + b);
        }
        public static dvec4 operator -(double b, dvec4 a)
        {
            return new dvec4(a.x - b, a.y - b, a.z - b, a.w + b);
        }
        public static dvec4 operator -(dvec4 a)
        {
            return new dvec4(-a.x, -a.y, -a.z, -a.w);
        }

        public static dvec4 operator *(dvec4 a, dmat4 b)
        {
            return new dvec4((a.x * b.getValue(0, 0)) + (a.y * b.getValue(0, 1)) + (a.z * b.getValue(0, 2)) + (a.w * b.getValue(0, 3)),
                                 (a.x * b.getValue(1, 0)) + (a.y * b.getValue(1, 1)) + (a.z * b.getValue(1, 2)) + (a.w * b.getValue(1, 3)),
                                 (a.x * b.getValue(2, 0)) + (a.y * b.getValue(2, 1)) + (a.z * b.getValue(2, 2)) + (a.w * b.getValue(2, 3)),
                                 (a.x * b.getValue(3, 0)) + (a.y * b.getValue(3, 1)) + (a.z * b.getValue(3, 2)) + (a.w * b.getValue(3, 3))
                                 );
        }
        public static dvec4 operator *(dmat4 b, dvec4 a)
        {
            return a * b.transposed;
        }

        public static dvec4 operator *(dvec4 a, fmat4 b)
        {
            return new dvec4((a.x * b.getValue(0, 0)) + (a.y * b.getValue(0, 1)) + (a.z * b.getValue(0, 2)) + (a.w * b.getValue(0, 3)),
                                 (a.x * b.getValue(1, 0)) + (a.y * b.getValue(1, 1)) + (a.z * b.getValue(1, 2)) + (a.w * b.getValue(1, 3)),
                                 (a.x * b.getValue(2, 0)) + (a.y * b.getValue(2, 1)) + (a.z * b.getValue(2, 2)) + (a.w * b.getValue(2, 3)),
                                 (a.x * b.getValue(3, 0)) + (a.y * b.getValue(3, 1)) + (a.z * b.getValue(3, 2)) + (a.w * b.getValue(3, 3))
                                 );
        }
        public static dvec4 operator *(fmat4 b, dvec4 a)
        {
            return a * b.transposed;
        }


#if NESTING_ENABLED
        public static dvec4 operator *(dvec4 a, tvec4<tvec4<double>> b)
        {
            dmat4 matrix = dmat4.fromNestedVector(b);

            return a * matrix;
        }
        public static dvec4 operator *(tvec4<tvec4<double>> b, dvec4 a)
        {
            dmat4 matrix = dmat4.fromNestedVector(b);

            return a * matrix.transposed;
        }

#endif
        public new double this[int i]
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


        public override double[] ToArray()
        {
            return new double[] { x, y, z, w };
        }


        ///////////////////////////
        //     Interpolation     //
        ///////////////////////////
#if INTERPOLATION_ENABLED
        public static dvec4 linearInterpolate(dvec4 a, dvec4 b, double position)
        {
            return (a * (1 - position)) + (b * position);
        }
        public dvec4 linearInterpolateTo(dvec4 b, double position)
        {
            return linearInterpolate(this, b, position);
        }


        public static dvec4 quadraticBezierInterpolate(dvec4 a, dvec4 b, dvec4 c, double position)
        {
            return linearInterpolate(
                linearInterpolate(a, b, position),
                linearInterpolate(b, c, position),
                position);
        }
        public dvec4 quadraticBezierInterpolateTo(dvec4 b, dvec4 c, double position)
        {
            return quadraticBezierInterpolate(this, b, c, position);
        }
        //todo: cubic interpolation
        //todo: rational bezier interpolation (ie with weights)

#endif


    }
}
#endif
#endif