using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Interfaces
{
    /// <summary>
    /// A 3-component vector where each element is a templated type. Nesting is allowed.
    /// </summary>
    public interface itvec4<T> : itvec3<T>
    {
        ///////////////////////////
        //        Members        //
        ///////////////////////////

        public T w { get; set; }


        ///////////////////////////
        //        Swizzles       //
        ///////////////////////////

        // 4! = 4 * 3 * 2 * 1 = 24
        // There are 24 swizzles, in 4 groups of 6

        //Starting with X (6)

        public itvec4<T> xyzw
        {
            get;
            set;
        }
        public itvec4<T> xwzy
        {
            get;
            set;
        }
        public itvec4<T> xwyz
        {
            get;
            set;
        }
        public itvec4<T> xywz
        {
            get;
            set;
        }
        public itvec4<T> xzyw
        {
            get;
            set;
        }
        public itvec4<T> xzwy
        {
            get;
            set;
        }





        //Starting with Y (6)

        public itvec4<T> yxzw
        {
            get;
            set;
        }
        public itvec4<T> yxwz
        {
            get;
            set;
        }
        public itvec4<T> yzxw
        {
            get;
            set;
        }
        public itvec4<T> yzwx
        {
            get;
            set;
        }
        public itvec4<T> ywzx
        {
            get;
            set;
        }
        public itvec4<T> ywxz
        {
            get;
            set;
        }



        //Starting with Z (6)

        public itvec4<T> zxyw
        {
            get;
            set;
        }
        public itvec4<T> zyxw
        {
            get;
            set;
        }
        public itvec4<T> zywx
        {
            get;
            set;
        }
        public itvec4<T> zxwy
        {
            get;
            set;
        }
        public itvec4<T> zwxy
        {
            get;
            set;
        }
        public itvec4<T> zwyx
        {
            get;
            set;
        }



        //Starting with W (6)

        public itvec4<T> wxyz
        {
            get;
            set;
        }

        public itvec4<T> wxzy
        {
            get;
            set;
        }
        public itvec4<T> wyxz
        {
            get;
            set;
        }
        public itvec4<T> wyzx
        {
            get;
            set;
        }
        public itvec4<T> wzxy
        {
            get;
            set;
        }
        public itvec4<T> wzyx
        {
            get;
            set;
        }


    }
}
