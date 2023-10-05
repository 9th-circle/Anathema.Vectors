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

        public T x { get; set; }
        public T y { get; set; }


        ///////////////////////////
        //        Swizzles       //
        ///////////////////////////

        public itvec2<T> xy
        {
            get;
            set;
        }
        public itvec2<T> yx
        {
            get;
            set;
        }

    }
}
