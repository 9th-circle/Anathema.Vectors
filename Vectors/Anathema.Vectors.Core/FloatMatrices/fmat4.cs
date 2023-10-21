#if FLOATS_ENABLED
#if THREED_ENABLED

using System;

namespace Anathema.Vectors.Core
{
    /// <summary>
    /// A single-precision floating point, 4x4 (16 element) matrix.
    /// </summary>
    public partial class fmat4 : fmat3
    {
        public override int xLength { get { return 4; } }
        public override int yLength { get { return 4; } }

        public fmat4()
        {
            data = new float[16];
        }

        public fmat4(fmat4 template)
        {
            data = new float[16];
            Array.Copy(template.data, data, data.Length);
        }
        public fmat4(float[] data)
        {
            this.data = data;
        }

    }
}
#endif
#endif