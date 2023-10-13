#if DOUBLES_ENABLED
#if THREED_ENABLED
using System;

namespace Anathema.Vectors.Core
{
    /// <summary>
    /// A double precision floating point, 3-component vector.
    /// </summary>
    public partial class dvec3 : dvec2
    {
        public double z { get; set; }

        public dvec3()
        {
        }
        public dvec3(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public dvec3(dvec3 xyz)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

        public dvec3(double[] xyz)
        {
            this[0] = xyz[0];
            this[1] = xyz[1];
            this[2] = xyz[2];
        }

        public new double this[int i]
        {
            get
            {
                if (i == 0)
                    return x;
                if (i == 1)
                    return y;
                if (i == 2)
                    return z;
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (i == 0)
                { x = value; return; }
                if (i == 1)
                { y = value; return; }
                if (i == 2)
                { z = value; return; }
                throw new IndexOutOfRangeException();
            }
        }

        public override double[] ToArray()
        {
            return new double[] { x, y, z };
        }
    }
}
#endif
#endif