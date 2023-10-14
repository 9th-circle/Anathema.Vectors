#if TEMPLATES_ENABLED
#if THREED_ENABLED
using System;

namespace Anathema.Vectors.Core
{
    /// <summary>
    /// A 4-component vector where each element is a templated type. Nesting is allowed.
    /// </summary>
    public partial class tvec4<T> : tvec3<T>
    {
        public T w { get; set; }

        public tvec4()
        {
        }
        public tvec4(tvec4<T> xyzw)
        {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        public tvec4(T x, T y, T z, T w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        public tvec4(T[] xyzw)
        {
            this[0] = xyzw[0];
            this[1] = xyzw[1];
            this[2] = xyzw[2];
            this[3] = xyzw[3];
        }

        public new T this[int i]
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

        public override T[] ToArray()
        {
            return new T[] { x, y, z, w };
        }

    }
}
#endif
#endif