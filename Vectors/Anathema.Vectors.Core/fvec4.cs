#if FLOATS_ENABLED
#if THREED_ENABLED
using System;

namespace Anathema.Vectors.Core
{
    /// <summary>
    /// A single-precision floating point, 4-component vector.
    /// </summary>
    public partial class fvec4 : fvec3
    {
        ///////////////////////////
        //        Members        //
        ///////////////////////////

        public float w { get; set; }

        ///////////////////////////
        //     Constructors      //
        ///////////////////////////

        public fvec4()
        {
        }
        public fvec4(fvec3 xyz, float w)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
            this.w = w;
        }
#if CONVERSIONS_ENABLED
        public fvec4(float x, fvec3 yzw)
        {
            this.x = x;
            y = yzw.x;
            z = yzw.y;
            w = yzw.z;
        }
        public fvec4(fvec2 xy, fvec2 zw)
        {
            x = xy.x;
            y = xy.y;
            z = zw.x;
            w = zw.y;
        }
        public fvec4(float x, float y, fvec2 zw)
        {
            this.x = x;
            this.y = y;
            z = zw.x;
            w = zw.y;
        }
        public fvec4(float x, fvec2 yz, float w)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
            this.w = w;
        }
        public fvec4(fvec2 xy, float z, float w)
        {
            x = xy.x;
            y = xy.y;
            this.z = z;
            this.w = w;
        }
        public fvec4(dvec4 xyzw)
        {
            x = (float)xyzw.x;
            y = (float)xyzw.y;
            z = (float)xyzw.z;
            w = (float)xyzw.w;
        }
#endif
        public fvec4(fvec4 xyzw)
        {
            x = xyzw.x;
            y = xyzw.y;
            z = xyzw.z;
            w = xyzw.w;
        }
        public fvec4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public fvec4(float[] xyzw)
        {
            this[0] = xyzw[0];
            this[1] = xyzw[1];
            this[2] = xyzw[2];
            this[3] = xyzw[3];
        }
        ///////////////////////////
        //      Derivations      //
        ///////////////////////////

        public fvec3 scaledToFVec3()
        {
            return new fvec3(x / w, y / w, z / w);
        }

        public override float length
        {
            get
            {
                return (float)Math.Sqrt((x * x) + (y * y) + (z * z) + (w * w));
            }
        }
        public new fvec4 normalised
        {
            get
            {
                return this / length;
            }
        }

        ///////////////////////////
        //       Operators       //
        ///////////////////////////


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
            return new fvec4(    (a.x * b.getValue(0, 0)) + (a.y * b.getValue(0, 1)) + (a.z * b.getValue(0, 2)) + (a.w * b.getValue(0, 3)),
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


        public override float[] ToArray()
        {
            return new float[] { x, y, z, w};
        }

#if CONVERSIONS_ENABLED
#if TEMPLATES_ENABLED
        public tvec4<float> toTVec4()
        {
            return new tvec4<float>(x, y, z, w);
        }
#endif
#endif
        ///////////////////////////
        //     Interpolation     //
        ///////////////////////////
#if INTERPOLATION_ENABLED
        public static fvec4 linearInterpolate(fvec4 a, fvec4 b, float position)
        {
            return (a * (1 - position)) + (b * position);
        }
        public fvec4 linearInterpolateTo(fvec4 b, float position)
        {
            return linearInterpolate(this, b, position);
        }


        public static fvec4 quadraticBezierInterpolate(fvec4 a, fvec4 b, fvec4 c, float position)
        {
            return linearInterpolate(
                linearInterpolate(a, b, position),
                linearInterpolate(b, c, position),
                position);
        }
        public fvec4 quadraticBezierInterpolateTo(fvec4 b, fvec4 c, float position)
        {
            return quadraticBezierInterpolate(this, b, c, position);
        }


        //todo: validate this
        public static fvec4 cubicBezierInterpolate(fvec4 a, fvec4 b, fvec4 c, fvec4 d, float position)
        {
            return linearInterpolate(
                quadraticBezierInterpolate(a, b, c, position),
                quadraticBezierInterpolate(b, c, d, position),
                position);
        }
        public fvec4 cubicBezierInterpolateTo(fvec4 b, fvec4 c, fvec4 d, float position)
        {
            return cubicBezierInterpolate(this, b, c, d, position);
        }
        //todo: rational bezier interpolation (ie with weights)

#endif
    }
}
#endif
#endif