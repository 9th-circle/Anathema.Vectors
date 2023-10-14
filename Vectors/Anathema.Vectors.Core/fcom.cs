#if FLOATS_ENABLED
#if COMPLEX_ENABLED
using System;

namespace Anathema.Vectors.Core
{
    /// <summary>
    /// Single precision floating point complex number
    /// </summary>
    public class fcom
    {
        public float real { get; set; }
        public float imaginary { get; set; }

        public fcom()
        {

        }
        public fcom(float real, float imaginary) {
            this.real = real;
            this.imaginary = imaginary;
        }

        public fcom(float[] ri)
        {
            this.real = ri[0];
            this.imaginary = ri[1];
        }

        public static fcom operator +(fcom a, fcom b) {
            return new fcom(a.real + b.real, a.imaginary + b.imaginary);
        }
        public static fcom operator -(fcom a, fcom b)
        {
            return new fcom(a.real - b.real, a.imaginary - b.imaginary);
        }
        public static fcom operator *(fcom a, fcom b)
        {
            return new fcom((a.real * b.real) - (a.imaginary * b.imaginary),
                (a.real * b.imaginary) + (b.real * a.imaginary));
        }
        public static fcom operator /(fcom a, fcom b)
        {
            return new fcom(
                (a.real * b.real) + (a.imaginary * b.imaginary) /
                ((b.real * b.real) + (b.imaginary * b.imaginary)),

                (a.imaginary * b.real) - (a.real * b.imaginary) /
                ((b.real * b.real) + (b.imaginary * b.imaginary)));
        }

        public static fcom operator +(fcom a, float b)
        {
            throw new NotImplementedException();
        }
        public static fcom operator -(fcom a, float b)
        {
            throw new NotImplementedException();
        }
        public static fcom operator *(fcom a, float b)
        {
            throw new NotImplementedException();
        }
        public static fcom operator /(fcom a, float b)
        {
            throw new NotImplementedException();
        }

        public static fcom operator +(float a, fcom b)
        {
            throw new NotImplementedException();
        }
        public static fcom operator -(float a, fcom b)
        {
            throw new NotImplementedException();
        }
        public static fcom operator *(float a, fcom b)
        {
            throw new NotImplementedException();
        }
        public static fcom operator /(float a, fcom b)
        {
            throw new NotImplementedException();
        }



        public static bool operator !=(fcom a, fcom b)
        {
            return !(a == b);
        }
        public static bool operator ==(fcom a, fcom b)
        {
            if (!(a is null) && b is null)
                return false;
            if (a is null && b is null)
                return true;
            return scalar.isClose(a.real, b.real) && scalar.isClose(a.imaginary, b.imaginary);
        }
    }
}
#endif
#endif