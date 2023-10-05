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
    public interface idmat2
    {
        ///////////////////////////
        //        Values         //
        ///////////////////////////

        public double[] data { get; }

        public virtual int rowCount { get { return 2; } }
        public virtual int columnCount { get { return 2; } }


        ///////////////////////////
        //      Accessors        //
        ///////////////////////////

        public double getValue(int row, int column);
        public void setValue(int row, int column, double value);

        ///////////////////////////
        //      Transforms       //
        ///////////////////////////

        public idmat2 transposed { get; }

        ///////////////////////////
        //       Mutators        //
        ///////////////////////////

        public void transpose();

        public void assign(idmat2 other);

        ///////////////////////////
        //       Operators       //
        ///////////////////////////


        public double this[int i] { get; set; }

    }
}
