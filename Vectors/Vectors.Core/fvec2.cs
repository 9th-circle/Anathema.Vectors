using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Core
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


        ///////////////////////////
        //      Derivations      //
        ///////////////////////////


        public float angle
        {
            get
            {
                return (float)Math.Atan2(y, x);
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


        ///////////////////////////
        //       Operators       //
        ///////////////////////////


        public fvec2 dot(fvec2 b)
        {
            return dot(this, b);
        }
        public static fvec2 dot(fvec2 a, fvec2 b)
        {
            return a * b;
        }

        public fvec2 cross()
        {
            return cross(this);
        }
        public static fvec2 cross(fvec2 a)
        {
            return new fvec2(a.y, a.x);
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
            return new fvec2(a.x / b, a.y / b);
        }
        public static fvec2 operator +(float b, fvec2 a)
        {
            return new fvec2(a.x + b, a.y + b);
        }
        public static fvec2 operator -(float b, fvec2 a)
        {
            return new fvec2(a.x - b, a.y - b);
        }
        public static fvec2 operator -(fvec2 a)
        {
            return new fvec2(-a.x, -a.y);
        }


        public static fvec2 operator *(fvec2 a, fmat2 b)
        {
            return new fvec2(   (a.x * b.getValue(0, 0)) + (a.y * b.getValue(0, 1)), 
                                (a.x * b.getValue(1, 0)) + (a.y * b.getValue(1, 1)));
        }
        public static fvec2 operator *(fmat2 b, fvec2 a)
        {
            return a * b.transposed;
        }

    }
}
