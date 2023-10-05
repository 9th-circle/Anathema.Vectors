using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Core
{
    /// <summary>
    /// A single-precision floating point, 3-component vector.
    /// </summary>
    public interface ifvec3 : ifvec2
    {
        ///////////////////////////
        //        Members        //
        ///////////////////////////

        public float z { get; set; }



        ///////////////////////////
        //      Derivations      //
        ///////////////////////////

        public new ifvec3 normalised { get; }


        ///////////////////////////
        //        Swizzles       //
        ///////////////////////////

        // 3! = 3 * 2 * 1 = 6
        // There are 6 swizzles, in 3 groups of 2

        //Starting with X (2)

        public ifvec3 xyz
        {
            get;
            set;
        }
        public ifvec3 xzy
        {
            get;
            set;
        }


        //Starting with Y (2)


        public ifvec3 yxz
        {
            get;
            set;
        }
        public ifvec3 yzx
        {
            get;
            set;
        }


        //Starting with Z (2)


        public ifvec3 zxy
        {
            get;
            set;
        }
        public ifvec3 zyx
        {
            get;
            set;
        }


        ///////////////////////////
        //       Operators       //
        ///////////////////////////


        public ifvec3 dot(ifvec3 b);

        public ifvec3 cross(ifvec3 b);
    }
}
