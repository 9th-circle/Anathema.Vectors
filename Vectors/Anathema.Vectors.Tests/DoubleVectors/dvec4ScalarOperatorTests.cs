using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.FloatVectors
{
    public class DVec4ScalarOperatorTests
    {

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f, 23 })]
        [InlineData(new object[] { -37, 0, 2, -5, 1})]
        public void scalarAddition(double x1, double y1, double z1, double w1, double b)
        {
            dvec4 a = new dvec4(x1, y1, z1, w1);

            dvec4 c = a + b;
            dvec4 d = b + a;

            Assert.Equal(x1 + b, c.x);
            Assert.Equal(b + x1, d.x);
            Assert.Equal(y1 + b, c.y);
            Assert.Equal(b + y1, d.y);
            Assert.Equal(z1 + b, c.z);
            Assert.Equal(b + z1, d.z);
        }



        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f, 23 })]
        [InlineData(new object[] { -37, 0, 2, -5, 1 })]
        public void scalarSubtraction(double x1, double y1, double z1, double w1, double b)
        {
            dvec4 a = new dvec4(x1, y1, z1, w1);

            dvec4 c = a - b;
            dvec4 d = b - a;

            Assert.Equal(x1 - b, c.x);
            Assert.Equal(b - x1, d.x);
            Assert.Equal(y1 - b, c.y);
            Assert.Equal(b - y1, d.y);
            Assert.Equal(z1 - b, c.z);
            Assert.Equal(b - z1, d.z);
        }




        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f, 23 })]
        [InlineData(new object[] { -37, 0, 2, -5, 1 })]
        public void scalarMultiplication(double x1, double y1, double z1, double w1, double b)
        {
            dvec4 a = new dvec4(x1, y1, z1, w1);

            dvec4 c = a * b;
            dvec4 d = b * a;

            Assert.Equal(x1 * b, c.x);
            Assert.Equal(b * x1, d.x);
            Assert.Equal(y1 * b, c.y);
            Assert.Equal(b * y1, d.y);
            Assert.Equal(z1 * b, c.z);
            Assert.Equal(b * z1, d.z);
        }




        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f, 23 })]
        [InlineData(new object[] { -37, 0, 2, -5, 1 })]
        public void scalarDivision(double x1, double y1, double z1, double w1, double b)
        {
            dvec4 a = new dvec4(x1, y1, z1, w1);

            dvec4 c = a / b;
            dvec4 d = b / a;

            Assert.Equal(x1 / b, c.x);
            Assert.Equal(b / x1, d.x);
            Assert.Equal(y1 / b, c.y);
            Assert.Equal(b / y1, d.y);
            Assert.Equal(z1 / b, c.z);
            Assert.Equal(b / z1, d.z);
            Assert.Equal(w1 / b, c.w);
            Assert.Equal(b / w1, d.w);
        }


    }
}
