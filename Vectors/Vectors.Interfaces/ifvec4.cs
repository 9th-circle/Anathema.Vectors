using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Core
{
    /// <summary>
    /// A single-precision floating point, 4-component vector.
    /// </summary>
    public interface ifvec4 : ifvec3
    {
        ///////////////////////////
        //        Members        //
        ///////////////////////////

        public float w { get; set; }


        ///////////////////////////
        //        Swizzles       //
        ///////////////////////////

        // 4! = 4 * 3 * 2 * 1 = 24
        // There are 24 swizzles, in 4 groups of 6

        //Starting with X (6)

        public ifvec4 xyzw
        {
            get;
            set;
        }
        public ifvec4 xwzy
        {
            get;
            set;
        }
        public ifvec4 xwyz
        {
            get;
            set;
        }
        public ifvec4 xywz
        {
            get;
            set;
        }
        public ifvec4 xzyw
        {
            get;
            set;
        }
        public ifvec4 xzwy
        {
            get;
            set;
        }





        //Starting with Y (6)

        public ifvec4 yxzw
        {
            get;
            set;
        }
        public ifvec4 yxwz
        {
            get;
            set;
        }
        public ifvec4 yzxw
        {
            get;
            set;
        }
        public ifvec4 yzwx
        {
            get;
            set;
        }
        public ifvec4 ywzx
        {
            get;
            set;
        }
        public ifvec4 ywxz
        {
            get;
            set;
        }



        //Starting with Z (6)

        public ifvec4 zxyw
        {
            get;
            set;
        }
        public ifvec4 zyxw
        {
            get;
            set;
        }
        public ifvec4 zywx
        {
            get;
            set;
        }
        public ifvec4 zxwy
        {
            get;
            set;
        }
        public ifvec4 zwxy
        {
            get;
            set;
        }
        public ifvec4 zwyx
        {
            get;
            set;
        }



        //Starting with W (6)

        public ifvec4 wxyz
        {
            get;
            set;
        }

        public ifvec4 wxzy
        {
            get;
            set;
        }
        public ifvec4 wyxz
        {
            get;
            set;
        }
        public ifvec4 wyzx
        {
            get;
            set;
        }
        public ifvec4 wzxy
        {
            get;
            set;
        }
        public ifvec4 wzyx
        {
            get;
            set;
        }


        ///////////////////////////
        //       Operators       //
        ///////////////////////////

        public ifvec4 dot(ifvec4 b);

    }
}
