#if DOUBLES_ENABLED

namespace Anathema.Vectors.Core
{
    public partial class dvec2
    {


#if CAPITALS_ENABLED
        public double X
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
        public double Y
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
        public dvec2 xy
        {
            get
            {
                return new dvec2(x, y);
            }
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        public dvec2 yx
        {
            get
            {
                return new dvec2(y, x);
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
        public double R
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
        public double G
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
        public double r
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
        public double g
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
        public dvec2 rg
        {
            get
            {
                return new dvec2(x, y);
            }
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        public dvec2 gr
        {
            get
            {
                return new dvec2(y, x);
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