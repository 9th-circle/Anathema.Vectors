using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Core
{
    /// <summary>
    /// A 2-component vector where each element is a templated type. Nesting is allowed.
    /// </summary>
    public class tvec2<T>
    {
        ///////////////////////////
        //        Members        //
        ///////////////////////////

        public T x { get; set; }
        public T y { get; set; }


        ///////////////////////////
        //     Constructors      //
        ///////////////////////////

        public tvec2()
        {
        }

        public tvec2(T x, T y)
        {
            this.x = x;
            this.y = y;
        }
        public tvec2(tvec2<T> xy)
        {
            x = xy.x;
            y = xy.y;
        }


        ///////////////////////////
        //        Swizzles       //
        ///////////////////////////

        public tvec2<T> xy
        {
            get
            {
                return new tvec2<T>(x, y);
            }
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        public tvec2<T> yx
        {
            get
            {
                return new tvec2<T>(y, x);
            }
            set
            {
                y = value.x;
                x = value.y;
            }
        }



        ///////////////////////////
        //      Conversions      //
        ///////////////////////////

        public static tvec2<tvec2<double>> fromDMat2(dmat2 input)
        {
            throw new NotImplementedException();
        }

    }
}
