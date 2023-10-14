using System;

namespace Anathema.Vectors.Core
{
    public class scalar
    {
        public static float REALLY_SMALL_VALUE = 0.00005f;    //using float.epsilon is not better - floating point granularity is nonlinear

        //Yes: this sucks. 
#if FLOATS_ENABLED
        public static bool isClose(float x, float y)
        {
            return Math.Abs(x - y) <= REALLY_SMALL_VALUE;
        }
        public static float linearInterpolate(float a, float b, float position)
        {
            return (a * (1 - position)) + (b * position);
        }
        public static float bezierInterpolate(float a, float b, float c, float position)
        {
            return linearInterpolate(   linearInterpolate(a, b, position),
                                        linearInterpolate(b, c, position),
                                        position);
        }
#endif
#if DOUBLES_ENABLED
        public static bool isClose(double x, double y)
        {
            return Math.Abs(x - y) <= REALLY_SMALL_VALUE;
        }
        public static double linearInterpolate(double a, double b, double position)
        {
            return (a * (1 - position)) + (b * position);
        }
        public static double bezierInterpolate(double a, double b, double c, double position)
        {
            return linearInterpolate(   linearInterpolate(a, b, position),
                                        linearInterpolate(b, c, position),
                                        position);
        }
#endif
    }
}
