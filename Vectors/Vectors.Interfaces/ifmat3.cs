using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Interfaces
{
    /// <summary>
    /// A single-precision floating point, 3x3 (9 element) matrix.
    /// </summary>
    public interface ifmat3 : ifmat2
    {

        ///////////////////////////
        //      Transforms       //
        ///////////////////////////

        new ifmat3 transposed { get; }

        void assign(ifmat3 other);
    }
}
