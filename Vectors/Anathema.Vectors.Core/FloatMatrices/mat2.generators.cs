#if FLOATS_ENABLED
using System;

namespace Anathema.Vectors.Core
{
    public partial class mat2
    {
        public static mat2 identity()
        {
            mat2 output = new mat2();
            for (int i = 0; i < output.xLength && i < output.yLength; i++)
                output.setValue(i, i, 1);
            return output;
        }
        public static mat2 rotateRadians(float angle)
        {
            mat2 output = new mat2();

            output.setValue(0, 0, (float)Math.Cos(angle));
            output.setValue(0, 1, (float)-Math.Sin(angle));
            output.setValue(1, 0, (float)Math.Sin(angle));
            output.setValue(1, 1, (float)Math.Cos(angle));

            return output;
        }
        public static mat2 rotateDegrees(float angle)
        {
            return rotateRadians(angle * (float)(Math.PI / 180.0));
        }


        public static mat2 scale(vec2 basis)
        {
            mat2 output = new mat2();
            output.setValue(0, 0, basis.x);
            output.setValue(1, 1, basis.y);
            return output;
        }

        public static mat2 scale(float size)
        {
            mat2 output = new mat2();
            output.setValue(0, 0, size);
            output.setValue(1, 1, size);
            return output;
        }
    }
}
#endif