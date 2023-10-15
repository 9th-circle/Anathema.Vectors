#if FLOATS_ENABLED
using System;

namespace Anathema.Vectors.Core
{
    public partial class fmat2
    {
        public static fmat2 identity()
        {
            fmat2 output = new fmat2();
            for (int i = 0; i < output.rowCount && i < output.columnCount; i++)
                output.setValue(i, i, 1);
            return output;
        }
        public static fmat2 rotateRadians(float angle)
        {
            fmat2 output = new fmat2();

            output.setValue(0, 0, (float)Math.Cos(angle));
            output.setValue(0, 1, (float)-Math.Sin(angle));
            output.setValue(1, 0, (float)Math.Sin(angle));
            output.setValue(1, 1, (float)Math.Cos(angle));

            return output;
        }
        public static fmat2 rotateDegrees(float angle)
        {
            return rotateRadians(angle * (float)(Math.PI / 180.0));
        }


        public static fmat2 scale(fvec2 basis)
        {
            fmat2 output = new fmat2();
            output.setValue(0, 0, basis.x);
            output.setValue(1, 1, basis.y);
            return output;
        }

        public static fmat2 scale(float size)
        {
            fmat2 output = new fmat2();
            output.setValue(0, 0, size);
            output.setValue(1, 1, size);
            return output;
        }
    }
}
#endif