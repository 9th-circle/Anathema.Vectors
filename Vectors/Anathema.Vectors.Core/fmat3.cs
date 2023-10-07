#if FLOATS_ENABLED
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.Vectors.Core
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

        public fmat4 toFMat4()
        {
            fmat4 output = new fmat4();
            output.setValue(0, 0, getValue(0, 0));
            output.setValue(0, 1, getValue(0, 1));
            output.setValue(0, 2, getValue(0, 2));

            output.setValue(1, 0, getValue(1, 0));
            output.setValue(1, 1, getValue(1, 1));
            output.setValue(1, 2, getValue(1, 2));

            output.setValue(2, 0, getValue(2, 0));
            output.setValue(2, 1, getValue(2, 1));
            output.setValue(2, 2, getValue(2, 2));

            return output;
        }

        public new static fmat3 identity()
        {
            fmat3 output = new fmat3();
            for (int i = 0; i < output.rowCount && i < output.columnCount; i++)
                output.setValue(i, i, 1);
            return output;
        }

        //Derived from https://en.wikipedia.org/wiki/Rotation_matrix#Rotation_matrix_from_axis_and_angle
        public static fmat3 rotateRadians(fvec3 axis, float angle)
        {
            fmat3 output = new fmat3();
            output[0, 0] = (float)(Math.Cos(angle) + (axis.x * (1 - Math.Cos(angle))));


            return output;

            throw new NotImplementedException();
        }

        //Derivation from https://en.wikipedia.org/wiki/Rotation_matrix#General_3D_rotations
        //a=pitch, b=yaw, g=roll
        //todo: verify; check for transposition
        //todo: when this is verified to work, swap those names
        public static fmat3 rotateRadians(float a, float b, float g)
        {
            fmat3 output = new fmat3();

            output[0, 0] = (float)(Math.Cos(a) * Math.Cos(b));
            output[0, 1] = (float)((Math.Cos(a) * Math.Sin(b) * Math.Sin(g))-(Math.Sin(a)*Math.Cos(g)));
            output[0, 2] = (float)((Math.Cos(a) * Math.Sin(b) * Math.Cos(g)) + (Math.Sin(a) * Math.Sin(g)));

            output[1, 0] = (float)(Math.Sin(a) * Math.Cos(b));
            output[1, 1] = (float)((Math.Sin(a) * Math.Sin(b) * Math.Sin(g)) + (Math.Cos(a) * Math.Cos(g)));
            output[1, 2] = (float)((Math.Sin(a) * Math.Sin(b) * Math.Cos(g)) - (Math.Cos(a) * Math.Sin(g)));

            output[2, 0] = (float)-Math.Sin(b);
            output[2, 1] = (float)(Math.Cos(b) * Math.Sin(g));
            output[2, 2] = (float)(Math.Cos(b) * Math.Cos(g));

            return output;
        }
        public static fmat3 rotateDegrees(fvec3 axis, float angle)
        {
            return rotateRadians(axis, angle * (float)(Math.PI / 180.0));
        }

        public static fmat3 rotateDegrees(float eulerX, float eulerY, float eulerZ)
        {
            return rotateRadians(   eulerX * (float)(Math.PI / 180.0),
                                    eulerY * (float)(Math.PI / 180.0),
                                    eulerZ * (float)(Math.PI / 180.0));
        }

        public static fmat3 scale(fvec3 basis)
        {
            fmat3 output = new fmat3();
            output.setValue(0, 0, basis.x);
            output.setValue(1, 1, basis.y);
            output.setValue(2, 2, basis.z);
            return output;
        }

        public static new fmat3 scale(float size)
        {
            fmat3 output = new fmat3();
            output.setValue(0, 0, size);
            output.setValue(1, 1, size);
            output.setValue(2, 2, size);
            return output;
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
#endif