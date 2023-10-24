#if FLOATS_ENABLED
#if THREED_ENABLED
namespace Anathema.Vectors.Core
{
    public partial class vec4
    {

        public override bool Equals(object o)
        {
            if (o is vec2)
                return ((vec2)o) == this;
            else
                return false;
        }
        public float dot(vec4 b)
        {
            return dot(this, b);
        }
        public static float dot(vec4 a, vec4 b)
        {
            return (a.x * b.x) + (a.y * b.y) + (a.z * b.z) + (a.w * b.w);
        }

        public static bool operator !=(vec4 a, vec4 b)
        {
            return !(a == b);
        }
        public static bool operator ==(vec4 a, vec4 b)
        {
            if (a is null && b is null)
                return true;
            if ((a is null) != (b is null))
                return false;
            return scalar.isClose(a.x, b.x) && scalar.isClose(a.y, b.y) && scalar.isClose(a.z, b.z) && scalar.isClose(a.w, b.w);
        }


        public static vec4 operator *(vec4 a, vec4 b)
        {
            return new vec4(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
        }
        public static vec4 operator /(vec4 a, vec4 b)
        {
            return new vec4(a.x / b.x, a.y / b.y, a.z / b.z, a.w / b.w);
        }
        public static vec4 operator +(vec4 a, vec4 b)
        {
            return new vec4(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
        }
        public static vec4 operator -(vec4 a, vec4 b)
        {
            return new vec4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
        }

#if CONVERSIONS_ENABLED

        public static vec4 operator *(vec2 a, vec4 b)
        {
            return new vec4(a.x * b.x, a.y * b.y, b.z, b.w);
        }
        public static vec4 operator /(vec2 a, vec4 b)
        {
            return new vec4(a.x / b.x, a.y / b.y, 1.0f / b.z, 1.0f / b.w);
        }
        public static vec4 operator +(vec2 a, vec4 b)
        {
            return new vec4(a.x + b.x, a.y + b.y, b.z, b.w);
        }
        public static vec4 operator -(vec2 a, vec4 b)
        {
            return new vec4(a.x - b.x, a.y - b.y, -b.z, -b.w);
        }



        public static vec4 operator *(vec4 a, vec2 b)
        {
            return new vec4(a.x * b.x, a.y * b.y, a.z, a.w);
        }
        public static vec4 operator /(vec4 a, vec2 b)
        {
            return new vec4(a.x / b.x, a.y / b.y, 1.0f/a.z, a.w);
        }
        public static vec4 operator +(vec4 a, vec2 b)
        {
            return new vec4(a.x + b.x, a.y + b.y, a.z, a.w);
        }
        public static vec4 operator -(vec4 a, vec2 b)
        {
            return new vec4(a.x - b.x, a.y - b.y, -a.z, -a.w);
        }



        public static vec4 operator *(vec3 a, vec4 b)
        {
            return new vec4(a.x * b.x, a.y * b.y, a.z * b.z, b.w);
        }
        public static vec4 operator /(vec3 a, vec4 b)
        {
            return new vec4(a.x / b.x, a.y / b.y, a.z / b.z, 1.0f/b.w);
        }
        public static vec4 operator +(vec3 a, vec4 b)
        {
            return new vec4(a.x + b.x, a.y + b.y, a.z + b.z, b.w);
        }
        public static vec4 operator -(vec3 a, vec4 b)
        {
            return new vec4(a.x - b.x, a.y - b.y, a.z - b.z, -b.w);
        }



        public static vec4 operator *(vec4 a, vec3 b)
        {
            return new vec4(a.x * b.x, a.y * b.y, a.z * b.z, a.w);
        }
        public static vec4 operator /(vec4 a, vec3 b)
        {
            return new vec4(a.x / b.x, a.y / b.y, a.z / b.z, a.w);
        }
        public static vec4 operator +(vec4 a, vec3 b)
        {
            return new vec4(a.x + b.x, a.y + b.y, a.z + b.z, a.w);
        }
        public static vec4 operator -(vec4 a, vec3 b)
        {
            return new vec4(a.x - b.x, a.y - b.y, a.z - b.z, a.w);
        }

#endif



        public static vec4 operator *(vec4 a, float b)
        {
            return new vec4(a.x * b, a.y * b, a.z * b, a.w * b);
        }
        public static vec4 operator /(vec4 a, float b)
        {
            return new vec4(a.x / b, a.y / b, a.z / b, a.w / b);
        }
        public static vec4 operator +(vec4 a, float b)
        {
            return new vec4(a.x + b, a.y + b, a.z + b, a.w + b);
        }
        public static vec4 operator -(vec4 a, float b)
        {
            return new vec4(a.x - b, a.y - b, a.z - b, a.w - b);
        }


        public static vec4 operator *(float b, vec4 a)
        {
            return new vec4(a.x * b, a.y * b, a.z * b, a.w * b);
        }
        public static vec4 operator /(float b, vec4 a)
        {
            return new vec4(b / a.x, b / a.y, b / a.z, b / a.w);
        }
        public static vec4 operator +(float b, vec4 a)
        {
            return new vec4(a.x + b, a.y + b, a.z + b, a.w + b);
        }
        public static vec4 operator -(float b, vec4 a)
        {
            return new vec4(b - a.x, b - a.y, b - a.z, b - a.w);
        }
        public static vec4 operator -(vec4 a)
        {
            return new vec4(-a.x, -a.y, -a.z, -a.w);
        }

        public static vec4 operator *(vec4 a, mat4 b)
        {
            return new vec4((a.x * b.getValue(0, 0)) + (a.y * b.getValue(0, 1)) + (a.z * b.getValue(0, 2)) + (a.w * b.getValue(0, 3)),
                                 (a.x * b.getValue(1, 0)) + (a.y * b.getValue(1, 1)) + (a.z * b.getValue(1, 2)) + (a.w * b.getValue(1, 3)),
                                 (a.x * b.getValue(2, 0)) + (a.y * b.getValue(2, 1)) + (a.z * b.getValue(2, 2)) + (a.w * b.getValue(2, 3)),
                                 (a.x * b.getValue(3, 0)) + (a.y * b.getValue(3, 1)) + (a.z * b.getValue(3, 2)) + (a.w * b.getValue(3, 3))
                                 );
        }
        public static vec4 operator *(mat4 b, vec4 a)
        {
            return a * b.transposed;
        }


#if CONVERSIONS_ENABLED
#if DOUBLES_ENABLED
        public static dvec4 operator *(vec4 a, dmat4 b)
        {
            return new dvec4((a.x * b.getValue(0, 0)) + (a.y * b.getValue(0, 1)) + (a.z * b.getValue(0, 2)) + (a.w * b.getValue(0, 3)),
                                 (a.x * b.getValue(1, 0)) + (a.y * b.getValue(1, 1)) + (a.z * b.getValue(1, 2)) + (a.w * b.getValue(1, 3)),
                                 (a.x * b.getValue(2, 0)) + (a.y * b.getValue(2, 1)) + (a.z * b.getValue(2, 2)) + (a.w * b.getValue(2, 3)),
                                 (a.x * b.getValue(3, 0)) + (a.y * b.getValue(3, 1)) + (a.z * b.getValue(3, 2)) + (a.w * b.getValue(3, 3))
                                 );
        }
        public static dvec4 operator *(dmat4 b, vec4 a)
        {
            return a * b.transposed;
        }
#endif
#endif
#if NESTING_ENABLED
#if TEMPLATES_ENABLED
        public static vec4 operator *(vec4 a, tvec4<tvec4<float>> b)
        {
            mat4 matrix = mat4.fromNestedVector(b);

            return a * matrix;
        }
        public static vec4 operator *(tvec4<tvec4<float>> b, vec4 a)
        {
            mat4 matrix = mat4.fromNestedVector(b);

            return a * matrix.transposed;
        }
#endif
#endif

    }
}
#endif
#endif