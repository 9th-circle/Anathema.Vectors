using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.FloatVectors
{
    public class FVec3ScalarOperatorTests
    {

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void scalarAddition(float x1, float y1, float z1, float b)
        {
            vec3 a = new vec3(x1, y1, z1);

            vec3 c = a + b;
            vec3 d = b + a;

            Assert.Equal(x1 + b, c.x);
            Assert.Equal(b + x1, d.x);
            Assert.Equal(y1 + b, c.y);
            Assert.Equal(b + y1, d.y);
            Assert.Equal(z1 + b, c.z);
            Assert.Equal(b + z1, d.z);
        }


        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void scalarSubtraction(float x1, float y1, float z1, float b)
        {
            vec3 a = new vec3(x1, y1, z1);

            vec3 c = a - b;
            vec3 d = b - a;

            Assert.Equal(x1 - b, c.x);
            Assert.Equal(b - x1, d.x);
            Assert.Equal(y1 - b, c.y);
            Assert.Equal(b - y1, d.y);
            Assert.Equal(z1 - b, c.z);
            Assert.Equal(b - z1, d.z);
        }



        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void scalarMultiplication(float x1, float y1, float z1, float b)
        {
            vec3 a = new vec3(x1, y1, z1);

            vec3 c = a * b;
            vec3 d = b * a;

            Assert.Equal(x1 * b, c.x);
            Assert.Equal(b * x1, d.x);
            Assert.Equal(y1 * b, c.y);
            Assert.Equal(b * y1, d.y);
            Assert.Equal(z1 * b, c.z);
            Assert.Equal(b * z1, d.z);
        }



        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void scalarDivision(float x1, float y1, float z1, float b)
        {
            vec3 a = new vec3(x1, y1, z1);

            vec3 c = a / b;
            vec3 d = b / a;

            Assert.Equal(x1 / b, c.x);
            Assert.Equal(b / x1, d.x);
            Assert.Equal(y1 / b, c.y);
            Assert.Equal(b / y1, d.y);
            Assert.Equal(z1 / b, c.z);
            Assert.Equal(b / z1, d.z);
        }


    }
}
