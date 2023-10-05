using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Core
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



        ///////////////////////////
        //      Conversions      //
        ///////////////////////////

        public tvec3<tvec3<double>> fromDMat3(idmat3 input)
        {
            throw new NotImplementedException();
        }

    }
}
