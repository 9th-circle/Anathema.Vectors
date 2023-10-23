#if THREED_ENABLED
#if TEMPLATES_ENABLED
#if TEMPLATE_OPERATIONS_ENABLED
using System;
using System.Collections.Generic;
using System.Text;

namespace Anathema.Vectors.Core
{
    public partial class tvec3<T> : tvec2<T>
    {
        public override bool Equals(object o)
        {
            if (o is tvec3<T>)
                return ((tvec3<T>)o) == this;
            else
                return false;
        }
        public static bool operator !=(tvec3<T> a, tvec3<T> b)
        {
            return !(a == b);
        }
        public static bool operator ==(tvec3<T> a, tvec3<T> b)
        {
            if (a is null && b is null)
                return true;
            if ((a is null) != (b is null))
                return false;
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float az = tToFloat(a.z);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                float bz = tToFloat(b.z);
                return scalar.isClose(ax, bx) && scalar.isClose(ay, by) && scalar.isClose(az, bz);
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
        public static tvec3<T> operator -(tvec3<T> a)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float az = tToFloat(a.z);
                return new tvec3<T>(floatToT(-ax), floatToT(-ay), floatToT(-az));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double az = tToDouble(a.z);
                return new tvec3<T>(doubleToT(-ax), doubleToT(-ay), doubleToT(-az));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal az = tToDecimal(a.z);
                return new tvec3<T>(decimalToT(-ax), decimalToT(-ay), decimalToT(-az));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte az = tToByte(a.z);
                return new tvec3<T>(byteToT((byte)(-ax)), byteToT((byte)(-ay)), byteToT((byte)(-az)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short az = tToShort(a.z);
                return new tvec3<T>(shortToT((short)(-ax)), shortToT((short)(-ay)), shortToT((short)(-az)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int az = tToInt(a.z);
                return new tvec3<T>(intToT(-ax), intToT(-ay), intToT(-az));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long az = tToLong(a.z);
                return new tvec3<T>(longToT(-ax), longToT(-ay), longToT(-az));
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


#if TEMPLATE_DIVISION_ENABLED
        public static tvec3<T> operator /(tvec3<T> a, tvec3<T> b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float az = tToFloat(a.z);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                float bz = tToFloat(b.z);
                return new tvec3<T>(floatToT(ax / bx), floatToT(ay / by), floatToT(az / bz));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double az = tToDouble(a.z);
                double bx = tToDouble(b.x);
                double by = tToDouble(b.y);
                double bz = tToDouble(b.z);
                return new tvec3<T>(doubleToT(ax / bx), doubleToT(ay / by), doubleToT(az / bz));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal az = tToDecimal(a.z);
                decimal bx = tToDecimal(b.x);
                decimal by = tToDecimal(b.y);
                decimal bz = tToDecimal(b.z);
                return new tvec3<T>(decimalToT(ax / bx), decimalToT(ay / by), decimalToT(az / bz));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte az = tToByte(a.z);
                byte bx = tToByte(b.x);
                byte by = tToByte(b.y);
                byte bz = tToByte(b.z);
                return new tvec3<T>(byteToT((byte)(ax / bx)), byteToT((byte)(ay / by)), byteToT((byte)(az / bz)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short az = tToShort(a.z);
                short bx = tToShort(b.x);
                short by = tToShort(b.y);
                short bz = tToShort(b.z);
                return new tvec3<T>(shortToT((short)(ax / bx)), shortToT((short)(ay / by)), shortToT((short)(az / bz)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int az = tToInt(a.z);
                int bx = tToInt(b.x);
                int by = tToInt(b.y);
                int bz = tToInt(b.z);
                return new tvec3<T>(intToT(ax / bx), intToT(ay / by), intToT(az / bz));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long az = tToLong(a.z);
                long bx = tToLong(b.x);
                long by = tToLong(b.y);
                long bz = tToLong(b.z);
                return new tvec3<T>(longToT(ax / bx), longToT(ay / by), longToT(az / bz));
            }
            throw new TypeLoadException();
        }
#endif


        public static tvec3<T> operator +(tvec3<T> a, tvec3<T> b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float az = tToFloat(a.z);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                float bz = tToFloat(b.z);
                return new tvec3<T>(floatToT(ax + bx), floatToT(ay + by), floatToT(az + bz));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double az = tToDouble(a.z);
                double bx = tToDouble(b.x);
                double by = tToDouble(b.y);
                double bz = tToDouble(b.z);
                return new tvec3<T>(doubleToT(ax + bx), doubleToT(ay + by), doubleToT(az + bz));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal az = tToDecimal(a.z);
                decimal bx = tToDecimal(b.x);
                decimal by = tToDecimal(b.y);
                decimal bz = tToDecimal(b.z);
                return new tvec3<T>(decimalToT(ax + bx), decimalToT(ay + by), decimalToT(az + bz));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte az = tToByte(a.z);
                byte bx = tToByte(b.x);
                byte by = tToByte(b.y);
                byte bz = tToByte(b.z);
                return new tvec3<T>(byteToT((byte)(ax + bx)), byteToT((byte)(ay + by)), byteToT((byte)(az + bz)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short az = tToShort(a.z);
                short bx = tToShort(b.x);
                short by = tToShort(b.y);
                short bz = tToShort(b.z);
                return new tvec3<T>(shortToT((short)(ax + bx)), shortToT((short)(ay + by)), shortToT((short)(az + bz)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int az = tToInt(a.z);
                int bx = tToInt(b.x);
                int by = tToInt(b.y);
                int bz = tToInt(b.z);
                return new tvec3<T>(intToT(ax + bx), intToT(ay + by), intToT(az + bz));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long az = tToLong(a.z);
                long bx = tToLong(b.x);
                long by = tToLong(b.y);
                long bz = tToLong(b.z);
                return new tvec3<T>(longToT(ax + bx), longToT(ay + by), longToT(az + bz));
            }
            throw new TypeLoadException();
        }

        public static tvec3<T> operator -(tvec3<T> a, tvec3<T> b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float az = tToFloat(a.z);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                float bz = tToFloat(b.z);
                return new tvec3<T>(floatToT(ax - bx), floatToT(ay - by), floatToT(az - bz));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double az = tToDouble(a.z);
                double bx = tToDouble(b.x);
                double by = tToDouble(b.y);
                double bz = tToDouble(b.z);
                return new tvec3<T>(doubleToT(ax - bx), doubleToT(ay - by), doubleToT(az - bz));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal az = tToDecimal(a.z);
                decimal bx = tToDecimal(b.x);
                decimal by = tToDecimal(b.y);
                decimal bz = tToDecimal(b.z);
                return new tvec3<T>(decimalToT(ax - bx), decimalToT(ay - by), decimalToT(az - bz));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte az = tToByte(a.z);
                byte bx = tToByte(b.x);
                byte by = tToByte(b.y);
                byte bz = tToByte(b.z);
                return new tvec3<T>(byteToT((byte)(ax - bx)), byteToT((byte)(ay - by)), byteToT((byte)(az - bz)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short az = tToShort(a.z);
                short bx = tToShort(b.x);
                short by = tToShort(b.y);
                short bz = tToShort(b.z);
                return new tvec3<T>(shortToT((short)(ax - bx)), shortToT((short)(ay - by)), shortToT((short)(az - bz)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int az = tToInt(a.z);
                int bx = tToInt(b.x);
                int by = tToInt(b.y);
                int bz = tToInt(b.z);
                return new tvec3<T>(intToT(ax - bx), intToT(ay - by), intToT(az - bz));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long az = tToLong(a.z);
                long bx = tToLong(b.x);
                long by = tToLong(b.y);
                long bz = tToLong(b.z);
                return new tvec3<T>(longToT(ax - bx), longToT(ay - by), longToT(az - bz));
            }
            throw new TypeLoadException();
        }







        public static tvec3<T> operator *(tvec3<T> a, T b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float az = tToFloat(a.z);
                float bx = tToFloat(b);
                float by = tToFloat(b);
                float bz = tToFloat(b);
                return new tvec3<T>(floatToT(ax * bx), floatToT(ay * by), floatToT(az * bz));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double az = tToDouble(a.z);
                double bx = tToDouble(b);
                double by = tToDouble(b);
                double bz = tToDouble(b);
                return new tvec3<T>(doubleToT(ax * bx), doubleToT(ay * by), doubleToT(az * bz));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal az = tToDecimal(a.z);
                decimal bx = tToDecimal(b);
                decimal by = tToDecimal(b);
                decimal bz = tToDecimal(b);
                return new tvec3<T>(decimalToT(ax * bx), decimalToT(ay * by), decimalToT(az * bz));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte az = tToByte(a.z);
                byte bx = tToByte(b);
                byte by = tToByte(b);
                byte bz = tToByte(b);
                return new tvec3<T>(byteToT((byte)(ax * bx)), byteToT((byte)(ay * by)), byteToT((byte)(az * bz)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short az = tToShort(a.z);
                short bx = tToShort(b);
                short by = tToShort(b);
                short bz = tToShort(b);
                return new tvec3<T>(shortToT((short)(ax * bx)), shortToT((short)(ay * by)), shortToT((short)(az * bz)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int az = tToInt(a.z);
                int bx = tToInt(b);
                int by = tToInt(b);
                int bz = tToInt(b);
                return new tvec3<T>(intToT(ax * bx), intToT(ay * by), intToT(az * bz));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long az = tToLong(a.z);
                long bx = tToLong(b);
                long by = tToLong(b);
                long bz = tToLong(b);
                return new tvec3<T>(longToT(ax * bx), longToT(ay * by), longToT(az * bz));
            }
            throw new TypeLoadException();
        }


#if TEMPLATE_DIVISION_ENABLED
        public static tvec3<T> operator /(tvec3<T> a, T b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float az = tToFloat(a.z);
                float bx = tToFloat(b);
                float by = tToFloat(b);
                float bz = tToFloat(b);
                return new tvec3<T>(floatToT(ax / bx), floatToT(ay / by), floatToT(az / bz));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double az = tToDouble(a.z);
                double bx = tToDouble(b);
                double by = tToDouble(b);
                double bz = tToDouble(b);
                return new tvec3<T>(doubleToT(ax / bx), doubleToT(ay / by), doubleToT(az / bz));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal az = tToDecimal(a.z);
                decimal bx = tToDecimal(b);
                decimal by = tToDecimal(b);
                decimal bz = tToDecimal(b);
                return new tvec3<T>(decimalToT(ax / bx), decimalToT(ay / by), decimalToT(az / bz));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte az = tToByte(a.z);
                byte bx = tToByte(b);
                byte by = tToByte(b);
                byte bz = tToByte(b);
                return new tvec3<T>(byteToT((byte)(ax / bx)), byteToT((byte)(ay / by)), byteToT((byte)(az / bz)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short az = tToShort(a.z);
                short bx = tToShort(b);
                short by = tToShort(b);
                short bz = tToShort(b);
                return new tvec3<T>(shortToT((short)(ax / bx)), shortToT((short)(ay / by)), shortToT((short)(az / bz)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int az = tToInt(a.z);
                int bx = tToInt(b);
                int by = tToInt(b);
                int bz = tToInt(b);
                return new tvec3<T>(intToT(ax / bx), intToT(ay / by), intToT(az / bz));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long az = tToLong(a.z);
                long bx = tToLong(b);
                long by = tToLong(b);
                long bz = tToLong(b);
                return new tvec3<T>(longToT(ax / bx), longToT(ay / by), longToT(az / bz));
            }
            throw new TypeLoadException();
        }
#endif

        public static tvec3<T> operator +(tvec3<T> a, T b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float az = tToFloat(a.z);
                float bx = tToFloat(b);
                float by = tToFloat(b);
                float bz = tToFloat(b);
                return new tvec3<T>(floatToT(ax + bx), floatToT(ay + by), floatToT(az + bz));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double az = tToDouble(a.z);
                double bx = tToDouble(b);
                double by = tToDouble(b);
                double bz = tToDouble(b);
                return new tvec3<T>(doubleToT(ax + bx), doubleToT(ay + by), doubleToT(az + bz));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal az = tToDecimal(a.z);
                decimal bx = tToDecimal(b);
                decimal by = tToDecimal(b);
                decimal bz = tToDecimal(b);
                return new tvec3<T>(decimalToT(ax + bx), decimalToT(ay + by), decimalToT(az + bz));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte az = tToByte(a.z);
                byte bx = tToByte(b);
                byte by = tToByte(b);
                byte bz = tToByte(b);
                return new tvec3<T>(byteToT((byte)(ax + bx)), byteToT((byte)(ay + by)), byteToT((byte)(az + bz)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short az = tToShort(a.z);
                short bx = tToShort(b);
                short by = tToShort(b);
                short bz = tToShort(b);
                return new tvec3<T>(shortToT((short)(ax + bx)), shortToT((short)(ay + by)), shortToT((short)(az + bz)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int az = tToInt(a.z);
                int bx = tToInt(b);
                int by = tToInt(b);
                int bz = tToInt(b);
                return new tvec3<T>(intToT(ax + bx), intToT(ay + by), intToT(az + bz));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long az = tToLong(a.z);
                long bx = tToLong(b);
                long by = tToLong(b);
                long bz = tToLong(b);
                return new tvec3<T>(longToT(ax + bx), longToT(ay + by), longToT(az + bz));
            }
            throw new TypeLoadException();
        }

        public static tvec3<T> operator -(tvec3<T> a, T b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float az = tToFloat(a.z);
                float bx = tToFloat(b);
                float by = tToFloat(b);
                float bz = tToFloat(b);
                return new tvec3<T>(floatToT(ax - bx), floatToT(ay - by), floatToT(az - bz));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double az = tToDouble(a.z);
                double bx = tToDouble(b);
                double by = tToDouble(b);
                double bz = tToDouble(b);
                return new tvec3<T>(doubleToT(ax - bx), doubleToT(ay - by), doubleToT(az - bz));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal az = tToDecimal(a.z);
                decimal bx = tToDecimal(b);
                decimal by = tToDecimal(b);
                decimal bz = tToDecimal(b);
                return new tvec3<T>(decimalToT(ax - bx), decimalToT(ay - by), decimalToT(az - bz));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte az = tToByte(a.z);
                byte bx = tToByte(b);
                byte by = tToByte(b);
                byte bz = tToByte(b);
                return new tvec3<T>(byteToT((byte)(ax - bx)), byteToT((byte)(ay - by)), byteToT((byte)(az - bz)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short az = tToShort(a.z);
                short bx = tToShort(b);
                short by = tToShort(b);
                short bz = tToShort(b);
                return new tvec3<T>(shortToT((short)(ax - bx)), shortToT((short)(ay - by)), shortToT((short)(az - bz)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int az = tToInt(a.z);
                int bx = tToInt(b);
                int by = tToInt(b);
                int bz = tToInt(b);
                return new tvec3<T>(intToT(ax - bx), intToT(ay - by), intToT(az - bz));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long az = tToLong(a.z);
                long bx = tToLong(b);
                long by = tToLong(b);
                long bz = tToLong(b);
                return new tvec3<T>(longToT(ax - bx), longToT(ay - by), longToT(az - bz));
            }
            throw new TypeLoadException();
        }




        public static tvec3<T> operator *(T a, tvec3<T> b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a);
                float ay = tToFloat(a);
                float az = tToFloat(a);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                float bz = tToFloat(b.z);
                return new tvec3<T>(floatToT(ax * bx), floatToT(ay * by), floatToT(az * bz));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a);
                double ay = tToDouble(a);
                double az = tToDouble(a);
                double bx = tToDouble(b.x);
                double by = tToDouble(b.y);
                double bz = tToDouble(b.z);
                return new tvec3<T>(doubleToT(ax * bx), doubleToT(ay * by), doubleToT(az * bz));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a);
                decimal ay = tToDecimal(a);
                decimal az = tToDecimal(a);
                decimal bx = tToDecimal(b.x);
                decimal by = tToDecimal(b.y);
                decimal bz = tToDecimal(b.z);
                return new tvec3<T>(decimalToT(ax * bx), decimalToT(ay * by), decimalToT(az * bz));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a);
                byte ay = tToByte(a);
                byte az = tToByte(a);
                byte bx = tToByte(b.x);
                byte by = tToByte(b.y);
                byte bz = tToByte(b.z);
                return new tvec3<T>(byteToT((byte)(ax * bx)), byteToT((byte)(ay * by)), byteToT((byte)(az * bz)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a);
                short ay = tToShort(a);
                short az = tToShort(a);
                short bx = tToShort(b.x);
                short by = tToShort(b.y);
                short bz = tToShort(b.z);
                return new tvec3<T>(shortToT((short)(ax * bx)), shortToT((short)(ay * by)), shortToT((short)(az * bz)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a);
                int ay = tToInt(a);
                int az = tToInt(a);
                int bx = tToInt(b.x);
                int by = tToInt(b.y);
                int bz = tToInt(b.z);
                return new tvec3<T>(intToT(ax * bx), intToT(ay * by), intToT(az * bz));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a);
                long ay = tToLong(a);
                long az = tToLong(a);
                long bx = tToLong(b.x);
                long by = tToLong(b.y);
                long bz = tToLong(b.z);
                return new tvec3<T>(longToT(ax * bx), longToT(ay * by), longToT(az * bz));
            }
            throw new TypeLoadException();
        }


#if TEMPLATE_DIVISION_ENABLED
        public static tvec3<T> operator /(T a, tvec3<T> b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a);
                float ay = tToFloat(a);
                float az = tToFloat(a);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                float bz = tToFloat(b.z);
                return new tvec3<T>(floatToT(ax / bx), floatToT(ay / by), floatToT(az / bz));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a);
                double ay = tToDouble(a);
                double az = tToDouble(a);
                double bx = tToDouble(b.x);
                double by = tToDouble(b.y);
                double bz = tToDouble(b.z);
                return new tvec3<T>(doubleToT(ax / bx), doubleToT(ay / by), doubleToT(az / bz));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a);
                decimal ay = tToDecimal(a);
                decimal az = tToDecimal(a);
                decimal bx = tToDecimal(b.x);
                decimal by = tToDecimal(b.y);
                decimal bz = tToDecimal(b.z);
                return new tvec3<T>(decimalToT(ax / bx), decimalToT(ay / by), decimalToT(az / bz));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a);
                byte ay = tToByte(a);
                byte az = tToByte(a);
                byte bx = tToByte(b.x);
                byte by = tToByte(b.y);
                byte bz = tToByte(b.z);
                return new tvec3<T>(byteToT((byte)(ax / bx)), byteToT((byte)(ay / by)), byteToT((byte)(az / bz)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a);
                short ay = tToShort(a);
                short az = tToShort(a);
                short bx = tToShort(b.x);
                short by = tToShort(b.y);
                short bz = tToShort(b.z);
                return new tvec3<T>(shortToT((short)(ax / bx)), shortToT((short)(ay / by)), shortToT((short)(az / bz)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a);
                int ay = tToInt(a);
                int az = tToInt(a);
                int bx = tToInt(b.x);
                int by = tToInt(b.y);
                int bz = tToInt(b.z);
                return new tvec3<T>(intToT(ax / bx), intToT(ay / by), intToT(az / bz));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a);
                long ay = tToLong(a);
                long az = tToLong(a);
                long bx = tToLong(b.x);
                long by = tToLong(b.y);
                long bz = tToLong(b.z);
                return new tvec3<T>(longToT(ax / bx), longToT(ay / by), longToT(az / bz));
            }
            throw new TypeLoadException();
        }
#endif

        public static tvec3<T> operator +(T a, tvec3<T> b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a);
                float ay = tToFloat(a);
                float az = tToFloat(a);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                float bz = tToFloat(b.z);
                return new tvec3<T>(floatToT(ax + bx), floatToT(ay + by), floatToT(az + bz));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a);
                double ay = tToDouble(a);
                double az = tToDouble(a);
                double bx = tToDouble(b.x);
                double by = tToDouble(b.y);
                double bz = tToDouble(b.z);
                return new tvec3<T>(doubleToT(ax + bx), doubleToT(ay + by), doubleToT(az + bz));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a);
                decimal ay = tToDecimal(a);
                decimal az = tToDecimal(a);
                decimal bx = tToDecimal(b.x);
                decimal by = tToDecimal(b.y);
                decimal bz = tToDecimal(b.z);
                return new tvec3<T>(decimalToT(ax + bx), decimalToT(ay + by), decimalToT(az + bz));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a);
                byte ay = tToByte(a);
                byte az = tToByte(a);
                byte bx = tToByte(b.x);
                byte by = tToByte(b.y);
                byte bz = tToByte(b.z);
                return new tvec3<T>(byteToT((byte)(ax + bx)), byteToT((byte)(ay + by)), byteToT((byte)(az + bz)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a);
                short ay = tToShort(a);
                short az = tToShort(a);
                short bx = tToShort(b.x);
                short by = tToShort(b.y);
                short bz = tToShort(b.z);
                return new tvec3<T>(shortToT((short)(ax + bx)), shortToT((short)(ay + by)), shortToT((short)(az + bz)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a);
                int ay = tToInt(a);
                int az = tToInt(a);
                int bx = tToInt(b.x);
                int by = tToInt(b.y);
                int bz = tToInt(b.z);
                return new tvec3<T>(intToT(ax + bx), intToT(ay + by), intToT(az + bz));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a);
                long ay = tToLong(a);
                long az = tToLong(a);
                long bx = tToLong(b.x);
                long by = tToLong(b.y);
                long bz = tToLong(b.z);
                return new tvec3<T>(longToT(ax + bx), longToT(ay + by), longToT(az + bz));
            }
            throw new TypeLoadException();
        }

        public static tvec3<T> operator -(T a, tvec3<T> b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a);
                float ay = tToFloat(a);
                float az = tToFloat(a);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                float bz = tToFloat(b.z);
                return new tvec3<T>(floatToT(ax - bx), floatToT(ay - by), floatToT(az - bz));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a);
                double ay = tToDouble(a);
                double az = tToDouble(a);
                double bx = tToDouble(b.x);
                double by = tToDouble(b.y);
                double bz = tToDouble(b.z);
                return new tvec3<T>(doubleToT(ax - bx), doubleToT(ay - by), doubleToT(az - bz));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a);
                decimal ay = tToDecimal(a);
                decimal az = tToDecimal(a);
                decimal bx = tToDecimal(b.x);
                decimal by = tToDecimal(b.y);
                decimal bz = tToDecimal(b.z);
                return new tvec3<T>(decimalToT(ax - bx), decimalToT(ay - by), decimalToT(az - bz));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a);
                byte ay = tToByte(a);
                byte az = tToByte(a);
                byte bx = tToByte(b.x);
                byte by = tToByte(b.y);
                byte bz = tToByte(b.z);
                return new tvec3<T>(byteToT((byte)(ax - bx)), byteToT((byte)(ay - by)), byteToT((byte)(az - bz)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a);
                short ay = tToShort(a);
                short az = tToShort(a);
                short bx = tToShort(b.x);
                short by = tToShort(b.y);
                short bz = tToShort(b.z);
                return new tvec3<T>(shortToT((short)(ax - bx)), shortToT((short)(ay - by)), shortToT((short)(az - bz)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a);
                int ay = tToInt(a);
                int az = tToInt(a);
                int bx = tToInt(b.x);
                int by = tToInt(b.y);
                int bz = tToInt(b.z);
                return new tvec3<T>(intToT(ax - bx), intToT(ay - by), intToT(az - bz));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a);
                long ay = tToLong(a);
                long az = tToLong(a);
                long bx = tToLong(b.x);
                long by = tToLong(b.y);
                long bz = tToLong(b.z);
                return new tvec3<T>(longToT(ax - bx), longToT(ay - by), longToT(az - bz));
            }
            throw new TypeLoadException();
        }

    }
}
#endif
#endif
#endif