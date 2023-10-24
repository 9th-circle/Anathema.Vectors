
#if THREED_ENABLED
#if DOUBLES_ENABLED
namespace Anathema.Vectors.Core
{
    public partial class dvec4
    {


        public override bool Equals(object o)
        {
            if (o is dvec4)
                return ((dvec4)o) == this;
            else
                return false;
        }
        public double dot(dvec4 b)
        {
            return dot(this, b);
        }
        public static double dot(dvec4 a, dvec4 b)
        {
            return (a.x * b.x) + (a.y * b.y) + (a.z * b.z) + (a.w * b.w);
        }



        public static bool operator !=(dvec4 a, dvec4 b)
        {
            return !(a == b);
        }
        public static bool operator ==(dvec4 a, dvec4 b)
        {
            if (a is null && b is null)
                return true;
            if ((a is null) != (b is null))
                return false;
            return scalar.isClose(a.x, b.x) && scalar.isClose(a.y, b.y) && scalar.isClose(a.z, b.z) && scalar.isClose(a.w, b.w);
        }



        public static dvec4 operator *(dvec4 a, dvec4 b)
        {
            return new dvec4(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
        }
        public static dvec4 operator /(dvec4 a, dvec4 b)
        {
            return new dvec4(a.x / b.x, a.y / b.y, a.z / b.z, a.w / b.w);
        }
        public static dvec4 operator +(dvec4 a, dvec4 b)
        {
            return new dvec4(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
        }
        public static dvec4 operator -(dvec4 a, dvec4 b)
        {
            return new dvec4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
        }



#if CONVERSIONS_ENABLED
#if FLOATS_ENABLED
        public static dvec4 operator *(vec4 a, dvec4 b)
        {
            return new dvec4(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
        }
        public static dvec4 operator /(vec4 a, dvec4 b)
        {
            return new dvec4(a.x / b.x, a.y / b.y, a.z / b.z, a.w / b.w);
        }
        public static dvec4 operator +(vec4 a, dvec4 b)
        {
            return new dvec4(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
        }
        public static dvec4 operator -(vec4 a, dvec4 b)
        {
            return new dvec4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
        }
#endif
#endif




#if FLOATS_ENABLED
        public static dvec4 operator *(dvec4 a, vec4 b)
        {
            return new dvec4(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
        }
        public static dvec4 operator /(dvec4 a, vec4 b)
        {
            return new dvec4(a.x / b.x, a.y / b.y, a.z / b.z, a.w / b.w);
        }
        public static dvec4 operator +(dvec4 a, vec4 b)
        {
            return new dvec4(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
        }
        public static dvec4 operator -(dvec4 a, vec4 b)
        {
            return new dvec4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
        }
#endif


        public static dvec4 operator *(dvec2 a, dvec4 b)
        {
            return new dvec4(a.x * b.x, a.y * b.y, b.z, b.w);
        }
        public static dvec4 operator /(dvec2 a, dvec4 b)
        {
            return new dvec4(a.x / b.x, a.y / b.y, b.z, b.w);
        }
        public static dvec4 operator +(dvec2 a, dvec4 b)
        {
            return new dvec4(a.x + b.x, a.y + b.y, b.z, b.w);
        }
        public static dvec4 operator -(dvec2 a, dvec4 b)
        {
            return new dvec4(a.x - b.x, a.y - b.y, b.z, b.w);
        }



        public static dvec4 operator *(dvec4 a, dvec2 b)
        {
            return new dvec4(a.x * b.x, a.y * b.y, a.z, a.w);
        }
        public static dvec4 operator /(dvec4 a, dvec2 b)
        {
            return new dvec4(a.x / b.x, a.y / b.y, a.z, a.w);
        }
        public static dvec4 operator +(dvec4 a, dvec2 b)
        {
            return new dvec4(a.x + b.x, a.y + b.y, a.z, a.w);
        }
        public static dvec4 operator -(dvec4 a, dvec2 b)
        {
            return new dvec4(a.x - b.x, a.y - b.y, a.z, a.w);
        }



        public static dvec4 operator *(dvec3 a, dvec4 b)
        {
            return new dvec4(a.x * b.x, a.y * b.y, a.z * b.z, b.w);
        }
        public static dvec4 operator /(dvec3 a, dvec4 b)
        {
            return new dvec4(a.x / b.x, a.y / b.y, a.z / b.z, b.w);
        }
        public static dvec4 operator +(dvec3 a, dvec4 b)
        {
            return new dvec4(a.x + b.x, a.y + b.y, a.z + b.z, b.w);
        }
        public static dvec4 operator -(dvec3 a, dvec4 b)
        {
            return new dvec4(a.x - b.x, a.y - b.y, a.z - b.z, b.w);
        }



        public static dvec4 operator *(dvec4 a, dvec3 b)
        {
            return new dvec4(a.x * b.x, a.y * b.y, a.z * b.z, a.w);
        }
        public static dvec4 operator /(dvec4 a, dvec3 b)
        {
            return new dvec4(a.x / b.x, a.y / b.y, a.z / b.z, a.w);
        }
        public static dvec4 operator +(dvec4 a, dvec3 b)
        {
            return new dvec4(a.x + b.x, a.y + b.y, a.z + b.z, a.w);
        }
        public static dvec4 operator -(dvec4 a, dvec3 b)
        {
            return new dvec4(a.x - b.x, a.y - b.y, a.z - b.z, a.w);
        }





public static dvec4 operator *(dvec4 a, double b)
        {
            return new dvec4(a.x * b, a.y * b, a.z * b, a.w * b);
        }
        public static dvec4 operator /(dvec4 a, double b)
        {
            return new dvec4(a.x / b, a.y / b, a.z / b, a.w / b);
        }
        public static dvec4 operator +(dvec4 a, double b)
        {
            return new dvec4(a.x + b, a.y + b, a.z + b, a.w + b);
        }
        public static dvec4 operator -(dvec4 a, double b)
        {
            return new dvec4(a.x - b, a.y - b, a.z - b, a.w - b);
        }


        public static dvec4 operator *(double b, dvec4 a)
        {
            return new dvec4(a.x * b, a.y * b, a.z * b, a.w * b);
        }
        public static dvec4 operator /(double b, dvec4 a)
        {
            return new dvec4(b / a.x, b / a.y, b / a.z, b / a.w);
        }
        public static dvec4 operator +(double b, dvec4 a)
        {
            return new dvec4(a.x + b, a.y + b, a.z + b, a.w + b);
        }
        public static dvec4 operator -(double b, dvec4 a)
        {
            return new dvec4(b - a.x, b - a.y, b - a.z, b - a.w);
        }
        public static dvec4 operator -(dvec4 a)
        {
            return new dvec4(-a.x, -a.y, -a.z, -a.w);
        }

        public static dvec4 operator *(dvec4 a, dmat4 b)
        {
            return new dvec4((a.x * b.getValue(0, 0)) + (a.y * b.getValue(0, 1)) + (a.z * b.getValue(0, 2)) + (a.w * b.getValue(0, 3)),
                                 (a.x * b.getValue(1, 0)) + (a.y * b.getValue(1, 1)) + (a.z * b.getValue(1, 2)) + (a.w * b.getValue(1, 3)),
                                 (a.x * b.getValue(2, 0)) + (a.y * b.getValue(2, 1)) + (a.z * b.getValue(2, 2)) + (a.w * b.getValue(2, 3)),
                                 (a.x * b.getValue(3, 0)) + (a.y * b.getValue(3, 1)) + (a.z * b.getValue(3, 2)) + (a.w * b.getValue(3, 3))
                                 );
        }
        public static dvec4 operator *(dmat4 b, dvec4 a)
        {
            return a * b.transposed;
        }

#if CONVERSIONS_ENABLED
#if FLOATS_ENABLED
        public static dvec4 operator *(dvec4 a, mat4 b)
        {
            return new dvec4((a.x * b.getValue(0, 0)) + (a.y * b.getValue(0, 1)) + (a.z * b.getValue(0, 2)) + (a.w * b.getValue(0, 3)),
                                 (a.x * b.getValue(1, 0)) + (a.y * b.getValue(1, 1)) + (a.z * b.getValue(1, 2)) + (a.w * b.getValue(1, 3)),
                                 (a.x * b.getValue(2, 0)) + (a.y * b.getValue(2, 1)) + (a.z * b.getValue(2, 2)) + (a.w * b.getValue(2, 3)),
                                 (a.x * b.getValue(3, 0)) + (a.y * b.getValue(3, 1)) + (a.z * b.getValue(3, 2)) + (a.w * b.getValue(3, 3))
                                 );
        }
        public static dvec4 operator *(mat4 b, dvec4 a)
        {
            return a * b.transposed;
        }
#endif
#endif

#if NESTING_ENABLED
#if TEMPLATES_ENABLED
        public static dvec4 operator *(dvec4 a, tvec4<tvec4<double>> b)
        {
            dmat4 matrix = dmat4.fromNestedVector(b);

            return a * matrix;
        }
        public static dvec4 operator *(tvec4<tvec4<double>> b, dvec4 a)
        {
            dmat4 matrix = dmat4.fromNestedVector(b);

            return a * matrix.transposed;
        }
#endif
#endif
    }
}
#endif
#endif