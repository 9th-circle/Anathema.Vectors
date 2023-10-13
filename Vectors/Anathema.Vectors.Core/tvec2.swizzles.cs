#if TEMPLATES_ENABLED
namespace Anathema.Vectors.Core
{
    public partial class tvec2<T>
    {
#if SWIZZLES_ENABLED

        public tvec2<T> xy
        {
            get
            {
                return new tvec2<T>(x, y);
            }
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        public tvec2<T> yx
        {
            get
            {
                return new tvec2<T>(y, x);
            }
            set
            {
                y = value.x;
                x = value.y;
            }
        }

#endif
#if COLOURS_ENABLED
        public T r
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
        public T g
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
        public tvec2<T> rg
        {
            get
            {
                return new tvec2<T>(x, y);
            }
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        public tvec2<T> gr
        {
            get
            {
                return new tvec2<T>(y, x);
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