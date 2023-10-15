#if FLOATS_ENABLED
#if THREED_ENABLED
namespace Anathema.Vectors.Core
{
    public partial class fmat3
    {
        public override void transpose()
        {
            assign(transposed);
        }

        public void assign(fmat3 other)
        {
            for (int i = 0; i < other.data.Length && i < data.Length; i++)
                data[i] = other.data[i];
        }


        public new fmat3 transposed
        {
            get
            {
                fmat3 output = new fmat3();
                for (int x = 0; x < rowCount; x++)
                    for (int y = 0; y < columnCount; y++)
                        output.setValue(x, y, getValue(y, x));
                return output;
            }
        }
    }
}
#endif
#endif