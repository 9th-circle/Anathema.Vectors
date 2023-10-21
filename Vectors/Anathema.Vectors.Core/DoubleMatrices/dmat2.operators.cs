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
                for (int x = 0; x < rowCount; x++)
                    for (int y = 0; y < columnCount; y++)
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

        //todo: ==/!= operators

        public double this[int i] { get { return data[i]; } set { data[i] = value; } }
        public double this[int x, int y] { get { return getValue(x, y); } set { setValue(x, y, value); } }

        public double[] ToArray()
        {
            return data;
        }
    }
}
#endif