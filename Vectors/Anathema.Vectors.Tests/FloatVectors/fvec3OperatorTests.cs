using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.FloatVectors
{
    public class fvec3OperatorTests
    {
        [Fact]
        public void negation()
        {
            fvec3 a = new fvec3(1, 2, 3);
            fvec3 b = -a;

            Assert.Equal(-1, b.x);
            Assert.Equal(-2, b.y);
            Assert.Equal(-3, b.z);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5, 6 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f, -10000.0f, 20.0f })]
        [InlineData(new object[] { -37, 0, 2, -5, 0, 10 })]
        public void fvec3Addition(float x1, float y1, float z1, float x2, float y2, float z2)
        {
            fvec3 a = new fvec3(x1, y1, z1);
            fvec3 b = new fvec3(x2, y2, z2);

            fvec3 c = a + b;
            fvec3 d = b + a;

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
        public void fvec3Subtraction(float x1, float y1, float z1, float x2, float y2, float z2)
        {
            fvec3 a = new fvec3(x1, y1, z1);
            fvec3 b = new fvec3(x2, y2, z2);

            fvec3 c = a - b;
            fvec3 d = b - a;

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
        public void fvec3Multiplication(float x1, float y1, float z1, float x2, float y2, float z2)
        {
            fvec3 a = new fvec3(x1, y1, z1);
            fvec3 b = new fvec3(x2, y2, z2);

            fvec3 c = a * b;
            fvec3 d = b * a;

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
        public void fvec3Division(float x1, float y1, float z1, float x2, float y2, float z2)
        {
            fvec3 a = new fvec3(x1, y1, z1);
            fvec3 b = new fvec3(x2, y2, z2);

            fvec3 c = a / b;
            fvec3 d = b / a;

            Assert.Equal(x1 / x2, c.x);
            Assert.Equal(x2 / x1, d.x);
            Assert.Equal(y1 / y2, c.y);
            Assert.Equal(y2 / y1, d.y);
            Assert.Equal(z1 / z2, c.z);
            Assert.Equal(z2 / z1, d.z);
        }


    }
}
