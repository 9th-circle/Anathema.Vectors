#if DOUBLES_ENABLED

namespace Anathema.Vectors.Core
{
    public partial class dmat2
    {
        public dmat2 transposed
        {
            get
            {
                dmat2 output = new dmat2();
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

        public void assign(dmat2 other)
        {
            for (int i = 0; i < other.data.Length && i < data.Length; i++)
                data[i] = other.data[i];
        }

        public static bool operator ==(dmat2 a, dmat2 b)
        {
            if (a is null && b is null)
                return true;
            if(a is null != b is null)
                return false;
            for (int i = 0; i < a.data.Length; i++)
                if (a[i] != b[i]) return false;
            return true;
        }
        public static bool operator !=(dmat2 a, dmat2 b)
        {
            return !(a == b);
        }

        public double this[int i] { get { return data[i]; } set { data[i] = value; } }
        public double this[int x, int y] { get { return getValue(x, y); } set { setValue(x, y, value); } }

        public double[] ToArray()
        {
            return data;
        }
    }
}
#endif