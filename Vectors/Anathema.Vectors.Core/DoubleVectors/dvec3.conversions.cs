#if DOUBLES_ENABLED
#if THREED_ENABLED

namespace Anathema.Vectors.Core
{
    public partial class dvec3
    {
        public dvec3(dvec2 a, double z)
        {
            x = a.x;
            y = a.y;
            this.z = z;
        }
        public dvec3(double x, dvec2 yz)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }
        public dvec3(fvec3 xyz)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }

#if CONVERSIONS_ENABLED
#if TEMPLATES_ENABLED
        public tvec3<double> toTVec3()
        {
            return new tvec3<double>(x, y, z);
        }
#endif
#endif
    }
}
#endif
#endif