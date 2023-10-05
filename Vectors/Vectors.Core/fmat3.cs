using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Core
{
    /// <summary>
    /// A single-precision floating point, 3x3 (9 element) matrix.
    /// </summary>
    public class fmat3 : fmat2
    {

        ///////////////////////////
        //        Values         //
        ///////////////////////////
        
        public override int rowCount { get { return 3; } }
        public override int columnCount { get { return 3; } }

        ///////////////////////////
        //     Constructors      //
        ///////////////////////////

        public fmat3()
        {
            data = new float[9];
        }
        public fmat3(fmat3 template)
        {
            data = new float[9];
            Array.Copy(template.data, data, data.Length);
        }

        ///////////////////////////
        //      Generators       //
        ///////////////////////////

        public new static fmat3 identity()
        {
            fmat3 output = new fmat3();
            for (int i = 0; i < output.rowCount && i < output.columnCount; i++)
                output.setValue(i, i, 1);
            return output;
        }
        public static fmat3 rotate(fvec3 axis, float angle)
        {
            throw new NotImplementedException();
        }

        public static fmat3 rotate(float eulerX, float eulerY, float eulerZ)
        {
            throw new NotImplementedException();
        }

        public static fmat3 scale(fvec3 basis)
        {
            throw new NotImplementedException();
        }

        public static fmat3 scale(float size)
        {
            throw new NotImplementedException();
        }

        public static fmat3 translate(fvec3 basis)
        {
            throw new NotImplementedException();
        }

        ///////////////////////////
        //      Conversions      //
        ///////////////////////////

        //todo: check if this causes a transpose
        public static fmat3 fromNestedVector(tvec3<tvec3<float>> input)
        {
            fmat4 output = new fmat4();
            output.setValue(0, 0, input.x.x);
            output.setValue(0, 1, input.x.y);
            output.setValue(0, 2, input.x.z);

            output.setValue(1, 0, input.y.x);
            output.setValue(1, 1, input.y.y);
            output.setValue(1, 2, input.y.z);

            output.setValue(2, 0, input.z.x);
            output.setValue(2, 1, input.z.y);
            output.setValue(2, 2, input.z.z);

            return output;
        }

        ///////////////////////////
        //      Transforms       //
        ///////////////////////////

        public new fmat3 transposed
        {
            get
            {
                fmat3 output = new fmat3();
                for (int x = 0; x < rowCount; x++)
                    for (int y = 0; y < columnCount; y++)
                        output.setValue(x, y, getValue(y, x));
                return output;
            }
        }

        ///////////////////////////
        //       Mutators        //
        ///////////////////////////

        public override void transpose()
        {
            assign(transposed);
        }

        public void assign(fmat3 other)
        {
            for (int i = 0; i < other.data.Length && i < data.Length; i++)
                data[i] = other.data[i];
        }


        ///////////////////////////
        //       Operators       //
        ///////////////////////////
        



    }
}
