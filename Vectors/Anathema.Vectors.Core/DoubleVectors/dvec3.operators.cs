﻿#if THREED_ENABLED && DOUBLES_ENABLED
namespace Anathema.Vectors.Core
{
    public partial class dvec3
    {

        public override bool Equals(object o)
        {
            if (o is dvec3)
                return ((dvec3)o) == this;
            else
                return false;
        }
        public double dot(dvec3 b)
        {
            return dot(this, b);
        }
        public static double dot(dvec3 a, dvec3 b)
        {
            return (a.x * b.x) + (a.y * b.y) + (a.z * b.z);
        }


        public dvec3 cross(dvec3 b)
        {
            return cross(this, b);
        }
        public static dvec3 cross(dvec3 a, dvec3 b)
        {
            return new dvec3((a.y * b.z) - (a.z * b.y),
                                    (a.z * b.x) - (a.x * b.z),
                                    (a.x * b.y) - (a.y * b.x));
        }



        public static bool operator !=(dvec3 a, dvec3 b)
        {
            return !(a == b);
        }
        public static bool operator ==(dvec3 a, dvec3 b)
        {
            if (a is null && b is null)
                return true;
            if ((a is null) != (b is null))
                return false;
            return scalar.isClose(a.x, b.x) && scalar.isClose(a.y, b.y) && scalar.isClose(a.z, b.z);
        }




        public static dvec3 operator *(dvec3 a, dvec3 b)
        {
            return new dvec3(a.x * b.x, a.y * b.y, a.z * b.z);
        }
        public static dvec3 operator /(dvec3 a, dvec3 b)
        {
            return new dvec3(a.x / b.x, a.y / b.y, a.z / b.z);
        }
        public static dvec3 operator +(dvec3 a, dvec3 b)
        {
            return new dvec3(a.x + b.x, a.y + b.y, a.z + b.z);
        }
        public static dvec3 operator -(dvec3 a, dvec3 b)
        {
            return new dvec3(a.x - b.x, a.y - b.y, a.z - b.z);
        }



#if CONVERSIONS_ENABLED
#if FLOATS_ENABLED
        public static dvec3 operator *(vec3 a, dvec3 b)
        {
            return new dvec3(a.x * b.x, a.y * b.y, a.z * b.z);
        }
        public static dvec3 operator /(vec3 a, dvec3 b)
        {
            return new dvec3(a.x / b.x, a.y / b.y, a.z / b.z);
        }
        public static dvec3 operator +(vec3 a, dvec3 b)
        {
            return new dvec3(a.x + b.x, a.y + b.y, a.z + b.z);
        }
        public static dvec3 operator -(vec3 a, dvec3 b)
        {
            return new dvec3(a.x - b.x, a.y - b.y, a.z - b.z);
        }



        public static dvec3 operator *(dvec3 a, vec3 b)
        {
            return new dvec3(a.x * b.x, a.y * b.y, a.z * b.z);
        }
        public static dvec3 operator /(dvec3 a, vec3 b)
        {
            return new dvec3(a.x / b.x, a.y / b.y, a.z / b.z);
        }
        public static dvec3 operator +(dvec3 a, vec3 b)
        {
            return new dvec3(a.x + b.x, a.y + b.y, a.z + b.z);
        }
        public static dvec3 operator -(dvec3 a, vec3 b)
        {
            return new dvec3(a.x - b.x, a.y - b.y, a.z - b.z);
        }
#endif






        public static dvec3 operator *(dvec2 a, dvec3 b)
        {
            return new dvec3(a.x * b.x, a.y * b.y, b.z);
        }
        public static dvec3 operator /(dvec2 a, dvec3 b)
        {
            return new dvec3(a.x / b.x, a.y / b.y, b.z);
        }
        public static dvec3 operator +(dvec2 a, dvec3 b)
        {
            return new dvec3(a.x + b.x, a.y + b.y, b.z);
        }
        public static dvec3 operator -(dvec2 a, dvec3 b)
        {
            return new dvec3(a.x - b.x, a.y - b.y, b.z);
        }



        public static dvec3 operator *(dvec3 a, dvec2 b)
        {
            return new dvec3(a.x * b.x, a.y * b.y, a.z);
        }
        public static dvec3 operator /(dvec3 a, dvec2 b)
        {
            return new dvec3(a.x / b.x, a.y / b.y, a.z);
        }
        public static dvec3 operator +(dvec3 a, dvec2 b)
        {
            return new dvec3(a.x + b.x, a.y + b.y, a.z);
        }
        public static dvec3 operator -(dvec3 a, dvec2 b)
        {
            return new dvec3(a.x - b.x, a.y - b.y, a.z);
        }
#endif


        public static dvec3 operator *(dvec3 a, double b)
        {
            return new dvec3(a.x * b, a.y * b, a.z * b);
        }
        public static dvec3 operator /(dvec3 a, double b)
        {
            return new dvec3(a.x / b, a.y / b, a.z / b);
        }
        public static dvec3 operator +(dvec3 a, double b)
        {
            return new dvec3(a.x + b, a.y + b, a.z + b);
        }
        public static dvec3 operator -(dvec3 a, double b)
        {
            return new dvec3(a.x - b, a.y - b, a.z - b);
        }


        public static dvec3 operator *(double b, dvec3 a)
        {
            return new dvec3(a.x * b, a.y * b, a.z * b);
        }
        public static dvec3 operator /(double b, dvec3 a)
        {
            return new dvec3(b / a.x, b / a.y, b / a.z);
        }
        public static dvec3 operator +(double b, dvec3 a)
        {
            return new dvec3(a.x + b, a.y + b, a.z + b);
        }
        public static dvec3 operator -(double b, dvec3 a)
        {
            return new dvec3(b - a.x, b - a.y, b - a.z);
        }
        public static dvec3 operator -(dvec3 a)
        {
            return new dvec3(-a.x, -a.y, -a.z);
        }


        public static dvec3 operator *(dvec3 a, dmat3 b)
        {
            return new dvec3((a.x * b.getValue(0, 0)) + (a.y * b.getValue(0, 1)) + (a.z * b.getValue(0, 2)),
                                 (a.x * b.getValue(1, 0)) + (a.y * b.getValue(1, 1)) + (a.z * b.getValue(1, 2)),
                                 (a.x * b.getValue(2, 0)) + (a.y * b.getValue(2, 1)) + (a.z * b.getValue(2, 2)));
        }
        public static dvec3 operator *(dmat3 b, dvec3 a)
        {
            return a * b.transposed;
        }

        public static dvec3 operator *(dvec3 a, dmat4 b)
        {
            dvec4 result = new dvec4(a.x, a.y, a.z, 1.0f) * b;

            return result.scaledToDVec3();
        }
        public static dvec3 operator *(dmat4 b, dvec3 a)
        {
            return a * b.transposed;
        }

#if CONVERSIONS_ENABLED && FLOATS_ENABLED
        public static dvec3 operator *(dvec3 a, mat4 b)
        {
            dvec4 result = new dvec4(a.x, a.y, a.z, 1.0f) * b;

            return result.scaledToDVec3();
        }
        public static dvec3 operator *(mat4 b, dvec3 a)
        {
            return a * b.transposed;
        }
#endif
#if NESTING_ENABLED && TEMPLATES_ENABLED
        public static dvec3 operator *(dvec3 a, tvec3<tvec3<double>> b)
        {
            dmat3 matrix = dmat3.fromNestedVector(b);

            return a * matrix;
        }
        public static dvec3 operator *(tvec3<tvec3<double>> b, dvec3 a)
        {
            dmat3 matrix = dmat3.fromNestedVector(b);

            return a * matrix.transposed;
        }
#endif


    }
}
#endif