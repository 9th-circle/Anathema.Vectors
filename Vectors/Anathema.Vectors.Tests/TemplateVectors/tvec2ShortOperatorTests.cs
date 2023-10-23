using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.TemplateVectors
{
    public class tvec2ShortOperatorTests
    {
        [Fact]
        public void negation()
        {
            tvec2<short> a = new tvec2<short>(1, 2);
            tvec2<short> b = -a;

            Assert.Equal(-1, b.x);
            Assert.Equal(-2, b.y);
        }
        [Fact]
        public void equality()
        {
            tvec2<short> a = new tvec2<short>(1, 2);
            tvec2<short> b = new tvec2<short>(1, 2);
            tvec2<short> c = new tvec2<short>(3, 4);
            tvec2<short> n = null;
            Assert.True(a == b);
            Assert.False(a == c);
            Assert.False(a != b);
            Assert.True(a != c);
            Assert.False(a == n);
            Assert.False(n == a);
        }
        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        public void tvec2Addition(short x1, short y1, short x2, short y2)
        {
            tvec2<short> a = new tvec2<short>(x1, y1);
            tvec2<short> b = new tvec2<short>(x2, y2);

            tvec2<short> c = a + b;
            tvec2<short> d = b + a;

            Assert.Equal(x1 + x2, c.x);
            Assert.Equal(x1 + x2, d.x);
            Assert.Equal(y1 + y2, c.y);
            Assert.Equal(y1 + y2, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        public void tvec2Subtraction(short x1, short y1, short x2, short y2)
        {
            tvec2<short> a = new tvec2<short>(x1, y1);
            tvec2<short> b = new tvec2<short>(x2, y2);

            tvec2<short> c = a - b;
            tvec2<short> d = b - a;

            Assert.Equal(x1 - x2, c.x);
            Assert.Equal(x2 - x1, d.x);
            Assert.Equal(y1 - y2, c.y);
            Assert.Equal(y2 - y1, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        public void tvec2Multiplication(short x1, short y1, short x2, short y2)
        {
            tvec2<short> a = new tvec2<short>(x1, y1);
            tvec2<short> b = new tvec2<short>(x2, y2);

            tvec2<short> c = a * b;
            tvec2<short> d = b * a;

            Assert.Equal(x1 * x2, c.x);
            Assert.Equal(x1 * x2, d.x);
            Assert.Equal(y1 * y2, c.y);
            Assert.Equal(y1 * y2, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { -37, 1, 2, -5 })]
        public void tvec2MutatorMultiplication(short x1, short y1, short x2, short y2)
        {
            tvec2<short> a = new tvec2<short>(x1, y1);
            tvec2<short> b = new tvec2<short>(x2, y2);

            a *= b;

            Assert.True(x1 * x2 == a.x);
            Assert.True(y1 * y2 == a.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { -37, 1, 2, -5 })]
        public void vec2Division(short x1, short y1, short x2, short y2)
        {
            tvec2<short> a = new tvec2<short>(x1, y1);
            tvec2<short> b = new tvec2<short>(x2, y2);

            tvec2<short> c = a / b;
            tvec2<short> d = b / a;

            Assert.Equal(x1 / x2, c.x);
            Assert.Equal(y1 / y2, c.y);
            Assert.Equal(x2 / x1, d.x);
            Assert.Equal(y2 / y1, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { -37, 1, 2 })]
        public void scalarMultiplication(short x, short y, short scalar)
        {
            tvec2<short> a = new tvec2<short>(x, y);

            tvec2<short> c = a * scalar;
            tvec2<short> d = scalar * a;

            Assert.Equal(x * scalar, c.x);
            Assert.Equal(x * scalar, d.x);
            Assert.Equal(y * scalar, c.y);
            Assert.Equal(y * scalar, d.y);
        }


        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { -37, 1, 2 })]
        public void scalarDivision(short x, short y, short scalar)
        {
            tvec2<short> a = new tvec2<short>(x, y);

            tvec2<short> c = a / scalar;
            tvec2<short> d = scalar / a;

            Assert.Equal(x / scalar, c.x);
            Assert.Equal(y / scalar, c.y);
            Assert.Equal(scalar / x, d.x);
            Assert.Equal(scalar / y, d.y);
        }
        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { -37, 1, 2 })]
        public void scalarAddition(short x, short y, short scalar)
        {
            tvec2<short> a = new tvec2<short>(x, y);

            tvec2<short> c = a + scalar;
            tvec2<short> d = scalar + a;

            Assert.Equal(x + scalar, c.x);
            Assert.Equal(x + scalar, d.x);
            Assert.Equal(y + scalar, c.y);
            Assert.Equal(y + scalar, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { -37, 1, 2 })]
        public void scalarSubtraction(short x, short y, short scalar)
        {
            tvec2<short> a = new tvec2<short>(x, y);

            tvec2<short> c = a - scalar;
            tvec2<short> d = scalar - a;

            Assert.Equal(x - scalar, c.x);
            Assert.Equal(y - scalar, c.y);
            Assert.Equal(scalar - x, d.x);
            Assert.Equal(scalar - y, d.y);
        }
    }
}
