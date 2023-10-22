#if FLOATS_ENABLED
#if COMPLEX_ENABLED
#if THREED_ENABLED
using System;

namespace Anathema.Vectors.Core
{
    /// <summary>
    /// Single precision floating point quaternion
    /// </summary>
    public class quat
    {
        //todo: implement quaternions
        //We're almost entirely here for the SLERPing
        //The reason we need quaternions is for spherical linear interpolation
        public quat(float eulerX, float eulerY, float eulerZ)
        {

        }
        public quat(mat3 orientation)
        {

        }
        public quat(float[] abcd)
        {
            this.a = abcd[0];
            this.b = abcd[1];
            this.c = abcd[2];
            this.d = abcd[3];
        }
        public quat(float a, float b, float c, float d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public float a { get; set; }
        public float b { get; set; }
        public float c { get; set; }
        public float d { get; set; }

        public static quat slerp(quat from, quat to, float position)
        {
            throw new NotImplementedException();
        }

        public mat3 toFMat3()
        {
            throw new NotImplementedException();
        }
        public vec3 toEulerAngles()
        {
            throw new NotImplementedException();
        }

    }
}
#endif
#endif
#endif