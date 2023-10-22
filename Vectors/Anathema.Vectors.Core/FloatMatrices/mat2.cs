#if FLOATS_ENABLED
using System;

namespace Anathema.Vectors.Core
{
    /// <summary>
    /// A single-precision floating point, 2x2 (4 element) matrix.
    /// </summary>
    public partial class mat2
    {
        public float[] data { get; protected set; } = new float[4];

        public virtual int xLength { get { return 2; } }
        public virtual int yLength { get { return 2; } }

        public mat2()
        {
        }
        public mat2(mat2 template)
        {
            Array.Copy(template.data, data, data.Length);
        }

        public mat2(float[] data)
        {
            this.data = data;
        }
    }
}
#endif