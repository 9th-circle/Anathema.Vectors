#if CONVERSIONS_ENABLED
#if THREED_ENABLED
#if TEMPLATES_ENABLED
using System;

namespace Anathema.Vectors.Core
{
    public partial class tvec3<T> : tvec2<T>
    {
        public tvec3(tvec2<T> a, T z)
        {
            x = a.x;
            y = a.y;
            this.z = z;
        }
        public tvec3(T x, tvec2<T> yz)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }

#if DOUBLES_ENABLED
#if NESTING_ENABLED
        public static tvec3<tvec3<double>> fromDMat3(dmat3 input)
        {
            var output = new tvec3<tvec3<double>>();

            output.x = new tvec3<double>();
            output.y = new tvec3<double>();
            output.z = new tvec3<double>();

            output.x.x = input.getValue(0, 0);
            output.x.y = input.getValue(0, 1);
            output.x.z = input.getValue(0, 2);

            output.y.x = input.getValue(1, 0);
            output.y.y = input.getValue(1, 1);
            output.y.z = input.getValue(1, 2);

            output.z.x = input.getValue(2, 0);
            output.z.y = input.getValue(2, 1);
            output.z.z = input.getValue(2, 2);

            return output;
        }
#endif
#if FLOATS_ENABLED
        public static tvec3<tvec3<float>> fromFMat3(fmat3 input)
        {
            var output = new tvec3<tvec3<float>>();

            output.x = new tvec3<float>();
            output.y = new tvec3<float>();
            output.z = new tvec3<float>();

            output.x.x = input.getValue(0, 0);
            output.x.y = input.getValue(0, 1);
            output.x.z = input.getValue(0, 2);

            output.y.x = input.getValue(1, 0);
            output.y.y = input.getValue(1, 1);
            output.y.z = input.getValue(1, 2);

            output.z.x = input.getValue(2, 0);
            output.z.y = input.getValue(2, 1);
            output.z.z = input.getValue(2, 2);

            return output;
        }
#endif

#endif


#if FLOATS_ENABLED
        public fvec3 floatTVec3ToFVec3()
        {
            if (typeof(T) != typeof(float))
                throw new ArgumentException();

            float fx = (float)Convert.ChangeType(x, typeof(float));
            float fy = (float)Convert.ChangeType(y, typeof(float));
            float fz = (float)Convert.ChangeType(z, typeof(float));

            return new fvec3(fx, fy, fz);
        }
#endif
#if DOUBLES_ENABLED
        public dvec3 doubleTVec3ToDVec3()
        {
            if (typeof(T) != typeof(double))
                throw new ArgumentException();

            double fx = (double)Convert.ChangeType(x, typeof(double));
            double fy = (double)Convert.ChangeType(y, typeof(double));
            double fz = (double)Convert.ChangeType(z, typeof(double));

            return new dvec3(fx, fy, fz);
        }
#endif
    }
}
#endif
#endif
#endif