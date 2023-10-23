using System;
using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.TemplateVectors
{
    public class tvec3ShortOperatorTests
    {
        [Fact]
        public void negation()
        {
            tvec3<short> a = new tvec3<short>(1, 2, 3);
            tvec3<short> b = -a;

            Assert.Equal(-1, b.x);
            Assert.Equal(-2, b.y);
            Assert.Equal(-3, b.z);


            tvec3<string> sa = new tvec3<string>("a", "b", "c");
            Assert.Throws<TypeLoadException>(delegate { tvec3<string> sb = -sa; });
        }
        [Fact]
        public void equality()
        {
            tvec3<short> a = new tvec3<short>(1, 2, 3);
            tvec3<short> b = new tvec3<short>(1, 2, 3);
            tvec3<short> c = new tvec3<short>(3, 4, 5);
            tvec3<short> n = null;
            tvec3<short> n2 = null;
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
            tvec3<string> a = new tvec3<string>("a", "b", "c");
            tvec3<string> b = new tvec3<string>("a", "b", "c");
            Assert.Throws<TypeLoadException>(delegate { var x = a == b; });
        }
        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5, 6 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f, 0.01f, 10 })]
        [InlineData(new object[] { -37, 0, 2, -5, -3, -2 })]
        public void tvec3Addition(short x1, short y1, short z1, short x2, short y2, short z2)
        {
            tvec3<short> a = new tvec3<short>(x1, y1, z1);
            tvec3<short> b = new tvec3<short>(x2, y2, z2);

            tvec3<short> c = a + b;
            tvec3<short> d = b + a;

            Assert.Equal(x1 + x2, c.x);
            Assert.Equal(x1 + x2, d.x);
            Assert.Equal(y1 + y2, c.y);
            Assert.Equal(y1 + y2, d.y);
            Assert.Equal(z1 + z2, c.z);
            Assert.Equal(z1 + z2, d.z);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5, 6 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f, 0.01f, 10 })]
        [InlineData(new object[] { -37, 0, 2, -5, -3, -2 })]
        public void tvec3Subtraction(short x1, short y1, short z1, short x2, short y2, short z2)
        {
            tvec3<short> a = new tvec3<short>(x1, y1, z1);
            tvec3<short> b = new tvec3<short>(x2, y2, z2);

            tvec3<short> c = a - b;
            tvec3<short> d = b - a;

            Assert.Equal(x1 - x2, c.x);
            Assert.Equal(x2 - x1, d.x);
            Assert.Equal(y1 - y2, c.y);
            Assert.Equal(y2 - y1, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5, 6 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f, 0.01f, 10 })]
        [InlineData(new object[] { -37, 0, 2, -5, -3, -2 })]
        public void tvec3Multiplication(short x1, short y1, short z1, short x2, short y2, short z2)
        {
            tvec3<short> a = new tvec3<short>(x1, y1, z1);
            tvec3<short> b = new tvec3<short>(x2, y2, z2);
            tvec3<short> c = a * b;
            tvec3<short> d = b * a;

            Assert.Equal(x1 * x2, c.x);
            Assert.Equal(x1 * x2, d.x);
            Assert.Equal(y1 * y2, c.y);
            Assert.Equal(y1 * y2, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5, 6 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f, 0.01f, 10 })]
        [InlineData(new object[] { -37, 0, 2, -5, -3, -2 })]
        public void tvec3MutatorMultiplication(short x1, short y1, short z1, short x2, short y2, short z2)
        {
            tvec3<short> a = new tvec3<short>(x1, y1, z1);
            tvec3<short> b = new tvec3<short>(x2, y2, z2);

            a *= b;

            Assert.True(x1 * x2 == a.x);
            Assert.True(y1 * y2 == a.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5, 6 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f, 1, 10 })]
        [InlineData(new object[] { -37, 1, 2, -5, -3, -2 })]
        public void tvec3Division(short x1, short y1, short z1, short x2, short y2, short z2)
        {
            tvec3<short> a = new tvec3<short>(x1, y1, z1);
            tvec3<short> b = new tvec3<short>(x2, y2, z2);

            tvec3<short> c = a / b;
            tvec3<short> d = b / a;

            Assert.Equal(x1 / x2, c.x);
            Assert.Equal(y1 / y2, c.y);
            Assert.Equal(x2 / x1, d.x);
            Assert.Equal(y2 / y1, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 20.99999999999f, 2 })]
        [InlineData(new object[] { -37, 0, 2, 1 })]
        public void scalarMultiplication(short x, short y, short z, short scalar)
        {
            tvec3<short> a = new tvec3<short>(x, y, z);

            tvec3<short> c = a * scalar;
            tvec3<short> d = scalar * a;

            Assert.Equal(x * scalar, c.x);
            Assert.Equal(x * scalar, d.x);
            Assert.Equal(y * scalar, c.y);
            Assert.Equal(y * scalar, d.y);
        }


        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 20.99999999999f, 2 })]
        [InlineData(new object[] { -37, 1, 2, 1 })]
        public void scalarDivision(short x, short y, short z, short scalar)
        {
            tvec3<short> a = new tvec3<short>(x, y, z);

            tvec3<short> c = a / scalar;
            tvec3<short> d = scalar / a;

            Assert.Equal(x / scalar, c.x);
            Assert.Equal(y / scalar, c.y);
            Assert.Equal(scalar / x, d.x);
            Assert.Equal(scalar / y, d.y);
        }
        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 20.99999999999f, 2 })]
        [InlineData(new object[] { -37, 0, 2, 1 })]
        public void scalarAddition(short x, short y, short z, short scalar)
        {
            tvec3<short> a = new tvec3<short>(x, y, z);

            tvec3<short> c = a + scalar;
            tvec3<short> d = scalar + a;

            Assert.Equal(x + scalar, c.x);
            Assert.Equal(x + scalar, d.x);
            Assert.Equal(y + scalar, c.y);
            Assert.Equal(y + scalar, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 20.99999999999f, 2 })]
        [InlineData(new object[] { -37, 0, 2, 1 })]
        public void scalarSubtraction(short x, short y, short z,short scalar)
        {
            tvec3<short> a = new tvec3<short>(x, y, z);

            tvec3<short> c = a - scalar;
            tvec3<short> d = scalar - a;

            Assert.Equal(x - scalar, c.x);
            Assert.Equal(y - scalar, c.y);
            Assert.Equal(scalar - x, d.x);
            Assert.Equal(scalar - y, d.y);
        }
    }
}
