
#if FLOATS_ENABLED
namespace Anathema.Vectors.Core
{
    public partial class fvec2
    {

#if SWIZZLES_ENABLED
        public fvec2 xy
        {
            get
            {
                return new fvec2(x, y);
            }
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        public fvec2 yx
        {
            get
            {
                return new fvec2(y, x);
            }
            set
            {
                y = value.x;
                x = value.y;
            }
        }
#endif

#if COLOURS_ENABLED
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
        public fvec2 rg
        {
            get
            {
                return new fvec2(x, y);
            }
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        public fvec2 gr
        {
            get
            {
                return new fvec2(y, x);
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