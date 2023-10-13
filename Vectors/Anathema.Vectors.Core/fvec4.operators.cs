using System;
using System.Collections.Generic;
using System.Text;

namespace Anathema.Vectors.Core
{
    public partial class fvec4
    {

        public float dot(fvec4 b)
        {
            return dot(this, b);
        }
        public static float dot(fvec4 a, fvec4 b)
        {
            return (a.x * b.x) + (a.y * b.y) + (a.z * b.z) + (a.w * b.w);
        }

        public static bool operator !=(fvec4 a, fvec4 b)
        {
            return !(a == b);
        }
        public static bool operator ==(fvec4 a, fvec4 b)
        {
            return scalar.isClose(a.x, b.x) && scalar.isClose(a.y, b.y) && scalar.isClose(a.z, b.z) && scalar.isClose(a.w, b.w);
        }


        public static fvec4 operator *(fvec4 a, fvec4 b)
        {
            return new fvec4(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
        }
        public static fvec4 operator /(fvec4 a, fvec4 b)
        {
            return new fvec4(a.x / b.x, a.y / b.y, a.z / b.z, a.w / b.w);
        }
        public static fvec4 operator +(fvec4 a, fvec4 b)
        {
            return new fvec4(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
        }
        public static fvec4 operator -(fvec4 a, fvec4 b)
        {
            return new fvec4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
        }

#if CONVERSIONS_ENABLED

        public static fvec4 operator *(fvec2 a, fvec4 b)
        {
            return new fvec4(a.x * b.x, a.y * b.y, b.z, b.w);
        }
        public static fvec4 operator /(fvec2 a, fvec4 b)
        {
            return new fvec4(a.x / b.x, a.y / b.y, b.z, b.w);
        }
        public static fvec4 operator +(fvec2 a, fvec4 b)
        {
            return new fvec4(a.x + b.x, a.y + b.y, b.z, b.w);
        }
        public static fvec4 operator -(fvec2 a, fvec4 b)
        {
            return new fvec4(a.x - b.x, a.y - b.y, b.z, b.w);
        }



        public static fvec4 operator *(fvec4 a, fvec2 b)
        {
            return new fvec4(a.x * b.x, a.y * b.y, a.z, a.w);
        }
        public static fvec4 operator /(fvec4 a, fvec2 b)
        {
            return new fvec4(a.x / b.x, a.y / b.y, a.z, a.w);
        }
        public static fvec4 operator +(fvec4 a, fvec2 b)
        {
            return new fvec4(a.x + b.x, a.y + b.y, a.z, a.w);
        }
        public static fvec4 operator -(fvec4 a, fvec2 b)
        {
            return new fvec4(a.x - b.x, a.y - b.y, a.z, a.w);
        }



        public static fvec4 operator *(fvec3 a, fvec4 b)
        {
            return new fvec4(a.x * b.x, a.y * b.y, a.z * b.z, b.w);
        }
        public static fvec4 operator /(fvec3 a, fvec4 b)
        {
            return new fvec4(a.x / b.x, a.y / b.y, a.z / b.z, b.w);
        }
        public static fvec4 operator +(fvec3 a, fvec4 b)
        {
            return new fvec4(a.x + b.x, a.y + b.y, a.z + b.z, b.w);
        }
        public static fvec4 operator -(fvec3 a, fvec4 b)
        {
            return new fvec4(a.x - b.x, a.y - b.y, a.z - b.z, b.w);
        }



        public static fvec4 operator *(fvec4 a, fvec3 b)
        {
            return new fvec4(a.x * b.x, a.y * b.y, a.z * b.z, a.w);
        }
        public static fvec4 operator /(fvec4 a, fvec3 b)
        {
            return new fvec4(a.x / b.x, a.y / b.y, a.z / b.z, a.w);
        }
        public static fvec4 operator +(fvec4 a, fvec3 b)
        {
            return new fvec4(a.x + b.x, a.y + b.y, a.z + b.z, a.w);
        }
        public static fvec4 operator -(fvec4 a, fvec3 b)
        {
            return new fvec4(a.x - b.x, a.y - b.y, a.z - b.z, a.w);
        }

#endif



        public static fvec4 operator *(fvec4 a, float b)
        {
            return new fvec4(a.x * b, a.y * b, a.z * b, a.w * b);
        }
        public static fvec4 operator /(fvec4 a, float b)
        {
            return new fvec4(a.x / b, a.y / b, a.z / b, a.w / b);
        }
        public static fvec4 operator +(fvec4 a, float b)
        {
            return new fvec4(a.x + b, a.y + b, a.z + b, a.w + b);
        }
        public static fvec4 operator -(fvec4 a, float b)
        {
            return new fvec4(a.x - b, a.y - b, a.z - b, a.w - b);
        }


        public static fvec4 operator *(float b, fvec4 a)
        {
            return new fvec4(a.x * b, a.y * b, a.z * b, a.w * b);
        }
        public static fvec4 operator /(float b, fvec4 a)
        {
            return new fvec4(a.x / b, a.y / b, a.z / b, a.w / b);
        }
        public static fvec4 operator +(float b, fvec4 a)
        {
            return new fvec4(a.x + b, a.y + b, a.z + b, a.w + b);
        }
        public static fvec4 operator -(float b, fvec4 a)
        {
            return new fvec4(a.x - b, a.y - b, a.z - b, a.w + b);
        }
        public static fvec4 operator -(fvec4 a)
        {
            return new fvec4(-a.x, -a.y, -a.z, -a.w);
        }

        public static fvec4 operator *(fvec4 a, fmat4 b)
        {
            return new fvec4((a.x * b.getValue(0, 0)) + (a.y * b.getValue(0, 1)) + (a.z * b.getValue(0, 2)) + (a.w * b.getValue(0, 3)),
                                 (a.x * b.getValue(1, 0)) + (a.y * b.getValue(1, 1)) + (a.z * b.getValue(1, 2)) + (a.w * b.getValue(1, 3)),
                                 (a.x * b.getValue(2, 0)) + (a.y * b.getValue(2, 1)) + (a.z * b.getValue(2, 2)) + (a.w * b.getValue(2, 3)),
                                 (a.x * b.getValue(3, 0)) + (a.y * b.getValue(3, 1)) + (a.z * b.getValue(3, 2)) + (a.w * b.getValue(3, 3))
                                 );
        }
        public static fvec4 operator *(fmat4 b, fvec4 a)
        {
            return a * b.transposed;
        }


#if CONVERSIONS_ENABLED
        public static dvec4 operator *(fvec4 a, dmat4 b)
        {
            return new dvec4((a.x * b.getValue(0, 0)) + (a.y * b.getValue(0, 1)) + (a.z * b.getValue(0, 2)) + (a.w * b.getValue(0, 3)),
                                 (a.x * b.getValue(1, 0)) + (a.y * b.getValue(1, 1)) + (a.z * b.getValue(1, 2)) + (a.w * b.getValue(1, 3)),
                                 (a.x * b.getValue(2, 0)) + (a.y * b.getValue(2, 1)) + (a.z * b.getValue(2, 2)) + (a.w * b.getValue(2, 3)),
                                 (a.x * b.getValue(3, 0)) + (a.y * b.getValue(3, 1)) + (a.z * b.getValue(3, 2)) + (a.w * b.getValue(3, 3))
                                 );
        }
        public static dvec4 operator *(dmat4 b, fvec4 a)
        {
            return a * b.transposed;
        }
#endif
#if NESTING_ENABLED
        public static fvec4 operator *(fvec4 a, tvec4<tvec4<float>> b)
        {
            fmat4 matrix = fmat4.fromNestedVector(b);

            return a * matrix;
        }
        public static fvec4 operator *(tvec4<tvec4<float>> b, fvec4 a)
        {
            fmat4 matrix = fmat4.fromNestedVector(b);

            return a * matrix.transposed;
        }

#endif

    }
}
