using System;

#if DOUBLES_ENABLED

namespace Anathema.Vectors.Core
{
    public partial class dmat2
    {
        //todo: check if this causes a transpose
#if NESTING_ENABLED && TEMPLATES_ENABLED
        public static dmat2 fromNestedVector(tvec2<tvec2<double>> input)
        {
            dmat2 output = new dmat2();

            output.setValue(0, 0, input.x.x);
            output.setValue(0, 1, input.x.y);

            output.setValue(1, 0, input.y.x);
            output.setValue(1, 1, input.y.y);

            return output;
        }
#endif

        public double getValue(int x, int y)
        {
            //Design decision: we should be able to pass around a mat2 in a mat3
            // reference and simply use the columns that are present.

            if (x >= xLength || y >= yLength || x < 0 || y < 0)
                return 0;
            return data[(y * xLength) + x];
        }

        public void setValue(int x, int y, double value)
        {
            //Design decision: writing to a matrix out of its bounds
            // should fail. This is so that if you're passing around a
            // mat2 in a mat3 reference, it shouldn't silently fail
            // when you try to write to a slot that doesn't exist.
            // This is an asymmetry between get and set which might
            // not be obvious.

            if (x >= xLength || y >= yLength || x < 0 || y < 0)
                throw new IndexOutOfRangeException();
            data[(y * xLength) + x] = value;
        }
    }
}
#endif