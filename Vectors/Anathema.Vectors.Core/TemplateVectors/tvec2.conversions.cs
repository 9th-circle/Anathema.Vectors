#if TEMPLATES_ENABLED
#if CONVERSIONS_ENABLED
using System;

namespace Anathema.Vectors.Core
{
    public partial class tvec2<T>
    {
#if NESTING_ENABLED
#if DOUBLES_ENABLED
        public static tvec2<tvec2<double>> fromDMat2(dmat2 input)
        {
            var output = new tvec2<tvec2<double>>();

            output.x.x = input.getValue(0, 0);
            output.x.y = input.getValue(0, 1);

            output.y.x = input.getValue(1, 0);
            output.y.y = input.getValue(1, 1);

            return output;
        }
        public static tvec2<tvec2<float>> fromFMat2(fmat2 input)
        {
            var output = new tvec2<tvec2<float>>();

            output.x.x = input.getValue(0, 0);
            output.x.y = input.getValue(0, 1);

            output.y.x = input.getValue(1, 0);
            output.y.y = input.getValue(1, 1);

            return output;
        }
#endif
#endif

#if FLOATS_ENABLED
        public fvec2 floatTVec2ToFVec2()
        {
            if (typeof(T) != typeof(float))
                throw new ArgumentException();

            float fx = (float)Convert.ChangeType(x, typeof(float));
            float fy = (float)Convert.ChangeType(y, typeof(float));

            return new fvec2(fx, fy);
        }
#endif
#if DOUBLES_ENABLED
        public dvec2 doubleTVec2ToDVec2()
        {
            if (typeof(T) != typeof(double))
                throw new ArgumentException();

            double fx = (double)Convert.ChangeType(x, typeof(double));
            double fy = (double)Convert.ChangeType(y, typeof(double));

            return new dvec2(fx, fy);
        }
#endif

    }
}
#endif
#endif