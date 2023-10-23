using System;
using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.TemplateVectors
{
    public class tvec2FloatOperatorTests
    {
        [Fact]
        public void negation()
        {
            tvec2<float> a = new tvec2<float>(1, 2);
            tvec2<float> b = -a;

            Assert.Equal(-1, b.x);
            Assert.Equal(-2, b.y);


            tvec2<string> sa = new tvec2<string>("a", "b");
            Assert.Throws<TypeLoadException>(delegate { tvec2<string> sb = -sa; });
        }
       [Fact]
       public void equality()
       {
           tvec2<float> a = new tvec2<float>(1, 2);
           tvec2<float> b = new tvec2<float>(1, 2);
           tvec2<float> c = new tvec2<float>(3, 4);
           tvec2<float> n = null;
           tvec2<float> n2 = null;
            Assert.True(a == b);
           Assert.False(a == c);
           Assert.False(a != b);
           Assert.True(a != c);
           Assert.False(a == n);
           Assert.False(n == a);
           Assert.True(n == n2);
        }
        [Fact]
        public void equalityInvalid()
        {
            tvec2<string> a = new tvec2<string>("a", "b");
            tvec2<string> b = new tvec2<string>("a", "b");
            Assert.Throws<TypeLoadException>(delegate { var x = a == b; });
        }
            [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void tvec2Addition(float x1, float y1, float x2, float y2)
        {
            tvec2<float> a = new tvec2<float>(x1, y1);
            tvec2<float> b = new tvec2<float>(x2, y2);

            tvec2<float> c = a + b;
            tvec2<float> d = b + a;

            Assert.Equal(x1 + x2, c.x);
            Assert.Equal(x1 + x2, d.x);
            Assert.Equal(y1 + y2, c.y);
            Assert.Equal(y1 + y2, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void tvec2Subtraction(float x1, float y1, float x2, float y2)
        {
            tvec2<float> a = new tvec2<float>(x1, y1);
            tvec2<float> b = new tvec2<float>(x2, y2);

            tvec2<float> c = a - b;
            tvec2<float> d = b - a;

            Assert.Equal(x1 - x2, c.x);
            Assert.Equal(x2 - x1, d.x);
            Assert.Equal(y1 - y2, c.y);
            Assert.Equal(y2 - y1, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void tvec2Multiplication(float x1, float y1, float x2, float y2)
        {
            tvec2<float> a = new tvec2<float>(x1, y1);
            tvec2<float> b = new tvec2<float>(x2, y2);

            tvec2<float> c = a * b;
            tvec2<float> d = b * a;

            Assert.Equal(x1 * x2, c.x);
            Assert.Equal(x1 * x2, d.x);
            Assert.Equal(y1 * y2, c.y);
            Assert.Equal(y1 * y2, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void tvec2MutatorMultiplication(float x1, float y1, float x2, float y2)
        {
            tvec2<float> a = new tvec2<float>(x1, y1);
            tvec2<float> b = new tvec2<float>(x2, y2);

            a *= b;

            Assert.True(x1 * x2 == a.x);
            Assert.True(y1 * y2 == a.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void vec2Division(float x1, float y1, float x2, float y2)
        {
            tvec2<float> a = new tvec2<float>(x1, y1);
            tvec2<float> b = new tvec2<float>(x2, y2);

            tvec2<float> c = a / b;
            tvec2<float> d = b / a;

            Assert.Equal(x1 / x2, c.x);
            Assert.Equal(y1 / y2, c.y);
            Assert.Equal(x2 / x1, d.x);
            Assert.Equal(y2 / y1, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2 })]
        public void scalarMultiplication(float x, float y, float scalar)
        {
            tvec2<float> a = new tvec2<float>(x, y);

            tvec2<float> c = a * scalar;
            tvec2<float> d = scalar * a;

            Assert.Equal(x * scalar, c.x);
            Assert.Equal(x * scalar, d.x);
            Assert.Equal(y * scalar, c.y);
            Assert.Equal(y * scalar, d.y);
        }


        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2 })]
        public void scalarDivision(float x, float y, float scalar)
        {
            tvec2<float> a = new tvec2<float>(x, y);

            tvec2<float> c = a / scalar;
            tvec2<float> d = scalar / a;

            Assert.Equal(x / scalar, c.x);
            Assert.Equal(y / scalar, c.y);
            Assert.Equal(scalar / x, d.x);
            Assert.Equal(scalar / y, d.y);
        }
        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2 })]
        public void scalarAddition(float x, float y, float scalar)
        {
            tvec2<float> a = new tvec2<float>(x, y);

            tvec2<float> c = a + scalar;
            tvec2<float> d = scalar + a;

            Assert.Equal(x + scalar, c.x);
            Assert.Equal(x + scalar, d.x);
            Assert.Equal(y + scalar, c.y);
            Assert.Equal(y + scalar, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2 })]
        public void scalarSubtraction(float x, float y, float scalar)
        {
            tvec2<float> a = new tvec2<float>(x, y);

            tvec2<float> c = a - scalar;
            tvec2<float> d = scalar - a;

            Assert.Equal(x - scalar, c.x);
            Assert.Equal(y - scalar, c.y);
            Assert.Equal(scalar - x, d.x);
            Assert.Equal(scalar - y, d.y);
        }
    }
}
