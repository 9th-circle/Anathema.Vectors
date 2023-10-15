using System;
#if FLOATS_ENABLED
#if THREED_ENABLED

namespace Anathema.Vectors.Core
{
    public partial class fmat4
    {
        public new static fmat4 identity()
        {
            fmat4 output = new fmat4();
            for (int i = 0; i < output.rowCount && i < output.columnCount; i++)
                output.setValue(i, i, 1);
            return output;
        }

        public static new fmat4 rotateRadians(fvec3 axis, float angle)
        {
            return fmat3.rotateRadians(axis, angle).toFMat4();
        }

        public static new fmat4 rotateRadians(float eulerX, float eulerY, float eulerZ)
        {
            return fmat3.rotateRadians(eulerX, eulerY, eulerZ).toFMat4();
        }

        public static new fmat4 rotateDegrees(fvec3 axis, float angle)
        {
            return rotateRadians(axis, angle * (float)(Math.PI / 180.0));
        }

        public static new fmat4 rotateDegrees(float eulerX, float eulerY, float eulerZ)
        {
            return rotateRadians(eulerX * (float)(Math.PI / 180.0),
                                    eulerY * (float)(Math.PI / 180.0),
                                    eulerZ * (float)(Math.PI / 180.0));
        }
        public static fmat4 scale(fvec4 basis)
        {
            fmat4 output = new fmat4();
            output.setValue(0, 0, basis.x);
            output.setValue(1, 1, basis.y);
            output.setValue(2, 2, basis.z);
            output.setValue(3, 3, basis.w);
            return output;
        }

        public static new fmat4 scale(float size)
        {
            fmat4 output = new fmat4();
            output.setValue(0, 0, size);
            output.setValue(1, 1, size);
            output.setValue(2, 2, size);
            output.setValue(3, 3, size);
            return output;
        }

        public static new fmat4 translate(fvec3 basis)
        {
            fmat4 output = fmat4.identity();

            //todo: check transposition
            output[3, 0] = basis.x;
            output[3, 1] = basis.y;
            output[3, 2] = basis.z;

            return output;
        }

        public static fmat4 projection()
        {
            //todo: implement projection matrices
            throw new NotImplementedException();
        }

    }
}
#endif
#endif