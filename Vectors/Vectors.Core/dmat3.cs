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

        ///////////////////////////
        //        Values         //
        ///////////////////////////

        public override int rowCount { get { return 3; } }
        public override int columnCount { get { return 3; } }

        ///////////////////////////
        //     Constructors      //
        ///////////////////////////

        public dmat3()
        {
            data = new double[9];
        }
        public dmat3(dmat3 template)
        {
            data = new double[9];
            Array.Copy(template.data, data, data.Length);
        }

        ///////////////////////////
        //      Generators       //
        ///////////////////////////

        public new static dmat3 identity()
        {
            dmat3 output = new dmat3();
            for (int i = 0; i < output.rowCount && i < output.columnCount; i++)
                output.setValue(i, i, 1);
            return output;
        }
        public static dmat3 rotate(fvec3 axis, double angle)
        {
            throw new NotImplementedException();
        }

        public static dmat3 rotate(double eulerX, double eulerY, double eulerZ)
        {
            throw new NotImplementedException();
        }

        public static dmat3 scale(dvec3 basis)
        {
            dmat3 output = new dmat3();
            output.setValue(0, 0, basis.x);
            output.setValue(1, 1, basis.y);
            output.setValue(2, 2, basis.z);
            return output;
        }

        public static dmat3 scale(double size)
        {
            dmat3 output = new dmat3();
            output.setValue(0, 0, size);
            output.setValue(1, 1, size);
            output.setValue(2, 2, size);
            return output;
        }

        public static dmat3 translate(fvec3 basis)
        {
            throw new NotImplementedException();
        }

        ///////////////////////////
        //      Conversions      //
        ///////////////////////////

        //todo: check if this causes a transpose
        public static dmat3 fromNestedVector(tvec3<tvec3<double>> input)
        {
            dmat4 output = new dmat4();
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

        public new dmat3 transposed
        {
            get
            {
                dmat3 output = new dmat3();
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

        public void assign(dmat3 other)
        {
            for (int i = 0; i < other.data.Length && i < data.Length; i++)
                data[i] = other.data[i];
        }


        ///////////////////////////
        //       Operators       //
        ///////////////////////////




    }
}
