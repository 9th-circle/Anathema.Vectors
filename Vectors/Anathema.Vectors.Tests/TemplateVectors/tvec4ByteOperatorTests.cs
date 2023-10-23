using System;
using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.TemplateVectors
{
    public class tvec4ByteOperatorTests
    {
        [Fact]
        public void negation()
        {
            tvec4<byte> a = new tvec4<byte>(1, 2, 3, 4);
            tvec4<byte> b = -a;

            Assert.Equal(255, b.x);
            Assert.Equal(254, b.y);
            Assert.Equal(253, b.z);
            Assert.Equal(252, b.w);


            tvec4<string> sa = new tvec4<string>("a", "b", "c", "d");
            Assert.Throws<TypeLoadException>(delegate { tvec4<string> sb = -sa; });
        }
        [Fact]
        public void equality()
        {
            tvec4<byte> a = new tvec4<byte>(1, 2, 3, 4);
            tvec4<byte> b = new tvec4<byte>(1, 2, 3, 4);
            tvec4<byte> c = new tvec4<byte>(3, 4, 5, 6);
            tvec4<byte> n = null;
            tvec4<byte> n2 = null;
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
            tvec4<string> a = new tvec4<string>("a", "b", "c", "d");
            tvec4<string> b = new tvec4<string>("a", "b", "c", "d");
            Assert.Throws<TypeLoadException>(delegate { var x = a == b; });
        }
        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f, 0.01f, 10, 12, 1.3 })]
        public void tvec4Addition(byte x1, byte y1, byte z1, byte w1, byte x2, byte y2, byte z2, byte w2)
        {
            tvec4<byte> a = new tvec4<byte>(x1, y1, z1, w1);
            tvec4<byte> b = new tvec4<byte>(x2, y2, z2, w2);

            tvec4<byte> c = a + b;
            tvec4<byte> d = b + a;

            Assert.Equal(x1 + x2, c.x);
            Assert.Equal(x1 + x2, d.x);
            Assert.Equal(y1 + y2, c.y);
            Assert.Equal(y1 + y2, d.y);
            Assert.Equal(z1 + z2, c.z);
            Assert.Equal(z1 + z2, d.z);
        }

        [Theory]
        [InlineData(new object[] { 10,20,30,40,1,2,3,4 })]
        public void tvec4Subtraction(byte x1, byte y1, byte z1, byte w1, byte x2, byte y2, byte z2, byte w2)
        {
            tvec4<byte> a = new tvec4<byte>(x1, y1, z1, w1);
            tvec4<byte> b = new tvec4<byte>(x2, y2, z2, w2);

            tvec4<byte> c = a - b;

            Assert.Equal(x1 - x2, c.x);
            Assert.Equal(y1 - y2, c.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f, 1f, 10, 12, 1.3 })]
        public void tvec4Multiplication(byte x1, byte y1, byte z1, byte w1, byte x2, byte y2, byte z2, byte w2)
        {
            tvec4<byte> a = new tvec4<byte>(x1, y1, z1, w1);
            tvec4<byte> b = new tvec4<byte>(x2, y2, z2, w2);
            tvec4<byte> c = a * b;
            tvec4<byte> d = b * a;

            Assert.Equal(x1 * x2, c.x);
            Assert.Equal(x1 * x2, d.x);
            Assert.Equal(y1 * y2, c.y);
            Assert.Equal(y1 * y2, d.y);
        }
        
        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f, 1f, 10, 12, 1.3 })]
        public void tvec4MutatorMultiplication(byte x1, byte y1, byte z1, byte w1, byte x2, byte y2, byte z2, byte w2)
        {
            tvec4<byte> a = new tvec4<byte>(x1, y1, z1, w1);
            tvec4<byte> b = new tvec4<byte>(x2, y2, z2, w2);

            a *= b;

            Assert.True(x1 * x2 == a.x);
            Assert.True(y1 * y2 == a.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f, 1, 10, 12, 1.3 })]
        public void tvec4Division(byte x1, byte y1, byte z1, byte w1, byte x2, byte y2, byte z2, byte w2)
        {
            tvec4<byte> a = new tvec4<byte>(x1, y1, z1, w1);
            tvec4<byte> b = new tvec4<byte>(x2, y2, z2, w2);

            tvec4<byte> c = a / b;
            tvec4<byte> d = b / a;

            Assert.Equal(x1 / x2, c.x);
            Assert.Equal(y1 / y2, c.y);
            Assert.Equal(x2 / x1, d.x);
            Assert.Equal(y2 / y1, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5 })]
        public void scalarMultiplication(byte x, byte y, byte z, byte w, byte scalar)
        {
            tvec4<byte> a = new tvec4<byte>(x, y, z, w);

            tvec4<byte> c = a * scalar;
            tvec4<byte> d = scalar * a;

            Assert.Equal(x * scalar, c.x);
            Assert.Equal(x * scalar, d.x);
            Assert.Equal(y * scalar, c.y);
            Assert.Equal(y * scalar, d.y);
        }


        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 20.99999999999f, 2, 123 })]
        public void scalarDivision(byte x, byte y, byte z, byte w, byte scalar)
        {
            tvec4<byte> a = new tvec4<byte>(x, y, z, w);

            tvec4<byte> c = a / scalar;
            tvec4<byte> d = scalar / a;

            Assert.Equal(x / scalar, c.x);
            Assert.Equal(y / scalar, c.y);
            Assert.Equal(scalar / x, d.x);
            Assert.Equal(scalar / y, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 20.99999999999f, 2, 123 })]
        public void scalarAddition(byte x, byte y, byte z, byte w, byte scalar)
        {
            tvec4<byte> a = new tvec4<byte>(x, y, z, w);

            tvec4<byte> c = a + scalar;
            tvec4<byte> d = scalar + a;

            Assert.Equal(x + scalar, c.x);
            Assert.Equal(x + scalar, d.x);
            Assert.Equal(y + scalar, c.y);
            Assert.Equal(y + scalar, d.y);
        }


        [Theory]
        [InlineData(new object[] { 4, 5, 6, 7, 3 })]
        [InlineData(new object[] { 37, 1, 2, 1, 1 })]
        public void scalarSubtraction(byte x, byte y, byte z, byte w, byte scalar)
        {
            tvec4<byte> a = new tvec4<byte>(x, y, z, w);


            tvec4<byte> c = a - scalar;

            Assert.Equal(x - scalar, c.x);
            Assert.Equal(y - scalar, c.y);
            Assert.Equal(z - scalar, c.z);
            Assert.Equal(w - scalar, c.w);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 4 })]
        [InlineData(new object[] { 0, 1, 2, 3, 37 })]
        public void scalarSubtraction2(byte x, byte y, byte z, byte w, byte scalar)
        {
            tvec4<byte> a = new tvec4<byte>(x, y, z, w);


            tvec4<byte> c = a - scalar;
            tvec4<byte> d = scalar - a;

            Assert.Equal(scalar - x, d.x);
            Assert.Equal(scalar - y, d.y);
            Assert.Equal(scalar - z, d.z);
            Assert.Equal(scalar - w, d.w);
        }
    }
}
