#if TEMPLATES_ENABLED
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Core
{
    /// <summary>
    /// A 4-component vector where each element is a templated type. Nesting is allowed.
    /// </summary>
    public class tvec4<T> : tvec3<T>
    {
        ///////////////////////////
        //        Members        //
        ///////////////////////////

        public T w { get; set; }

        ///////////////////////////
        //     Constructors      //
        ///////////////////////////

        public tvec4()
        {
        }
        public tvec4(tvec3<T> xyz, T w)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }
        public tvec4(T x, tvec3<T> yzw)
        {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }
        public tvec4(tvec2<T> xy, tvec2<T> zw)
        {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }
        public tvec4(T x, T y, tvec2<T> zw)
        {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }
        public tvec4(T x, tvec2<T> yz, T w)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }
        public tvec4(tvec2<T> xy, T z, T w)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }
        public tvec4(T x, T y, T z, T w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        public tvec4(tvec4<T> xyzw)
        {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }


        ///////////////////////////
        //        Swizzles       //
        ///////////////////////////

        // 4! = 4 * 3 * 2 * 1 = 24
        // There are 24 swizzles, in 4 groups of 6

        //Starting with X (6)

#if SWIZZLES_ENABLED
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

        ///////////////////////////
        //      Conversions      //
        ///////////////////////////

#if NESTING_ENABLED
        public static tvec4<tvec4<double>> fromDMat4(dmat4 input)
        {
            var output = new tvec4<tvec4<double>>();

            output.x.x = input.getValue(0, 0);
            output.x.y = input.getValue(0, 1);
            output.x.z = input.getValue(0, 2);
            output.x.w = input.getValue(0, 3);

            output.y.x = input.getValue(1, 0);
            output.y.y = input.getValue(1, 1);
            output.y.z = input.getValue(1, 2);
            output.y.w = input.getValue(1, 3);

            output.z.x = input.getValue(2, 0);
            output.z.y = input.getValue(2, 1);
            output.z.z = input.getValue(2, 2);
            output.z.w = input.getValue(2, 3);

            output.w.x = input.getValue(3, 0);
            output.w.y = input.getValue(3, 1);
            output.w.z = input.getValue(3, 2);
            output.w.w = input.getValue(3, 3);

            return output;
        }
        public static tvec4<tvec4<float>> fromFMat4(fmat4 input)
        {
            var output = new tvec4<tvec4<float>>();

            output.x.x = input.getValue(0, 0);
            output.x.y = input.getValue(0, 1);
            output.x.z = input.getValue(0, 2);
            output.x.w = input.getValue(0, 3);

            output.y.x = input.getValue(1, 0);
            output.y.y = input.getValue(1, 1);
            output.y.z = input.getValue(1, 2);
            output.y.w = input.getValue(1, 3);

            output.z.x = input.getValue(2, 0);
            output.z.y = input.getValue(2, 1);
            output.z.z = input.getValue(2, 2);
            output.z.w = input.getValue(2, 3);

            output.w.x = input.getValue(3, 0);
            output.w.y = input.getValue(3, 1);
            output.w.z = input.getValue(3, 2);
            output.w.w = input.getValue(3, 3);

            return output;
        }

#endif
        public new T this[int i]
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
    }
}
#endif