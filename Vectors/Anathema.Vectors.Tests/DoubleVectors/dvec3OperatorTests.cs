using Anathema.Vectors.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
#pragma warning disable CS1718 // Comparison made to same variable

namespace Anathema.Vectors.Tests.DoubleVectors
{
    public class dvec3OperatorTests
    {


        [Fact]
        public void negation()
        {

            dvec3 a = new dvec3(1, 2, 3);
            dvec3 b = -a;

            Assert.Equal(-1, b.x);
            Assert.Equal(-2, b.y);
            Assert.Equal(-3, b.z);

        }

        [Fact]
        public void equality()
        {
            dvec3 a = new dvec3(1, 2, 3);
            dvec3 b = new dvec3((1 / 3.0f) * 3.0f, 2, 3);
            dvec3 c = new dvec3(5, 2, 3);

            Assert.False(a.Equals("text"));
            Assert.False(a.Equals(c));
            Assert.False(a != a);
            Assert.False(b != b);
            Assert.False(c != c);

            Assert.True(a == a);
            Assert.True(b == b);
            Assert.True(c == c);

            Assert.True(a == b);
            Assert.True(b == a);

            Assert.True(a != c);
            Assert.True(c != a);

            Assert.True(b != c);
            Assert.True(c != b);

            Assert.False(a == c);
            Assert.False(c == a);

            Assert.False(b == c);
            Assert.False(c == b);
        }



        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5, 6 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f, -10000.0f, 20.0f })]
        [InlineData(new object[] { -37, 0, 2, -5, 0, 10 })]
        public void dvec3Addition(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            dvec3 a = new dvec3(x1, y1, z1);
            dvec3 b = new dvec3(x2, y2, z2);

            dvec3 c = a + b;
            dvec3 d = b + a;

            Assert.Equal(x1 + x2, c.x);
            Assert.Equal(x2 + x1, d.x);
            Assert.Equal(y1 + y2, c.y);
            Assert.Equal(y2 + y1, d.y);
            Assert.Equal(z1 + z2, c.z);
            Assert.Equal(z2 + z1, d.z);
        }


        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5, 6 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f, -10000.0f, 20.0f })]
        [InlineData(new object[] { -37, 0, 2, -5, 0, 10 })]
        public void dvec3Subtraction(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            dvec3 a = new dvec3(x1, y1, z1);
            dvec3 b = new dvec3(x2, y2, z2);

            dvec3 c = a - b;
            dvec3 d = b - a;

            Assert.Equal(x1 - x2, c.x);
            Assert.Equal(x2 - x1, d.x);
            Assert.Equal(y1 - y2, c.y);
            Assert.Equal(y2 - y1, d.y);
            Assert.Equal(z1 - z2, c.z);
            Assert.Equal(z2 - z1, d.z);
        }



        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5, 6 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f, -10000.0f, 20.0f })]
        [InlineData(new object[] { -37, 0, 2, -5, 0, 10 })]
        public void dvec3Multiplication(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            dvec3 a = new dvec3(x1, y1, z1);
            dvec3 b = new dvec3(x2, y2, z2);

            dvec3 c = a * b;
            dvec3 d = b * a;

            Assert.Equal(x1 * x2, c.x);
            Assert.Equal(x2 * x1, d.x);
            Assert.Equal(y1 * y2, c.y);
            Assert.Equal(y2 * y1, d.y);
            Assert.Equal(z1 * z2, c.z);
            Assert.Equal(z2 * z1, d.z);
        }



        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5, 6 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f, -10000.0f, 20.0f })]
        [InlineData(new object[] { -37, 0, 2, -5, 0, 10 })]
        public void dvec3Division(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            dvec3 a = new dvec3(x1, y1, z1);
            dvec3 b = new dvec3(x2, y2, z2);

            dvec3 c = a / b;
            dvec3 d = b / a;

            Assert.Equal(x1 / x2, c.x);
            Assert.Equal(x2 / x1, d.x);
            Assert.Equal(y1 / y2, c.y);
            Assert.Equal(y2 / y1, d.y);
            Assert.Equal(z1 / z2, c.z);
            Assert.Equal(z2 / z1, d.z);
        }
    }
}
