using Anathema.Vectors.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Anathema.Vectors.Tests.FloatVectors
{
    public class dvec4OperatorTests
    {
        [Fact]
        public void negation()
        {
            dvec4 a = new dvec4(1, 2, 3, 4);
            dvec4 b = -a;

            Assert.Equal(-1, b.x);
            Assert.Equal(-2, b.y);
            Assert.Equal(-3, b.z);
            Assert.Equal(-4, b.w);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f, -10000.0f, 20.0f, 22, 4 })]
        [InlineData(new object[] { -37, 0, 2, -5, 0, 10, 3, 4 })]
        public void dvec4Addition(double x1, double y1, double z1, double w1, double x2, double y2, double z2, double w2)
        {
            dvec4 a = new dvec4(x1, y1, z1, w1);
            dvec4 b = new dvec4(x2, y2, z2, w2);

            dvec4 c = a + b;
            dvec4 d = b + a;

            Assert.Equal(x1 + x2, c.x);
            Assert.Equal(x2 + x1, d.x);
            Assert.Equal(y1 + y2, c.y);
            Assert.Equal(y2 + y1, d.y);
            Assert.Equal(z1 + z2, c.z);
            Assert.Equal(z2 + z1, d.z);
            Assert.Equal(w1 + w2, c.w);
            Assert.Equal(w2 + w1, d.w);
        }


        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f, -10000.0f, 20.0f, 22, 4 })]
        [InlineData(new object[] { -37, 0, 2, -5, 0, 10, 3, 4 })]
        public void dvec4Subtraction(double x1, double y1, double z1, double w1, double x2, double y2, double z2, double w2)
        {
            dvec4 a = new dvec4(x1, y1, z1, w1);
            dvec4 b = new dvec4(x2, y2, z2, w2);

            dvec4 c = a - b;
            dvec4 d = b - a;

            Assert.Equal(x1 - x2, c.x);
            Assert.Equal(x2 - x1, d.x);
            Assert.Equal(y1 - y2, c.y);
            Assert.Equal(y2 - y1, d.y);
            Assert.Equal(z1 - z2, c.z);
            Assert.Equal(z2 - z1, d.z);
            Assert.Equal(w1 - w2, c.w);
            Assert.Equal(w2 - w1, d.w);
        }



        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f, -10000.0f, 20.0f, 22, 4 })]
        [InlineData(new object[] { -37, 0, 2, -5, 0, 10, 3, 4 })]
        public void dvec4Multiplication(double x1, double y1, double z1, double w1, double x2, double y2, double z2, double w2)
        {
            dvec4 a = new dvec4(x1, y1, z1, w1);
            dvec4 b = new dvec4(x2, y2, z2, w2);

            dvec4 c = a * b;
            dvec4 d = b * a;

            Assert.Equal(x1 * x2, c.x);
            Assert.Equal(x2 * x1, d.x);
            Assert.Equal(y1 * y2, c.y);
            Assert.Equal(y2 * y1, d.y);
            Assert.Equal(z1 * z2, c.z);
            Assert.Equal(z2 * z1, d.z);
            Assert.Equal(w1 * w2, c.w);
            Assert.Equal(w2 * w1, d.w);
        }



        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f, -10000.0f, 20.0f, 22, 4 })]
        [InlineData(new object[] { -37, 0, 2, -5, 0, 10, 3, 4 })]
        public void dvec4Division(double x1, double y1, double z1, double w1, double x2, double y2, double z2, double w2)
        {
            dvec4 a = new dvec4(x1, y1, z1, w1);
            dvec4 b = new dvec4(x2, y2, z2, w2);

            dvec4 c = a / b;
            dvec4 d = b / a;

            Assert.Equal(x1 / x2, c.x);
            Assert.Equal(x2 / x1, d.x);
            Assert.Equal(y1 / y2, c.y);
            Assert.Equal(y2 / y1, d.y);
            Assert.Equal(z1 / z2, c.z);
            Assert.Equal(z2 / z1, d.z);
            Assert.Equal(w1 / w2, c.w);
            Assert.Equal(w2 / w1, d.w);
        }

    }
}
