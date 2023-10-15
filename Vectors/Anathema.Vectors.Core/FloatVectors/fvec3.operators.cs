#if FLOATS_ENABLED
#if THREED_ENABLED
namespace Anathema.Vectors.Core
{
    public partial class fvec3
    {
        public float dot(fvec3 b)
        {
            return dot(this, b);
        }
        public static float dot(fvec3 a, fvec3 b)
        {
            return (a.x * b.x) + (a.y * b.y) + (a.z * b.z);
        }


        public fvec3 cross(fvec3 b)
        {
            return cross(this, b);
        }
        public static fvec3 cross(fvec3 a, fvec3 b)
        {
            return new fvec3((a.y * b.z) - (a.z * b.y),
                                    (a.z * b.x) - (a.x * b.z),
                                    (a.x * b.y) - (a.y * b.x));
        }

        public static bool operator !=(fvec3 a, fvec3 b)
        {
            return !(a == b);
        }
        public static bool operator ==(fvec3 a, fvec3 b)
        {
            if (!(a is null) && b is null)
                return false;
            if (a is null && !(b is null))
                return false;
            if (a is null && b is null)
                return true;
            return scalar.isClose(a.x, b.x) && scalar.isClose(a.y, b.y) && scalar.isClose(a.z, b.z);
        }

        public static fvec3 operator *(fvec3 a, fvec3 b)
        {
            return new fvec3(a.x * b.x, a.y * b.y, a.z * b.z);
        }
        public static fvec3 operator /(fvec3 a, fvec3 b)
        {
            return new fvec3(a.x / b.x, a.y / b.y, a.z / b.z);
        }
        public static fvec3 operator +(fvec3 a, fvec3 b)
        {
            return new fvec3(a.x + b.x, a.y + b.y, a.z + b.z);
        }
        public static fvec3 operator -(fvec3 a, fvec3 b)
        {
            return new fvec3(a.x - b.x, a.y - b.y, a.z - b.z);
        }


#if CONVERSIONS_ENABLED
        public static fvec3 operator *(fvec2 a, fvec3 b)
        {
            return new fvec3(a.x * b.x, a.y * b.y, b.z);
        }
        public static fvec3 operator /(fvec2 a, fvec3 b)
        {
            return new fvec3(a.x / b.x, a.y / b.y, b.z);
        }
        public static fvec3 operator +(fvec2 a, fvec3 b)
        {
            return new fvec3(a.x + b.x, a.y + b.y, b.z);
        }
        public static fvec3 operator -(fvec2 a, fvec3 b)
        {
            return new fvec3(a.x - b.x, a.y - b.y, b.z);
        }



        public static fvec3 operator *(fvec3 a, fvec2 b)
        {
            return new fvec3(a.x * b.x, a.y * b.y, a.z);
        }
        public static fvec3 operator /(fvec3 a, fvec2 b)
        {
            return new fvec3(a.x / b.x, a.y / b.y, a.z);
        }
        public static fvec3 operator +(fvec3 a, fvec2 b)
        {
            return new fvec3(a.x + b.x, a.y + b.y, a.z);
        }
        public static fvec3 operator -(fvec3 a, fvec2 b)
        {
            return new fvec3(a.x - b.x, a.y - b.y, a.z);
        }
#endif

        public static fvec3 operator *(fvec3 a, float b)
        {
            return new fvec3(a.x * b, a.y * b, a.z * b);
        }
        public static fvec3 operator /(fvec3 a, float b)
        {
            return new fvec3(a.x / b, a.y / b, a.z / b);
        }
        public static fvec3 operator +(fvec3 a, float b)
        {
            return new fvec3(a.x + b, a.y + b, a.z + b);
        }
        public static fvec3 operator -(fvec3 a, float b)
        {
            return new fvec3(a.x - b, a.y - b, a.z - b);
        }


        public static fvec3 operator *(float b, fvec3 a)
        {
            return new fvec3(a.x * b, a.y * b, a.z * b);
        }
        public static fvec3 operator /(float b, fvec3 a)
        {
            return new fvec3(a.x / b, a.y / b, a.z / b);
        }
        public static fvec3 operator +(float b, fvec3 a)
        {
            return new fvec3(a.x + b, a.y + b, a.z + b);
        }
        public static fvec3 operator -(float b, fvec3 a)
        {
            return new fvec3(a.x - b, a.y - b, a.z - b);
        }
        public static fvec3 operator -(fvec3 a)
        {
            return new fvec3(-a.x, -a.y, -a.z);
        }


        public static fvec3 operator *(fvec3 a, fmat3 b)
        {
            return new fvec3((a.x * b.getValue(0, 0)) + (a.y * b.getValue(0, 1)) + (a.z * b.getValue(0, 2)),
                                 (a.x * b.getValue(1, 0)) + (a.y * b.getValue(1, 1)) + (a.z * b.getValue(1, 2)),
                                 (a.x * b.getValue(2, 0)) + (a.y * b.getValue(2, 1)) + (a.z * b.getValue(2, 2)));
        }
        public static fvec3 operator *(fmat3 b, fvec3 a)
        {
            return a * b.transposed;
        }

        public static fvec3 operator *(fvec3 a, fmat4 b)
        {
            fvec4 result = new fvec4(a.x, a.y, a.z, 1.0f) * b;

            return result.scaledToFVec3();
        }
        public static fvec3 operator *(fmat4 b, fvec3 a)
        {
            return a * b.transposed;
        }

#if CONVERSIONS_ENABLED
#if DOUBLES_ENABLED
        public static dvec3 operator *(fvec3 a, dmat4 b)
        {
            dvec4 result = new dvec4(a.x, a.y, a.z, 1.0f) * b;

            return result.scaledToDVec3();
        }
        public static dvec3 operator *(dmat4 b, fvec3 a)
        {
            return a * b.transposed;
        }
#endif
#endif
#if NESTING_ENABLED
#if TEMPLATES_ENABLED
        public static fvec3 operator *(fvec3 a, tvec3<tvec3<float>> b)
        {
            fmat3 matrix = fmat3.fromNestedVector(b);

            return a * matrix;
        }
        public static fvec3 operator *(tvec3<tvec3<float>> b, fvec3 a)
        {
            fmat3 matrix = fmat3.fromNestedVector(b);

            return a * matrix.transposed;
        }
#endif
#endif

    }
}
#endif
#endif