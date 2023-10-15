
#if THREED_ENABLED
#if FLOATS_ENABLED

namespace Anathema.Vectors.Core
{
    public partial class fvec4
    {

#if CONVERSIONS_ENABLED
        public fvec4(fvec3 xyz, float w)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }
        public fvec4(float x, fvec3 yzw)
        {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }
        public fvec4(fvec2 xy, fvec2 zw)
        {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }
        public fvec4(float x, float y, fvec2 zw)
        {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }
        public fvec4(float x, fvec2 yz, float w)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }
        public fvec4(fvec2 xy, float z, float w)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }
#if DOUBLES_ENABLED
        public fvec4(dvec4 xyzw)
        {
            x = (float)xyzw.x;
            y = (float)xyzw.y;
            z = (float)xyzw.z;
            w = (float)xyzw.w;
        }
#endif


#if TEMPLATES_ENABLED
        public tvec4<float> toTVec4()
        {
            return new tvec4<float>(x, y, z, w);
        }
#endif
#endif
    }
}
#endif
#endif