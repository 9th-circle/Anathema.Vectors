using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Core
{
    /// <summary>
    /// A double-precision floating point, 3x3 (9 element) matrix.
    /// </summary>
    public class dmat3 : dmat2
    {
        public dmat3()
        {
            data = new double[9];
        }






        ///////////////////////////
        //      Conversions      //
        ///////////////////////////

        public static dmat3 fromNestedVector(tvec3<tvec3<double>> input)
        {
            throw new NotImplementedException();
        }
    }
}
