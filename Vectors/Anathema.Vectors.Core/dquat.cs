#if DOUBLES_ENABLED
#if COMPLEX_ENABLED
using System;
using System.Collections.Generic;

using System.Text;


namespace Anathema.Vectors.Core
{
    /// <summary>
    /// Double precision floating point quaternion
    /// </summary>
    public class dquat
    {
        //todo: implement quaternions
        //We're almost entirely here for the SLERPing
        //The reason we need quaternions is for spherical linear interpolation

        public dquat(float eulerX, float eulerY, float eulerZ)
        {

        }
        public dquat(fmat3 orientation)
        {

        }
        public dquat(double a, double b, double c, double d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public double d { get; set; }

        public static dquat slerp(dquat a, dquat b, float position)
        {
            throw new NotImplementedException();
        }

        public dmat3 toFMat3()
        {
            throw new NotImplementedException();
        }

    }
}
#endif
#endif