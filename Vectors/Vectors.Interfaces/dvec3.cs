using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Core
{
    /// <summary>
    /// A double precision floating point, 3-component vector.
    /// </summary>
    public class dvec3 : dvec2
    {
        ///////////////////////////
        //        Members        //
        ///////////////////////////

        public double z { get; set; }


        ///////////////////////////
        //     Constructors      //
        ///////////////////////////

        public dvec3()
        {
        }
        public dvec3(dvec2 a, double z)
        {
            x = a.x;
            y = a.y;
            this.z = z;
        }
        public dvec3(double x, dvec2 yz)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }
        public dvec3(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public dvec3(dvec3 xyz)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }
        public dvec3(fvec3 xyz)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }



        ///////////////////////////
        //      Derivations      //
        ///////////////////////////


        public override double length
        {
            get
            {
                return Math.Sqrt((x * x) + (y * y) + (z * z));
            }
        }
        public new dvec3 normalised
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
            double f = length;
            x /= f;
            y /= f;
        }

        ///////////////////////////
        //        Swizzles       //
        ///////////////////////////

        // 3! = 3 * 2 * 1 = 6
        // There are 6 swizzles, in 3 groups of 2

        //Starting with X (2)

        public dvec3 xyz
        {
            get
            {
                return new dvec3(x, y, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }
        public dvec3 xzy
        {
            get
            {
                return new dvec3(x, z, y);
            }
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
            }
        }


        //Starting with Y (2)


        public dvec3 yxz
        {
            get
            {
                return new dvec3(y, x, z);
            }
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
            }
        }
        public dvec3 yzx
        {
            get
            {
                return new dvec3(y, z, x);
            }
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
            }
        }


        //Starting with Z (2)


        public dvec3 zxy
        {
            get
            {
                return new dvec3(z, x, y);
            }
            set
            {
                z = value.x;
                x = value.y;
                y = value.z;
            }
        }
        public dvec3 zyx
        {
            get
            {
                return new dvec3(z, y, x);
            }
            set
            {
                z = value.x;
                y = value.y;
                x = value.z;
            }
        }


        ///////////////////////////
        //       Operators       //
        ///////////////////////////


        public dvec3 dot(dvec3 b)
        {
            return dot(this, b);
        }
        public static dvec3 dot(dvec3 a, dvec3 b)
        {
            return a * b;
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
            return new dvec3(a.x / b, a.y / b, a.z / b);
        }
        public static dvec3 operator +(double b, dvec3 a)
        {
            return new dvec3(a.x + b, a.y + b, a.z + b);
        }
        public static dvec3 operator -(double b, dvec3 a)
        {
            return new dvec3(a.x - b, a.y - b, a.z - b);
        }
        public static dvec3 operator -(dvec3 a)
        {
            return new dvec3(-a.x, -a.y, -a.z);
        }


        public static dvec3 operator *(dvec3 a, fmat3 b)
        {
            return new dvec3((a.x * b.getValue(0, 0)) + (a.y * b.getValue(0, 1)) + (a.z * b.getValue(0, 2)),
                                 (a.x * b.getValue(1, 0)) + (a.y * b.getValue(1, 1)) + (a.z * b.getValue(1, 2)),
                                 (a.x * b.getValue(2, 0)) + (a.y * b.getValue(2, 1)) + (a.z * b.getValue(2, 2)));
        }
        public static dvec3 operator *(fmat3 b, dvec3 a)
        {
            return a * b.transposed;
        }

        public static dvec3 operator *(dvec3 a, fmat4 b)
        {
            return new dvec4(a.x, a.y, a.z, 1.0f) * b;
        }
        public static dvec3 operator *(fmat4 b, dvec3 a)
        {
            return a * b.transposed;
        }





    }
}
