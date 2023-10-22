using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.DoubleVectors
{
    public class dvec2OperatorTests
    {
        [Fact]
        public void equality()
        {
            double a = 1.0f;
            double b = a / 3.0f;
            double c = b * 3.0f;
            double d = 0.999999999999f;

            dvec2 x = new dvec2(a, c);
            dvec2 y = new dvec2(c, a);
            dvec2 z = new dvec2(d, d);
            dvec2 w = new dvec2(1.1f, a);
            dvec2 nullvec = null;

            Assert.True(nullvec == null);
            Assert.True(null == nullvec);
            Assert.False(nullvec == x);
            Assert.False(x == nullvec);
            Assert.False(nullvec != null);
            Assert.False(null != nullvec);
            Assert.True(nullvec != x);
            Assert.True(x != nullvec);

            Assert.False(x == null);
            Assert.False(null == x);
            Assert.True(x != null);
            Assert.True(null != x);

            Assert.True(x == y);
            Assert.True(y == z);
            Assert.True(z == x);
            Assert.False(w == x);
            Assert.False(w == y);
            Assert.False(w == z);
            Assert.True(w == w);

            Assert.False(x != y);
            Assert.False(y != z);
            Assert.False(z != x);
            Assert.True(w != x);
            Assert.True(w != y);
            Assert.True(w != z);
            Assert.False(w != w);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void dvec2Addition(double x1, double y1, double x2, double y2)
        {
            dvec2 a = new dvec2(x1, y1);
            dvec2 b = new dvec2(x2, y2);

            dvec2 c = a + b;
            dvec2 d = b + a;

            Assert.Equal(x1 + x2, c.x);
            Assert.Equal(x1 + x2, d.x);
            Assert.Equal(y1 + y2, c.y);
            Assert.Equal(y1 + y2, d.y);
        }

        [Fact]
        public void negation()
        {
            dvec2 a = new dvec2(1, 2);
            dvec2 b = -a;

            Assert.Equal(-1, b.x);
            Assert.Equal(-2, b.y);
        }




        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2 })]
        public void scalarAddition(double x, double y, double scalar)
        {
            dvec2 a = new dvec2(x, y);

            dvec2 c = a + scalar;
            dvec2 d = scalar + a;

            Assert.Equal(x + scalar, c.x);
            Assert.Equal(x + scalar, d.x);
            Assert.Equal(y + scalar, c.y);
            Assert.Equal(y + scalar, d.y);
        }


        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void vec2Subtraction(double x1, double y1, double x2, double y2)
        {
            dvec2 a = new dvec2(x1, y1);
            dvec2 b = new dvec2(x2, y2);

            dvec2 c = a - b;
            dvec2 d = b - a;

            Assert.Equal(x1 - x2, c.x);
            Assert.Equal(x2 - x1, d.x);
            Assert.Equal(y1 - y2, c.y);
            Assert.Equal(y2 - y1, d.y);
        }


        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void dvec2Subtraction(double x1, double y1, double x2, double y2)
        {
            dvec2 a = new dvec2(x1, y1);
            dvec2 b = new dvec2(x2, y2);

            dvec2 c = a - b;
            dvec2 d = b - a;

            Assert.True(x1 - x2 == c.x);
            Assert.True(y1 - y2 == c.y);
            Assert.True(x2 - x1 == d.x);
            Assert.True(y2 - y1 == d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2 })]
        public void scalarSubtraction(double x, double y, double scalar)
        {
            dvec2 a = new dvec2(x, y);

            dvec2 c = a - scalar;
            dvec2 d = scalar - a;

            Assert.Equal(x - scalar, c.x);
            Assert.Equal(y - scalar, c.y);
            Assert.Equal(scalar - x, d.x);
            Assert.Equal(scalar - y, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void vec2Multiplication(double x1, double y1, double x2, double y2)
        {
            dvec2 a = new dvec2(x1, y1);
            dvec2 b = new dvec2(x2, y2);

            dvec2 c = a * b;
            dvec2 d = b * a;

            Assert.Equal(x1 * x2, c.x);
            Assert.Equal(x1 * x2, d.x);
            Assert.Equal(y1 * y2, c.y);
            Assert.Equal(y1 * y2, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void dvec2Multiplication(double x1, double y1, double x2, double y2)
        {
            dvec2 a = new dvec2(x1, y1);
            dvec2 b = new dvec2(x2, y2);

            dvec2 c = a * b;
            dvec2 d = b * a;

            Assert.True(x1 * x2 == c.x);
            Assert.True(x1 * x2 == d.x);
            Assert.True(y1 * y2 == c.y);
            Assert.True(y1 * y2 == d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void fvec2MutatorMultiplication(double x1, double y1, double x2, double y2)
        {
            dvec2 a = new dvec2(x1, y1);
            dvec2 b = new dvec2(x2, y2);

            a *= b;

            Assert.True(x1 * x2 == a.x);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2 })]
        public void scalarMultiplication(double x, double y, double scalar)
        {
            dvec2 a = new dvec2(x, y);

            dvec2 c = a * scalar;
            dvec2 d = scalar * a;

            Assert.Equal(x * scalar, c.x);
            Assert.Equal(x * scalar, d.x);
            Assert.Equal(y * scalar, c.y);
            Assert.Equal(y * scalar, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void vec2Division(double x1, double y1, double x2, double y2)
        {
            dvec2 a = new dvec2(x1, y1);
            dvec2 b = new dvec2(x2, y2);

            dvec2 c = a / b;
            dvec2 d = b / a;

            Assert.Equal(x1 / x2, c.x);
            Assert.Equal(y1 / y2, c.y);
            Assert.Equal(x2 / x1, d.x);
            Assert.Equal(y2 / y1, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void dvec2Division(double x1, double y1, double x2, double y2)
        {
            dvec2 a = new dvec2(x1, y1);
            dvec2 b = new dvec2(x2, y2);

            dvec2 c = a / b;
            dvec2 d = b / a;

            Assert.True(x1 / x2 == c.x);
            Assert.True(y1 / y2 == c.y);
            Assert.True(x2 / x1 == d.x);
            Assert.True(y2 / y1 == d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2 })]
        public void scalarDivision(double x, double y, double scalar)
        {
            dvec2 a = new dvec2(x, y);

            dvec2 c = a / scalar;
            dvec2 d = scalar / a;

            Assert.Equal(x / scalar, c.x);
            Assert.Equal(y / scalar, c.y);
            Assert.Equal(scalar / x, d.x);
            Assert.Equal(scalar / y, d.y);
        }
    }
}
