using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Core
{
    public class scalar
    {
        const float REALLY_SMALL_VALUE = 0.000000001f;    //using float.epsilon is not better - floating point granularity is nonlinear

        //Yes: this sucks. 
#if FLOATS_ENABLED
        public static bool isClose(float x, float y)
        {
            return Math.Abs(x - y) <= REALLY_SMALL_VALUE;
        }
#endif
#if DOUBLES_ENABLED
        public static bool isClose(double x, double y)
        {
            return Math.Abs(x - y) <= REALLY_SMALL_VALUE;
        }
#endif
    }
}
