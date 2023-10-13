#if DOUBLES_ENABLED
using System;

namespace Anathema.Vectors.Core
{
    /// <summary>
    /// A double precision floating point, 2-component vector.
    /// </summary>
    public partial class dvec2
    {
        public double x { get; set; }
        public double y { get; set; }

        public dvec2()
        {
        }

        public dvec2(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public dvec2(dvec2 xy)
        {
            x = xy.x;
            y = xy.y;
        }
        public dvec2(double[] xy)
        {
            this[0] = xy[0];
            this[1] = xy[1];
        }


        public double this[int i]
        {
            get
            {
                if (i == 0)
                    return x;
                if (i == 1)
                    return y;
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (i == 0)
                { x = value; return; }
                if (i == 1)
                { y = value; return; }
                throw new IndexOutOfRangeException();
            }
        }

        public virtual double[] ToArray()
        {
            return new double[] { x, y };
        }
    }
}
#endif