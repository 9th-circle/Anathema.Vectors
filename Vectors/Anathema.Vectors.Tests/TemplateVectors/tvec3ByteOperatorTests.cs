using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.TemplateVectors
{
    public class tvec3ByteOperatorTests
    {
        [Fact]
        public void negation()
        {
            tvec3<byte> a = new tvec3<byte>(1, 2, 3);
            tvec3<byte> b = -a;

            Assert.Equal(255, b.x);
            Assert.Equal(254, b.y);
        }
        [Fact]
        public void equality()
        {
            tvec3<byte> a = new tvec3<byte>(1, 2, 3);
            tvec3<byte> b = new tvec3<byte>(1, 2, 3);
            tvec3<byte> c = new tvec3<byte>(3, 4, 5);
            tvec3<byte> n = null;
            Assert.True(a == b);
            Assert.False(a == c);
            Assert.False(a != b);
            Assert.True(a != c);
            Assert.False(a == n);
            Assert.False(n == a);
        }
        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5, 6 })]
        public void tvec3Addition(byte x1, byte y1, byte z1, byte x2, byte y2, byte z2)
        {
            tvec3<byte> a = new tvec3<byte>(x1, y1, z1);
            tvec3<byte> b = new tvec3<byte>(x2, y2, z2);

            tvec3<byte> c = a + b;
            tvec3<byte> d = b + a;

            Assert.Equal(x1 + x2, c.x);
            Assert.Equal(x1 + x2, d.x);
            Assert.Equal(y1 + y2, c.y);
            Assert.Equal(y1 + y2, d.y);
            Assert.Equal(z1 + z2, c.z);
            Assert.Equal(z1 + z2, d.z);
        }

        [Theory]
        [InlineData(new object[] { 8, 9, 10, 1, 2, 3 })]
        public void tvec3Subtraction(byte x1, byte y1, byte z1, byte x2, byte y2, byte z2)
        {
            tvec3<byte> a = new tvec3<byte>(x1, y1, z1);
            tvec3<byte> b = new tvec3<byte>(x2, y2, z2);

            tvec3<byte> c = a - b;

            Assert.Equal(x1 - x2, c.x);
            Assert.Equal(y1 - y2, c.y);
            Assert.Equal(z1 - z2, c.z);
        }
        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5, 6 })]
        public void tvec3Multiplication(byte x1, byte y1, byte z1, byte x2, byte y2, byte z2)
        {
            tvec3<byte> a = new tvec3<byte>(x1, y1, z1);
            tvec3<byte> b = new tvec3<byte>(x2, y2, z2);

            tvec3<byte> c = a * b;
            tvec3<byte> d = b * a;

            Assert.Equal(x1 * x2, c.x);
            Assert.Equal(x1 * x2, d.x);
            Assert.Equal(y1 * y2, c.y);
            Assert.Equal(y1 * y2, d.y);
            Assert.Equal(z1 * z2, c.z);
            Assert.Equal(z1 * z2, d.z);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5, 6 })]
        public void tvec3MultiplyImperative(byte x1, byte y1, byte z1, byte x2, byte y2, byte z2)
        {
            tvec3<byte> a = new tvec3<byte>(x1, y1, z1);
            tvec3<byte> b = new tvec3<byte>(x2, y2, z2);

            a *= b;

            Assert.True(x1 * x2 == a.x);
            Assert.True(y1 * y2 == a.y);
            Assert.True(z1 * z2 == a.z);
        }
        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5, 6 })]
        public void tvec3Division(byte x1, byte y1, byte z1, byte x2, byte y2, byte z2)
        {
            tvec3<byte> a = new tvec3<byte>(x1, y1, z1);
            tvec3<byte> b = new tvec3<byte>(x2, y2, z2);
            tvec3<byte> c = a / b;
            tvec3<byte> d = b / a;

            Assert.Equal(x1 / x2, c.x);
            Assert.Equal(y1 / y2, c.y);
            Assert.Equal(z1 / z2, c.z);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 37, 1, 2, 1 })]
        public void scalarMultiplication(byte x, byte y, byte z, byte scalar)
        {
            tvec3<byte> a = new tvec3<byte>(x, y, z);

            tvec3<byte> c = a * scalar;
            tvec3<byte> d = scalar * a;

            Assert.Equal(x * scalar, c.x);
            Assert.Equal(x * scalar, d.x);
            Assert.Equal(y * scalar, c.y);
            Assert.Equal(y * scalar, d.y);
            Assert.Equal(z * scalar, c.z);
            Assert.Equal(z * scalar, d.z);
        }


        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 37, 1, 2, 1 })]
        public void scalarDivision(byte x, byte y, byte z, byte scalar)
        {
            tvec3<byte> a = new tvec3<byte>(x, y, z);

            tvec3<byte> c = a / scalar;
            tvec3<byte> d = scalar / a;

            Assert.Equal(x / scalar, c.x);
            Assert.Equal(y / scalar, c.y);
            Assert.Equal(scalar / x, d.x);
            Assert.Equal(scalar / y, d.y);
            Assert.Equal(z / scalar, c.z);
            Assert.Equal(scalar / z, d.z);
        }
        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 37, 1, 2, 1 })]
        public void scalarAddition(byte x, byte y, byte z, byte scalar)
        {
            tvec3<byte> a = new tvec3<byte>(x, y, z);

            tvec3<byte> c = a + scalar;
            tvec3<byte> d = scalar + a;

            Assert.Equal(x + scalar, c.x);
            Assert.Equal(x + scalar, d.x);
            Assert.Equal(y + scalar, c.y);
            Assert.Equal(y + scalar, d.y);
            Assert.Equal(z + scalar, c.z);
            Assert.Equal(z + scalar, d.z);
        }
        [Theory]
        [InlineData(new object[] { 4,5,6,3 })]
        [InlineData(new object[] { 37, 1, 2, 1 })]
        public void scalarSubtraction(byte x, byte y, byte z, byte scalar)
        {
            tvec3<byte> a = new tvec3<byte>(x, y, z);


            tvec3<byte> c = a - scalar;

            Assert.Equal(x - scalar, c.x);
            Assert.Equal(y - scalar, c.y);
            Assert.Equal(z - scalar, c.z);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 0, 1, 2, 37 })]
        public void scalarSubtraction2(byte x, byte y, byte z, byte scalar)
        {
            tvec3<byte> a = new tvec3<byte>(x, y, z);


            tvec3<byte> c = a - scalar;
            tvec3<byte> d = scalar - a;

            Assert.Equal(scalar - x, d.x);
            Assert.Equal(scalar - y, d.y);
            Assert.Equal(scalar - z, d.z);
        }

    }
}
