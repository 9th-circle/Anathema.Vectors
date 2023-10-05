using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Core
{
    /// <summary>
    /// A double-precision floating point, 2x2 (4 element) matrix.
    /// </summary>
    public class dmat2
    {
        public double[] data { get; set; } = new double[4];




        ///////////////////////////
        //      Conversions      //
        ///////////////////////////

        public static dmat2 fromNestedVector(tvec2<tvec2<double>> input)
        {
            throw new NotImplementedException();
        }
    }
}
