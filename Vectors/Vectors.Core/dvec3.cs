using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Core
{
    /// <summary>
    /// A double-precision floating point, 3-component vector.
    /// </summary>
    public class dvec3 : dvec2
    {
        ///////////////////////////
        //        Members        //
        ///////////////////////////

        public double z { get; set; }


        ///////////////////////////
        //     Constructors      //
        ///////////////////////////

        public dvec3()
        {
        }
        public dvec3(dvec2 a, double z)
        {
            x = a.x;
            y = a.y;
            this.z = z;
        }
        public dvec3(double x, dvec2 yz)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }
        public dvec3(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public dvec3(dvec3 xyz)
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
    }
}
