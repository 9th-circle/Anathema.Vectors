using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Interfaces
{
    /// <summary>
    /// A double precision floating point, 3-component vector.
    /// </summary>
    public interface idvec3 : idvec2
    {
        ///////////////////////////
        //        Members        //
        ///////////////////////////

        double z { get; set; }


        ///////////////////////////
        //      Derivations      //
        ///////////////////////////


        double length
        {
            get;
        }
        new idvec3 normalised
        {
            get;
        }


        ///////////////////////////
        //        Swizzles       //
        ///////////////////////////

        // 3! = 3 * 2 * 1 = 6
        // There are 6 swizzles, in 3 groups of 2

        //Starting with X (2)

        public idvec3 xyz
        {
            get;
            set;
        }
        public idvec3 xzy
        {
            get;
            set;
        }


        //Starting with Y (2)


        public idvec3 yxz
        {
            get;
            set;
        }
        public idvec3 yzx
        {
            get; set;
        }


        //Starting with Z (2)


        public idvec3 zxy
        {
            get; set;
        }
        public idvec3 zyx
        {
            get; set;
        }


        ///////////////////////////
        //       Operators       //
        ///////////////////////////


        idvec3 dot(idvec3 b);


        public idvec3 cross(idvec3 b);


    }
}
