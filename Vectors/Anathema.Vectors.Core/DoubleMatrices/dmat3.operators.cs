#if DOUBLES_ENABLED
#if THREED_ENABLED
using System;

namespace Anathema.Vectors.Core
{
    public partial class dmat3
    {
        public new dmat3 transposed
        {
            get
            {
                dmat3 output = new dmat3();
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

        public static bool operator ==(dmat3 a, dmat3 b)
        {
            if (a is null && b is null)
                return true;
            if (a is null != b is null)
                return false;
            for (int i = 0; i < a.data.Length; i++)
                if (Math.Abs(a[i] - b[i]) > scalar.floatComparisonTolerance) return false;
            return true;
        }
        public static bool operator !=(dmat3 a, dmat3 b)
        {
            return !(a == b);
        }

        public void assign(dmat3 other)
        {
            for (int i = 0; i < other.data.Length && i < data.Length; i++)
                data[i] = other.data[i];
        }
    }
}
#endif
#endif