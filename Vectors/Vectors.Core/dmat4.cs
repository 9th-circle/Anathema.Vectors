using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Vectors.Core
{
    /// <summary>
    /// A double-precision floating point, 4x4 (16 element) matrix.
    /// </summary>
    public class dmat4 : dmat3
    {

        ///////////////////////////
        //        Values         //
        ///////////////////////////

        public override int rowCount { get { return 4; } }
        public override int columnCount { get { return 4; } }

        ///////////////////////////
        //     Constructors      //
        ///////////////////////////

        public dmat4()
        {
            data = new double[16];
        }

        public dmat4(dmat4 template)
        {
            data = new double[16];
            Array.Copy(template.data, data, data.Length);
        }

        ///////////////////////////
        //      Generators       //
        ///////////////////////////

        public new static dmat4 identity()
        {
            dmat4 output = new dmat4();
            for (int i = 0; i < output.rowCount && i < output.columnCount; i++)
                output.setValue(i, i, 1);
            return output;
        }

        public static new dmat4 rotateRadians(fvec3 axis, double angle)
        {
            throw new NotImplementedException();
        }

        public static new dmat4 rotateRadians(double eulerX, double eulerY, double eulerZ)
        {
            throw new NotImplementedException();
        }
        public static new dmat4 rotateDegrees(fvec3 axis, double angle)
        {
            throw new NotImplementedException();
        }

        public static new dmat4 rotateDegrees(double eulerX, double eulerY, double eulerZ)
        {
            throw new NotImplementedException();
        }

        public static dmat4 scale(dvec4 basis)
        {
            dmat4 output = new dmat4();
            output.setValue(0, 0, basis.x);
            output.setValue(1, 1, basis.y);
            output.setValue(2, 2, basis.z);
            output.setValue(3, 3, basis.w);
            return output;
        }

        public static new dmat4 scale(double size)
        {
            dmat4 output = new dmat4();
            output.setValue(0, 0, size);
            output.setValue(1, 1, size);
            output.setValue(2, 2, size);
            output.setValue(3, 3, size);
            return output;
        }


        public static new dmat4 translate(fvec3 basis)
        {
            throw new NotImplementedException();
        }

        public static dmat4 projection()
        {
            throw new NotImplementedException();
        }

        ///////////////////////////
        //      Conversions      //
        ///////////////////////////

        //todo: check if this causes a transpose
        public static dmat4 fromNestedVector(tvec4<tvec4<double>> input)
        {
            dmat4 output = new dmat4();
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

        public new dmat4 transposed
        {
            get
            {
                return transposedRaw;
            }
        }
        public new dmat4 transposedRaw
        {
            get
            {
                dmat4 output = new dmat4();
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

        public void assign(dmat4 other)
        {
            for (int i = 0; i < other.data.Length && i < data.Length; i++)
                data[i] = other.data[i];
        }


        ///////////////////////////
        //       Operators       //
        ///////////////////////////



    }
}
