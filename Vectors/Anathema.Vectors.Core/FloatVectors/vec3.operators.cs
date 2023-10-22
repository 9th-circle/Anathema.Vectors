#if FLOATS_ENABLED && THREED_ENABLED
namespace Anathema.Vectors.Core
{
    public partial class vec3
    {

        public override bool Equals(object o)
        {
            if (o is vec3)
                return ((vec3)o) == this;
            else
                return false;
        }
        public float dot(vec3 b)
        {
            return dot(this, b);
        }
        public static float dot(vec3 a, vec3 b)
        {
            return (a.x * b.x) + (a.y * b.y) + (a.z * b.z);
        }


        public vec3 cross(vec3 b)
        {
            return cross(this, b);
        }
        public static vec3 cross(vec3 a, vec3 b)
        {
            return new vec3((a.y * b.z) - (a.z * b.y),
                                    (a.z * b.x) - (a.x * b.z),
                                    (a.x * b.y) - (a.y * b.x));
        }

        public static bool operator !=(vec3 a, vec3 b)
        {
            return !(a == b);
        }
        public static bool operator ==(vec3 a, vec3 b)
        {
            if (a is null && b is null)
                return true;
            if ((a is null) != (b is null))
                return false;
            return scalar.isClose(a.x, b.x) && scalar.isClose(a.y, b.y) && scalar.isClose(a.z, b.z);
        }

        public static vec3 operator *(vec3 a, vec3 b)
        {
            return new vec3(a.x * b.x, a.y * b.y, a.z * b.z);
        }
        public static vec3 operator /(vec3 a, vec3 b)
        {
            return new vec3(a.x / b.x, a.y / b.y, a.z / b.z);
        }
        public static vec3 operator +(vec3 a, vec3 b)
        {
            return new vec3(a.x + b.x, a.y + b.y, a.z + b.z);
        }
        public static vec3 operator -(vec3 a, vec3 b)
        {
            return new vec3(a.x - b.x, a.y - b.y, a.z - b.z);
        }


#if CONVERSIONS_ENABLED
        public static vec3 operator *(vec2 a, vec3 b)
        {
            return new vec3(a.x * b.x, a.y * b.y, b.z);
        }
        public static vec3 operator /(vec2 a, vec3 b)
        {
            return new vec3(a.x / b.x, a.y / b.y, b.z);
        }
        public static vec3 operator +(vec2 a, vec3 b)
        {
            return new vec3(a.x + b.x, a.y + b.y, b.z);
        }
        public static vec3 operator -(vec2 a, vec3 b)
        {
            return new vec3(a.x - b.x, a.y - b.y, b.z);
        }



        public static vec3 operator *(vec3 a, vec2 b)
        {
            return new vec3(a.x * b.x, a.y * b.y, a.z);
        }
        public static vec3 operator /(vec3 a, vec2 b)
        {
            return new vec3(a.x / b.x, a.y / b.y, a.z);
        }
        public static vec3 operator +(vec3 a, vec2 b)
        {
            return new vec3(a.x + b.x, a.y + b.y, a.z);
        }
        public static vec3 operator -(vec3 a, vec2 b)
        {
            return new vec3(a.x - b.x, a.y - b.y, a.z);
        }
#endif

        public static vec3 operator *(vec3 a, float b)
        {
            return new vec3(a.x * b, a.y * b, a.z * b);
        }
        public static vec3 operator /(vec3 a, float b)
        {
            return new vec3(a.x / b, a.y / b, a.z / b);
        }
        public static vec3 operator +(vec3 a, float b)
        {
            return new vec3(a.x + b, a.y + b, a.z + b);
        }
        public static vec3 operator -(vec3 a, float b)
        {
            return new vec3(a.x - b, a.y - b, a.z - b);
        }


        public static vec3 operator *(float b, vec3 a)
        {
            return new vec3(a.x * b, a.y * b, a.z * b);
        }
        public static vec3 operator /(float b, vec3 a)
        {
            return new vec3(b / a.x, b / a.y, b / a.z);
        }
        public static vec3 operator +(float b, vec3 a)
        {
            return new vec3(a.x + b, a.y + b, a.z + b);
        }
        public static vec3 operator -(float b, vec3 a)
        {
            return new vec3(b - a.x, b - a.y, b - a.z);
        }
        public static vec3 operator -(vec3 a)
        {
            return new vec3(-a.x, -a.y, -a.z);
        }


        public static vec3 operator *(vec3 a, mat3 b)
        {
            return new vec3((a.x * b.getValue(0, 0)) + (a.y * b.getValue(0, 1)) + (a.z * b.getValue(0, 2)),
                                 (a.x * b.getValue(1, 0)) + (a.y * b.getValue(1, 1)) + (a.z * b.getValue(1, 2)),
                                 (a.x * b.getValue(2, 0)) + (a.y * b.getValue(2, 1)) + (a.z * b.getValue(2, 2)));
        }
        public static vec3 operator *(mat3 b, vec3 a)
        {
            return a * b.transposed;
        }

        public static vec3 operator *(vec3 a, mat4 b)
        {
            vec4 result = new vec4(a.x, a.y, a.z, 1.0f) * b;

            return result.scaledToFVec3();
        }
        public static vec3 operator *(mat4 b, vec3 a)
        {
            return a * b.transposed;
        }

#if CONVERSIONS_ENABLED && DOUBLES_ENABLED
        public static dvec3 operator *(vec3 a, dmat4 b)
        {
            dvec4 result = new dvec4(a.x, a.y, a.z, 1.0f) * b;

            return result.scaledToDVec3();
        }
        public static dvec3 operator *(dmat4 b, vec3 a)
        {
            return a * b.transposed;
        }
#endif
#if NESTING_ENABLED && TEMPLATES_ENABLED
        public static vec3 operator *(vec3 a, tvec3<tvec3<float>> b)
        {
            mat3 matrix = mat3.fromNestedVector(b);

            return a * matrix;
        }
        public static vec3 operator *(tvec3<tvec3<float>> b, vec3 a)
        {
            mat3 matrix = mat3.fromNestedVector(b);

            return a * matrix.transposed;
        }
#endif

    }
}
#endif