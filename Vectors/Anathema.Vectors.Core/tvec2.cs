#if TEMPLATES_ENABLED
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        ///////////////////////////
        //      Conversions      //
        ///////////////////////////


#if NESTING_ENABLED
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


        public fvec2 floatTVec2ToFVec2()
        {
            if (typeof(T) != typeof(float))
                throw new ArgumentException();
            
            throw new NotImplementedException();
        }

        public dvec2 doubleTVec2ToDVec2()
        {
            if (typeof(T) != typeof(double))
                throw new ArgumentException();

            throw new NotImplementedException();
        }



        ///////////////////////////
        //       Operators       //
        ///////////////////////////


        protected int tToByte(T a)
        {
            return (int)Convert.ChangeType(a, typeof(int));
        }
        protected int tToShort(T a)
        {
            return (int)Convert.ChangeType(a, typeof(int));
        }
        protected int tToInt(T a)
        {
            return (int)Convert.ChangeType(a, typeof(int));
        }

        protected int tToLong(T a)
        {
            return (int)Convert.ChangeType(a, typeof(int));
        }
        protected int tToDecimal(T a)
        {
            return (int)Convert.ChangeType(a, typeof(decimal));
        }
        protected int tToFloat(T a)
        {
            return (int)Convert.ChangeType(a, typeof(float));
        }
        protected int tToDouble(T a)
        {
            return (int)Convert.ChangeType(a, typeof(double));
        }



        protected T byteToT(byte a)
        {
            return (T)Convert.ChangeType(a, typeof(T));
        }
        protected T shortToT(short a)
        {
            return (T)Convert.ChangeType(a, typeof(T));
        }
        protected T intToT(int a)
        {
            return (T)Convert.ChangeType(a, typeof(T));
        }
        protected T longToT(long a)
        {
            return (T)Convert.ChangeType(a, typeof(T));
        }
        protected T decimalToT(decimal a)
        {
            return (T)Convert.ChangeType(a, typeof(T));
        }
        protected T floatToT(float a)
        {
            return (T)Convert.ChangeType(a, typeof(T));
        }
        protected T doubleToT(double a)
        {
            return (T)Convert.ChangeType(a, typeof(T));
        }



        public static bool operator !=(tvec2<T> a, tvec2<T> b)
        {
            throw new NotImplementedException();
        }
        public static bool operator ==(tvec2<T> a, tvec2<T> b)
        {
            throw new NotImplementedException();
        }

        public static tvec2<T> operator *(tvec2<T> a, tvec2<T> b)
        {
            throw new NotImplementedException();
        }
        public static tvec2<T> operator /(tvec2<T> a, tvec2<T> b)
        {
            throw new NotImplementedException();
        }
        public static tvec2<T> operator +(tvec2<T> a, tvec2<T> b)
        {
            throw new NotImplementedException();
        }
        public static tvec2<T> operator -(tvec2<T> a, tvec2<T> b)
        {
            throw new NotImplementedException();
        }

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
    }
}
#endif