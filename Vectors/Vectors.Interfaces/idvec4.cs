using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Interfaces
{
    /// <summary>
    /// A double precision floating point, 4-component vector.
    /// </summary>
    public interface idvec4 : idvec3
    {
        ///////////////////////////
        //        Members        //
        ///////////////////////////

        public double w { get; set; }



        ///////////////////////////
        //        Swizzles       //
        ///////////////////////////

        // 4! = 4 * 3 * 2 * 1 = 24
        // There are 24 swizzles, in 4 groups of 6

        //Starting with X (6)

        public idvec4 xyzw
        {
            get;
            set;
        }
        public idvec4 xwzy
        {
            get;
            set;
        }
        public idvec4 xwyz
        {
            get;
            set;
        }
        public idvec4 xywz
        {
            get; set;
        }
        public idvec4 xzyw
        {
            get; set;
        }
        public idvec4 xzwy
        {
            get; set;
        }





        //Starting with Y (6)

        public idvec4 yxzw
        {
            get;
            set;
        }
        public idvec4 yxwz
        {
            get; set;
        }
        public idvec4 yzxw
        {
            get; set;
        }
        public idvec4 yzwx
        {
            get; set;
        }
        public idvec4 ywzx
        {
            get; set;
        }
        public idvec4 ywxz
        {
            get; set;
        }



        //Starting with Z (6)

        public idvec4 zxyw
        {
            get; set;
        }
        public idvec4 zyxw
        {
            get; set;
        }
        public idvec4 zywx
        {
            get; set;
        }
        public idvec4 zxwy
        {
            get; set;
        }
        public idvec4 zwxy
        {
            get; set;
        }
        public idvec4 zwyx
        {
            get; set;
        }



        //Starting with W (6)

        public idvec4 wxyz
        {
            get; set;
        }

        public idvec4 wxzy
        {
            get; set;
        }
        public idvec4 wyxz
        {
            get; set;
        }
        public idvec4 wyzx
        {
            get; set;
        }
        public idvec4 wzxy
        {
            get; set;
        }
        public idvec4 wzyx
        {
            get; set;
        }


        ///////////////////////////
        //       Operators       //
        ///////////////////////////


        public idvec4 dot(idvec4 b);
    }
}
