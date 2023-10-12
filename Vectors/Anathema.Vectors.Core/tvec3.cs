#if TEMPLATES_ENABLED
#if THREED_ENABLED
using System;

namespace Anathema.Vectors.Core
{
    /// <summary>
    /// A 3-component vector where each element is a templated type. Nesting is allowed.
    /// </summary>
    public class tvec3<T> : tvec2<T>
    {
        ///////////////////////////
        //        Members        //
        ///////////////////////////

        public T z { get; set; }


        ///////////////////////////
        //     Constructors      //
        ///////////////////////////

        public tvec3()
        {
        }
        public tvec3(tvec2<T> a, T z)
        {
            x = a.x;
            y = a.y;
            this.z = z;
        }
        public tvec3(T x, tvec2<T> yz)
        {
            this.x = x;
            y = yz.x;
            z = yz.y;
        }
        public tvec3(T x, T y, T z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public tvec3(tvec3<T> xyz)
        {
            x = xyz.x;
            y = xyz.y;
            z = xyz.z;
        }


        public tvec3(T[] xyz)
        {
            this.x = xyz[0];
            this.y = xyz[1];
            this.z = xyz[2];
        }

        ///////////////////////////
        //        Swizzles       //
        ///////////////////////////

        // 3! = 3 * 2 * 1 = 6
        // There are 6 swizzles, in 3 groups of 2

        //Starting with X (2)

#if SWIZZLES_ENABLED
        public tvec3<T> xyz
        {
            get
            {
                return new tvec3<T>(x, y, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }
        public tvec3<T> xzy
        {
            get
            {
                return new tvec3<T>(x, z, y);
            }
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
            }
        }


        //Starting with Y (2)


        public tvec3<T> yxz
        {
            get
            {
                return new tvec3<T>(y, x, z);
            }
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
            }
        }
        public tvec3<T> yzx
        {
            get
            {
                return new tvec3<T>(y, z, x);
            }
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
            }
        }


        //Starting with Z (2)


        public tvec3<T> zxy
        {
            get
            {
                return new tvec3<T>(z, x, y);
            }
            set
            {
                z = value.x;
                x = value.y;
                y = value.z;
            }
        }
        public tvec3<T> zyx
        {
            get
            {
                return new tvec3<T>(z, y, x);
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
        public T b
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
        public tvec3<T> rgb
        {
            get
            {
                return new tvec3<T>(x, y, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }
        public tvec3<T> rbg
        {
            get
            {
                return new tvec3<T>(x, z, y);
            }
            set
            {
                x = value.x;
                z = value.y;
                y = value.z;
            }
        }
        public tvec3<T> grb
        {
            get
            {
                return new tvec3<T>(y, x, z);
            }
            set
            {
                y = value.x;
                x = value.y;
                z = value.z;
            }
        }
        public tvec3<T> gbr
        {
            get
            {
                return new tvec3<T>(y, z, x);
            }
            set
            {
                y = value.x;
                z = value.y;
                x = value.z;
            }
        }
        public tvec3<T> bgr
        {
            get
            {
                return new tvec3<T>(z, y, x);
            }
            set
            {
                z = value.x;
                y = value.y;
                x = value.z;
            }
        }
        public tvec3<T> brg
        {
            get
            {
                return new tvec3<T>(z, x, y);
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
        //      Conversions      //
        ///////////////////////////


#if NESTING_ENABLED
        public static tvec3<tvec3<double>> fromDMat3(dmat3 input)
        {
            var output = new tvec3<tvec3<double>>();

            output.x.x = input.getValue(0, 0);
            output.x.y = input.getValue(0, 1);
            output.x.z = input.getValue(0, 2);

            output.y.x = input.getValue(1, 0);
            output.y.y = input.getValue(1, 1);
            output.y.z = input.getValue(1, 2);

            output.z.x = input.getValue(2, 0);
            output.z.y = input.getValue(2, 1);
            output.z.z = input.getValue(2, 2);

            return output;
        }
        public static tvec3<tvec3<float>> fromFMat3(fmat3 input)
        {
            var output = new tvec3<tvec3<float>>();

            output.x.x = input.getValue(0, 0);
            output.x.y = input.getValue(0, 1);
            output.x.z = input.getValue(0, 2);

            output.y.x = input.getValue(1, 0);
            output.y.y = input.getValue(1, 1);
            output.y.z = input.getValue(1, 2);

            output.z.x = input.getValue(2, 0);
            output.z.y = input.getValue(2, 1);
            output.z.z = input.getValue(2, 2);

            return output;
        }
#endif



#if CONVERSIONS_ENABLED
#if FLOATS_ENABLED
        public fvec3 floatTVec3ToFVec3()
        {
            if (typeof(T) != typeof(float))
                throw new ArgumentException();

            float fx = (float)Convert.ChangeType(x, typeof(float));
            float fy = (float)Convert.ChangeType(y, typeof(float));
            float fz = (float)Convert.ChangeType(z, typeof(float));

            return new fvec3(fx, fy, fz);
        }
#endif
#if DOUBLES_ENABLED
        public dvec3 doubleTVec3ToDVec3()
        {
            if (typeof(T) != typeof(double))
                throw new ArgumentException();

            double fx = (double)Convert.ChangeType(x, typeof(double));
            double fy = (double)Convert.ChangeType(y, typeof(double));
            double fz = (double)Convert.ChangeType(z, typeof(double));

            return new dvec3(fx, fy, fz);
        }
#endif
#endif



        public new T this[int i]
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

        public override T[] ToArray()
        {
            return new T[] { x, y, z };
        }



#if TEMPLATE_OPERATIONS_ENABLED

        public static bool operator !=(tvec3<T> a, tvec3<T> b)
        {
            return !(a == b);
        }
        public static bool operator ==(tvec3<T> a, tvec3<T> b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float az = tToFloat(a.z);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                float bz = tToFloat(b.z);
                return scalar.isClose(ax, bx) && scalar.isClose(ay, by) && scalar.isClose(az,bz);
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double az = tToDouble(a.z);
                double bx = tToDouble(b.x);
                double by = tToDouble(b.y);
                double bz = tToDouble(b.z);
                return scalar.isClose(ax, bx) && scalar.isClose(ay, by) && scalar.isClose(az, bz);
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal az = tToDecimal(a.z);
                decimal bx = tToDecimal(b.x);
                decimal by = tToDecimal(b.y);
                decimal bz = tToDecimal(b.z);
                return ax == bx && ay == by && az == bz;
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte az = tToByte(a.z);
                byte bx = tToByte(b.x);
                byte by = tToByte(b.y);
                byte bz = tToByte(b.z);
                return ax == bx && ay == by && az == bz;
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short az = tToShort(a.z);
                short bx = tToShort(b.x);
                short by = tToShort(b.y);
                short bz = tToShort(b.z);
                return ax == bx && ay == by && az == bz;
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int az = tToInt(a.z);
                int bx = tToInt(b.x);
                int by = tToInt(b.y);
                int bz = tToInt(b.z);
                return ax == bx && ay == by && az == bz;
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long az = tToLong(a.z);
                long bx = tToLong(b.x);
                long by = tToLong(b.y);
                long bz = tToLong(b.z);
                return ax == bx && ay == by && az == bz;
            }
            throw new TypeLoadException();
        }

        public static tvec3<T> operator *(tvec3<T> a, tvec3<T> b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float az = tToFloat(a.z);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                float bz = tToFloat(b.z);
                return new tvec3<T>(floatToT(ax * bx), floatToT(ay * by), floatToT(az * bz));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double az = tToDouble(a.z);
                double bx = tToDouble(b.x);
                double by = tToDouble(b.y);
                double bz = tToDouble(b.z);
                return new tvec3<T>(doubleToT(ax * bx), doubleToT(ay * by), doubleToT(az * bz));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal az = tToDecimal(a.z);
                decimal bx = tToDecimal(b.x);
                decimal by = tToDecimal(b.y);
                decimal bz = tToDecimal(b.z);
                return new tvec3<T>(decimalToT(ax * bx), decimalToT(ay * by), decimalToT(az * bz));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte az = tToByte(a.z);
                byte bx = tToByte(b.x);
                byte by = tToByte(b.y);
                byte bz = tToByte(b.z);
                return new tvec3<T>(byteToT((byte)(ax * bx)), byteToT((byte)(ay * by)), byteToT((byte)(az * bz)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short az = tToShort(a.z);
                short bx = tToShort(b.x);
                short by = tToShort(b.y);
                short bz = tToShort(b.z);
                return new tvec3<T>(shortToT((short)(ax * bx)), shortToT((short)(ay * by)), shortToT((short)(az * bz)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int az = tToInt(a.z);
                int bx = tToInt(b.x);
                int by = tToInt(b.y);
                int bz = tToInt(b.z);
                return new tvec3<T>(intToT(ax * bx), intToT(ay * by), intToT(az * bz));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long az = tToLong(a.z);
                long bx = tToLong(b.x);
                long by = tToLong(b.y);
                long bz = tToLong(b.z);
                return new tvec3<T>(longToT(ax * bx), longToT(ay * by), longToT(az * bz));
            }
            throw new TypeLoadException();
        }



#endif
    }
}
#endif
#endif