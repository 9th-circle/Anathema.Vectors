#if FLOATS_ENABLED
#if COMPLEX_ENABLED
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

        public static fquat slerp(fquat a, fquat b, float position)
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