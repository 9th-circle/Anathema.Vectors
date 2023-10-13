#if FLOATS_ENABLED
using System;

namespace Anathema.Vectors.Core
{
    /// <summary>
    /// A single-precision floating point, 2x2 (4 element) matrix.
    /// </summary>
    public partial class fmat2
    {
        public float[] data { get; protected set; } = new float[4];

        public virtual int rowCount { get { return 2; } }
        public virtual int columnCount { get { return 2; } }

        public fmat2()
        {
        }
        public fmat2(fmat2 template)
        {
            Array.Copy(template.data, data, data.Length);
        }

        public fmat2(float[] data)
        {
            this.data = data;
        }
        ///////////////////////////
        //      Generators       //
        ///////////////////////////


        ///////////////////////////
        //      Conversions      //
        ///////////////////////////


        ///////////////////////////
        //      Transforms       //
        ///////////////////////////

        public fmat2 transposed
        {
            get
            {
                fmat2 output = new fmat2();
                for (int x = 0; x < rowCount; x++)
                    for (int y = 0; y < columnCount; y++)
                        output.setValue(x, y, getValue(y, x));
                return output;
            }
        }

        ///////////////////////////
        //       Mutators        //
        ///////////////////////////

        public virtual void transpose()
        {
            assign(transposed);
        }

        public void assign(fmat2 other)
        {
            for (int i = 0; i < other.data.Length && i < data.Length; i++)
                data[i] = other.data[i];
        }

        ///////////////////////////
        //       Operators       //
        ///////////////////////////


        public float this[int i] { get { return data[i]; } set { data[i] = value; } }
        public float this[int x, int y] { get { return getValue(x,y); } set { setValue(x,y,value); } }

        public float[] ToArray()
        {
            return data;
        }
    }
}
#endif