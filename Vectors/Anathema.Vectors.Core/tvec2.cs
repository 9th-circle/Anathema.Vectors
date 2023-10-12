#if TEMPLATES_ENABLED
using System;

namespace Anathema.Vectors.Core
{
    /// <summary>
    /// A 2-component vector where each element is a templated type. Nesting is allowed.
    /// </summary>
    public class tvec2<T>
    {
        ///////////////////////////
        //        Members        //
        ///////////////////////////

        public T x { get; set; }
        public T y { get; set; }


        ///////////////////////////
        //     Constructors      //
        ///////////////////////////

        public tvec2()
        {
        }

        public tvec2(T x, T y)
        {
            this.x = x;
            this.y = y;
        }
        public tvec2(tvec2<T> xy)
        {
            x = xy.x;
            y = xy.y;
        }
        public tvec2(T[] xy)
        {
            this.x = xy[0];
            this.y = xy[1];
        }


        ///////////////////////////
        //        Swizzles       //
        ///////////////////////////

#if SWIZZLES_ENABLED

        public tvec2<T> xy
        {
            get
            {
                return new tvec2<T>(x, y);
            }
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        public tvec2<T> yx
        {
            get
            {
                return new tvec2<T>(y, x);
            }
            set
            {
                y = value.x;
                x = value.y;
            }
        }

#endif
#if COLOURS_ENABLED
        public T r
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
        public T g
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
        public tvec2<T> rg
        {
            get
            {
                return new tvec2<T>(x, y);
            }
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        public tvec2<T> gr
        {
            get
            {
                return new tvec2<T>(y, x);
            }
            set
            {
                y = value.x;
                x = value.y;
            }
        }
#endif



        ///////////////////////////
        //      Conversions      //
        ///////////////////////////


#if NESTING_ENABLED
#if DOUBLES_ENABLED
        public static tvec2<tvec2<double>> fromDMat2(dmat2 input)
        {
            var output = new tvec2<tvec2<double>>();

            output.x.x = input.getValue(0, 0);
            output.x.y = input.getValue(0, 1);

            output.y.x = input.getValue(1, 0);
            output.y.y = input.getValue(1, 1);

            return output;
        }
#endif
#endif

#if CONVERSIONS_ENABLED
#if FLOATS_ENABLED
        public fvec2 floatTVec2ToFVec2()
        {
            if (typeof(T) != typeof(float))
                throw new ArgumentException();
            
            float fx = (float)Convert.ChangeType(x, typeof(float));
            float fy = (float)Convert.ChangeType(y, typeof(float));

            return new fvec2(fx, fy);
        }
#endif
#if DOUBLES_ENABLED
        public dvec2 doubleTVec2ToDVec2()
        {
            if (typeof(T) != typeof(double))
                throw new ArgumentException();

            double fx = (double)Convert.ChangeType(x, typeof(double));
            double fy = (double)Convert.ChangeType(y, typeof(double));

            return new dvec2(fx, fy);
        }
#endif
#endif

///////////////////////////
//       Operators       //
///////////////////////////


#if TEMPLATE_OPERATIONS_ENABLED
        protected static byte tToByte(T a)
        {
            return (byte)Convert.ChangeType(a, typeof(byte));
        }
        protected static short tToShort(T a)
        {
            return (short)Convert.ChangeType(a, typeof(short));
        }
        protected static int tToInt(T a)
        {
            return (int)Convert.ChangeType(a, typeof(int));
        }

        protected static long tToLong(T a)
        {
            return (long)Convert.ChangeType(a, typeof(long));
        }
        protected static int tToDecimal(T a)
        {
            return (int)Convert.ChangeType(a, typeof(decimal));
        }
        protected static int tToFloat(T a)
        {
            return (int)Convert.ChangeType(a, typeof(float));
        }
        protected static int tToDouble(T a)
        {
            return (int)Convert.ChangeType(a, typeof(double));
        }



        protected static T byteToT(byte a)
        {
            return (T)Convert.ChangeType(a, typeof(T));
        }
        protected static T shortToT(short a)
        {
            return (T)Convert.ChangeType(a, typeof(T));
        }
        protected static T intToT(int a)
        {
            return (T)Convert.ChangeType(a, typeof(T));
        }
        protected static T longToT(long a)
        {
            return (T)Convert.ChangeType(a, typeof(T));
        }
        protected static T decimalToT(decimal a)
        {
            return (T)Convert.ChangeType(a, typeof(T));
        }
        protected static T floatToT(float a)
        {
            return (T)Convert.ChangeType(a, typeof(T));
        }
        protected static T doubleToT(double a)
        {
            return (T)Convert.ChangeType(a, typeof(T));
        }


        public static bool operator !=(tvec2<T> a, tvec2<T> b)
        {
            return !(a == b);
        }
        public static bool operator ==(tvec2<T> a, tvec2<T> b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                return scalar.isClose(ax, bx) && scalar.isClose(ay, by);
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double bx = tToDouble(b.x);
                double by = tToDouble(b.y);
                return scalar.isClose(ax, bx) && scalar.isClose(ay, by);
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal bx = tToDecimal(b.x);
                decimal by = tToDecimal(b.y);
                return ax == bx && ay == by;
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte bx = tToByte(b.x);
                byte by = tToByte(b.y);
                return ax == bx && ay == by;
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short bx = tToShort(b.x);
                short by = tToShort(b.y);
                return ax == bx && ay == by;
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int bx = tToInt(b.x);
                int by = tToInt(b.y);
                return ax == bx && ay == by;
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long bx = tToLong(b.x);
                long by = tToLong(b.y);
                return ax == bx && ay == by;
            }
            throw new TypeLoadException();
        }

        public static tvec2<T> operator *(tvec2<T> a, tvec2<T> b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                return new tvec2<T>(floatToT(ax * bx), floatToT(ay * by));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double bx = tToDouble(b.x);
                double by = tToDouble(b.y);
                return new tvec2<T>(doubleToT(ax * bx), doubleToT(ay * by));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal bx = tToDecimal(b.x);
                decimal by = tToDecimal(b.y);
                return new tvec2<T>(decimalToT(ax * bx), decimalToT(ay * by));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte bx = tToByte(b.x);
                byte by = tToByte(b.y);
                return new tvec2<T>(byteToT((byte)(ax * bx)), byteToT((byte)(ay * by)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short bx = tToShort(b.x);
                short by = tToShort(b.y);
                return new tvec2<T>(shortToT((short)(ax * bx)), shortToT((short)(ay * by)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int bx = tToInt(b.x);
                int by = tToInt(b.y);
                return new tvec2<T>(intToT(ax * bx), intToT(ay * by));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long bx = tToLong(b.x);
                long by = tToLong(b.y);
                return new tvec2<T>(longToT(ax * bx), longToT(ay * by));
            }
            throw new TypeLoadException();
        }
        public static tvec2<T> operator /(tvec2<T> a, tvec2<T> b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                return new tvec2<T>(floatToT(ax / bx), floatToT(ay / by));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double bx = tToDouble(b.x);
                double by = tToDouble(b.y);
                return new tvec2<T>(doubleToT(ax / bx), doubleToT(ay / by));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal bx = tToDecimal(b.x);
                decimal by = tToDecimal(b.y);
                return new tvec2<T>(decimalToT(ax / bx), decimalToT(ay / by));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte bx = tToByte(b.x);
                byte by = tToByte(b.y);
                return new tvec2<T>(byteToT((byte)(ax / bx)), byteToT((byte)(ay / by)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short bx = tToShort(b.x);
                short by = tToShort(b.y);
                return new tvec2<T>(shortToT((short)(ax / bx)), shortToT((short)(ay / by)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int bx = tToInt(b.x);
                int by = tToInt(b.y);
                return new tvec2<T>(intToT(ax / bx), intToT(ay / by));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long bx = tToLong(b.x);
                long by = tToLong(b.y);
                return new tvec2<T>(longToT(ax / bx), longToT(ay / by));
            }
            throw new TypeLoadException();
        }
        public static tvec2<T> operator +(tvec2<T> a, tvec2<T> b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                return new tvec2<T>(floatToT(ax + bx), floatToT(ay + by));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double bx = tToDouble(b.x);
                double by = tToDouble(b.y);
                return new tvec2<T>(doubleToT(ax + bx), doubleToT(ay + by));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal bx = tToDecimal(b.x);
                decimal by = tToDecimal(b.y);
                return new tvec2<T>(decimalToT(ax + bx), decimalToT(ay + by));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte bx = tToByte(b.x);
                byte by = tToByte(b.y);
                return new tvec2<T>(byteToT((byte)(ax + bx)), byteToT((byte)(ay + by)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short bx = tToShort(b.x);
                short by = tToShort(b.y);
                return new tvec2<T>(shortToT((short)(ax + bx)), shortToT((short)(ay + by)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int bx = tToInt(b.x);
                int by = tToInt(b.y);
                return new tvec2<T>(intToT(ax + bx), intToT(ay + by));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long bx = tToLong(b.x);
                long by = tToLong(b.y);
                return new tvec2<T>(longToT(ax + bx), longToT(ay + by));
            }
            throw new TypeLoadException();
        }
        public static tvec2<T> operator -(tvec2<T> a, tvec2<T> b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                return new tvec2<T>(floatToT(ax - bx), floatToT(ay - by));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double bx = tToDouble(b.x);
                double by = tToDouble(b.y);
                return new tvec2<T>(doubleToT(ax - bx), doubleToT(ay - by));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal bx = tToDecimal(b.x);
                decimal by = tToDecimal(b.y);
                return new tvec2<T>(decimalToT(ax - bx), decimalToT(ay - by));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte bx = tToByte(b.x);
                byte by = tToByte(b.y);
                return new tvec2<T>(byteToT((byte)(ax - bx)), byteToT((byte)(ay - by)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short bx = tToShort(b.x);
                short by = tToShort(b.y);
                return new tvec2<T>(shortToT((short)(ax - bx)), shortToT((short)(ay - by)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int bx = tToInt(b.x);
                int by = tToInt(b.y);
                return new tvec2<T>(intToT(ax - bx), intToT(ay - by));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long bx = tToLong(b.x);
                long by = tToLong(b.y);
                return new tvec2<T>(longToT(ax - bx), longToT(ay - by));
            }
            throw new TypeLoadException();
        }
#endif
        public T this[int i]
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


        public virtual T[] ToArray()
        {
            return new T[] { x, y };
        }
    }
}
#endif