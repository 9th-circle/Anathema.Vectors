using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Core
{
    /// <summary>
    /// A double-precision floating point, 4x4 (16 element) matrix.
    /// </summary>
    public class dmat4 : dmat3
    {
        public dmat4()
        {
            data = new double[16];
        }




        ///////////////////////////
        //      Conversions      //
        ///////////////////////////

        public static dmat4 fromNestedVector(tvec4<tvec4<double>> input)
        {
            throw new NotImplementedException();
        }
    }
}
