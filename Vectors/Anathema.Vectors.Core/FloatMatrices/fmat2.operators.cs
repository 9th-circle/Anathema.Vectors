#if FLOATS_ENABLED
using System;
using System.Collections.Generic;
using System.Text;

namespace Anathema.Vectors.Core
{
    public partial class fmat2
    {
        public fmat2 transposed
        {
            get
            {
                fmat2 output = new fmat2();
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

        public void assign(fmat2 other)
        {
            for (int i = 0; i < other.data.Length && i < data.Length; i++)
                data[i] = other.data[i];
        }
        //todo: ==/!= operators


        public float this[int i] { get { return data[i]; } set { data[i] = value; } }
        public float this[int x, int y] { get { return getValue(x, y); } set { setValue(x, y, value); } }

        public float[] ToArray()
        {
            return data;
        }
    }
}
#endif