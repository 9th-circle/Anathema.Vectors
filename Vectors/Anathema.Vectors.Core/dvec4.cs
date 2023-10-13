#if DOUBLES_ENABLED
#if THREED_ENABLED

using System;

namespace Anathema.Vectors.Core
{
    /// <summary>
    /// A double precision floating point, 4-component vector.
    /// </summary>
    public partial class dvec4 : dvec3
    {
        public double w { get; set; }

        public dvec4()
        {
        }
        public dvec4(double x, double y, double z, double w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        public dvec4(dvec4 xyzw)
        {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        public dvec4(double[] xyzw)
        {
            this[0] = xyzw[0];
            this[1] = xyzw[1];
            this[2] = xyzw[2];
            this[3] = xyzw[3];
        }

        public dvec3 scaledToDVec3()
        {
            return new dvec3(x / w, y / w, z / w);
        }

        public override double length
        {
            get
            {
                return Math.Sqrt((x * x) + (y * y) + (z * z) + (w * w));
            }
        }
        public new dvec4 normalised
        {
            get
            {
                return this / length;
            }
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
                if (i == 3)
                    return w;
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
                if (i == 3)
                { w = value; return; }
                throw new IndexOutOfRangeException();
            }
        }

        public override double[] ToArray()
        {
            return new double[] { x, y, z, w };
        }
    }
}
#endif
#endif