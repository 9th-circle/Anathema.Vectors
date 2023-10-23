#if FLOATS_ENABLED && THREED_ENABLED

using System;

namespace Anathema.Vectors.Core
{
    /// <summary>
    /// A single-precision floating point, 3x3 (9 element) matrix.
    /// </summary>
    public partial class mat3 : mat2
    {
        public override int xLength => 3;
        public override int yLength => 3;

        public mat3()
        {
            data = new float[9];
        }
        public mat3(mat3 template)
        {
            data = new float[9];
            Array.Copy(template.data, data, data.Length);
        }
        public mat3(float[] data)
        {
            this.data = data;
        }

    }
}
#endif