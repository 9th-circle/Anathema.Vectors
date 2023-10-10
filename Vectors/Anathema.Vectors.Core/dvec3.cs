#if DOUBLES_ENABLED
#if THREED_ENABLED
using System;

namespace Anathema.Vectors.Core
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

#if SWIZZLES_ENABLED

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
#endif

#if COLOURS_ENABLED
        public double b
        {
            get
            {
                return z;
            }
            set
            {
                z = value;
            }
        }
        public dvec3 rgb
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
        public dvec3 rbg
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
        public dvec3 grb
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
        public dvec3 gbr
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
        public dvec3 bgr
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
        public dvec3 brg
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



#endif
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



        public static bool operator !=(dvec3 a, dvec3 b)
        {
            return !(a == b);
        }
        public static bool operator ==(dvec3 a, dvec3 b)
        {
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
        public static dvec3 operator *(fvec3 a, dvec3 b)
        {
            return new dvec3(a.x * b.x, a.y * b.y, a.z * b.z);
        }
        public static dvec3 operator /(fvec3 a, dvec3 b)
        {
            return new dvec3(a.x / b.x, a.y / b.y, a.z / b.z);
        }
        public static dvec3 operator +(fvec3 a, dvec3 b)
        {
            return new dvec3(a.x + b.x, a.y + b.y, a.z + b.z);
        }
        public static dvec3 operator -(fvec3 a, dvec3 b)
        {
            return new dvec3(a.x - b.x, a.y - b.y, a.z - b.z);
        }



        public static dvec3 operator *(dvec3 a, fvec3 b)
        {
            return new dvec3(a.x * b.x, a.y * b.y, a.z * b.z);
        }
        public static dvec3 operator /(dvec3 a, fvec3 b)
        {
            return new dvec3(a.x / b.x, a.y / b.y, a.z / b.z);
        }
        public static dvec3 operator +(dvec3 a, fvec3 b)
        {
            return new dvec3(a.x + b.x, a.y + b.y, a.z + b.z);
        }
        public static dvec3 operator -(dvec3 a, fvec3 b)
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


        public static dvec3 operator *(dvec3 a, fmat4 b)
        {
            dvec4 result = new dvec4(a.x, a.y, a.z, 1.0f) * b;

            return result.scaledToDVec3();
        }
        public static dvec3 operator *(fmat4 b, dvec3 a)
        {
            return a * b.transposed;
        }

#if NESTING_ENABLED
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


        public new double this[int i]
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

        public override double[] ToArray()
        {
            return new double[] { x, y, z };
        }


        ///////////////////////////
        //     Interpolation     //
        ///////////////////////////
#if INTERPOLATION_ENABLED
        public static dvec3 linearInterpolate(dvec3 a, dvec3 b, double position)
        {
            return (a * (1 - position)) + (b * position);
        }
        public dvec3 linearInterpolateTo(dvec3 b, double position)
        {
            return linearInterpolate(this, b, position);
        }
        public static dvec3 quadraticBezierInterpolate(dvec3 a, dvec3 b, dvec3 c, double position)
        {
            return linearInterpolate(
                linearInterpolate(a, b, position),
                linearInterpolate(b, c, position),
                position);
        }
        public dvec3 quadraticBezierInterpolateTo(dvec3 b, dvec3 c, double position)
        {
            return quadraticBezierInterpolate(this, b, c, position);
        }
        //todo: cubic interpolation
        //todo: rational bezier interpolation (ie with weights)

#endif
    }
}
#endif
#endif