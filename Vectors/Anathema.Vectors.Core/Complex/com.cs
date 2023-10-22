#if FLOATS_ENABLED
#if COMPLEX_ENABLED
using System;

namespace Anathema.Vectors.Core
{
    /// <summary>
    /// Single precision floating point complex number
    /// </summary>
    public class com
    {
        public override bool Equals(object o)
        {
            if (o is com)
                return ((com)o) == this;
            else
                return false;
        }
        public float real { get; set; }
        public float imaginary { get; set; }

        public com()
        {

        }
        public com(float real, float imaginary) {
            this.real = real;
            this.imaginary = imaginary;
        }

        public com(float[] ri)
        {
            this.real = ri[0];
            this.imaginary = ri[1];
        }

        public static com operator +(com a, com b) {
            return new com(a.real + b.real, a.imaginary + b.imaginary);
        }
        public static com operator -(com a, com b)
        {
            return new com(a.real - b.real, a.imaginary - b.imaginary);
        }
        public static com operator *(com a, com b)
        {
            return new com((a.real * b.real) - (a.imaginary * b.imaginary),
                (a.real * b.imaginary) + (b.real * a.imaginary));
        }
        public static com operator /(com a, com b)
        {
            return new com(
                (a.real * b.real) + (a.imaginary * b.imaginary) /
                ((b.real * b.real) + (b.imaginary * b.imaginary)),

                (a.imaginary * b.real) - (a.real * b.imaginary) /
                ((b.real * b.real) + (b.imaginary * b.imaginary)));
        }

        public static com operator +(com a, float b)
        {
            throw new NotImplementedException();
        }
        public static com operator -(com a, float b)
        {
            throw new NotImplementedException();
        }
        public static com operator *(com a, float b)
        {
            throw new NotImplementedException();
        }
        public static com operator /(com a, float b)
        {
            throw new NotImplementedException();
        }

        public static com operator +(float a, com b)
        {
            throw new NotImplementedException();
        }
        public static com operator -(float a, com b)
        {
            throw new NotImplementedException();
        }
        public static com operator *(float a, com b)
        {
            throw new NotImplementedException();
        }
        public static com operator /(float a, com b)
        {
            throw new NotImplementedException();
        }



        public static bool operator !=(com a, com b)
        {
            return !(a == b);
        }
        public static bool operator ==(com a, com b)
        {
            if (!(a is null) && b is null)
                return false;
            if (a is null && !(b is null))
                return false;
            if (a is null && b is null)
                return true;
            return scalar.isClose(a.real, b.real) && scalar.isClose(a.imaginary, b.imaginary);
        }
    }
}
#endif
#endif