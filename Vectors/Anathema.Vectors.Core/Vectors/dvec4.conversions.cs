#if DOUBLES_ENABLED
#if THREED_ENABLED

namespace Anathema.Vectors.Core
{
    public partial class dvec4
    {
        public dvec4(dvec3 xyz, double w)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }
        public dvec4(double x, dvec3 yzw)
        {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }
        public dvec4(dvec2 xy, dvec2 zw)
        {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }
        public dvec4(double x, double y, dvec2 zw)
        {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }
        public dvec4(double x, dvec2 yz, double w)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }
        public dvec4(dvec2 xy, double z, double w)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }
#if FLOATS_ENABLED
        public dvec4(fvec4 xyzw)
        {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }
#endif


#if CONVERSIONS_ENABLED
#if TEMPLATES_ENABLED
        public tvec4<double> toTVec4()
        {
            return new tvec4<double>(x, y, z, w);
        }
#endif
#endif
    }
}
#endif
#endif