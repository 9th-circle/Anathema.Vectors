using Anathema.Vectors.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Anathema.Vectors.Tests.FloatVectors
{
    public class vec4vec2OperatorTests
    {
        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f, -10000.0f, 20.0f, 22, 4 })]
        [InlineData(new object[] { -37, 0, 2, -5, 0, 10, 3, 4 })]
        public void vec4Addition(float x1, float y1, float z1, float w1, float x2, float y2, float z2, float w2)
        {
            vec4 a = new vec4(x1, y1, z1, w1);
            vec2 b = new vec2(x2, y2);

            vec4 c = a + b;
            vec4 d = b + a;

            Assert.Equal(x1 + x2, c.x);
            Assert.Equal(x2 + x1, d.x);
            Assert.Equal(y1 + y2, c.y);
            Assert.Equal(y2 + y1, d.y);
            Assert.Equal(z1 + 0, c.z);
            Assert.Equal(0 + z1, d.z);
            Assert.Equal(w1 + 0, c.w);
            Assert.Equal(0 + w1, d.w);
        }


        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f, -10000.0f, 20.0f, 22, 4 })]
        [InlineData(new object[] { -37, 0, 2, -5, 0, 10, 3, 4 })]
        public void vec4Subtraction(float x1, float y1, float z1, float w1, float x2, float y2, float z2, float w2)
        {
            vec4 a = new vec4(x1, y1, z1, w1);
            vec2 b = new vec2(x2, y2);

            vec4 c = a - b;
            vec4 d = b - a;

            Assert.Equal(x1 - x2, c.x);
            Assert.Equal(x2 - x1, d.x);
            Assert.Equal(y1 - y2, c.y);
            Assert.Equal(y2 - y1, d.y);
            Assert.Equal(z1 - 0, c.z);
            Assert.Equal(0 - z1, d.z);
            Assert.Equal(w1 - 0, c.w);
            Assert.Equal(0 - w1, d.w);
        }



        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f, -10000.0f, 20.0f, 22, 4 })]
        [InlineData(new object[] { -37, 0, 2, -5, 0, 10, 3, 4 })]
        public void vec4Multiplication(float x1, float y1, float z1, float w1, float x2, float y2, float z2, float w2)
        {
            vec4 a = new vec4(x1, y1, z1, w1);
            vec2 b = new vec2(x2, y2);

            vec4 c = a * b;
            vec4 d = b * a;

            Assert.Equal(x1 * x2, c.x);
            Assert.Equal(x2 * x1, d.x);
            Assert.Equal(y1 * y2, c.y);
            Assert.Equal(y2 * y1, d.y);
            Assert.Equal(z1 * 1, c.z);
            Assert.Equal(1 * z1, d.z);
            Assert.Equal(w1 * 1, c.w);
            Assert.Equal(1 * w1, d.w);
        }



        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5, 6, 7, 8 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f, -10000.0f, 20.0f, 22, 4 })]
        [InlineData(new object[] { -37, 0, 2, -5, 0, 10, 3, 4 })]
        public void vec4Division(float x1, float y1, float z1, float w1, float x2, float y2, float z2, float w2)
        {
            vec4 a = new vec4(x1, y1, z1, w1);
            vec2 b = new vec2(x2, y2);

            vec4 c = a / b;
            vec4 d = b / a;

            Assert.Equal(x1 / x2, c.x);
            Assert.Equal(x2 / x1, d.x);
            Assert.Equal(y1 / y2, c.y);
            Assert.Equal(y2 / y1, d.y);
            Assert.Equal(z1 / 1, c.z);
            Assert.Equal(1 / z1, d.z);
            Assert.Equal(w1 / 1, c.w);
            Assert.Equal(1 / w1, d.w);
        }

    }
}
