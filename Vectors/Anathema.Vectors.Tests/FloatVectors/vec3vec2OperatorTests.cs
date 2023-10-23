using Anathema.Vectors.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Anathema.Vectors.Tests.FloatVectors
{
    public class vec3vec2OperatorTests
    {
        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f, -10000.0f})]
        [InlineData(new object[] { -37, 0, 2, -5, 0 })]
        public void vec32Addition(float x1, float y1, float z1, float x2, float y2)
        {
            vec3 a = new vec3(x1, y1, z1);
            vec2 b = new vec2(x2, y2);

            vec3 c = a + b;
            vec3 d = b + a;

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
        public void vec32Subtraction(float x1, float y1, float z1, float x2, float y2)
        {
            vec3 a = new vec3(x1, y1, z1);
            vec2 b = new vec2(x2, y2);

            vec3 c = a - b;
            vec3 d = b - a;

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
        public void vec32Multiplication(float x1, float y1, float z1, float x2, float y2)
        {
            vec3 a = new vec3(x1, y1, z1);
            vec2 b = new vec2(x2, y2);

            vec3 c = a * b;
            vec3 d = b * a;

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
        public void vec32Division(float x1, float y1, float z1, float x2, float y2)
        {
            vec3 a = new vec3(x1, y1, z1);
            vec2 b = new vec2(x2, y2);

            vec3 c = a / b;
            vec3 d = b / a;

            Assert.Equal(x1 / x2, c.x);
            Assert.Equal(x2 / x1, d.x);
            Assert.Equal(y1 / y2, c.y);
            Assert.Equal(y2 / y1, d.y);
            Assert.Equal(z1, c.z);
            Assert.Equal(z1, d.z);
        }


    }
}
