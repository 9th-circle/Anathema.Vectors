#if FLOATS_ENABLED
using System;

namespace Anathema.Vectors.Core
{
    /// <summary>
    /// A single-precision floating point, 2-component vector.
    /// </summary>
    public class fvec2
    {
        ///////////////////////////
        //        Members        //
        ///////////////////////////

        public float x { get; set; }
        public float y { get; set; }


        ///////////////////////////
        //     Constructors      //
        ///////////////////////////

        public fvec2()
        {
        }

        public fvec2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public fvec2(fvec2 xy)
        {
            x = xy.x;
            y = xy.y;
        }
#if CONVERSIONS_ENABLED
        public fvec2(dvec2 xy)
        {
            x = (float)xy.x;
            y = (float)xy.y;
        }
#endif

        ///////////////////////////
        //      Conversions      //
        ///////////////////////////


        public static fvec2 fromAngleRadians(float angle)
        {
            return new fvec2((float)Math.Cos(angle - (Math.PI / 2)), (float)Math.Sin(angle - (Math.PI / 2)));
        }
        public static fvec2 fromAngleRadiansAndLength(float angle, float length)
        {
            return fromAngleRadians(angle) * length;
        }
        public static fvec2 fromAngleDegrees(float angle)
        {
            return fromAngleRadians(angle * (float)(Math.PI / 180.0f));
        }
        public static fvec2 fromAngleDegreesAndLength(float angle, float length)
        {
            return fromAngleRadiansAndLength(angle * (float)(Math.PI / 180.0f), length);
        }



        ///////////////////////////
        //      Derivations      //
        ///////////////////////////


        public float angleRadians
        {
            get
            {
                return (float)(Math.Atan2(y, x) + (Math.PI/2));
            }
        }
        public float angleDegrees
        {
            get
            {
                return angleRadians * (180.0f / (float)Math.PI);
            }
        }

        public virtual float length
        {
            get
            {
                return (float)Math.Sqrt((x * x) + (y * y));
            }
        }
        public fvec2 normalised
        {
            get
            {
                return this / length;
            }
        }


        ///////////////////////////
        //       Mutators        //
        ///////////////////////////

        public virtual void normalise()
        {
            float f = length;
            x /= f;
            y /= f;
        }

        ///////////////////////////
        //        Swizzles       //
        ///////////////////////////
#if SWIZZLES_ENABLED
        public fvec2 xy
        {
            get
            {
                return new fvec2(x, y);
            }
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        public fvec2 yx
        {
            get
            {
                return new fvec2(y, x);
            }
            set
            {
                y = value.x;
                x = value.y;
            }
        }
#endif

#if COLOURS_ENABLED
        public float r
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public float g
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public fvec2 rg
        {
            get
            {
                return new fvec2(x, y);
            }
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        public fvec2 gr
        {
            get
            {
                return new fvec2(y, x);
            }
            set
            {
                y = value.x;
                x = value.y;
            }
        }
#endif


        ///////////////////////////
        //       Operators       //
        ///////////////////////////


        public float dot(fvec2 b)
        {
            return dot(this, b);
        }
        public static float dot(fvec2 a, fvec2 b)
        {
            return (a.x * b.x) + (a.y * b.y);
        }

        public fvec2 cross()
        {
            return cross(this);
        }
        public static fvec2 cross(fvec2 a)
        {
            return new fvec2(a.y, a.x);
        }


        public static bool operator !=(fvec2 a, fvec2 b)
        {
            return !(a == b);
        }
        public static bool operator ==(fvec2 a, fvec2 b)
        {
            return scalar.isClose(a.x, b.x) && scalar.isClose(a.y, b.y);
        }

        public static fvec2 operator *(fvec2 a, fvec2 b)
        {
            return new fvec2(a.x * b.x, a.y * b.y);
        }
        public static fvec2 operator /(fvec2 a, fvec2 b)
        {
            return new fvec2(a.x / b.x, a.y / b.y);
        }
        public static fvec2 operator +(fvec2 a, fvec2 b)
        {
            return new fvec2(a.x + b.x, a.y + b.y);
        }
        public static fvec2 operator -(fvec2 a, fvec2 b)
        {
            return new fvec2(a.x - b.x, a.y - b.y);
        }



        public static fvec2 operator *(fvec2 a, float b)
        {
            return new fvec2(a.x * b, a.y * b);
        }
        public static fvec2 operator /(fvec2 a, float b)
        {
            return new fvec2(a.x / b, a.y / b);
        }
        public static fvec2 operator +(fvec2 a, float b)
        {
            return new fvec2(a.x + b, a.y + b);
        }
        public static fvec2 operator -(fvec2 a, float b)
        {
            return new fvec2(a.x - b, a.y - b);
        }



        public static fvec2 operator *(float b, fvec2 a)
        {
            return new fvec2(a.x * b, a.y * b);
        }
        public static fvec2 operator /(float b, fvec2 a)
        {
            return new fvec2(b / a.x, b / a.y);
        }
        public static fvec2 operator +(float b, fvec2 a)
        {
            return new fvec2(a.x + b, a.y + b);
        }
        public static fvec2 operator -(float b, fvec2 a)
        {
            return new fvec2(b - a.x, b - a.y);
        }
        public static fvec2 operator -(fvec2 a)
        {
            return new fvec2(-a.x, -a.y);
        }


        public static fvec2 operator *(fvec2 a, fmat2 b)
        {
            return new fvec2((a.x * b.getValue(0, 0)) + (a.y * b.getValue(0, 1)),
                                (a.x * b.getValue(1, 0)) + (a.y * b.getValue(1, 1)));
        }
        public static fvec2 operator *(fmat2 b, fvec2 a)
        {
            return a * b.transposed;
        }
        public static dvec2 operator *(fvec2 a, dmat2 b)
        {
            return new dvec2((a.x * b.getValue(0, 0)) + (a.y * b.getValue(0, 1)),
                                (a.x * b.getValue(1, 0)) + (a.y * b.getValue(1, 1)));
        }
#if CONVERSIONS_ENABLED
        public static dvec2 operator *(dmat2 b, fvec2 a)
        {
            return a * b.transposed;
        }
#endif

#if NESTING_ENABLED
        public static fvec2 operator *(fvec2 a, tvec2<tvec2<float>> b)
        {
            fmat2 matrix = fmat2.fromNestedVector(b);

            return a * matrix;
        }
        public static fvec2 operator *(tvec2<tvec2<float>> b, fvec2 a)
        {
            fmat2 matrix = fmat2.fromNestedVector(b);

            return a * matrix.transposed;
        }

#endif
        public float this[int i]
        {
            get
            {
                if (i == 0)
                    return x;
                if (i == 1)
                    return y;
                throw new IndexOutOfRangeException();
            }
            set
            {
                if (i == 0)
                { x = value; return; }
                if (i == 1)
                { y = value; return; }
                throw new IndexOutOfRangeException();
            }
        }
    }
}
#endif