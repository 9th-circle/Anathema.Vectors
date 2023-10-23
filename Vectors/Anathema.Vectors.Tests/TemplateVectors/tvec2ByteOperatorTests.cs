using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.TemplateVectors
{
    public class tvec2ByteOperatorTests
    {
        [Fact]
        public void negation()
        {
            tvec2<byte> a = new tvec2<byte>(1, 2);
            tvec2<byte> b = -a;

            Assert.Equal(255, b.x);
            Assert.Equal(254, b.y);
        }
        [Fact]
        public void equality()
        {
            tvec2<byte> a = new tvec2<byte>(1, 2);
            tvec2<byte> b = new tvec2<byte>(1, 2);
            tvec2<byte> c = new tvec2<byte>(3, 4);
            tvec2<byte> n = null;
            Assert.True(a == b);
            Assert.False(a == c);
            Assert.False(a != b);
            Assert.True(a != c);
            Assert.False(a == n);
            Assert.False(n == a);
        }
        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        public void tvec2Addition(byte x1, byte y1, byte x2, byte y2)
        {
            tvec2<byte> a = new tvec2<byte>(x1, y1);
            tvec2<byte> b = new tvec2<byte>(x2, y2);

            tvec2<byte> c = a + b;
            tvec2<byte> d = b + a;

            Assert.Equal(x1 + x2, c.x);
            Assert.Equal(x1 + x2, d.x);
            Assert.Equal(y1 + y2, c.y);
            Assert.Equal(y1 + y2, d.y);
        }

        [Theory]
        [InlineData(new object[] { 20, 8, 10, 4 })]
        public void tvec2Subtraction(byte x1, byte y1, byte x2, byte y2)
        {
            tvec2<byte> a = new tvec2<byte>(x1, y1);
            tvec2<byte> b = new tvec2<byte>(x2, y2);

            tvec2<byte> c = a - b;
            tvec2<byte> d = b - a;

            Assert.Equal(x1 - x2, c.x);
            Assert.Equal(y1 - y2, c.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        public void tvec2Multiplication(byte x1, byte y1, byte x2, byte y2)
        {
            tvec2<byte> a = new tvec2<byte>(x1, y1);
            tvec2<byte> b = new tvec2<byte>(x2, y2);

            tvec2<byte> c = a * b;
            tvec2<byte> d = b * a;

            Assert.Equal(x1 * x2, c.x);
            Assert.Equal(x1 * x2, d.x);
            Assert.Equal(y1 * y2, c.y);
            Assert.Equal(y1 * y2, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 37, 1, 2, 5 })]
        public void tvec2MutatorMultiplication(byte x1, byte y1, byte x2, byte y2)
        {
            tvec2<byte> a = new tvec2<byte>(x1, y1);
            tvec2<byte> b = new tvec2<byte>(x2, y2);

            a *= b;

            Assert.True(x1 * x2 == a.x);
            Assert.True(y1 * y2 == a.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 37, 1, 2, 5 })]
        public void vec2Division(byte x1, byte y1, byte x2, byte y2)
        {
            tvec2<byte> a = new tvec2<byte>(x1, y1);
            tvec2<byte> b = new tvec2<byte>(x2, y2);

            tvec2<byte> c = a / b;
            tvec2<byte> d = b / a;

            Assert.Equal(x1 / x2, c.x);
            Assert.Equal(y1 / y2, c.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 37, 1, 2 })]
        public void scalarMultiplication(byte x, byte y, byte scalar)
        {
            tvec2<byte> a = new tvec2<byte>(x, y);

            tvec2<byte> c = a * scalar;
            tvec2<byte> d = scalar * a;

            Assert.Equal(x * scalar, c.x);
            Assert.Equal(x * scalar, d.x);
            Assert.Equal(y * scalar, c.y);
            Assert.Equal(y * scalar, d.y);
        }


        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 37, 1, 2 })]
        public void scalarDivision(byte x, byte y, byte scalar)
        {
            tvec2<byte> a = new tvec2<byte>(x, y);

            tvec2<byte> c = a / scalar;
            tvec2<byte> d = scalar / a;

            Assert.Equal(x / scalar, c.x);
            Assert.Equal(y / scalar, c.y);
            Assert.Equal(scalar / x, d.x);
            Assert.Equal(scalar / y, d.y);
        }
        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 37, 1, 2 })]
        public void scalarAddition(byte x, byte y, byte scalar)
        {
            tvec2<byte> a = new tvec2<byte>(x, y);

            tvec2<byte> c = a + scalar;
            tvec2<byte> d = scalar + a;

            Assert.Equal(x + scalar, c.x);
            Assert.Equal(x + scalar, d.x);
            Assert.Equal(y + scalar, c.y);
            Assert.Equal(y + scalar, d.y);
        }

        [Theory]
        [InlineData(new object[] { 10, 20, 3 })]
        [InlineData(new object[] { 37, 10, 2 })]
        public void scalarSubtraction(byte x, byte y, byte scalar)
        {
            tvec2<byte> a = new tvec2<byte>(x, y);

            tvec2<byte> c = a - scalar;
            tvec2<byte> d = scalar - a;

            Assert.Equal(x - scalar, c.x);
            Assert.Equal(y - scalar, c.y);
        }

        [Theory]
        [InlineData(new object[] { 10, 20, 43 })]
        [InlineData(new object[] { 37, 10, 52 })]
        public void scalarSubtraction2(byte x, byte y, byte scalar)
        {
            tvec2<byte> a = new tvec2<byte>(x, y);

            tvec2<byte> c = a - scalar;
            tvec2<byte> d = scalar - a;

            Assert.Equal(scalar - x, d.x);
            Assert.Equal(scalar - y, d.y);
        }

    }
}
