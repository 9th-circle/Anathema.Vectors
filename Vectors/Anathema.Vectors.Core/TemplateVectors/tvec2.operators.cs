#if TEMPLATES_ENABLED
#if TEMPLATE_OPERATIONS_ENABLED
using System;

namespace Anathema.Vectors.Core
{
    public partial class tvec2<T>
    {
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
            if (a is null && b is null)
                return true;
            if ((a is null) != (b is null))
                return false;
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



        public static tvec2<T> operator *(tvec2<T> a, T b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float bx = tToFloat(b);
                float by = tToFloat(b);
                return new tvec2<T>(floatToT(ax * bx), floatToT(ay * by));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double bx = tToDouble(b);
                double by = tToDouble(b);
                return new tvec2<T>(doubleToT(ax * bx), doubleToT(ay * by));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal bx = tToDecimal(b);
                decimal by = tToDecimal(b);
                return new tvec2<T>(decimalToT(ax * bx), decimalToT(ay * by));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte bx = tToByte(b);
                byte by = tToByte(b);
                return new tvec2<T>(byteToT((byte)(ax * bx)), byteToT((byte)(ay * by)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short bx = tToShort(b);
                short by = tToShort(b);
                return new tvec2<T>(shortToT((short)(ax * bx)), shortToT((short)(ay * by)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int bx = tToInt(b);
                int by = tToInt(b);
                return new tvec2<T>(intToT(ax * bx), intToT(ay * by));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long bx = tToLong(b);
                long by = tToLong(b);
                return new tvec2<T>(longToT(ax * bx), longToT(ay * by));
            }
            throw new TypeLoadException();
        }
        public static tvec2<T> operator /(tvec2<T> a, T b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float bx = tToFloat(b);
                float by = tToFloat(b);
                return new tvec2<T>(floatToT(ax / bx), floatToT(ay / by));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double bx = tToDouble(b);
                double by = tToDouble(b);
                return new tvec2<T>(doubleToT(ax / bx), doubleToT(ay / by));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal bx = tToDecimal(b);
                decimal by = tToDecimal(b);
                return new tvec2<T>(decimalToT(ax / bx), decimalToT(ay / by));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte bx = tToByte(b);
                byte by = tToByte(b);
                return new tvec2<T>(byteToT((byte)(ax / bx)), byteToT((byte)(ay / by)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short bx = tToShort(b);
                short by = tToShort(b);
                return new tvec2<T>(shortToT((short)(ax / bx)), shortToT((short)(ay / by)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int bx = tToInt(b);
                int by = tToInt(b);
                return new tvec2<T>(intToT(ax / bx), intToT(ay / by));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long bx = tToLong(b);
                long by = tToLong(b);
                return new tvec2<T>(longToT(ax / bx), longToT(ay / by));
            }
            throw new TypeLoadException();
        }
        public static tvec2<T> operator +(tvec2<T> a, T b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float bx = tToFloat(b);
                float by = tToFloat(b);
                return new tvec2<T>(floatToT(ax + bx), floatToT(ay + by));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double bx = tToDouble(b);
                double by = tToDouble(b);
                return new tvec2<T>(doubleToT(ax + bx), doubleToT(ay + by));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal bx = tToDecimal(b);
                decimal by = tToDecimal(b);
                return new tvec2<T>(decimalToT(ax + bx), decimalToT(ay + by));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte bx = tToByte(b);
                byte by = tToByte(b);
                return new tvec2<T>(byteToT((byte)(ax + bx)), byteToT((byte)(ay + by)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short bx = tToShort(b);
                short by = tToShort(b);
                return new tvec2<T>(shortToT((short)(ax + bx)), shortToT((short)(ay + by)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int bx = tToInt(b);
                int by = tToInt(b);
                return new tvec2<T>(intToT(ax + bx), intToT(ay + by));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long bx = tToLong(b);
                long by = tToLong(b);
                return new tvec2<T>(longToT(ax + bx), longToT(ay + by));
            }
            throw new TypeLoadException();
        }
        public static tvec2<T> operator -(tvec2<T> a, T b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float bx = tToFloat(b);
                float by = tToFloat(b);
                return new tvec2<T>(floatToT(ax - bx), floatToT(ay - by));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double bx = tToDouble(b);
                double by = tToDouble(b);
                return new tvec2<T>(doubleToT(ax - bx), doubleToT(ay - by));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal bx = tToDecimal(b);
                decimal by = tToDecimal(b);
                return new tvec2<T>(decimalToT(ax - bx), decimalToT(ay - by));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte bx = tToByte(b);
                byte by = tToByte(b);
                return new tvec2<T>(byteToT((byte)(ax - bx)), byteToT((byte)(ay - by)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short bx = tToShort(b);
                short by = tToShort(b);
                return new tvec2<T>(shortToT((short)(ax - bx)), shortToT((short)(ay - by)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int bx = tToInt(b);
                int by = tToInt(b);
                return new tvec2<T>(intToT(ax - bx), intToT(ay - by));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long bx = tToLong(b);
                long by = tToLong(b);
                return new tvec2<T>(longToT(ax - bx), longToT(ay - by));
            }
            throw new TypeLoadException();
        }







        public static tvec2<T> operator *(T a, tvec2<T> b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a);
                float ay = tToFloat(a);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                return new tvec2<T>(floatToT(ax * bx), floatToT(ay * by));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a);
                double ay = tToDouble(a);
                double bx = tToDouble(b.x);
                double by = tToDouble(b.y);
                return new tvec2<T>(doubleToT(ax * bx), doubleToT(ay * by));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a);
                decimal ay = tToDecimal(a);
                decimal bx = tToDecimal(b.x);
                decimal by = tToDecimal(b.y);
                return new tvec2<T>(decimalToT(ax * bx), decimalToT(ay * by));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a);
                byte ay = tToByte(a);
                byte bx = tToByte(b.x);
                byte by = tToByte(b.y);
                return new tvec2<T>(byteToT((byte)(ax * bx)), byteToT((byte)(ay * by)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a);
                short ay = tToShort(a);
                short bx = tToShort(b.x);
                short by = tToShort(b.y);
                return new tvec2<T>(shortToT((short)(ax * bx)), shortToT((short)(ay * by)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a);
                int ay = tToInt(a);
                int bx = tToInt(b.x);
                int by = tToInt(b.y);
                return new tvec2<T>(intToT(ax * bx), intToT(ay * by));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a);
                long ay = tToLong(a);
                long bx = tToLong(b.x);
                long by = tToLong(b.y);
                return new tvec2<T>(longToT(ax * bx), longToT(ay * by));
            }
            throw new TypeLoadException();
        }
        public static tvec2<T> operator /(T a, tvec2<T> b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a);
                float ay = tToFloat(a);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                return new tvec2<T>(floatToT(ax / bx), floatToT(ay / by));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a);
                double ay = tToDouble(a);
                double bx = tToDouble(b.x);
                double by = tToDouble(b.y);
                return new tvec2<T>(doubleToT(ax / bx), doubleToT(ay / by));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a);
                decimal ay = tToDecimal(a);
                decimal bx = tToDecimal(b.x);
                decimal by = tToDecimal(b.y);
                return new tvec2<T>(decimalToT(ax / bx), decimalToT(ay / by));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a);
                byte ay = tToByte(a);
                byte bx = tToByte(b.x);
                byte by = tToByte(b.y);
                return new tvec2<T>(byteToT((byte)(ax / bx)), byteToT((byte)(ay / by)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a);
                short ay = tToShort(a);
                short bx = tToShort(b.x);
                short by = tToShort(b.y);
                return new tvec2<T>(shortToT((short)(ax / bx)), shortToT((short)(ay / by)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a);
                int ay = tToInt(a);
                int bx = tToInt(b.x);
                int by = tToInt(b.y);
                return new tvec2<T>(intToT(ax / bx), intToT(ay / by));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a);
                long ay = tToLong(a);
                long bx = tToLong(b.x);
                long by = tToLong(b.y);
                return new tvec2<T>(longToT(ax / bx), longToT(ay / by));
            }
            throw new TypeLoadException();
        }
        public static tvec2<T> operator +(T a, tvec2<T> b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a);
                float ay = tToFloat(a);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                return new tvec2<T>(floatToT(ax + bx), floatToT(ay + by));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a);
                double ay = tToDouble(a);
                double bx = tToDouble(b.x);
                double by = tToDouble(b.y);
                return new tvec2<T>(doubleToT(ax + bx), doubleToT(ay + by));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a);
                decimal ay = tToDecimal(a);
                decimal bx = tToDecimal(b.x);
                decimal by = tToDecimal(b.y);
                return new tvec2<T>(decimalToT(ax + bx), decimalToT(ay + by));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a);
                byte ay = tToByte(a);
                byte bx = tToByte(b.x);
                byte by = tToByte(b.y);
                return new tvec2<T>(byteToT((byte)(ax + bx)), byteToT((byte)(ay + by)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a);
                short ay = tToShort(a);
                short bx = tToShort(b.x);
                short by = tToShort(b.y);
                return new tvec2<T>(shortToT((short)(ax + bx)), shortToT((short)(ay + by)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a);
                int ay = tToInt(a);
                int bx = tToInt(b.x);
                int by = tToInt(b.y);
                return new tvec2<T>(intToT(ax + bx), intToT(ay + by));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a);
                long ay = tToLong(a);
                long bx = tToLong(b.x);
                long by = tToLong(b.y);
                return new tvec2<T>(longToT(ax + bx), longToT(ay + by));
            }
            throw new TypeLoadException();
        }
        public static tvec2<T> operator -(T a, tvec2<T> b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a);
                float ay = tToFloat(a);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                return new tvec2<T>(floatToT(ax - bx), floatToT(ay - by));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a);
                double ay = tToDouble(a);
                double bx = tToDouble(b.x);
                double by = tToDouble(b.y);
                return new tvec2<T>(doubleToT(ax - bx), doubleToT(ay - by));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a);
                decimal ay = tToDecimal(a);
                decimal bx = tToDecimal(b.x);
                decimal by = tToDecimal(b.y);
                return new tvec2<T>(decimalToT(ax - bx), decimalToT(ay - by));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a);
                byte ay = tToByte(a);
                byte bx = tToByte(b.x);
                byte by = tToByte(b.y);
                return new tvec2<T>(byteToT((byte)(ax - bx)), byteToT((byte)(ay - by)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a);
                short ay = tToShort(a);
                short bx = tToShort(b.x);
                short by = tToShort(b.y);
                return new tvec2<T>(shortToT((short)(ax - bx)), shortToT((short)(ay - by)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a);
                int ay = tToInt(a);
                int bx = tToInt(b.x);
                int by = tToInt(b.y);
                return new tvec2<T>(intToT(ax - bx), intToT(ay - by));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a);
                long ay = tToLong(a);
                long bx = tToLong(b.x);
                long by = tToLong(b.y);
                return new tvec2<T>(longToT(ax - bx), longToT(ay - by));
            }
            throw new TypeLoadException();
        }

    }
}
#endif
#endif