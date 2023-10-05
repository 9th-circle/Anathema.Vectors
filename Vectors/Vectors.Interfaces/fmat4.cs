using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Interfaces
{
    /// <summary>
    /// A single-precision floating point, 4x4 (16 element) matrix.
    /// </summary>
    public class fmat4 : fmat3
    {

        ///////////////////////////
        //        Values         //
        ///////////////////////////

        public override int rowCount { get { return 4; } }
        public override int columnCount { get { return 4; } }

        ///////////////////////////
        //     Constructors      //
        ///////////////////////////

        public fmat4()
        {
            data = new float[16];
        }

        public fmat4(fmat4 template)
        {
            data = new float[16];
            Array.Copy(template.data, data, data.Length);
        }

        ///////////////////////////
        //      Generators       //
        ///////////////////////////

        public new static fmat4 identity()
        {
            fmat4 output = new fmat4();
            for (int i = 0; i < output.rowCount && i < output.columnCount; i++)
                output.setValue(i, i, 1);
            return output;
        }

        public static new fmat4 rotate(ifvec3 axis, float angle)
        {
            throw new NotImplementedException();
        }

        public static new fmat4 rotate(float eulerX, float eulerY, float eulerZ)
        {
            throw new NotImplementedException();
        }

        public static new fmat4 scale(ifvec3 basis)
        {
            throw new NotImplementedException();
        }

        public static new fmat4 scale(float size)
        {
            throw new NotImplementedException();
        }

        public static new fmat4 translate(ifvec3 basis)
        {
            throw new NotImplementedException();
        }

        public static fmat4 projection()
        {
            throw new NotImplementedException();
        }

        ///////////////////////////
        //      Conversions      //
        ///////////////////////////

        //todo: check if this causes a transpose
        public static fmat4 fromNestedVector(itvec4<itvec4<float>> input)
        {
            fmat4 output = new fmat4();
            output.setValue(0, 0, input.x.x);
            output.setValue(0, 1, input.x.y);
            output.setValue(0, 2, input.x.z);
            output.setValue(0, 3, input.x.w);

            output.setValue(1, 0, input.y.x);
            output.setValue(1, 1, input.y.y);
            output.setValue(1, 2, input.y.z);
            output.setValue(1, 3, input.y.w);

            output.setValue(2, 0, input.z.x);
            output.setValue(2, 1, input.z.y);
            output.setValue(2, 2, input.z.z);
            output.setValue(2, 3, input.z.w);

            output.setValue(3, 0, input.w.x);
            output.setValue(3, 1, input.w.y);
            output.setValue(3, 2, input.w.z);
            output.setValue(3, 3, input.w.w);

            return output;
        }

        ///////////////////////////
        //      Transforms       //
        ///////////////////////////

        public new fmat4 transposed
        {
            get
            {
                fmat4 output = new fmat4();
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

        public void assign(fmat4 other)
        {
            for (int i = 0; i < other.data.Length && i < data.Length; i++)
                data[i] = other.data[i];
        }


        ///////////////////////////
        //       Operators       //
        ///////////////////////////



    }
}
