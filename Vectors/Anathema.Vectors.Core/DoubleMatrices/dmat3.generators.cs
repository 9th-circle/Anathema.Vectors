using System;
#if THREED_ENABLED
#if DOUBLES_ENABLED

namespace Anathema.Vectors.Core
{
    public partial class dmat3
    {
        public new static dmat3 identity()
        {
            dmat3 output = new dmat3();
            for (int i = 0; i < output.xLength && i < output.yLength; i++)
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
        public static dmat3 rotateRadians(double g, double b, double z)
        {
            //Make clockwise
            g = -g;
            b = -b;
            z = -z;

            dmat3 output = new dmat3();

            output[0, 0] = (Math.Cos(z) * Math.Cos(b));
            output[0, 1] = ((Math.Cos(z) * Math.Sin(b) * Math.Sin(g)) - (Math.Sin(z) * Math.Cos(g)));
            output[0, 2] = ((Math.Cos(z) * Math.Sin(b) * Math.Cos(g)) + (Math.Sin(z) * Math.Sin(g)));

            output[1, 0] = (Math.Sin(z) * Math.Cos(b));
            output[1, 1] = ((Math.Sin(z) * Math.Sin(b) * Math.Sin(g)) + (Math.Cos(z) * Math.Cos(g)));
            output[1, 2] = ((Math.Sin(z) * Math.Sin(b) * Math.Cos(g)) - (Math.Cos(z) * Math.Sin(g)));

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

    }
}
#endif
#endif