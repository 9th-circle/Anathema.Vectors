#if DOUBLES_ENABLED
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.Vectors.Core
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
        //Derivation from https://en.wikipedia.org/wiki/Rotation_matrix#Rotation_matrix_from_axis_and_angle
        //todo: verify; check for transposition
        public static dmat3 rotateRadians(dvec3 axis, double angle)
        {
            dmat3 output = new dmat3();

            output[0, 0] = (Math.Cos(angle) + (axis.x * (1 - Math.Cos(angle))));
            output[0, 1] = (axis.x * (1 - Math.Cos(angle)) - (axis.z * Math.Sin(angle)));
            output[0, 2] = (axis.x * axis.z * (1 - Math.Cos(angle)) + (axis.y * Math.Sin(angle)));

            output[1, 0] = (axis.y * axis.x * (1 - Math.Cos(angle)) + (axis.z * Math.Sin(angle)));
            output[1, 1] = (Math.Cos(angle) + (axis.y * (1 - Math.Cos(angle))));
            output[1, 2] = (axis.y * axis.z * (1 - Math.Cos(angle)) - (axis.x * Math.Sin(angle)));

            output[2, 0] = (axis.z * axis.x * (1 - Math.Cos(angle)) - (axis.y * Math.Sin(angle)));
            output[2, 1] = (axis.z * axis.y * (1 - Math.Cos(angle)) + (axis.x * Math.Sin(angle)));
            output[2, 2] = (Math.Cos(angle) + (axis.z * (1 - Math.Cos(angle))));

            return output;
        }

        //Derivation from https://en.wikipedia.org/wiki/Rotation_matrix#General_3D_rotations
        //a=pitch, b=yaw, g=roll
        //todo: verify; check for transposition
        //todo: when this is verified to work, swap those names
        public static dmat3 rotateRadians(double a, double b, double g)
        {
            dmat3 output = new dmat3();

            output[0, 0] = (Math.Cos(a) * Math.Cos(b));
            output[0, 1] = ((Math.Cos(a) * Math.Sin(b) * Math.Sin(g)) - (Math.Sin(a) * Math.Cos(g)));
            output[0, 2] = ((Math.Cos(a) * Math.Sin(b) * Math.Cos(g)) + (Math.Sin(a) * Math.Sin(g)));

            output[1, 0] = (Math.Sin(a) * Math.Cos(b));
            output[1, 1] = ((Math.Sin(a) * Math.Sin(b) * Math.Sin(g)) + (Math.Cos(a) * Math.Cos(g)));
            output[1, 2] = ((Math.Sin(a) * Math.Sin(b) * Math.Cos(g)) - (Math.Cos(a) * Math.Sin(g)));

            output[2, 0] = -Math.Sin(b);
            output[2, 1] = (Math.Cos(b) * Math.Sin(g));
            output[2, 2] = (Math.Cos(b) * Math.Cos(g));

            return output;
        }
        public static dmat3 rotateDegrees(dvec3 axis, double angle)
        {
            return rotateRadians(axis, angle * (Math.PI / 180.0));
        }

        public static dmat3 rotateDegrees(double eulerX, double eulerY, double eulerZ)
        {
            return rotateRadians(eulerX * (Math.PI / 180.0),
                                    eulerY * (Math.PI / 180.0),
                                    eulerZ * (Math.PI / 180.0));
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
#endif