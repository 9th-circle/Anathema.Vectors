#if DOUBLES_ENABLED
#if COMPLEX_ENABLED
using System;

namespace Anathema.Vectors.Core
{
    /// <summary>
    /// Double precision floating point complex number
    /// </summary>
    public class dcom
    {
        public double real { get; set; }
        public double imaginary { get; set; }

        public dcom()
        {

        }
        public dcom(double real, double imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }


        public static dcom operator +(dcom a, dcom b)
        {
            return new dcom(a.real + b.real, a.imaginary + b.imaginary);
        }
        public static dcom operator -(dcom a, dcom b)
        {
            return new dcom(a.real - b.real, a.imaginary - b.imaginary);
        }
        public static dcom operator *(dcom a, dcom b)
        {
            return new dcom((a.real * b.real) - (a.imaginary * b.imaginary),
                (a.real * b.imaginary) + (b.real * a.imaginary));
        }
        public static dcom operator /(dcom a, dcom b)
        {
            throw new NotImplementedException();
        }

        public static dcom operator +(dcom a, double b)
        {
            throw new NotImplementedException();
        }
        public static dcom operator -(dcom a, double b)
        {
            throw new NotImplementedException();
        }
        public static dcom operator *(dcom a, double b)
        {
            throw new NotImplementedException();
        }
        public static dcom operator /(dcom a, double b)
        {
            throw new NotImplementedException();
        }

        public static dcom operator +(double a, dcom b)
        {
            throw new NotImplementedException();
        }
        public static dcom operator -(double a, dcom b)
        {
            throw new NotImplementedException();
        }
        public static dcom operator *(double a, dcom b)
        {
            throw new NotImplementedException();
        }
        public static dcom operator /(double a, dcom b)
        {
            throw new NotImplementedException();
        }



        public static bool operator !=(dcom a, dcom b)
        {
            return !(a == b);
        }
        public static bool operator ==(dcom a, dcom b)
        {
            return scalar.isClose(a.real, b.real) && scalar.isClose(a.imaginary, b.imaginary);
        }
    }
}
#endif
#endif