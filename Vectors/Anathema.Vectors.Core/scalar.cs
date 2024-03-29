﻿using System;

namespace Anathema.Vectors.Core
{
    public class scalar
    {
        public static float floatComparisonTolerance = 0.00005f;    //using float.epsilon is not better - floating point granularity is nonlinear

        //Yes: this sucks.
        public static bool isClose(float x, float y)
        {
            return Math.Abs(x - y) <= floatComparisonTolerance;
        }
#if INTERPOLATION_ENABLED
        public static float linearInterpolate(float a, float b, float position)
        {
            return (a * (1 - position)) + (b * position);
        }
        public static float quadraticBezierInterpolate(float a, float b, float c, float position)
        {
            return linearInterpolate(   linearInterpolate(a, b, position),
                                        linearInterpolate(b, c, position),
                                        position);
        }
#endif
        public static bool isClose(double x, double y)
        {
            return Math.Abs(x - y) <= floatComparisonTolerance;
        }
#if INTERPOLATION_ENABLED
        public static double linearInterpolate(double a, double b, double position)
        {
            return (a * (1 - position)) + (b * position);
        }
        public static double quadraticBezierInterpolate(double a, double b, double c, double position)
        {
            return linearInterpolate(   linearInterpolate(a, b, position),
                                        linearInterpolate(b, c, position),
                                        position);
        }
#endif
    }
}
