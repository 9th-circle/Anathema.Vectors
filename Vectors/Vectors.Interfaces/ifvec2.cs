using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Core
{
    /// <summary>
    /// Interface to a single-precision floating point, 2-component vector.
    /// </summary>
    public interface ifvec2
    {
        ///////////////////////////
        //        Members        //
        ///////////////////////////

        float x { get; set; }
        float y { get; set; }


        ///////////////////////////
        //      Derivations      //
        ///////////////////////////


        float angleRadians { get; }
        float angleDegrees { get; }
        float length { get; }
        ifvec2 normalised { get; }


        ///////////////////////////
        //       Mutators        //
        ///////////////////////////

        void normalise();

        ///////////////////////////
        //        Swizzles       //
        ///////////////////////////

        ifvec2 xy
        {
            get;
            set;
        }
        ifvec2 yx
        {
            get;
            set;
        }


        ///////////////////////////
        //       Operators       //
        ///////////////////////////


        ifvec2 dot(ifvec2 b);

        ifvec2 cross();

    }
}
