#if FLOATS_ENABLED
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema.Vectors.Core
{
    /// <summary>
    /// A single-precision floating point, 3-component vector.
    /// </summary>
    public class fvec3 : fvec2
    {
        ///////////////////////////
        //        Members        //
        ///////////////////////////

        public float z { get; set; }


        ///////////////////////////
        //     Constructors      //
        ///////////////////////////

        public fvec3()
        {
        }
        public fvec3(fvec2 a, float z)
        {
            x = a.x;
            y = a.y;
            this.z = z;
        }
        public fvec3(float x, fvec2 yz)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }
        public fvec3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public fvec3(fvec3 xyz)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }
        public fvec3(dvec3 xyz)
        {
            x = (float)xyz.x;
            y = (float)xyz.y;
            z = (float)xyz.z;
        }



        ///////////////////////////
        //      Derivations      //
        ///////////////////////////


        public override float length
        {
            get
            {
                return (float)Math.Sqrt((x * x) + (y * y) + (z * z));
            }
        }
        public new fvec3 normalised
        {
            get
            {
                return this / length;
            }
        }


        ///////////////////////////
        //       Mutators        //
        ///////////////////////////

        public override void normalise()
        {
            float f = length;
            x /= f;
            y /= f;
        }

        ///////////////////////////
        //        Swizzles       //
        ///////////////////////////

        // 3! = 3 * 2 * 1 = 6
        // There are 6 swizzles, in 3 groups of 2

        //Starting with X (2)

#if SWIZZLES_ENABLED
        public fvec3 xyz
        {
            get
            {
                return new fvec3(x, y, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }
        public fvec3 xzy
        {
            get
            {
                return new fvec3(x, z, y);
            }
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
            }
        }


        //Starting with Y (2)


        public fvec3 yxz
        {
            get
            {
                return new fvec3(y, x, z);
            }
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
            }
        }
        public fvec3 yzx
        {
            get
            {
                return new fvec3(y, z, x);
            }
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
            }
        }


        //Starting with Z (2)


        public fvec3 zxy
        {
            get
            {
                return new fvec3(z, x, y);
            }
            set
            {
                z = value.x;
                x = value.y;
                y = value.z;
            }
        }
        public fvec3 zyx
        {
            get
            {
                return new fvec3(z, y, x);
            }
            set
            {
                z = value.x;
                y = value.y;
                x = value.z;
            }
        }
#endif


        ///////////////////////////
        //       Operators       //
        ///////////////////////////


        public fvec3 dot(fvec3 b)
        {
            return dot(this, b);
        }
        public static fvec3 dot(fvec3 a, fvec3 b)
        {
            return a * b;
        }


        public fvec3 cross(fvec3 b)
        {
            return cross(this, b);
        }
        public static fvec3 cross(fvec3 a, fvec3 b)
        {
            return new fvec3(       (a.y * b.z) - (a.z * b.y), 
                                    (a.z * b.x) - (a.x * b.z),
                                    (a.x * b.y) - (a.y * b.x));
        }

        public static bool operator !=(fvec3 a, fvec3 b)
        {
            return !(a == b);
        }
        public static bool operator ==(fvec3 a, fvec3 b)
        {
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
            return new fvec3(    (a.x * b.getValue(0, 0)) + (a.y * b.getValue(0, 1)) + (a.z * b.getValue(0, 2)),
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

        public static dvec3 operator *(fvec3 a, dmat4 b)
        {
            dvec4 result = new dvec4(a.x, a.y, a.z, 1.0f) * b;

            return result.scaledToDVec3();
        }
        public static dvec3 operator *(dmat4 b, fvec3 a)
        {
            return a * b.transposed;
        }

#if NESTING_ENABLED
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

        public new float this[int i]
        {
            get
            {
                if (i == 0)
                    return x;
                if (i == 1)
                    return y;
                if (i == 2)
                    return z;
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (i == 0)
                { x = value; return; }
                if (i == 1)
                { y = value; return; }
                if (i == 2)
                { z = value; return; }
                throw new IndexOutOfRangeException();
            }
        }


    }
}
#endif