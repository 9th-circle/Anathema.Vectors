using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Interfaces
{
    /// <summary>
    /// A 2-component vector where each element is a templated type. Nesting is allowed.
    /// </summary>
    public interface itvec2<T>
    {
        ///////////////////////////
        //        Members        //
        ///////////////////////////

        T x { get; set; }
        T y { get; set; }


        ///////////////////////////
        //        Swizzles       //
        ///////////////////////////

        itvec2<T> xy
        {
            get;
            set;
        }
        itvec2<T> yx
        {
            get;
            set;
        }

    }
}
