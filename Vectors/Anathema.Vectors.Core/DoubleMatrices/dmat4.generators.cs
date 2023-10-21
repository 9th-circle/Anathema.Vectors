using System;
#if DOUBLES_ENABLED
#if THREED_ENABLED

namespace Anathema.Vectors.Core
{
    public partial class dmat4
    {

        public dmat4 toDMat4()
        {
            dmat4 output = new dmat4();
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



        public new static dmat4 identity()
        {
            dmat4 output = new dmat4();
            for (int i = 0; i < output.xLength && i < output.yLength; i++)
                output.setValue(i, i, 1);
            return output;
        }

        public static new dmat4 rotateRadians(dvec3 axis, double angle)
        {
            //todo: implement 3D rotations
            throw new NotImplementedException();
        }

        public static new dmat4 rotateRadians(double eulerX, double eulerY, double eulerZ)
        {
            //todo: implement 3D rotations
            throw new NotImplementedException();
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
            output.setValue(3, 3, size);
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