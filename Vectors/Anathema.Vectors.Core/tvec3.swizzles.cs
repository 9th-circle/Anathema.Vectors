#if THREED_ENABLED
#if TEMPLATES_ENABLED
using System;
using System.Collections.Generic;
using System.Text;

namespace Anathema.Vectors.Core
{
    public partial class tvec3<T> : tvec2<T>
    {
        // 3! = 3 * 2 * 1 = 6
        // There are 6 swizzles, in 3 groups of 2

        //Starting with X (2)

#if SWIZZLES_ENABLED
        public tvec3<T> xyz
        {
            get
            {
                return new tvec3<T>(x, y, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }
        public tvec3<T> xzy
        {
            get
            {
                return new tvec3<T>(x, z, y);
            }
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
            }
        }


        //Starting with Y (2)


        public tvec3<T> yxz
        {
            get
            {
                return new tvec3<T>(y, x, z);
            }
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
            }
        }
        public tvec3<T> yzx
        {
            get
            {
                return new tvec3<T>(y, z, x);
            }
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
            }
        }


        //Starting with Z (2)


        public tvec3<T> zxy
        {
            get
            {
                return new tvec3<T>(z, x, y);
            }
            set
            {
                z = value.x;
                x = value.y;
                y = value.z;
            }
        }
        public tvec3<T> zyx
        {
            get
            {
                return new tvec3<T>(z, y, x);
            }
            set
            {
                z = value.x;
                y = value.y;
                x = value.z;
            }
        }
#endif
#if COLOURS_ENABLED
        public T b
        {
            get
            {
                return z;
            }
            set
            {
                z = value;
            }
        }
        public tvec3<T> rgb
        {
            get
            {
                return new tvec3<T>(x, y, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }
        public tvec3<T> rbg
        {
            get
            {
                return new tvec3<T>(x, z, y);
            }
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
            }
        }
        public tvec3<T> grb
        {
            get
            {
                return new tvec3<T>(y, x, z);
            }
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
            }
        }
        public tvec3<T> gbr
        {
            get
            {
                return new tvec3<T>(y, z, x);
            }
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
            }
        }
        public tvec3<T> bgr
        {
            get
            {
                return new tvec3<T>(z, y, x);
            }
            set
            {
                z = value.x;
                y = value.y;
                x = value.z;
            }
        }
        public tvec3<T> brg
        {
            get
            {
                return new tvec3<T>(z, x, y);
            }
            set
            {
                z = value.x;
                x = value.y;
                y = value.z;
            }
        }




    }
}

#endif
#endif