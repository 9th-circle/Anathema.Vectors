using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Interfaces
{
    /// <summary>
    /// A single-precision floating point, 2x2 (4 element) matrix.
    /// </summary>
    public interface ifmat2
    {
        ///////////////////////////
        //        Values         //
        ///////////////////////////

        float[] data { get; }

        int rowCount { get; }
        int columnCount { get; }

        ///////////////////////////
        //      Accessors        //
        ///////////////////////////

        //todo: check rows and columns aren't being swapped (transposed)
        float getValue(int row, int column);

        //todo: check rows and columns aren't being swapped (transposed)
        void setValue(int row, int column, float value);

        ///////////////////////////
        //      Transforms       //
        ///////////////////////////

        ifmat2 transposed
        {
            get;
        }

        ///////////////////////////
        //       Mutators        //
        ///////////////////////////

        void transpose();

        void assign(ifmat2 other);

        ///////////////////////////
        //       Operators       //
        ///////////////////////////


        float this[int i] { get; set; }

    }
}
