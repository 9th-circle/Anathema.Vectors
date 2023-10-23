#if FLOATS_ENABLED
using System;
using System.Collections.Generic;
using System.Text;

namespace Anathema.Vectors.Core
{
    public partial class mat2
    {
        public mat2 transposed
        {
            get
            {
                mat2 output = new mat2();
                for (int x = 0; x < xLength; x++)
                    for (int y = 0; y < yLength; y++)
                        output.setValue(x, y, getValue(y, x));
                return output;
            }
        }
        public virtual void transpose()
        {
            assign(transposed);
        }

        public void assign(mat2 other)
        {
            for (int i = 0; i < other.data.Length && i < data.Length; i++)
                data[i] = other.data[i];
        }

        public static bool operator ==(mat2 a, mat2 b)
        {
            if (a is null && b is null)
                return true;
            if (a is null != b is null)
                return false;
            for (int i = 0; i < a.data.Length; i++)
                if (Math.Abs(a[i] - b[i]) > scalar.floatComparisonTolerance) return false;
            return true;
        }
        public static bool operator !=(mat2 a, mat2 b)
        {
            return !(a == b);
        }


        public float this[int i] { get { return data[i]; } set { data[i] = value; } }
        public float this[int x, int y] { get { return getValue(x, y); } set { setValue(x, y, value); } }

        public float[] ToArray()
        {
            return data;
        }
    }
}
#endif