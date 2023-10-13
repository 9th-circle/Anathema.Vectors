#if TEMPLATES_ENABLED
#if THREED_ENABLED
using System;

namespace Anathema.Vectors.Core
{
    /// <summary>
    /// A 3-component vector where each element is a templated type. Nesting is allowed.
    /// </summary>
    public partial class tvec3<T> : tvec2<T>
    {
        ///////////////////////////
        //        Members        //
        ///////////////////////////

        public T z { get; set; }


        ///////////////////////////
        //     Constructors      //
        ///////////////////////////

        public tvec3()
        {
        }
        public tvec3(T x, T y, T z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public tvec3(tvec3<T> xyz)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }


        public tvec3(T[] xyz)
        {
            this[0] = xyz[0];
            this[1] = xyz[1];
            this[2] = xyz[2];
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

        public override T[] ToArray()
        {
            return new T[] { x, y, z };
        }
    }
}
#endif
#endif