using System;
using System.Collections.Generic;
using System.Text;

namespace Anathema.Vectors.Core
{
    public partial class dmat2
    {
        //todo: check if this causes a transpose
        public static dmat2 fromNestedVector(tvec2<tvec2<double>> input)
        {
            dmat4 output = new dmat4();

            output.setValue(0, 0, input.x.x);
            output.setValue(0, 1, input.x.y);

            output.setValue(1, 0, input.y.x);
            output.setValue(1, 1, input.y.y);

            return output;
        }
        //todo: check rows and columns aren't being swapped (transposed)
        public double getValue(int row, int column)
        {
            //Design decision: we should be able to pass around a mat2 in a mat3
            // reference and simply use the columns that are present.

            if (row >= rowCount || column >= columnCount || row < 0 || column < 0)
                return 0;
            return data[(row * columnCount) + column];
        }

        //todo: check rows and columns aren't being swapped (transposed)
        public void setValue(int row, int column, double value)
        {
            //Design decision: writing to a matrix out of its bounds
            // should fail. This is so that if you're passing around a
            // mat2 in a mat3 reference, it shouldn't silently fail
            // when you try to write to a slot that doesn't exist.
            // This is an asymmetry between get and set which might
            // not be obvious.

            if (row >= rowCount || column >= columnCount || row < 0 || column < 0)
                throw new IndexOutOfRangeException();
            data[(row * columnCount) + column] = value;
        }
    }
}
