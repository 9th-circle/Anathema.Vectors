﻿using System;
#if FLOATS_ENABLED && THREED_ENABLED

namespace Anathema.Vectors.Core
{
    public partial class mat4
    {
        public new static mat4 identity()
        {
            mat4 output = new mat4();
            for (int i = 0; i < output.xLength && i < output.yLength; i++)
                output.setValue(i, i, 1);
            return output;
        }

        public new static mat4 rotateRadians(vec3 axis, float angle)
        {
            return mat3.rotateRadians(axis, angle).toMat4();
        }

        public new static mat4 rotateRadians(float eulerX, float eulerY, float eulerZ)
        {
            return mat3.rotateRadians(eulerX, eulerY, eulerZ).toMat4();
        }

        public new static mat4 rotateDegrees(vec3 axis, float angle)
        {
            return rotateRadians(axis, angle * (float)(Math.PI / 180.0));
        }

        public new static mat4 rotateDegrees(float eulerX, float eulerY, float eulerZ)
        {
            return rotateRadians(eulerX * (float)(Math.PI / 180.0),
                                    eulerY * (float)(Math.PI / 180.0),
                                    eulerZ * (float)(Math.PI / 180.0));
        }
        public static mat4 scale(vec4 basis)
        {
            mat4 output = new mat4();
            output.setValue(0, 0, basis.x);
            output.setValue(1, 1, basis.y);
            output.setValue(2, 2, basis.z);
            output.setValue(3, 3, basis.w);
            return output;
        }

        public static new mat4 scale(float size)
        {
            mat4 output = new mat4();
            output.setValue(0, 0, size);
            output.setValue(1, 1, size);
            output.setValue(2, 2, size);
            output.setValue(3, 3, 1.0f);
            return output;
        }

        public static mat4 translate(vec3 basis)
        {
            mat4 output = identity();

            output[3, 0] = basis.x;
            output[3, 1] = basis.y;
            output[3, 2] = basis.z;

            return output;
        }

        public static mat4 ortho()
        {
            mat4 output = identity();

            output[2, 1] = -1.0f;    //one z unit should be turned into minus one y unit

            return output;
        }
        public static mat4 perspective()
        {
            mat4 output = identity();

            output[2, 3] = 1.0f;    //everything should be scaled by 1 divided by z

            return output;
        }

    }
}
#endif