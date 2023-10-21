#if DOUBLES_ENABLED
using System;

namespace Anathema.Vectors.Core
{
    /// <summary>
    /// A double-precision floating point, 2x2 (4 element) matrix.
    /// </summary>
    public partial class dmat2
    {
        ///////////////////////////
        //        Values         //
        ///////////////////////////

        public double[] data { get; protected set; } = new double[4];

        public virtual int xLength { get { return 2; } }
        public virtual int yLength { get { return 2; } }

        ///////////////////////////
        //     Constructors      //
        ///////////////////////////

        public dmat2()
        {
        }
        public dmat2(dmat2 template)
        {
            Array.Copy(template.data, data, data.Length);
        }
        public dmat2(double[] data)
        {
            this.data = data;
        }
    }
}
#endif