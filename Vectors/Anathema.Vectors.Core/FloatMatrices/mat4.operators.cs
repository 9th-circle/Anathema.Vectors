
#if FLOATS_ENABLED
#if THREED_ENABLED

using System;

namespace Anathema.Vectors.Core
{
    public partial class mat4
    {
        public new mat4 transposed
        {
            get
            {
                mat4 output = new mat4();
                for (int x = 0; x < xLength; x++)
                    for (int y = 0; y < yLength; y++)
                        output.setValue(x, y, getValue(y, x));
                return output;
            }
        }
        public override void transpose()
        {
            assign(transposed);
        }

        public static bool operator ==(mat4 a, mat4 b)
        {
            if (a is null && b is null)
                return true;
            if (a is null != b is null)
                return false;
            for (int i = 0; i < a.data.Length; i++)
                if (Math.Abs(a[i] - b[i]) > scalar.floatComparisonTolerance) return false;
            return true;
        }
        public static bool operator !=(mat4 a, mat4 b)
        {
            return !(a == b);
        }

        public void assign(mat4 other)
        {
            for (int i = 0; i < other.data.Length && i < data.Length; i++)
                data[i] = other.data[i];
        }

    }
}
#endif
#endif