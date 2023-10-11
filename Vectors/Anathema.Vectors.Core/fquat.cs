#if FLOATS_ENABLED
#if COMPLEX_ENABLED
#if THREED_ENABLED
using System;

namespace Anathema.Vectors.Core
{
    /// <summary>
    /// Single precision floating point quaternion
    /// </summary>
    public class fquat
    {
        //todo: implement quaternions
        //We're almost entirely here for the SLERPing
        //The reason we need quaternions is for spherical linear interpolation
        public fquat(float eulerX, float eulerY, float eulerZ)
        {

        }
        public fquat(fmat3 orientation)
        {

        }
        public fquat(float a, float b, float c, float d)
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

        public static fquat slerp(fquat from, fquat to, float position)
        {
            throw new NotImplementedException();
        }

        public fmat3 toFMat3()
        {
            throw new NotImplementedException();
        }

    }
}
#endif
#endif
#endif