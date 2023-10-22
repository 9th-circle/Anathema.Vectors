#if TEMPLATE_OPERATIONS_ENABLED
#if TEMPLATES_ENABLED
#if THREED_ENABLED
using System;
using System.Collections.Generic;
using System.Text;

namespace Anathema.Vectors.Core
{
    public partial class tvec4<T> : tvec3<T>
    {
        public override bool Equals(object o)
        {
            if (o is tvec4<T>)
                return ((tvec4<T>)o) == this;
            else
                return false;
        }
        public static bool operator !=(tvec4<T> a, tvec4<T> b)
        {
            return !(a == b);
        }
        public static tvec4<T> operator -(tvec4<T> a)
        {
            throw new NotImplementedException();
        }
        public static bool operator ==(tvec4<T> a, tvec4<T> b)
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
                float aw = tToFloat(a.w);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                float bz = tToFloat(b.z);
                float bw = tToFloat(b.w);
                return scalar.isClose(ax, bx) && scalar.isClose(ay, by) && scalar.isClose(az, bz) && scalar.isClose(aw, bw);
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double az = tToDouble(a.z);
                double aw = tToDouble(a.w);
                double bx = tToDouble(b.x);
                double by = tToDouble(b.y);
                double bz = tToDouble(b.z);
                double bw = tToDouble(b.w);
                return scalar.isClose(ax, bx) && scalar.isClose(ay, by) && scalar.isClose(az, bz) && scalar.isClose(aw, bw);
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal az = tToDecimal(a.z);
                decimal aw = tToDecimal(a.w);
                decimal bx = tToDecimal(b.x);
                decimal by = tToDecimal(b.y);
                decimal bz = tToDecimal(b.z);
                decimal bw = tToDecimal(b.w);
                return ax == bx && ay == by && az == bz && aw == bw;
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte az = tToByte(a.z);
                byte aw = tToByte(a.w);
                byte bx = tToByte(b.x);
                byte by = tToByte(b.y);
                byte bz = tToByte(b.z);
                byte bw = tToByte(b.w);
                return ax == bx && ay == by && az == bz && aw == bw;
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short az = tToShort(a.z);
                short aw = tToShort(a.w);
                short bx = tToShort(b.x);
                short by = tToShort(b.y);
                short bz = tToShort(b.z);
                short bw = tToShort(b.w);
                return ax == bx && ay == by && az == bz && aw == bw;
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int az = tToInt(a.z);
                int aw = tToInt(a.w);
                int bx = tToInt(b.x);
                int by = tToInt(b.y);
                int bz = tToInt(b.z);
                int bw = tToInt(b.w);
                return ax == bx && ay == by && az == bz && aw == bw;
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long az = tToLong(a.z);
                long aw = tToLong(a.w);
                long bx = tToLong(b.x);
                long by = tToLong(b.y);
                long bz = tToLong(b.z);
                long bw = tToLong(b.w);
                return ax == bx && ay == by && az == bz && aw == bw;
            }
            throw new TypeLoadException();
        }

        public static tvec4<T> operator *(tvec4<T> a, tvec4<T> b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float az = tToFloat(a.z);
                float aw = tToFloat(a.w);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                float bz = tToFloat(b.z);
                float bw = tToFloat(b.w);
                return new tvec4<T>(floatToT(ax * bx), floatToT(ay * by), floatToT(az * bz), floatToT(aw * bw));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double az = tToDouble(a.z);
                double aw = tToDouble(a.w);
                double bx = tToDouble(b.x);
                double by = tToDouble(b.y);
                double bz = tToDouble(b.z);
                double bw = tToDouble(b.w);
                return new tvec4<T>(doubleToT(ax * bx), doubleToT(ay * by), doubleToT(az * bz), doubleToT(aw * bw));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal az = tToDecimal(a.z);
                decimal aw = tToDecimal(a.w);
                decimal bx = tToDecimal(b.x);
                decimal by = tToDecimal(b.y);
                decimal bz = tToDecimal(b.z);
                decimal bw = tToDecimal(b.w);
                return new tvec4<T>(decimalToT(ax * bx), decimalToT(ay * by), decimalToT(az * bz), decimalToT(aw * bw));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte az = tToByte(a.z);
                byte aw = tToByte(a.w);
                byte bx = tToByte(b.x);
                byte by = tToByte(b.y);
                byte bz = tToByte(b.z);
                byte bw = tToByte(b.w);
                return new tvec4<T>(byteToT((byte)(ax * bx)), byteToT((byte)(ay * by)), byteToT((byte)(az * bz)), byteToT((byte)(aw * bw)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short az = tToShort(a.z);
                short aw = tToShort(a.w);
                short bx = tToShort(b.x);
                short by = tToShort(b.y);
                short bz = tToShort(b.z);
                short bw = tToShort(b.w);
                return new tvec4<T>(shortToT((short)(ax * bx)), shortToT((short)(ay * by)), shortToT((short)(az * bz)), shortToT((short)(aw * bw)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int az = tToInt(a.z);
                int aw = tToInt(a.w);
                int bx = tToInt(b.x);
                int by = tToInt(b.y);
                int bz = tToInt(b.z);
                int bw = tToInt(b.w);
                return new tvec4<T>(intToT(ax * bx), intToT(ay * by), intToT(az * bz), intToT(aw * bw));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long az = tToLong(a.z);
                long aw = tToLong(a.w);
                long bx = tToLong(b.x);
                long by = tToLong(b.y);
                long bz = tToLong(b.z);
                long bw = tToLong(b.w);
                return new tvec4<T>(longToT(ax * bx), longToT(ay * by), longToT(az * bz), longToT(aw * bw));
            }
            throw new TypeLoadException();
        }

#if INTEGER_DIVISION_ENABLED
        public static tvec4<T> operator /(tvec4<T> a, tvec4<T> b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float az = tToFloat(a.z);
                float aw = tToFloat(a.w);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                float bz = tToFloat(b.z);
                float bw = tToFloat(b.w);
                return new tvec4<T>(floatToT(ax / bx), floatToT(ay / by), floatToT(az / bz), floatToT(aw / bw));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double az = tToDouble(a.z);
                double aw = tToDouble(a.w);
                double bx = tToDouble(b.x);
                double by = tToDouble(b.y);
                double bz = tToDouble(b.z);
                double bw = tToDouble(b.w);
                return new tvec4<T>(doubleToT(ax / bx), doubleToT(ay / by), doubleToT(az / bz), doubleToT(aw / bw));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal az = tToDecimal(a.z);
                decimal aw = tToDecimal(a.w);
                decimal bx = tToDecimal(b.x);
                decimal by = tToDecimal(b.y);
                decimal bz = tToDecimal(b.z);
                decimal bw = tToDecimal(b.w);
                return new tvec4<T>(decimalToT(ax / bx), decimalToT(ay / by), decimalToT(az / bz), decimalToT(aw / bw));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte az = tToByte(a.z);
                byte aw = tToByte(a.w);
                byte bx = tToByte(b.x);
                byte by = tToByte(b.y);
                byte bz = tToByte(b.z);
                byte bw = tToByte(b.w);
                return new tvec4<T>(byteToT((byte)(ax / bx)), byteToT((byte)(ay / by)), byteToT((byte)(az / bz)), byteToT((byte)(aw / bw)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short az = tToShort(a.z);
                short aw = tToShort(a.w);
                short bx = tToShort(b.x);
                short by = tToShort(b.y);
                short bz = tToShort(b.z);
                short bw = tToShort(b.w);
                return new tvec4<T>(shortToT((short)(ax / bx)), shortToT((short)(ay / by)), shortToT((short)(az / bz)), shortToT((short)(aw / bw)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int az = tToInt(a.z);
                int aw = tToInt(a.w);
                int bx = tToInt(b.x);
                int by = tToInt(b.y);
                int bz = tToInt(b.z);
                int bw = tToInt(b.w);
                return new tvec4<T>(intToT(ax / bx), intToT(ay / by), intToT(az / bz), intToT(aw / bw));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long az = tToLong(a.z);
                long aw = tToLong(a.w);
                long bx = tToLong(b.x);
                long by = tToLong(b.y);
                long bz = tToLong(b.z);
                long bw = tToLong(b.w);
                return new tvec4<T>(longToT(ax / bx), longToT(ay / by), longToT(az / bz), longToT(aw / bw));
            }
            throw new TypeLoadException();
        }
#endif


        public static tvec4<T> operator +(tvec4<T> a, tvec4<T> b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float az = tToFloat(a.z);
                float aw = tToFloat(a.w);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                float bz = tToFloat(b.z);
                float bw = tToFloat(b.w);
                return new tvec4<T>(floatToT(ax + bx), floatToT(ay + by), floatToT(az + bz), floatToT(aw + bw));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double az = tToDouble(a.z);
                double aw = tToDouble(a.w);
                double bx = tToDouble(b.x);
                double by = tToDouble(b.y);
                double bz = tToDouble(b.z);
                double bw = tToDouble(b.w);
                return new tvec4<T>(doubleToT(ax + bx), doubleToT(ay + by), doubleToT(az + bz), doubleToT(aw + bw));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal az = tToDecimal(a.z);
                decimal aw = tToDecimal(a.w);
                decimal bx = tToDecimal(b.x);
                decimal by = tToDecimal(b.y);
                decimal bz = tToDecimal(b.z);
                decimal bw = tToDecimal(b.w);
                return new tvec4<T>(decimalToT(ax + bx), decimalToT(ay + by), decimalToT(az + bz), decimalToT(aw + bw));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte az = tToByte(a.z);
                byte aw = tToByte(a.w);
                byte bx = tToByte(b.x);
                byte by = tToByte(b.y);
                byte bz = tToByte(b.z);
                byte bw = tToByte(b.w);
                return new tvec4<T>(byteToT((byte)(ax + bx)), byteToT((byte)(ay + by)), byteToT((byte)(az + bz)), byteToT((byte)(aw + bw)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short az = tToShort(a.z);
                short aw = tToShort(a.w);
                short bx = tToShort(b.x);
                short by = tToShort(b.y);
                short bz = tToShort(b.z);
                short bw = tToShort(b.w);
                return new tvec4<T>(shortToT((short)(ax + bx)), shortToT((short)(ay + by)), shortToT((short)(az + bz)), shortToT((short)(aw + bw)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int az = tToInt(a.z);
                int aw = tToInt(a.w);
                int bx = tToInt(b.x);
                int by = tToInt(b.y);
                int bz = tToInt(b.z);
                int bw = tToInt(b.w);
                return new tvec4<T>(intToT(ax + bx), intToT(ay + by), intToT(az + bz), intToT(aw + bw));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long az = tToLong(a.z);
                long aw = tToLong(a.w);
                long bx = tToLong(b.x);
                long by = tToLong(b.y);
                long bz = tToLong(b.z);
                long bw = tToLong(b.w);
                return new tvec4<T>(longToT(ax + bx), longToT(ay + by), longToT(az + bz), longToT(aw + bw));
            }
            throw new TypeLoadException();
        }

        public static tvec4<T> operator -(tvec4<T> a, tvec4<T> b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float az = tToFloat(a.z);
                float aw = tToFloat(a.w);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                float bz = tToFloat(b.z);
                float bw = tToFloat(b.w);
                return new tvec4<T>(floatToT(ax - bx), floatToT(ay - by), floatToT(az - bz), floatToT(aw - bw));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double az = tToDouble(a.z);
                double aw = tToDouble(a.w);
                double bx = tToDouble(b.x);
                double by = tToDouble(b.y);
                double bz = tToDouble(b.z);
                double bw = tToDouble(b.w);
                return new tvec4<T>(doubleToT(ax - bx), doubleToT(ay - by), doubleToT(az - bz), doubleToT(aw - bw));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal az = tToDecimal(a.z);
                decimal aw = tToDecimal(a.w);
                decimal bx = tToDecimal(b.x);
                decimal by = tToDecimal(b.y);
                decimal bz = tToDecimal(b.z);
                decimal bw = tToDecimal(b.w);
                return new tvec4<T>(decimalToT(ax - bx), decimalToT(ay - by), decimalToT(az - bz), decimalToT(aw - bw));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte az = tToByte(a.z);
                byte aw = tToByte(a.w);
                byte bx = tToByte(b.x);
                byte by = tToByte(b.y);
                byte bz = tToByte(b.z);
                byte bw = tToByte(b.w);
                return new tvec4<T>(byteToT((byte)(ax - bx)), byteToT((byte)(ay - by)), byteToT((byte)(az - bz)), byteToT((byte)(aw - bw)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short az = tToShort(a.z);
                short aw = tToShort(a.w);
                short bx = tToShort(b.x);
                short by = tToShort(b.y);
                short bz = tToShort(b.z);
                short bw = tToShort(b.w);
                return new tvec4<T>(shortToT((short)(ax - bx)), shortToT((short)(ay - by)), shortToT((short)(az - bz)), shortToT((short)(aw - bw)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int az = tToInt(a.z);
                int aw = tToInt(a.w);
                int bx = tToInt(b.x);
                int by = tToInt(b.y);
                int bz = tToInt(b.z);
                int bw = tToInt(b.w);
                return new tvec4<T>(intToT(ax - bx), intToT(ay - by), intToT(az - bz), intToT(aw - bw));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long az = tToLong(a.z);
                long aw = tToLong(a.w);
                long bx = tToLong(b.x);
                long by = tToLong(b.y);
                long bz = tToLong(b.z);
                long bw = tToLong(b.w);
                return new tvec4<T>(longToT(ax - bx), longToT(ay - by), longToT(az - bz), longToT(aw - bw));
            }
            throw new TypeLoadException();
        }









        public static tvec4<T> operator *(tvec4<T> a, T b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float az = tToFloat(a.z);
                float aw = tToFloat(a.w);
                float bx = tToFloat(b);
                float by = tToFloat(b);
                float bz = tToFloat(b);
                float bw = tToFloat(b);
                return new tvec4<T>(floatToT(ax * bx), floatToT(ay * by), floatToT(az * bz), floatToT(aw * bw));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double az = tToDouble(a.z);
                double aw = tToDouble(a.w);
                double bx = tToDouble(b);
                double by = tToDouble(b);
                double bz = tToDouble(b);
                double bw = tToDouble(b);
                return new tvec4<T>(doubleToT(ax * bx), doubleToT(ay * by), doubleToT(az * bz), doubleToT(aw * bw));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal az = tToDecimal(a.z);
                decimal aw = tToDecimal(a.w);
                decimal bx = tToDecimal(b);
                decimal by = tToDecimal(b);
                decimal bz = tToDecimal(b);
                decimal bw = tToDecimal(b);
                return new tvec4<T>(decimalToT(ax * bx), decimalToT(ay * by), decimalToT(az * bz), decimalToT(aw * bw));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte az = tToByte(a.z);
                byte aw = tToByte(a.w);
                byte bx = tToByte(b);
                byte by = tToByte(b);
                byte bz = tToByte(b);
                byte bw = tToByte(b);
                return new tvec4<T>(byteToT((byte)(ax * bx)), byteToT((byte)(ay * by)), byteToT((byte)(az * bz)), byteToT((byte)(aw * bw)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short az = tToShort(a.z);
                short aw = tToShort(a.w);
                short bx = tToShort(b);
                short by = tToShort(b);
                short bz = tToShort(b);
                short bw = tToShort(b);
                return new tvec4<T>(shortToT((short)(ax * bx)), shortToT((short)(ay * by)), shortToT((short)(az * bz)), shortToT((short)(aw * bw)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int az = tToInt(a.z);
                int aw = tToInt(a.w);
                int bx = tToInt(b);
                int by = tToInt(b);
                int bz = tToInt(b);
                int bw = tToInt(b);
                return new tvec4<T>(intToT(ax * bx), intToT(ay * by), intToT(az * bz), intToT(aw * bw));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long az = tToLong(a.z);
                long aw = tToLong(a.w);
                long bx = tToLong(b);
                long by = tToLong(b);
                long bz = tToLong(b);
                long bw = tToLong(b);
                return new tvec4<T>(longToT(ax * bx), longToT(ay * by), longToT(az * bz), longToT(aw * bw));
            }
            throw new TypeLoadException();
        }

#if INTEGER_DIVISION_ENABLED
        public static tvec4<T> operator /(tvec4<T> a, T b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float az = tToFloat(a.z);
                float aw = tToFloat(a.w);
                float bx = tToFloat(b);
                float by = tToFloat(b);
                float bz = tToFloat(b);
                float bw = tToFloat(b);
                return new tvec4<T>(floatToT(ax / bx), floatToT(ay / by), floatToT(az / bz), floatToT(aw / bw));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double az = tToDouble(a.z);
                double aw = tToDouble(a.w);
                double bx = tToDouble(b);
                double by = tToDouble(b);
                double bz = tToDouble(b);
                double bw = tToDouble(b);
                return new tvec4<T>(doubleToT(ax / bx), doubleToT(ay / by), doubleToT(az / bz), doubleToT(aw / bw));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal az = tToDecimal(a.z);
                decimal aw = tToDecimal(a.w);
                decimal bx = tToDecimal(b);
                decimal by = tToDecimal(b);
                decimal bz = tToDecimal(b);
                decimal bw = tToDecimal(b);
                return new tvec4<T>(decimalToT(ax / bx), decimalToT(ay / by), decimalToT(az / bz), decimalToT(aw / bw));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte az = tToByte(a.z);
                byte aw = tToByte(a.w);
                byte bx = tToByte(b);
                byte by = tToByte(b);
                byte bz = tToByte(b);
                byte bw = tToByte(b);
                return new tvec4<T>(byteToT((byte)(ax / bx)), byteToT((byte)(ay / by)), byteToT((byte)(az / bz)), byteToT((byte)(aw / bw)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short az = tToShort(a.z);
                short aw = tToShort(a.w);
                short bx = tToShort(b);
                short by = tToShort(b);
                short bz = tToShort(b);
                short bw = tToShort(b);
                return new tvec4<T>(shortToT((short)(ax / bx)), shortToT((short)(ay / by)), shortToT((short)(az / bz)), shortToT((short)(aw / bw)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int az = tToInt(a.z);
                int aw = tToInt(a.w);
                int bx = tToInt(b);
                int by = tToInt(b);
                int bz = tToInt(b);
                int bw = tToInt(b);
                return new tvec4<T>(intToT(ax / bx), intToT(ay / by), intToT(az / bz), intToT(aw / bw));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long az = tToLong(a.z);
                long aw = tToLong(a.w);
                long bx = tToLong(b);
                long by = tToLong(b);
                long bz = tToLong(b);
                long bw = tToLong(b);
                return new tvec4<T>(longToT(ax / bx), longToT(ay / by), longToT(az / bz), longToT(aw / bw));
            }
            throw new TypeLoadException();
        }
#endif

        public static tvec4<T> operator +(tvec4<T> a, T b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float az = tToFloat(a.z);
                float aw = tToFloat(a.w);
                float bx = tToFloat(b);
                float by = tToFloat(b);
                float bz = tToFloat(b);
                float bw = tToFloat(b);
                return new tvec4<T>(floatToT(ax + bx), floatToT(ay + by), floatToT(az + bz), floatToT(aw + bw));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double az = tToDouble(a.z);
                double aw = tToDouble(a.w);
                double bx = tToDouble(b);
                double by = tToDouble(b);
                double bz = tToDouble(b);
                double bw = tToDouble(b);
                return new tvec4<T>(doubleToT(ax + bx), doubleToT(ay + by), doubleToT(az + bz), doubleToT(aw + bw));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal az = tToDecimal(a.z);
                decimal aw = tToDecimal(a.w);
                decimal bx = tToDecimal(b);
                decimal by = tToDecimal(b);
                decimal bz = tToDecimal(b);
                decimal bw = tToDecimal(b);
                return new tvec4<T>(decimalToT(ax + bx), decimalToT(ay + by), decimalToT(az + bz), decimalToT(aw + bw));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte az = tToByte(a.z);
                byte aw = tToByte(a.w);
                byte bx = tToByte(b);
                byte by = tToByte(b);
                byte bz = tToByte(b);
                byte bw = tToByte(b);
                return new tvec4<T>(byteToT((byte)(ax + bx)), byteToT((byte)(ay + by)), byteToT((byte)(az + bz)), byteToT((byte)(aw + bw)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short az = tToShort(a.z);
                short aw = tToShort(a.w);
                short bx = tToShort(b);
                short by = tToShort(b);
                short bz = tToShort(b);
                short bw = tToShort(b);
                return new tvec4<T>(shortToT((short)(ax + bx)), shortToT((short)(ay + by)), shortToT((short)(az + bz)), shortToT((short)(aw + bw)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int az = tToInt(a.z);
                int aw = tToInt(a.w);
                int bx = tToInt(b);
                int by = tToInt(b);
                int bz = tToInt(b);
                int bw = tToInt(b);
                return new tvec4<T>(intToT(ax + bx), intToT(ay + by), intToT(az + bz), intToT(aw + bw));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long az = tToLong(a.z);
                long aw = tToLong(a.w);
                long bx = tToLong(b);
                long by = tToLong(b);
                long bz = tToLong(b);
                long bw = tToLong(b);
                return new tvec4<T>(longToT(ax + bx), longToT(ay + by), longToT(az + bz), longToT(aw + bw));
            }
            throw new TypeLoadException();
        }

        public static tvec4<T> operator -(tvec4<T> a, T b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a.x);
                float ay = tToFloat(a.y);
                float az = tToFloat(a.z);
                float aw = tToFloat(a.w);
                float bx = tToFloat(b);
                float by = tToFloat(b);
                float bz = tToFloat(b);
                float bw = tToFloat(b);
                return new tvec4<T>(floatToT(ax - bx), floatToT(ay - by), floatToT(az - bz), floatToT(aw - bw));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a.x);
                double ay = tToDouble(a.y);
                double az = tToDouble(a.z);
                double aw = tToDouble(a.w);
                double bx = tToDouble(b);
                double by = tToDouble(b);
                double bz = tToDouble(b);
                double bw = tToDouble(b);
                return new tvec4<T>(doubleToT(ax - bx), doubleToT(ay - by), doubleToT(az - bz), doubleToT(aw - bw));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a.x);
                decimal ay = tToDecimal(a.y);
                decimal az = tToDecimal(a.z);
                decimal aw = tToDecimal(a.w);
                decimal bx = tToDecimal(b);
                decimal by = tToDecimal(b);
                decimal bz = tToDecimal(b);
                decimal bw = tToDecimal(b);
                return new tvec4<T>(decimalToT(ax - bx), decimalToT(ay - by), decimalToT(az - bz), decimalToT(aw - bw));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a.x);
                byte ay = tToByte(a.y);
                byte az = tToByte(a.z);
                byte aw = tToByte(a.w);
                byte bx = tToByte(b);
                byte by = tToByte(b);
                byte bz = tToByte(b);
                byte bw = tToByte(b);
                return new tvec4<T>(byteToT((byte)(ax - bx)), byteToT((byte)(ay - by)), byteToT((byte)(az - bz)), byteToT((byte)(aw - bw)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a.x);
                short ay = tToShort(a.y);
                short az = tToShort(a.z);
                short aw = tToShort(a.w);
                short bx = tToShort(b);
                short by = tToShort(b);
                short bz = tToShort(b);
                short bw = tToShort(b);
                return new tvec4<T>(shortToT((short)(ax - bx)), shortToT((short)(ay - by)), shortToT((short)(az - bz)), shortToT((short)(aw - bw)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a.x);
                int ay = tToInt(a.y);
                int az = tToInt(a.z);
                int aw = tToInt(a.w);
                int bx = tToInt(b);
                int by = tToInt(b);
                int bz = tToInt(b);
                int bw = tToInt(b);
                return new tvec4<T>(intToT(ax - bx), intToT(ay - by), intToT(az - bz), intToT(aw - bw));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a.x);
                long ay = tToLong(a.y);
                long az = tToLong(a.z);
                long aw = tToLong(a.w);
                long bx = tToLong(b);
                long by = tToLong(b);
                long bz = tToLong(b);
                long bw = tToLong(b);
                return new tvec4<T>(longToT(ax - bx), longToT(ay - by), longToT(az - bz), longToT(aw - bw));
            }
            throw new TypeLoadException();
        }












        public static tvec4<T> operator *(T a, tvec4<T> b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a);
                float ay = tToFloat(a);
                float az = tToFloat(a);
                float aw = tToFloat(a);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                float bz = tToFloat(b.z);
                float bw = tToFloat(b.w);
                return new tvec4<T>(floatToT(ax * bx), floatToT(ay * by), floatToT(az * bz), floatToT(aw * bw));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a);
                double ay = tToDouble(a);
                double az = tToDouble(a);
                double aw = tToDouble(a);
                double bx = tToDouble(b.x);
                double by = tToDouble(b.y);
                double bz = tToDouble(b.z);
                double bw = tToDouble(b.w);
                return new tvec4<T>(doubleToT(ax * bx), doubleToT(ay * by), doubleToT(az * bz), doubleToT(aw * bw));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a);
                decimal ay = tToDecimal(a);
                decimal az = tToDecimal(a);
                decimal aw = tToDecimal(a);
                decimal bx = tToDecimal(b.x);
                decimal by = tToDecimal(b.y);
                decimal bz = tToDecimal(b.z);
                decimal bw = tToDecimal(b.w);
                return new tvec4<T>(decimalToT(ax * bx), decimalToT(ay * by), decimalToT(az * bz), decimalToT(aw * bw));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a);
                byte ay = tToByte(a);
                byte az = tToByte(a);
                byte aw = tToByte(a);
                byte bx = tToByte(b.x);
                byte by = tToByte(b.y);
                byte bz = tToByte(b.z);
                byte bw = tToByte(b.w);
                return new tvec4<T>(byteToT((byte)(ax * bx)), byteToT((byte)(ay * by)), byteToT((byte)(az * bz)), byteToT((byte)(aw * bw)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a);
                short ay = tToShort(a);
                short az = tToShort(a);
                short aw = tToShort(a);
                short bx = tToShort(b.x);
                short by = tToShort(b.y);
                short bz = tToShort(b.z);
                short bw = tToShort(b.w);
                return new tvec4<T>(shortToT((short)(ax * bx)), shortToT((short)(ay * by)), shortToT((short)(az * bz)), shortToT((short)(aw * bw)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a);
                int ay = tToInt(a);
                int az = tToInt(a);
                int aw = tToInt(a);
                int bx = tToInt(b.x);
                int by = tToInt(b.y);
                int bz = tToInt(b.z);
                int bw = tToInt(b.w);
                return new tvec4<T>(intToT(ax * bx), intToT(ay * by), intToT(az * bz), intToT(aw * bw));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a);
                long ay = tToLong(a);
                long az = tToLong(a);
                long aw = tToLong(a);
                long bx = tToLong(b.x);
                long by = tToLong(b.y);
                long bz = tToLong(b.z);
                long bw = tToLong(b.w);
                return new tvec4<T>(longToT(ax * bx), longToT(ay * by), longToT(az * bz), longToT(aw * bw));
            }
            throw new TypeLoadException();
        }

#if INTEGER_DIVISION_ENABLED
        public static tvec4<T> operator /(T a, tvec4<T> b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a);
                float ay = tToFloat(a);
                float az = tToFloat(a);
                float aw = tToFloat(a);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                float bz = tToFloat(b.z);
                float bw = tToFloat(b.w);
                return new tvec4<T>(floatToT(ax / bx), floatToT(ay / by), floatToT(az / bz), floatToT(aw / bw));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a);
                double ay = tToDouble(a);
                double az = tToDouble(a);
                double aw = tToDouble(a);
                double bx = tToDouble(b.x);
                double by = tToDouble(b.y);
                double bz = tToDouble(b.z);
                double bw = tToDouble(b.w);
                return new tvec4<T>(doubleToT(ax / bx), doubleToT(ay / by), doubleToT(az / bz), doubleToT(aw / bw));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a);
                decimal ay = tToDecimal(a);
                decimal az = tToDecimal(a);
                decimal aw = tToDecimal(a);
                decimal bx = tToDecimal(b.x);
                decimal by = tToDecimal(b.y);
                decimal bz = tToDecimal(b.z);
                decimal bw = tToDecimal(b.w);
                return new tvec4<T>(decimalToT(ax / bx), decimalToT(ay / by), decimalToT(az / bz), decimalToT(aw / bw));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a);
                byte ay = tToByte(a);
                byte az = tToByte(a);
                byte aw = tToByte(a);
                byte bx = tToByte(b.x);
                byte by = tToByte(b.y);
                byte bz = tToByte(b.z);
                byte bw = tToByte(b.w);
                return new tvec4<T>(byteToT((byte)(ax / bx)), byteToT((byte)(ay / by)), byteToT((byte)(az / bz)), byteToT((byte)(aw / bw)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a);
                short ay = tToShort(a);
                short az = tToShort(a);
                short aw = tToShort(a);
                short bx = tToShort(b.x);
                short by = tToShort(b.y);
                short bz = tToShort(b.z);
                short bw = tToShort(b.w);
                return new tvec4<T>(shortToT((short)(ax / bx)), shortToT((short)(ay / by)), shortToT((short)(az / bz)), shortToT((short)(aw / bw)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a);
                int ay = tToInt(a);
                int az = tToInt(a);
                int aw = tToInt(a);
                int bx = tToInt(b.x);
                int by = tToInt(b.y);
                int bz = tToInt(b.z);
                int bw = tToInt(b.w);
                return new tvec4<T>(intToT(ax / bx), intToT(ay / by), intToT(az / bz), intToT(aw / bw));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a);
                long ay = tToLong(a);
                long az = tToLong(a);
                long aw = tToLong(a);
                long bx = tToLong(b.x);
                long by = tToLong(b.y);
                long bz = tToLong(b.z);
                long bw = tToLong(b.w);
                return new tvec4<T>(longToT(ax / bx), longToT(ay / by), longToT(az / bz), longToT(aw / bw));
            }
            throw new TypeLoadException();
        }
#endif

        public static tvec4<T> operator +(T a, tvec4<T> b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a);
                float ay = tToFloat(a);
                float az = tToFloat(a);
                float aw = tToFloat(a);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                float bz = tToFloat(b.z);
                float bw = tToFloat(b.w);
                return new tvec4<T>(floatToT(ax + bx), floatToT(ay + by), floatToT(az + bz), floatToT(aw + bw));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a);
                double ay = tToDouble(a);
                double az = tToDouble(a);
                double aw = tToDouble(a);
                double bx = tToDouble(b.x);
                double by = tToDouble(b.y);
                double bz = tToDouble(b.z);
                double bw = tToDouble(b.w);
                return new tvec4<T>(doubleToT(ax + bx), doubleToT(ay + by), doubleToT(az + bz), doubleToT(aw + bw));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a);
                decimal ay = tToDecimal(a);
                decimal az = tToDecimal(a);
                decimal aw = tToDecimal(a);
                decimal bx = tToDecimal(b.x);
                decimal by = tToDecimal(b.y);
                decimal bz = tToDecimal(b.z);
                decimal bw = tToDecimal(b.w);
                return new tvec4<T>(decimalToT(ax + bx), decimalToT(ay + by), decimalToT(az + bz), decimalToT(aw + bw));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a);
                byte ay = tToByte(a);
                byte az = tToByte(a);
                byte aw = tToByte(a);
                byte bx = tToByte(b.x);
                byte by = tToByte(b.y);
                byte bz = tToByte(b.z);
                byte bw = tToByte(b.w);
                return new tvec4<T>(byteToT((byte)(ax + bx)), byteToT((byte)(ay + by)), byteToT((byte)(az + bz)), byteToT((byte)(aw + bw)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a);
                short ay = tToShort(a);
                short az = tToShort(a);
                short aw = tToShort(a);
                short bx = tToShort(b.x);
                short by = tToShort(b.y);
                short bz = tToShort(b.z);
                short bw = tToShort(b.w);
                return new tvec4<T>(shortToT((short)(ax + bx)), shortToT((short)(ay + by)), shortToT((short)(az + bz)), shortToT((short)(aw + bw)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a);
                int ay = tToInt(a);
                int az = tToInt(a);
                int aw = tToInt(a);
                int bx = tToInt(b.x);
                int by = tToInt(b.y);
                int bz = tToInt(b.z);
                int bw = tToInt(b.w);
                return new tvec4<T>(intToT(ax + bx), intToT(ay + by), intToT(az + bz), intToT(aw + bw));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a);
                long ay = tToLong(a);
                long az = tToLong(a);
                long aw = tToLong(a);
                long bx = tToLong(b.x);
                long by = tToLong(b.y);
                long bz = tToLong(b.z);
                long bw = tToLong(b.w);
                return new tvec4<T>(longToT(ax + bx), longToT(ay + by), longToT(az + bz), longToT(aw + bw));
            }
            throw new TypeLoadException();
        }

        public static tvec4<T> operator -(T a, tvec4<T> b)
        {
            if (typeof(T) == typeof(float))
            {
                float ax = tToFloat(a);
                float ay = tToFloat(a);
                float az = tToFloat(a);
                float aw = tToFloat(a);
                float bx = tToFloat(b.x);
                float by = tToFloat(b.y);
                float bz = tToFloat(b.z);
                float bw = tToFloat(b.w);
                return new tvec4<T>(floatToT(ax - bx), floatToT(ay - by), floatToT(az - bz), floatToT(aw - bw));
            }
            if (typeof(T) == typeof(double))
            {
                double ax = tToDouble(a);
                double ay = tToDouble(a);
                double az = tToDouble(a);
                double aw = tToDouble(a);
                double bx = tToDouble(b.x);
                double by = tToDouble(b.y);
                double bz = tToDouble(b.z);
                double bw = tToDouble(b.w);
                return new tvec4<T>(doubleToT(ax - bx), doubleToT(ay - by), doubleToT(az - bz), doubleToT(aw - bw));
            }
            if (typeof(T) == typeof(decimal))
            {
                decimal ax = tToDecimal(a);
                decimal ay = tToDecimal(a);
                decimal az = tToDecimal(a);
                decimal aw = tToDecimal(a);
                decimal bx = tToDecimal(b.x);
                decimal by = tToDecimal(b.y);
                decimal bz = tToDecimal(b.z);
                decimal bw = tToDecimal(b.w);
                return new tvec4<T>(decimalToT(ax - bx), decimalToT(ay - by), decimalToT(az - bz), decimalToT(aw - bw));
            }
            if (typeof(T) == typeof(byte))
            {
                byte ax = tToByte(a);
                byte ay = tToByte(a);
                byte az = tToByte(a);
                byte aw = tToByte(a);
                byte bx = tToByte(b.x);
                byte by = tToByte(b.y);
                byte bz = tToByte(b.z);
                byte bw = tToByte(b.w);
                return new tvec4<T>(byteToT((byte)(ax - bx)), byteToT((byte)(ay - by)), byteToT((byte)(az - bz)), byteToT((byte)(aw - bw)));
            }
            if (typeof(T) == typeof(short))
            {
                short ax = tToShort(a);
                short ay = tToShort(a);
                short az = tToShort(a);
                short aw = tToShort(a);
                short bx = tToShort(b.x);
                short by = tToShort(b.y);
                short bz = tToShort(b.z);
                short bw = tToShort(b.w);
                return new tvec4<T>(shortToT((short)(ax - bx)), shortToT((short)(ay - by)), shortToT((short)(az - bz)), shortToT((short)(aw - bw)));
            }
            if (typeof(T) == typeof(int))
            {
                int ax = tToInt(a);
                int ay = tToInt(a);
                int az = tToInt(a);
                int aw = tToInt(a);
                int bx = tToInt(b.x);
                int by = tToInt(b.y);
                int bz = tToInt(b.z);
                int bw = tToInt(b.w);
                return new tvec4<T>(intToT(ax - bx), intToT(ay - by), intToT(az - bz), intToT(aw - bw));
            }
            if (typeof(T) == typeof(long))
            {
                long ax = tToLong(a);
                long ay = tToLong(a);
                long az = tToLong(a);
                long aw = tToLong(a);
                long bx = tToLong(b.x);
                long by = tToLong(b.y);
                long bz = tToLong(b.z);
                long bw = tToLong(b.w);
                return new tvec4<T>(longToT(ax - bx), longToT(ay - by), longToT(az - bz), longToT(aw - bw));
            }
            throw new TypeLoadException();
        }




    }
}

#endif
#endif
#endif