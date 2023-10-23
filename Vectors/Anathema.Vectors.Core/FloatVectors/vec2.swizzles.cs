﻿#if FLOATS_ENABLED
namespace Anathema.Vectors.Core
{
    public partial class vec2
    {
#if CAPITALS_ENABLED
        public float X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public float Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
#endif
#if SWIZZLES_ENABLED
        public vec2 xy
        {
            get
            {
                return new vec2(x, y);
            }
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        public vec2 yx
        {
            get
            {
                return new vec2(y, x);
            }
            set
            {
                y = value.x;
                x = value.y;
            }
        }
#endif

#if COLOURS_ENABLED
#if CAPITALS_ENABLED

        public float R
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public float G
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
#endif
        public float r
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public float g
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public vec2 rg
        {
            get
            {
                return new vec2(x, y);
            }
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        public vec2 gr
        {
            get
            {
                return new vec2(y, x);
            }
            set
            {
                y = value.x;
                x = value.y;
            }
        }
#endif

    }
}
#endif