#if FLOATS_ENABLED && THREED_ENABLED
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

        public static bool operator ==(mat3 a, mat3 b)
        {
            for(int i=0; i < a.data.Length; i++)
                if(a[i] != b[i]) return false;
            return true;
        }
        public static bool operator !=(mat3 a, mat3 b)
        {
            return !(a == b);
        }

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