using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Interfaces
{
    /// <summary>
    /// Interface to a single-precision floating point, 4-component vector.
    /// </summary>
    public interface ifvec4 : ifvec3
    {
        ///////////////////////////
        //        Members        //
        ///////////////////////////

        float w { get; set; }


        ///////////////////////////
        //        Swizzles       //
        ///////////////////////////

        // 4! = 4 * 3 * 2 * 1 = 24
        // There are 24 swizzles, in 4 groups of 6

        //Starting with X (6)

        ifvec4 xyzw
        {
            get;
            set;
        }
        ifvec4 xwzy
        {
            get;
            set;
        }
        ifvec4 xwyz
        {
            get;
            set;
        }
        ifvec4 xywz
        {
            get;
            set;
        }
        ifvec4 xzyw
        {
            get;
            set;
        }
        ifvec4 xzwy
        {
            get;
            set;
        }





        //Starting with Y (6)

        ifvec4 yxzw
        {
            get;
            set;
        }
        ifvec4 yxwz
        {
            get;
            set;
        }
        ifvec4 yzxw
        {
            get;
            set;
        }
        ifvec4 yzwx
        {
            get;
            set;
        }
        ifvec4 ywzx
        {
            get;
            set;
        }
        ifvec4 ywxz
        {
            get;
            set;
        }



        //Starting with Z (6)

        ifvec4 zxyw
        {
            get;
            set;
        }
        ifvec4 zyxw
        {
            get;
            set;
        }
        ifvec4 zywx
        {
            get;
            set;
        }
        ifvec4 zxwy
        {
            get;
            set;
        }
        ifvec4 zwxy
        {
            get;
            set;
        }
        ifvec4 zwyx
        {
            get;
            set;
        }



        //Starting with W (6)

        ifvec4 wxyz
        {
            get;
            set;
        }

        ifvec4 wxzy
        {
            get;
            set;
        }
        ifvec4 wyxz
        {
            get;
            set;
        }
        ifvec4 wyzx
        {
            get;
            set;
        }
        ifvec4 wzxy
        {
            get;
            set;
        }
        ifvec4 wzyx
        {
            get;
            set;
        }


        ///////////////////////////
        //       Operators       //
        ///////////////////////////

        ifvec4 dot(ifvec4 b);

    }
}
