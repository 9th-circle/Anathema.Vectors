#if FLOATS_ENABLED
#if THREED_ENABLED

using System;

namespace Anathema.Vectors.Core
{
    /// <summary>
    /// A single-precision floating point, 3x3 (9 element) matrix.
    /// </summary>
    public partial class fmat3 : fmat2
    {
        public override int xLength { get { return 3; } }
        public override int yLength { get { return 3; } }

        public fmat3()
        {
            data = new float[9];
        }
        public fmat3(fmat3 template)
        {
            data = new float[9];
            Array.Copy(template.data, data, data.Length);
        }
        public fmat3(float[] data)
        {
            this.data = data;
        }

    }
}
#endif
#endif