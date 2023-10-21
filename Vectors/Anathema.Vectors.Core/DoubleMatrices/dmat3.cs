#if DOUBLES_ENABLED
#if THREED_ENABLED
using System;

namespace Anathema.Vectors.Core
{
    /// <summary>
    /// A double-precision floating point, 3x3 (9 element) matrix.
    /// </summary>
    public partial class dmat3 : dmat2
    {
        public override int xLength { get { return 3; } }
        public override int yLength { get { return 3; } }

        public dmat3()
        {
            data = new double[9];
        }
        public dmat3(dmat3 template)
        {
            data = new double[9];
            Array.Copy(template.data, data, data.Length);
        }
        public dmat3(double[] data)
        {
            this.data = data;
        }

    }
}
#endif
#endif