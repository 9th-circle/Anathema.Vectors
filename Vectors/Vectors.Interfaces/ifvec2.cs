using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Core
{
    /// <summary>
    /// A single-precision floating point, 2-component vector.
    /// </summary>
    public interface ifvec2
    {
        ///////////////////////////
        //        Members        //
        ///////////////////////////

        public float x { get; set; }
        public float y { get; set; }


        ///////////////////////////
        //      Derivations      //
        ///////////////////////////


        public float angleRadians { get; }
        public float angleDegrees { get; }
        public float length { get; }
        public ifvec2 normalised { get; }


        ///////////////////////////
        //       Mutators        //
        ///////////////////////////

        public void normalise();

        ///////////////////////////
        //        Swizzles       //
        ///////////////////////////

        public ifvec2 xy
        {
            get;
            set;
        }
        public ifvec2 yx
        {
            get;
            set;
        }


        ///////////////////////////
        //       Operators       //
        ///////////////////////////


        public ifvec2 dot(ifvec2 b);

        public ifvec2 cross();

    }
}
