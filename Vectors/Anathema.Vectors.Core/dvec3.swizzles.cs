using System;
using System.Collections.Generic;
using System.Text;

namespace Anathema.Vectors.Core
{
    public partial class dvec3
    {

        // 3! = 3 * 2 * 1 = 6
        // There are 6 swizzles, in 3 groups of 2

        //Starting with X (2)

#if SWIZZLES_ENABLED

        public dvec3 xyz
        {
            get
            {
                return new dvec3(x, y, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }
        public dvec3 xzy
        {
            get
            {
                return new dvec3(x, z, y);
            }
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
            }
        }


        //Starting with Y (2)


        public dvec3 yxz
        {
            get
            {
                return new dvec3(y, x, z);
            }
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
            }
        }
        public dvec3 yzx
        {
            get
            {
                return new dvec3(y, z, x);
            }
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
            }
        }


        //Starting with Z (2)


        public dvec3 zxy
        {
            get
            {
                return new dvec3(z, x, y);
            }
            set
            {
                z = value.x;
                x = value.y;
                y = value.z;
            }
        }
        public dvec3 zyx
        {
            get
            {
                return new dvec3(z, y, x);
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
        public double b
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
        public dvec3 rgb
        {
            get
            {
                return new dvec3(x, y, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }
        public dvec3 rbg
        {
            get
            {
                return new dvec3(x, z, y);
            }
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
            }
        }
        public dvec3 grb
        {
            get
            {
                return new dvec3(y, x, z);
            }
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
            }
        }
        public dvec3 gbr
        {
            get
            {
                return new dvec3(y, z, x);
            }
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
            }
        }
        public dvec3 bgr
        {
            get
            {
                return new dvec3(z, y, x);
            }
            set
            {
                z = value.x;
                y = value.y;
                x = value.z;
            }
        }
        public dvec3 brg
        {
            get
            {
                return new dvec3(z, x, y);
            }
            set
            {
                z = value.x;
                x = value.y;
                y = value.z;
            }
        }



#endif
    }
}
