using System;
#if DOUBLES_ENABLED
namespace Anathema.Vectors.Core
{
    public partial class dmat2
    {
        public static dmat2 identity()
        {
            dmat2 output = new dmat2();
            for (int i = 0; i < output.xLength && i < output.yLength; i++)
                output.setValue(i, i, 1);
            return output;
        }
        public static dmat2 rotateRadians(double angle)
        {
            dmat2 output = new dmat2();

            output.setValue(0, 0, (double)Math.Cos(angle));
            output.setValue(0, 1, (double)-Math.Sin(angle));
            output.setValue(1, 0, (double)Math.Sin(angle));
            output.setValue(1, 1, (double)Math.Cos(angle));

            return output;
        }
        public static dmat2 rotateDegrees(double angle)
        {
            return rotateRadians(angle * (Math.PI / 180.0));
        }

        public static dmat2 scale(dvec2 basis)
        {
            dmat2 output = new dmat2();
            output.setValue(0, 0, basis.x);
            output.setValue(1, 1, basis.y);
            return output;
        }

        public static dmat2 scale(double size)
        {
            dmat2 output = new dmat2();
            output.setValue(0, 0, size);
            output.setValue(1, 1, size);
            return output;
        }
    }
}
#endif