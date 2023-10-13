#if DOUBLES_ENABLED
#if THREED_ENABLED

using System;

namespace Anathema.Vectors.Core
{
    /// <summary>
    /// A double precision floating point, 4-component vector.
    /// </summary>
    public partial class dvec4 : dvec3
    {
        ///////////////////////////
        //        Members        //
        ///////////////////////////

        public double w { get; set; }

        ///////////////////////////
        //     Constructors      //
        ///////////////////////////

        public dvec4()
        {
        }
        public dvec4(dvec3 xyz, double w)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }
        public dvec4(double x, dvec3 yzw)
        {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }
        public dvec4(dvec2 xy, dvec2 zw)
        {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }
        public dvec4(double x, double y, dvec2 zw)
        {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }
        public dvec4(double x, dvec2 yz, double w)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }
        public dvec4(dvec2 xy, double z, double w)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }
        public dvec4(double x, double y, double z, double w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        public dvec4(dvec4 xyzw)
        {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }
        public dvec4(fvec4 xyzw)
        {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }

        public dvec4(double[] xyzw)
        {
            this[0] = xyzw[0];
            this[1] = xyzw[1];
            this[2] = xyzw[2];
            this[3] = xyzw[3];
        }
        ///////////////////////////
        //      Derivations      //
        ///////////////////////////

        public dvec3 scaledToDVec3()
        {
            return new dvec3(x / w, y / w, z / w);
        }

        public override double length
        {
            get
            {
                return Math.Sqrt((x * x) + (y * y) + (z * z) + (w * w));
            }
        }
        public new dvec4 normalised
        {
            get
            {
                return this / length;
            }
        }


        ///////////////////////////
        //       Operators       //
        ///////////////////////////


        public double dot(dvec4 b)
        {
            return dot(this, b);
        }
        public static double dot(dvec4 a, dvec4 b)
        {
            return (a.x * b.x) + (a.y * b.y) + (a.z * b.z) + (a.w * b.w);
        }



        public static bool operator !=(dvec4 a, dvec4 b)
        {
            return !(a == b);
        }
        public static bool operator ==(dvec4 a, dvec4 b)
        {
            return scalar.isClose(a.x, b.x) && scalar.isClose(a.y, b.y) && scalar.isClose(a.z, b.z) && scalar.isClose(a.w, b.w);
        }




        public static dvec4 operator *(dvec4 a, dvec4 b)
        {
            return new dvec4(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
        }
        public static dvec4 operator /(dvec4 a, dvec4 b)
        {
            return new dvec4(a.x / b.x, a.y / b.y, a.z / b.z, a.w / b.w);
        }
        public static dvec4 operator +(dvec4 a, dvec4 b)
        {
            return new dvec4(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
        }
        public static dvec4 operator -(dvec4 a, dvec4 b)
        {
            return new dvec4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
        }



#if CONVERSIONS_ENABLED

        public static dvec4 operator *(fvec4 a, dvec4 b)
        {
            return new dvec4(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
        }
        public static dvec4 operator /(fvec4 a, dvec4 b)
        {
            return new dvec4(a.x / b.x, a.y / b.y, a.z / b.z, a.w / b.w);
        }
        public static dvec4 operator +(fvec4 a, dvec4 b)
        {
            return new dvec4(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
        }
        public static dvec4 operator -(fvec4 a, dvec4 b)
        {
            return new dvec4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
        }





        public static dvec4 operator *(dvec4 a, fvec4 b)
        {
            return new dvec4(a.x * b.x, a.y * b.y, a.z * b.z, a.w * b.w);
        }
        public static dvec4 operator /(dvec4 a, fvec4 b)
        {
            return new dvec4(a.x / b.x, a.y / b.y, a.z / b.z, a.w / b.w);
        }
        public static dvec4 operator +(dvec4 a, fvec4 b)
        {
            return new dvec4(a.x + b.x, a.y + b.y, a.z + b.z, a.w + b.w);
        }
        public static dvec4 operator -(dvec4 a, fvec4 b)
        {
            return new dvec4(a.x - b.x, a.y - b.y, a.z - b.z, a.w - b.w);
        }



        public static dvec4 operator *(dvec2 a, dvec4 b)
        {
            return new dvec4(a.x * b.x, a.y * b.y, b.z, b.w);
        }
        public static dvec4 operator /(dvec2 a, dvec4 b)
        {
            return new dvec4(a.x / b.x, a.y / b.y, b.z, b.w);
        }
        public static dvec4 operator +(dvec2 a, dvec4 b)
        {
            return new dvec4(a.x + b.x, a.y + b.y, b.z, b.w);
        }
        public static dvec4 operator -(dvec2 a, dvec4 b)
        {
            return new dvec4(a.x - b.x, a.y - b.y, b.z, b.w);
        }



        public static dvec4 operator *(dvec4 a, dvec2 b)
        {
            return new dvec4(a.x * b.x, a.y * b.y, a.z, a.w);
        }
        public static dvec4 operator /(dvec4 a, dvec2 b)
        {
            return new dvec4(a.x / b.x, a.y / b.y, a.z, a.w);
        }
        public static dvec4 operator +(dvec4 a, dvec2 b)
        {
            return new dvec4(a.x + b.x, a.y + b.y, a.z, a.w);
        }
        public static dvec4 operator -(dvec4 a, dvec2 b)
        {
            return new dvec4(a.x - b.x, a.y - b.y, a.z, a.w);
        }



        public static dvec4 operator *(dvec3 a, dvec4 b)
        {
            return new dvec4(a.x * b.x, a.y * b.y, a.z * b.z, b.w);
        }
        public static dvec4 operator /(dvec3 a, dvec4 b)
        {
            return new dvec4(a.x / b.x, a.y / b.y, a.z / b.z, b.w);
        }
        public static dvec4 operator +(dvec3 a, dvec4 b)
        {
            return new dvec4(a.x + b.x, a.y + b.y, a.z + b.z, b.w);
        }
        public static dvec4 operator -(dvec3 a, dvec4 b)
        {
            return new dvec4(a.x - b.x, a.y - b.y, a.z - b.z, b.w);
        }



        public static dvec4 operator *(dvec4 a, dvec3 b)
        {
            return new dvec4(a.x * b.x, a.y * b.y, a.z * b.z, a.w);
        }
        public static dvec4 operator /(dvec4 a, dvec3 b)
        {
            return new dvec4(a.x / b.x, a.y / b.y, a.z / b.z, a.w);
        }
        public static dvec4 operator +(dvec4 a, dvec3 b)
        {
            return new dvec4(a.x + b.x, a.y + b.y, a.z + b.z, a.w);
        }
        public static dvec4 operator -(dvec4 a, dvec3 b)
        {
            return new dvec4(a.x - b.x, a.y - b.y, a.z - b.z, a.w);
        }
#endif





        public static dvec4 operator *(dvec4 a, double b)
        {
            return new dvec4(a.x * b, a.y * b, a.z * b, a.w * b);
        }
        public static dvec4 operator /(dvec4 a, double b)
        {
            return new dvec4(a.x / b, a.y / b, a.z / b, a.w / b);
        }
        public static dvec4 operator +(dvec4 a, double b)
        {
            return new dvec4(a.x + b, a.y + b, a.z + b, a.w + b);
        }
        public static dvec4 operator -(dvec4 a, double b)
        {
            return new dvec4(a.x - b, a.y - b, a.z - b, a.w - b);
        }


        public static dvec4 operator *(double b, dvec4 a)
        {
            return new dvec4(a.x * b, a.y * b, a.z * b, a.w * b);
        }
        public static dvec4 operator /(double b, dvec4 a)
        {
            return new dvec4(a.x / b, a.y / b, a.z / b, a.w / b);
        }
        public static dvec4 operator +(double b, dvec4 a)
        {
            return new dvec4(a.x + b, a.y + b, a.z + b, a.w + b);
        }
        public static dvec4 operator -(double b, dvec4 a)
        {
            return new dvec4(a.x - b, a.y - b, a.z - b, a.w + b);
        }
        public static dvec4 operator -(dvec4 a)
        {
            return new dvec4(-a.x, -a.y, -a.z, -a.w);
        }

        public static dvec4 operator *(dvec4 a, dmat4 b)
        {
            return new dvec4((a.x * b.getValue(0, 0)) + (a.y * b.getValue(0, 1)) + (a.z * b.getValue(0, 2)) + (a.w * b.getValue(0, 3)),
                                 (a.x * b.getValue(1, 0)) + (a.y * b.getValue(1, 1)) + (a.z * b.getValue(1, 2)) + (a.w * b.getValue(1, 3)),
                                 (a.x * b.getValue(2, 0)) + (a.y * b.getValue(2, 1)) + (a.z * b.getValue(2, 2)) + (a.w * b.getValue(2, 3)),
                                 (a.x * b.getValue(3, 0)) + (a.y * b.getValue(3, 1)) + (a.z * b.getValue(3, 2)) + (a.w * b.getValue(3, 3))
                                 );
        }
        public static dvec4 operator *(dmat4 b, dvec4 a)
        {
            return a * b.transposed;
        }

#if CONVERSIONS_ENABLED
        public static dvec4 operator *(dvec4 a, fmat4 b)
        {
            return new dvec4((a.x * b.getValue(0, 0)) + (a.y * b.getValue(0, 1)) + (a.z * b.getValue(0, 2)) + (a.w * b.getValue(0, 3)),
                                 (a.x * b.getValue(1, 0)) + (a.y * b.getValue(1, 1)) + (a.z * b.getValue(1, 2)) + (a.w * b.getValue(1, 3)),
                                 (a.x * b.getValue(2, 0)) + (a.y * b.getValue(2, 1)) + (a.z * b.getValue(2, 2)) + (a.w * b.getValue(2, 3)),
                                 (a.x * b.getValue(3, 0)) + (a.y * b.getValue(3, 1)) + (a.z * b.getValue(3, 2)) + (a.w * b.getValue(3, 3))
                                 );
        }
        public static dvec4 operator *(fmat4 b, dvec4 a)
        {
            return a * b.transposed;
        }
#endif

#if NESTING_ENABLED
        public static dvec4 operator *(dvec4 a, tvec4<tvec4<double>> b)
        {
            dmat4 matrix = dmat4.fromNestedVector(b);

            return a * matrix;
        }
        public static dvec4 operator *(tvec4<tvec4<double>> b, dvec4 a)
        {
            dmat4 matrix = dmat4.fromNestedVector(b);

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
                if (i == 3)
                    return w;
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
                if (i == 3)
                { w = value; return; }
                throw new IndexOutOfRangeException();
            }
        }


        public override double[] ToArray()
        {
            return new double[] { x, y, z, w };
        }


#if CONVERSIONS_ENABLED
#if TEMPLATES_ENABLED
        public tvec4<double> toTVec4()
        {
            return new tvec4<double>(x, y, z, w);
        }
#endif
#endif
        ///////////////////////////
        //     Interpolation     //
        ///////////////////////////
#if INTERPOLATION_ENABLED
        public static dvec4 linearInterpolate(dvec4 a, dvec4 b, double position)
        {
            return (a * (1 - position)) + (b * position);
        }
        public dvec4 linearInterpolateTo(dvec4 b, double position)
        {
            return linearInterpolate(this, b, position);
        }


        public static dvec4 quadraticBezierInterpolate(dvec4 a, dvec4 b, dvec4 c, double position)
        {
            return linearInterpolate(
                linearInterpolate(a, b, position),
                linearInterpolate(b, c, position),
                position);
        }
        public dvec4 quadraticBezierInterpolateTo(dvec4 b, dvec4 c, double position)
        {
            return quadraticBezierInterpolate(this, b, c, position);
        }


        //todo: validate this
        public static dvec4 cubicBezierInterpolate(dvec4 a, dvec4 b, dvec4 c, dvec4 d, double position)
        {
            return linearInterpolate(
                quadraticBezierInterpolate(a, b, c, position),
                quadraticBezierInterpolate(b, c, d, position),
                position);
        }
        public dvec4 cubicBezierInterpolateTo(dvec4 b, dvec4 c, dvec4 d, double position)
        {
            return cubicBezierInterpolate(this, b, c, d, position);
        }



        //todo: rational bezier interpolation (ie with weights)

#endif


    }
}
#endif
#endif