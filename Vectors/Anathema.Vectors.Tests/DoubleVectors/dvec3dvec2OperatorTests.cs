using Anathema.Vectors.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Anathema.Vectors.Tests.DoubleVectors
{
    public class dvec3dvec2OperatorTests
    {
        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f, -10000.0f })]
        [InlineData(new object[] { -37, 0, 2, -5, 0 })]
        public void dvec32Addition(double x1, double y1, double z1, double x2, double y2)
        {
            dvec3 a = new dvec3(x1, y1, z1);
            dvec2 b = new dvec2(x2, y2);

            dvec3 c = a + b;
            dvec3 d = b + a;

            Assert.Equal(x1 + x2, c.x);
            Assert.Equal(x2 + x1, d.x);
            Assert.Equal(y1 + y2, c.y);
            Assert.Equal(y2 + y1, d.y);
            Assert.Equal(z1, c.z);
            Assert.Equal(z1, d.z);
        }


        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f, -10000.0f })]
        [InlineData(new object[] { -37, 0, 2, -5, 0 })]
        public void dvec32Subtraction(double x1, double y1, double z1, double x2, double y2)
        {
            dvec3 a = new dvec3(x1, y1, z1);
            dvec2 b = new dvec2(x2, y2);

            dvec3 c = a - b;
            dvec3 d = b - a;

            Assert.Equal(x1 - x2, c.x);
            Assert.Equal(x2 - x1, d.x);
            Assert.Equal(y1 - y2, c.y);
            Assert.Equal(y2 - y1, d.y);
            Assert.Equal(z1, c.z);
            Assert.Equal(z1, d.z);
        }



        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f, -10000.0f })]
        [InlineData(new object[] { -37, 0, 2, -5, 0 })]
        public void dvec32Multiplication(double x1, double y1, double z1, double x2, double y2)
        {
            dvec3 a = new dvec3(x1, y1, z1);
            dvec2 b = new dvec2(x2, y2);

            dvec3 c = a * b;
            dvec3 d = b * a;

            Assert.Equal(x1 * x2, c.x);
            Assert.Equal(x2 * x1, d.x);
            Assert.Equal(y1 * y2, c.y);
            Assert.Equal(y2 * y1, d.y);
            Assert.Equal(z1, c.z);
            Assert.Equal(z1, d.z);
        }



        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f, -10000.0f })]
        [InlineData(new object[] { -37, 0, 2, -5, 0 })]
        public void dvec32Division(double x1, double y1, double z1, double x2, double y2)
        {
            dvec3 a = new dvec3(x1, y1, z1);
            dvec2 b = new dvec2(x2, y2);

            dvec3 c = a / b;
            dvec3 d = b / a;

            Assert.Equal(x1 / x2, c.x);
            Assert.Equal(x2 / x1, d.x);
            Assert.Equal(y1 / y2, c.y);
            Assert.Equal(y2 / y1, d.y);
            Assert.Equal(z1, c.z);
            Assert.Equal(z1, d.z);
        }


    }
}
