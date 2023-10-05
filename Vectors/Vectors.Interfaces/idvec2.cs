using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Interfaces
{
    /// <summary>
    /// A double precision floating point, 2-component vector.
    /// </summary>
    public interface idvec2
    {
        ///////////////////////////
        //        Members        //
        ///////////////////////////

        double x { get; set; }
        double y { get; set; }

        ///////////////////////////
        //      Derivations      //
        ///////////////////////////


        double angleRadians
        {
            get;
        }
        double angleDegrees
        {
            get;
        }

        double length
        {
            get;
        }
        idvec2 normalised
        {
            get;
        }


        ///////////////////////////
        //       Mutators        //
        ///////////////////////////

        void normalise();

        ///////////////////////////
        //        Swizzles       //
        ///////////////////////////

        idvec2 xy
        {
            get;
            set;
        }
        idvec2 yx
        {
            get;
            set;
        }


        ///////////////////////////
        //       Operators       //
        ///////////////////////////


        idvec2 dot(idvec2 b);

        idvec2 cross();

    }
}
