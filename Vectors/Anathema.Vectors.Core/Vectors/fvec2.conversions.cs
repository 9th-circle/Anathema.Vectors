
#if FLOATS_ENABLED
namespace Anathema.Vectors.Core
{
    public partial class fvec2
    {
#if CONVERSIONS_ENABLED
#if DOUBLES_ENABLED
        public fvec2(dvec2 xy)
        {
            x = (float)xy.x;
            y = (float)xy.y;
        }
#endif
#if TEMPLATES_ENABLED
        public tvec2<float> toTVec2()
        {
            return new tvec2<float>(x, y);
        }
#endif
#endif
    }
}
#endif