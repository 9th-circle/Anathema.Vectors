#if DOUBLES_ENABLED
#if THREED_ENABLED
using System;

namespace Anathema.Vectors.Core
{
    /// <summary>
    /// A double-precision floating point, 4x4 (16 element) matrix.
    /// </summary>
    public partial class dmat4 : dmat3
    {
        public override int xLength { get { return 4; } }
        public override int yLength { get { return 4; } }

        public dmat4()
        {
            data = new double[16];
        }

        public dmat4(dmat4 template)
        {
            data = new double[16];
            Array.Copy(template.data, data, data.Length);
        }

        public dmat4(double[] data)
        {
            this.data = data;
        }

    }
}
#endif
#endif