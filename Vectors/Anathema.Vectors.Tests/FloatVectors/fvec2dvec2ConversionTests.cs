using Anathema.Vectors.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Anathema.Vectors.Tests.FloatVectors
{
    public class fvec2dvec2ConversionTests
    {

        [Theory]
        [InlineData(1, 2, 3, 4)]
        [InlineData(5.2f, 10.00001f, 15.23f, 20.99999999999f)]
        [InlineData(-37, 0, 2, -5)]
        public void dvec2Addition(float x1, float y1, double x2, double y2)
        {
            fvec2 a = new fvec2(x1, y1);
            dvec2 b = new dvec2(x2, y2);

            dvec2 c = a + b;
            dvec2 d = b + a;

            Assert.True(x1 + x2 == c.x);
            Assert.True(x1 + x2 == d.x);
            Assert.True(y1 + y2 == c.y);
            Assert.True(y1 + y2 == d.y);
        }



        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void dvec2Subtraction(float x1, float y1, double x2, double y2)
        {
            fvec2 a = new fvec2(x1, y1);
            dvec2 b = new dvec2(x2, y2);

            dvec2 c = a - b;
            dvec2 d = b - a;

            Assert.True(x1 - x2 == c.x);
            Assert.True(y1 - y2 == c.y);
            Assert.True(x2 - x1 == d.x);
            Assert.True(y2 - y1 == d.y);
        }





        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void dvec2Multiplication(float x1, float y1, double x2, double y2)
        {
            fvec2 a = new fvec2(x1, y1);
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
        public void dvec2Division(float x1, float y1, double x2, double y2)
        {
            fvec2 a = new fvec2(x1, y1);
            dvec2 b = new dvec2(x2, y2);

            dvec2 c = a / b;
            dvec2 d = b / a;

            Assert.True(x1 / x2 == c.x);
            Assert.True(y1 / y2 == c.y);
            Assert.True(x2 / x1 == d.x);
            Assert.True(y2 / y1 == d.y);
        }
    }
}
