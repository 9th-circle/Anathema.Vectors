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
    }
}
#endif