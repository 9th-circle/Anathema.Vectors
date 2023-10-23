#if DOUBLES_ENABLED
#if COMPLEX_ENABLED
#if THREED_ENABLED

using System;

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

        public dquat(double eulerX, double eulerY, double eulerZ)
        {

        }
        public dquat(dmat3 orientation)
        {

        }
        public dquat(double a, double b, double c, double d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
        }
        public dquat(double[] abcd)
        {
            this.a = abcd[0];
            this.b = abcd[1];
            this.c = abcd[2];
            this.d = abcd[3];
        }

        public double a { get; set; }
        public double b { get; set; }
        public double c { get; set; }
        public double d { get; set; }

        public static dquat slerp(dquat from, dquat to, float position)
        {
            throw new NotImplementedException();
        }

        public dmat3 toMat3()
        {
            throw new NotImplementedException();
        }
        public dvec3 toEulerAngles()
        {
            throw new NotImplementedException();
        }

    }
}
#endif
#endif
#endif