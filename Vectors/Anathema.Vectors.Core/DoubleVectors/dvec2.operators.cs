using System;
using System.Collections.Generic;
using System.Text;

#if DOUBLES_ENABLED
namespace Anathema.Vectors.Core
{
    public partial class dvec2
    {

        public double dot(dvec2 b)
        {
            return dot(this, b);
        }
        public static double dot(dvec2 a, dvec2 b)
        {
            return (a.x * b.x) + (a.y * b.y);
        }

        public dvec2 cross()
        {
            return cross(this);
        }
        public static dvec2 cross(dvec2 a)
        {
            return new dvec2(a.y, a.x);
        }


        public static bool operator !=(dvec2 a, dvec2 b)
        {
            return !(a == b);
        }
        public static bool operator ==(dvec2 a, dvec2 b)
        {
            if (a is null && b is null)
                return true;
            if ((a is null) != (b is null))
                return false;
            return scalar.isClose(a.x, b.x) && scalar.isClose(a.y, b.y);
        }


        public static dvec2 operator *(dvec2 a, dvec2 b)
        {
            return new dvec2(a.x * b.x, a.y * b.y);
        }
        public static dvec2 operator /(dvec2 a, dvec2 b)
        {
            return new dvec2(a.x / b.x, a.y / b.y);
        }
        public static dvec2 operator +(dvec2 a, dvec2 b)
        {
            return new dvec2(a.x + b.x, a.y + b.y);
        }
        public static dvec2 operator -(dvec2 a, dvec2 b)
        {
            return new dvec2(a.x - b.x, a.y - b.y);
        }


#if CONVERSIONS_ENABLED
#if FLOATS_ENABLED
        public static dvec2 operator *(fvec2 a, dvec2 b)
        {
            return new dvec2(a.x * b.x, a.y * b.y);
        }
        public static dvec2 operator /(fvec2 a, dvec2 b)
        {
            return new dvec2(a.x / b.x, a.y / b.y);
        }
        public static dvec2 operator +(fvec2 a, dvec2 b)
        {
            return new dvec2(a.x + b.x, a.y + b.y);
        }
        public static dvec2 operator -(fvec2 a, dvec2 b)
        {
            return new dvec2(a.x - b.x, a.y - b.y);
        }



        public static dvec2 operator *(dvec2 a, fvec2 b)
        {
            return new dvec2(a.x * b.x, a.y * b.y);
        }
        public static dvec2 operator /(dvec2 a, fvec2 b)
        {
            return new dvec2(a.x / b.x, a.y / b.y);
        }
        public static dvec2 operator +(dvec2 a, fvec2 b)
        {
            return new dvec2(a.x + b.x, a.y + b.y);
        }
        public static dvec2 operator -(dvec2 a, fvec2 b)
        {
            return new dvec2(a.x - b.x, a.y - b.y);
        }
#endif
#endif


        public static dvec2 operator *(dvec2 a, double b)
        {
            return new dvec2(a.x * b, a.y * b);
        }
        public static dvec2 operator /(dvec2 a, double b)
        {
            return new dvec2(a.x / b, a.y / b);
        }
        public static dvec2 operator +(dvec2 a, double b)
        {
            return new dvec2(a.x + b, a.y + b);
        }
        public static dvec2 operator -(dvec2 a, double b)
        {
            return new dvec2(a.x - b, a.y - b);
        }



        public static dvec2 operator *(double b, dvec2 a)
        {
            return new dvec2(a.x * b, a.y * b);
        }
        public static dvec2 operator /(double b, dvec2 a)
        {
            return new dvec2(b / a.x, b / a.y);
        }
        public static dvec2 operator +(double b, dvec2 a)
        {
            return new dvec2(a.x + b, a.y + b);
        }
        public static dvec2 operator -(double b, dvec2 a)
        {
            return new dvec2(b - a.x, b - a.y);
        }
        public static dvec2 operator -(dvec2 a)
        {
            return new dvec2(-a.x, -a.y);
        }


        public static dvec2 operator *(dvec2 a, dmat2 b)
        {
            return new dvec2((a.x * b.getValue(0, 0)) + (a.y * b.getValue(0, 1)),
                                (a.x * b.getValue(1, 0)) + (a.y * b.getValue(1, 1)));
        }
        public static dvec2 operator *(dmat2 b, dvec2 a)
        {
            return a * b.transposed;
        }
#if CONVERSIONS_ENABLED
#if FLOATS_ENABLED
        public static dvec2 operator *(dvec2 a, fmat2 b)
        {
            return new dvec2((a.x * b.getValue(0, 0)) + (a.y * b.getValue(0, 1)),
                                (a.x * b.getValue(1, 0)) + (a.y * b.getValue(1, 1)));
        }
        public static dvec2 operator *(fmat2 b, dvec2 a)
        {
            return a * b.transposed;
        }
#endif
#endif
#if NESTING_ENABLED
#if TEMPLATES_ENABLED
        public static dvec2 operator *(dvec2 a, tvec2<tvec2<double>> b)
        {
            dmat2 matrix = dmat2.fromNestedVector(b);

            return a * matrix;
        }
        public static dvec2 operator *(tvec2<tvec2<double>> b, dvec2 a)
        {
            dmat2 matrix = dmat2.fromNestedVector(b);

            return a * matrix.transposed;
        }
#endif
#endif
    }
}
#endif