#if FLOATS_ENABLED
using System;

namespace Anathema.Vectors.Core
{
    public partial class fmat2
    {

        //todo: check if this causes a transpose
#if NESTING_ENABLED && TEMPLATES_ENABLED
        public static fmat2 fromNestedVector(tvec2<tvec2<float>> input)
        {
            fmat2 output = new fmat2();

            output.setValue(0, 0, input.x.x);
            output.setValue(0, 1, input.x.y);

            output.setValue(1, 0, input.y.x);
            output.setValue(1, 1, input.y.y);

            return output;
        }
#endif

        public float getValue(int x, int y)
        {
            //Design decision: we should be able to pass around a mat2 in a mat3
            // reference and simply use the columns that are present.

            if (x >= rowCount || y >= columnCount || x < 0 || y < 0)
                return 0;
            return data[(y * rowCount) + x];
        }

        public void setValue(int x, int y, float value)
        {
            //Design decision: writing to a matrix out of its bounds
            // should fail. This is so that if you're passing around a
            // mat2 in a mat3 reference, it shouldn't silently fail
            // when you try to write to a slot that doesn't exist.
            // This is an asymmetry between get and set which might
            // not be obvious.

            if (x >= rowCount || y >= columnCount || x < 0 || y < 0)
                throw new IndexOutOfRangeException();
            data[(y * rowCount) + x] = value;
        }
    }
}
#endif