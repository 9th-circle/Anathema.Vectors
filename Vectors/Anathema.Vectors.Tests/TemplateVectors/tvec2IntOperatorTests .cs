using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.TemplateVectors
{
    public class tvec2IntOperatorTests
    {
        [Fact]
        public void negation()
        {
            tvec2<int> a = new tvec2<int>(1, 2);
            tvec2<int> b = -a;

            Assert.Equal(-1, b.x);
            Assert.Equal(-2, b.y);
        }
        [Fact]
        public void equality()
        {
            tvec2<int> a = new tvec2<int>(1, 2);
            tvec2<int> b = new tvec2<int>(1, 2);
            tvec2<int> c = new tvec2<int>(3, 4);
            tvec2<int> n = null;
            Assert.True(a == b);
            Assert.False(a == c);
            Assert.False(a != b);
            Assert.True(a != c);
            Assert.False(a == n);
            Assert.False(n == a);
        }
        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        public void tvec2Addition(int x1, int y1, int x2, int y2)
        {
            tvec2<int> a = new tvec2<int>(x1, y1);
            tvec2<int> b = new tvec2<int>(x2, y2);

            tvec2<int> c = a + b;
            tvec2<int> d = b + a;

            Assert.Equal(x1 + x2, c.x);
            Assert.Equal(x1 + x2, d.x);
            Assert.Equal(y1 + y2, c.y);
            Assert.Equal(y1 + y2, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        public void tvec2Subtraction(int x1, int y1, int x2, int y2)
        {
            tvec2<int> a = new tvec2<int>(x1, y1);
            tvec2<int> b = new tvec2<int>(x2, y2);

            tvec2<int> c = a - b;
            tvec2<int> d = b - a;

            Assert.Equal(x1 - x2, c.x);
            Assert.Equal(x2 - x1, d.x);
            Assert.Equal(y1 - y2, c.y);
            Assert.Equal(y2 - y1, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        public void tvec2Multiplication(int x1, int y1, int x2, int y2)
        {
            tvec2<int> a = new tvec2<int>(x1, y1);
            tvec2<int> b = new tvec2<int>(x2, y2);

            tvec2<int> c = a * b;
            tvec2<int> d = b * a;

            Assert.Equal(x1 * x2, c.x);
            Assert.Equal(x1 * x2, d.x);
            Assert.Equal(y1 * y2, c.y);
            Assert.Equal(y1 * y2, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { -37, 1, 2, -5 })]
        public void tvec2MutatorMultiplication(int x1, int y1, int x2, int y2)
        {
            tvec2<int> a = new tvec2<int>(x1, y1);
            tvec2<int> b = new tvec2<int>(x2, y2);

            a *= b;

            Assert.True(x1 * x2 == a.x);
            Assert.True(y1 * y2 == a.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { -37, 1, 2, -5 })]
        public void vec2Division(int x1, int y1, int x2, int y2)
        {
            tvec2<int> a = new tvec2<int>(x1, y1);
            tvec2<int> b = new tvec2<int>(x2, y2);

            tvec2<int> c = a / b;
            tvec2<int> d = b / a;

            Assert.Equal(x1 / x2, c.x);
            Assert.Equal(y1 / y2, c.y);
            Assert.Equal(x2 / x1, d.x);
            Assert.Equal(y2 / y1, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { -37, 1, 2 })]
        public void scalarMultiplication(int x, int y, int scalar)
        {
            tvec2<int> a = new tvec2<int>(x, y);

            tvec2<int> c = a * scalar;
            tvec2<int> d = scalar * a;

            Assert.Equal(x * scalar, c.x);
            Assert.Equal(x * scalar, d.x);
            Assert.Equal(y * scalar, c.y);
            Assert.Equal(y * scalar, d.y);
        }


        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { -37, 1, 2 })]
        public void scalarDivision(int x, int y, int scalar)
        {
            tvec2<int> a = new tvec2<int>(x, y);

            tvec2<int> c = a / scalar;
            tvec2<int> d = scalar / a;

            Assert.Equal(x / scalar, c.x);
            Assert.Equal(y / scalar, c.y);
            Assert.Equal(scalar / x, d.x);
            Assert.Equal(scalar / y, d.y);
        }
        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { -37, 1, 2 })]
        public void scalarAddition(int x, int y, int scalar)
        {
            tvec2<int> a = new tvec2<int>(x, y);

            tvec2<int> c = a + scalar;
            tvec2<int> d = scalar + a;

            Assert.Equal(x + scalar, c.x);
            Assert.Equal(x + scalar, d.x);
            Assert.Equal(y + scalar, c.y);
            Assert.Equal(y + scalar, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { -37, 1, 2 })]
        public void scalarSubtraction(int x, int y, int scalar)
        {
            tvec2<int> a = new tvec2<int>(x, y);

            tvec2<int> c = a - scalar;
            tvec2<int> d = scalar - a;

            Assert.Equal(x - scalar, c.x);
            Assert.Equal(y - scalar, c.y);
            Assert.Equal(scalar - x, d.x);
            Assert.Equal(scalar - y, d.y);
        }
    }
}
