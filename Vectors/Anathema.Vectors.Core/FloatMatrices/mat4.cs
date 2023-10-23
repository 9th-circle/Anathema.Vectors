#if FLOATS_ENABLED && THREED_ENABLED

using System;

namespace Anathema.Vectors.Core
{
    /// <summary>
    /// A single-precision floating point, 4x4 (16 element) matrix.
    /// </summary>
    public partial class mat4 : mat3
    {
        public override int xLength { get { return 4; } }
        public override int yLength { get { return 4; } }

        public mat4()
        {
            data = new float[16];
        }

        public mat4(mat4 template)
        {
            data = new float[16];
            Array.Copy(template.data, data, data.Length);
        }
        public mat4(float[] data)
        {
            this.data = data;
        }

    }
}
#endif