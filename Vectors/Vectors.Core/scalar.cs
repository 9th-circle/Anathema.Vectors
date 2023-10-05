using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Core
{
    public class scalar
    {

        //Yes: this sucks. 
#if FLOATS_ENABLED
        const float REALLY_SMALL_VALUE = 0.000000001f;    //using float.epsilon is not better - floating point granularity is nonlinear
        public static bool isClose(float x, float y)
        {
            return Math.Abs(x - y) <= REALLY_SMALL_VALUE;
        }
#endif
#if DOUBLES_ENABLED
        const double EVEN_SMALLER_VALUE = 0.000000000000001;
        public static bool isClose(double x, double y)
        {
            return Math.Abs(x - y) <= EVEN_SMALLER_VALUE;
        }
#endif
    }
}
