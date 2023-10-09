#if TEMPLATES_ENABLED
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.Vectors.Core
{
    /// <summary>
    /// A 3-component vector where each element is a templated type. Nesting is allowed.
    /// </summary>
    public class tvec3<T> : tvec2<T>
    {
        ///////////////////////////
        //        Members        //
        ///////////////////////////

        public T z { get; set; }


        ///////////////////////////
        //     Constructors      //
        ///////////////////////////

        public tvec3()
        {
        }
        public tvec3(tvec2<T> a, T z)
        {
            x = a.x;
            y = a.y;
            this.z = z;
        }
        public tvec3(T x, tvec2<T> yz)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }
        public tvec3(T x, T y, T z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public tvec3(tvec3<T> xyz)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }


        ///////////////////////////
        //        Swizzles       //
        ///////////////////////////

        // 3! = 3 * 2 * 1 = 6
        // There are 6 swizzles, in 3 groups of 2

        //Starting with X (2)

#if SWIZZLES_ENABLED
        public tvec3<T> xyz
        {
            get
            {
                return new tvec3<T>(x, y, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }
        public tvec3<T> xzy
        {
            get
            {
                return new tvec3<T>(x, z, y);
            }
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
            }
        }


        //Starting with Y (2)


        public tvec3<T> yxz
        {
            get
            {
                return new tvec3<T>(y, x, z);
            }
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
            }
        }
        public tvec3<T> yzx
        {
            get
            {
                return new tvec3<T>(y, z, x);
            }
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
            }
        }


        //Starting with Z (2)


        public tvec3<T> zxy
        {
            get
            {
                return new tvec3<T>(z, x, y);
            }
            set
            {
                z = value.x;
                x = value.y;
                y = value.z;
            }
        }
        public tvec3<T> zyx
        {
            get
            {
                return new tvec3<T>(z, y, x);
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
        public T b
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
        public tvec3<T> rgb
        {
            get
            {
                return new tvec3<T>(x, y, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }
        public tvec3<T> rbg
        {
            get
            {
                return new tvec3<T>(x, z, y);
            }
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
            }
        }
        public tvec3<T> grb
        {
            get
            {
                return new tvec3<T>(y, x, z);
            }
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
            }
        }
        public tvec3<T> gbr
        {
            get
            {
                return new tvec3<T>(y, z, x);
            }
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
            }
        }
        public tvec3<T> bgr
        {
            get
            {
                return new tvec3<T>(z, y, x);
            }
            set
            {
                z = value.x;
                y = value.y;
                x = value.z;
            }
        }
        public tvec3<T> brg
        {
            get
            {
                return new tvec3<T>(z, x, y);
            }
            set
            {
                z = value.x;
                x = value.y;
                y = value.z;
            }
        }



#endif


        ///////////////////////////
        //      Conversions      //
        ///////////////////////////


#if NESTING_ENABLED
        public static tvec3<tvec3<double>> fromDMat3(dmat3 input)
        {
            var output = new tvec3<tvec3<double>>();

            output.x.x = input.getValue(0, 0);
            output.x.y = input.getValue(0, 1);
            output.x.z = input.getValue(0, 2);

            output.y.x = input.getValue(1, 0);
            output.y.y = input.getValue(1, 1);
            output.y.z = input.getValue(1, 2);

            output.z.x = input.getValue(2, 0);
            output.z.y = input.getValue(2, 1);
            output.z.z = input.getValue(2, 2);

            return output;
        }
        public static tvec3<tvec3<float>> fromFMat3(fmat3 input)
        {
            var output = new tvec3<tvec3<float>>();

            output.x.x = input.getValue(0, 0);
            output.x.y = input.getValue(0, 1);
            output.x.z = input.getValue(0, 2);

            output.y.x = input.getValue(1, 0);
            output.y.y = input.getValue(1, 1);
            output.y.z = input.getValue(1, 2);

            output.z.x = input.getValue(2, 0);
            output.z.y = input.getValue(2, 1);
            output.z.z = input.getValue(2, 2);

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

        public override T[] ToArray()
        {
            return new T[] { x, y, z };
        }
    }
}
#endif