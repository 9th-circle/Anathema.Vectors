#if DOUBLES_ENABLED
#if THREED_ENABLED
namespace Anathema.Vectors.Core
{
    public partial class dmat3
    {
        public new dmat3 transposed
        {
            get
            {
                dmat3 output = new dmat3();
                for (int x = 0; x < rowCount; x++)
                    for (int y = 0; y < columnCount; y++)
                        output.setValue(x, y, getValue(y, x));
                return output;
            }
        }

        public override void transpose()
        {
            assign(transposed);
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