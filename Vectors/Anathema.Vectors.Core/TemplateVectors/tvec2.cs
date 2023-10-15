#if TEMPLATES_ENABLED
using System;

namespace Anathema.Vectors.Core
{
    /// <summary>
    /// A 2-component vector where each element is a templated type. Nesting is allowed.
    /// </summary>
    public partial class tvec2<T>
    {
        public T x { get; set; }
        public T y { get; set; }

        public tvec2()
        {
        }

        public tvec2(T x, T y)
        {
            this.x = x;
            this.y = y;
        }
        public tvec2(tvec2<T> xy)
        {
            x = xy.x;
            y = xy.y;
        }
        public tvec2(T[] xy)
        {
            this[0] = xy[0];
            this[1] = xy[1];
        }


        public T this[int i]
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


        public virtual T[] ToArray()
        {
            return new T[] { x, y };
        }
    }
}
#endif