using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Core
{
    /// <summary>
    /// A double-precision floating point, 2-component vector.
    /// </summary>
    public class dvec2
    {
        ///////////////////////////
        //        Members        //
        ///////////////////////////

        public double x { get; set; }
        public double y { get; set; }


        ///////////////////////////
        //     Constructors      //
        ///////////////////////////

        public dvec2()
        {
        }

        public dvec2(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public dvec2(dvec2 xy)
        {
            x = xy.x;
            y = xy.y;
        }


        ///////////////////////////
        //        Swizzles       //
        ///////////////////////////

        public dvec2 xy
        {
            get
            {
                return new dvec2(x, y);
            }
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        public dvec2 yx
        {
            get
            {
                return new dvec2(y, x);
            }
            set
            {
                y = value.x;
                x = value.y;
            }
        }

    }
}
