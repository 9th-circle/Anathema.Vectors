using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Interfaces
{
    /// <summary>
    /// Interface to a double-precision floating point, 2x2 (4 element) matrix.
    /// </summary>
    public interface idmat2
    {
        ///////////////////////////
        //        Values         //
        ///////////////////////////

        double[] data { get; }

        virtual int rowCount { get { return 2; } }
        virtual int columnCount { get { return 2; } }

        ///////////////////////////
        //      Accessors        //
        ///////////////////////////

        double getValue(int row, int column);
        void setValue(int row, int column, double value);

        ///////////////////////////
        //      Transforms       //
        ///////////////////////////

        idmat2 transposed { get; }

        ///////////////////////////
        //       Mutators        //
        ///////////////////////////

        void transpose();

        void assign(idmat2 other);

        ///////////////////////////
        //       Operators       //
        ///////////////////////////

        double this[int i] { get; set; }

    }
}
