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
    public interface itvec3<T> : itvec2<T>
    {
        ///////////////////////////
        //        Members        //
        ///////////////////////////

        public T z { get; set; }

        ///////////////////////////
        //        Swizzles       //
        ///////////////////////////

        // 3! = 3 * 2 * 1 = 6
        // There are 6 swizzles, in 3 groups of 2

        //Starting with X (2)

        public itvec3<T> xyz
        {
            get;
            set;
        }
        public itvec3<T> xzy
        {
            get;
            set;
        }


        //Starting with Y (2)


        public itvec3<T> yxz
        {
            get;
            set;
        }
        public itvec3<T> yzx
        {
            get;
            set;
        }


        //Starting with Z (2)


        public itvec3<T> zxy
        {
            get;
            set;
        }
        public itvec3<T> zyx
        {
            get;
            set;
        }
    }
}
