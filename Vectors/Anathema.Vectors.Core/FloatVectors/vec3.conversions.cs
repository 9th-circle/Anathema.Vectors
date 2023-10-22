#if FLOATS_ENABLED
#if THREED_ENABLED
namespace Anathema.Vectors.Core
{
    public partial class vec3
    {
#if CONVERSIONS_ENABLED
        public vec3(vec2 a, float z)
        {
            x = a.x;
            y = a.y;
            this.z = z;
        }
        public vec3(float x, vec2 yz)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }
#if DOUBLES_ENABLED
        public vec3(dvec3 xyz)
        {
            x = (float)xyz.x;
            y = (float)xyz.y;
            z = (float)xyz.z;
        }
#endif
#if TEMPLATES_ENABLED
        public tvec3<float> toTVec3()
        {
            return new tvec3<float>(x, y, z);
        }
#endif
#endif
    }
}
#endif
#endif