#if FLOATS_ENABLED && THREED_ENABLED
using System;
namespace Anathema.Vectors.Core
{
    public partial class mat3
    {

        public mat4 toMat4()
        {
            mat4 output = new mat4();
            output.setValue(0, 0, getValue(0, 0));
            output.setValue(0, 1, getValue(0, 1));
            output.setValue(0, 2, getValue(0, 2));

            output.setValue(1, 0, getValue(1, 0));
            output.setValue(1, 1, getValue(1, 1));
            output.setValue(1, 2, getValue(1, 2));

            output.setValue(2, 0, getValue(2, 0));
            output.setValue(2, 1, getValue(2, 1));
            output.setValue(2, 2, getValue(2, 2));

            output.setValue(3,3,1);

            return output;
        }

        public new static mat3 identity()
        {
            mat3 output = new mat3();
            for (int i = 0; i < output.xLength && i < output.yLength; i++)
                output.setValue(i, i, 1);
            return output;
        }

        //Derivation from https://en.wikipedia.org/wiki/Rotation_matrix#Rotation_matrix_from_axis_and_angle
        public static mat3 rotateRadians(vec3 axis, float angle)
        {
            //Make clockwise
            angle = -angle;

            //TODO: fix - there is g bug in this
            mat3 output = new mat3();

            output[0, 0] = (float)(Math.Cos(angle) + (axis.x * (1 - Math.Cos(angle))));
            output[0, 1] = (float)(axis.x * axis.y * (1 - Math.Cos(angle)) - (axis.z * Math.Sin(angle)));
            output[0, 2] = (float)(axis.x * axis.z * (1 - Math.Cos(angle)) + (axis.y * Math.Sin(angle)));

            output[1, 0] = (float)(axis.y * axis.x * (1 - Math.Cos(angle)) + (axis.z * Math.Sin(angle)));
            output[1, 1] = (float)(Math.Cos(angle) + (axis.y * (1 - Math.Cos(angle))));
            output[1, 2] = (float)(axis.y * axis.z * (1 - Math.Cos(angle)) - (axis.x * Math.Sin(angle)));

            output[2, 0] = (float)(axis.z * axis.x * (1 - Math.Cos(angle)) - (axis.y * Math.Sin(angle)));
            output[2, 1] = (float)(axis.z * axis.y * (1 - Math.Cos(angle)) + (axis.x * Math.Sin(angle)));
            output[2, 2] = (float)(Math.Cos(angle) + (axis.z * (1 - Math.Cos(angle))));

            return output;
        }

        //Derivation from https://en.wikipedia.org/wiki/Rotation_matrix#General_3D_rotations
        //g=pitch, b=yaw, z=roll
        //todo: verify; check for transposition
        //todo: when this is verified to work, swap those names
        public static mat3 rotateRadians(float g, float b, float z)
        {
            //Make clockwise
            g = -g;
            b = -b;
            z = -z;

            mat3 output = new mat3();

            output[0, 0] = (float)(Math.Cos(z) * Math.Cos(b));
            output[0, 1] = (float)((Math.Cos(z) * Math.Sin(b) * Math.Sin(g)) - (Math.Sin(z) * Math.Cos(g)));
            output[0, 2] = (float)((Math.Cos(z) * Math.Sin(b) * Math.Cos(g)) + (Math.Sin(z) * Math.Sin(g)));

            output[1, 0] = (float)(Math.Sin(z) * Math.Cos(b));
            output[1, 1] = (float)((Math.Sin(z) * Math.Sin(b) * Math.Sin(g)) + (Math.Cos(z) * Math.Cos(g)));
            output[1, 2] = (float)((Math.Sin(z) * Math.Sin(b) * Math.Cos(g)) - (Math.Cos(z) * Math.Sin(g)));

            output[2, 0] = (float)-Math.Sin(b);
            output[2, 1] = (float)(Math.Cos(b) * Math.Sin(g));
            output[2, 2] = (float)(Math.Cos(b) * Math.Cos(g));

            return output;
        }
        public static mat3 rotateDegrees(vec3 axis, float angle)
        {
            return rotateRadians(axis, angle * (float)(Math.PI / 180.0));
        }

        public static mat3 rotateDegrees(float eulerX, float eulerY, float eulerZ)
        {
            return rotateRadians(eulerX * (float)(Math.PI / 180.0),
                                    eulerY * (float)(Math.PI / 180.0),
                                    eulerZ * (float)(Math.PI / 180.0));
        }

        public static mat3 scale(vec3 basis)
        {
            mat3 output = new mat3();
            output.setValue(0, 0, basis.x);
            output.setValue(1, 1, basis.y);
            output.setValue(2, 2, basis.z);
            return output;
        }

        public static new mat3 scale(float size)
        {
            mat3 output = new mat3();
            output.setValue(0, 0, size);
            output.setValue(1, 1, size);
            output.setValue(2, 2, size);
            return output;
        }
    }
}
#endif