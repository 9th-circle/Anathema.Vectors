#if CONVERSIONS_ENABLED
#if TEMPLATES_ENABLED
#if THREED_ENABLED
using System;
using System.Collections.Generic;
using System.Text;

namespace Anathema.Vectors.Core
{
    public partial class tvec4<T> : tvec3<T>
    {
        public tvec4(tvec3<T> xyz, T w)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }
        public tvec4(T x, tvec3<T> yzw)
        {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }
        public tvec4(tvec2<T> xy, tvec2<T> zw)
        {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }
        public tvec4(T x, T y, tvec2<T> zw)
        {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }
        public tvec4(T x, tvec2<T> yz, T w)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }
        public tvec4(tvec2<T> xy, T z, T w)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }

#if NESTING_ENABLED
#if DOUBLES_ENABLED
        public static tvec4<tvec4<double>> fromDMat4(dmat4 input)
        {
            var output = new tvec4<tvec4<double>>();

            output.x.x = input.getValue(0, 0);
            output.x.y = input.getValue(0, 1);
            output.x.z = input.getValue(0, 2);
            output.x.w = input.getValue(0, 3);

            output.y.x = input.getValue(1, 0);
            output.y.y = input.getValue(1, 1);
            output.y.z = input.getValue(1, 2);
            output.y.w = input.getValue(1, 3);

            output.z.x = input.getValue(2, 0);
            output.z.y = input.getValue(2, 1);
            output.z.z = input.getValue(2, 2);
            output.z.w = input.getValue(2, 3);

            output.w.x = input.getValue(3, 0);
            output.w.y = input.getValue(3, 1);
            output.w.z = input.getValue(3, 2);
            output.w.w = input.getValue(3, 3);

            return output;
        }
#endif
#if FLOATS_ENABLED
        public static tvec4<tvec4<float>> fromFMat4(mat4 input)
        {
            var output = new tvec4<tvec4<float>>();

            output.x.x = input.getValue(0, 0);
            output.x.y = input.getValue(0, 1);
            output.x.z = input.getValue(0, 2);
            output.x.w = input.getValue(0, 3);

            output.y.x = input.getValue(1, 0);
            output.y.y = input.getValue(1, 1);
            output.y.z = input.getValue(1, 2);
            output.y.w = input.getValue(1, 3);

            output.z.x = input.getValue(2, 0);
            output.z.y = input.getValue(2, 1);
            output.z.z = input.getValue(2, 2);
            output.z.w = input.getValue(2, 3);

            output.w.x = input.getValue(3, 0);
            output.w.y = input.getValue(3, 1);
            output.w.z = input.getValue(3, 2);
            output.w.w = input.getValue(3, 3);

            return output;
        }
#endif
#endif


#if FLOATS_ENABLED
        public vec4 floatTVec4ToFVec4()
        {
            if (typeof(T) != typeof(float))
                throw new ArgumentException();

            float fx = (float)Convert.ChangeType(x, typeof(float));
            float fy = (float)Convert.ChangeType(y, typeof(float));
            float fz = (float)Convert.ChangeType(z, typeof(float));
            float fw = (float)Convert.ChangeType(w, typeof(float));

            return new vec4(fx, fy, fz, fw);
        }
#endif
#if DOUBLES_ENABLED
        public dvec4 doubleTVec4ToDVec4()
        {
            if (typeof(T) != typeof(double))
                throw new ArgumentException();

            double fx = (double)Convert.ChangeType(x, typeof(double));
            double fy = (double)Convert.ChangeType(y, typeof(double));
            double fz = (double)Convert.ChangeType(z, typeof(double));
            double fw = (double)Convert.ChangeType(w, typeof(double));

            return new dvec4(fx, fy, fz, fw);
        }
#endif
    }
}

#endif
#endif
#endif