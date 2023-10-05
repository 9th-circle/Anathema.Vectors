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
    public class fmat2
    {
        ///////////////////////////
        //        Values         //
        ///////////////////////////

        public float[] data { get; protected set; } = new float[4];

        public virtual int rowCount { get { return 2; } }
        public virtual int columnCount { get { return 2; } }

        ///////////////////////////
        //     Constructors      //
        ///////////////////////////

        public fmat2()
        {
        }
        public fmat2(fmat2 template)
        {
            Array.Copy(template.data, data, data.Length);
        }

        ///////////////////////////
        //      Generators       //
        ///////////////////////////

        public static fmat2 identity()
        {
            fmat2 output = new fmat2();
            for (int i = 0; i < output.rowCount && i < output.columnCount; i++)
                output.setValue(i, i, 1);
            return output;
        }
        public static fmat2 rotate(float angle)
        {
            throw new NotImplementedException();
        }

        ///////////////////////////
        //      Conversions      //
        ///////////////////////////

        //todo: check if this causes a transpose
        public static fmat2 fromNestedVector(itvec2<itvec2<float>> input)
        {
            fmat4 output = new fmat4();

            output.setValue(0, 0, input.x.x);
            output.setValue(0, 1, input.x.y);

            output.setValue(1, 0, input.y.x);
            output.setValue(1, 1, input.y.y);

            return output;
        }

        ///////////////////////////
        //      Accessors        //
        ///////////////////////////

        //todo: check rows and columns aren't being swapped (transposed)
        public float getValue(int row, int column)
        {
            //Design decision: we should be able to pass around a mat2 in a mat3
            // reference and simply use the columns that are present.

            if (row >= rowCount || column >= columnCount || row < 0 || column < 0)
                return 0;
            return data[(row * columnCount) + column];
        }

        //todo: check rows and columns aren't being swapped (transposed)
        public void setValue(int row, int column, float value)
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

        ///////////////////////////
        //      Transforms       //
        ///////////////////////////

        public fmat2 transposed
        {
            get
            {
                fmat2 output = new fmat2();
                for (int x = 0; x < rowCount; x++)
                    for (int y = 0; y < columnCount; y++)
                        output.setValue(x, y, getValue(y, x));
                return output;
            }
        }

        ///////////////////////////
        //       Mutators        //
        ///////////////////////////

        public virtual void transpose()
        {
            assign(transposed);
        }

        public void assign(fmat2 other)
        {
            for (int i = 0; i < other.data.Length && i < data.Length; i++)
                data[i] = other.data[i];
        }

        ///////////////////////////
        //       Operators       //
        ///////////////////////////


        public float this[int i] => data[i];

    }
}
