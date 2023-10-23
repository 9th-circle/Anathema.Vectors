using System;
#if DOUBLES_ENABLED
#if THREED_ENABLED

namespace Anathema.Vectors.Core
{
    public partial class dmat4
    {
        public new static dmat4 identity()
        {
            dmat4 output = new dmat4();
            for (int i = 0; i < output.xLength && i < output.yLength; i++)
                output.setValue(i, i, 1);
            return output;
        }

        public static new dmat4 rotateRadians(dvec3 axis, double angle)
        {
            return dmat3.rotateRadians(axis, angle).toDMat4();
        }

        public static new dmat4 rotateRadians(double eulerX, double eulerY, double eulerZ)
        {
            return dmat3.rotateRadians(eulerX, eulerY, eulerZ).toDMat4();
        }

        public static new dmat4 rotateDegrees(dvec3 axis, double angle)
        {
            return rotateRadians(axis, angle * (Math.PI / 180.0));
        }

        public static new dmat4 rotateDegrees(double eulerX, double eulerY, double eulerZ)
        {
            return rotateRadians(eulerX * (Math.PI / 180.0),
                                    eulerY * (Math.PI / 180.0),
                                    eulerZ * (Math.PI / 180.0));
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
            output.setValue(3, 3, 1.0);
            return output;
        }


        public static new dmat4 translate(dvec3 basis)
        {
            //todo: implement 3D translations
            throw new NotImplementedException();
        }

        public static dmat4 projection()
        {
            //todo: implement projection matrices
            throw new NotImplementedException();
        }

    }
}
#endif
#endif