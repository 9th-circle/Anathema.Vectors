﻿using System;
#if FLOATS_ENABLED
namespace Anathema.Vectors.Core
{
    public partial class vec2
    {
        public override bool Equals(object o)
        {
            if (o is vec2)
                return ((vec2)o) == this;
            else
                return false;
        }
        public float dot(vec2 b)
        {
            return dot(this, b);
        }
        public static float dot(vec2 a, vec2 b)
        {
            return (a.x * b.x) + (a.y * b.y);
        }

        public vec2 cross()
        {
            return cross(this);
        }
        public static vec2 cross(vec2 a)
        {
            return new vec2(a.y, a.x);
        }


        public static bool operator !=(vec2 a, vec2 b)
        {
            return !(a == b);
        }
        public static bool operator ==(vec2 a, vec2 b)
        {
            if (a is null && b is null)
                return true;
            if ((a is null) != (b is null))
                return false;
            return scalar.isClose(a.x, b.x) && scalar.isClose(a.y, b.y);
        }

        public static vec2 operator *(vec2 a, vec2 b)
        {
            return new vec2(a.x * b.x, a.y * b.y);
        }
        public static vec2 operator /(vec2 a, vec2 b)
        {
            return new vec2(a.x / b.x, a.y / b.y);
        }
        public static vec2 operator +(vec2 a, vec2 b)
        {
            return new vec2(a.x + b.x, a.y + b.y);
        }
        public static vec2 operator -(vec2 a, vec2 b)
        {
            return new vec2(a.x - b.x, a.y - b.y);
        }



        public static vec2 operator *(vec2 a, float b)
        {
            return new vec2(a.x * b, a.y * b);
        }
        public static vec2 operator /(vec2 a, float b)
        {
            return new vec2(a.x / b, a.y / b);
        }
        public static vec2 operator +(vec2 a, float b)
        {
            return new vec2(a.x + b, a.y + b);
        }
        public static vec2 operator -(vec2 a, float b)
        {
            return new vec2(a.x - b, a.y - b);
        }



        public static vec2 operator *(float b, vec2 a)
        {
            return new vec2(a.x * b, a.y * b);
        }
        public static vec2 operator /(float b, vec2 a)
        {
            return new vec2(b / a.x, b / a.y);
        }
        public static vec2 operator +(float b, vec2 a)
        {
            return new vec2(a.x + b, a.y + b);
        }
        public static vec2 operator -(float b, vec2 a)
        {
            return new vec2(b - a.x, b - a.y);
        }
        public static vec2 operator -(vec2 a)
        {
            return new vec2(-a.x, -a.y);
        }


        public static vec2 operator *(vec2 a, mat2 b)
        {
            return new vec2((a.x * b.getValue(0, 0)) + (a.y * b.getValue(0, 1)),
                                (a.x * b.getValue(1, 0)) + (a.y * b.getValue(1, 1)));
        }
        public static vec2 operator *(mat2 b, vec2 a)
        {
            return a * b.transposed;
        }
#if CONVERSIONS_ENABLED
#if DOUBLES_ENABLED
        public static dvec2 operator *(vec2 a, dmat2 b)
        {
            return new dvec2((a.x * b.getValue(0, 0)) + (a.y * b.getValue(0, 1)),
                                (a.x * b.getValue(1, 0)) + (a.y * b.getValue(1, 1)));
        }
        public static dvec2 operator *(dmat2 b, vec2 a)
        {
            return a * b.transposed;
        }
#endif
#endif

#if NESTING_ENABLED
#if TEMPLATES_ENABLED
        public static vec2 operator *(vec2 a, tvec2<tvec2<float>> b)
        {
            mat2 matrix = mat2.fromNestedVector(b);

            return a * matrix;
        }
        public static vec2 operator *(tvec2<tvec2<float>> b, vec2 a)
        {
            mat2 matrix = mat2.fromNestedVector(b);

            return a * matrix.transposed;
        }
#endif
#endif
        public float this[int i]
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