#if FLOATS_ENABLED
#if THREED_ENABLED
namespace Anathema.Vectors.Core
{
    public partial class mat3
    {
        public override void transpose()
        {
            assign(transposed);
        }

        public void assign(mat3 other)
        {
            for (int i = 0; i < other.data.Length && i < data.Length; i++)
                data[i] = other.data[i];
        }

        //todo: ==/!= operators


        public new mat3 transposed
        {
            get
            {
                mat3 output = new mat3();
                for (int x = 0; x < xLength; x++)
                    for (int y = 0; y < yLength; y++)
                        output.setValue(x, y, getValue(y, x));
                return output;
            }
        }
    }
}
#endif
#endif