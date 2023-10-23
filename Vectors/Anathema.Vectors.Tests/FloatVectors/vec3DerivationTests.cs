using Anathema.Vectors.Core;
using System;
using Xunit;

namespace Anathema.Vectors.Tests.FloatVectors
{
    public class vec3DerivationTests
    {

        const float REALLY_SMALL_VALUE = 0.00005f;

        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 12.345346356f })]
        [InlineData(new object[] { -37, 0, 11 })]
        [InlineData(new object[] { 3, 4, -4 })]
        [InlineData(new object[] { 15.23f, 20.99999999999f, 100000000000.0f })]
        [InlineData(new object[] { 2, -5, 0.1f })]
        public void arbitaryNormalisation(float x, float y, float z)
        {
            vec3 original = new vec3(x, y, z);
            vec3 normalised = original.normalised;
            vec3 reconstructed = normalised * original.length;

            Assert.True(Math.Abs(reconstructed.x - original.x) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(reconstructed.y - original.y) < REALLY_SMALL_VALUE);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 12.345346356f })]
        [InlineData(new object[] { -37, 0, 11 })]
        [InlineData(new object[] { 3, 4, -4 })]
        [InlineData(new object[] { 15.23f, 20.99999999999f, 100000000000.0f })]
        [InlineData(new object[] { 2, -5, 0.1f })]
        public void arbitaryNormalisationImperative(float x, float y, float z)
        {
            vec3 working = new vec3(x, y, z);
            float length = working.length;
            working.normalise();
            Assert.True(Math.Abs(working.length - 1) < REALLY_SMALL_VALUE);
            working *= length;
            Assert.True(Math.Abs(working.length - length) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(x - working.x) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(y - working.y) < REALLY_SMALL_VALUE);
        }


        [Theory]
        [InlineData(new object[] {  0, 0, 0,
                                    0, 0, 0,
                                       0 })]
        [InlineData(new object[] {  6, 0, 0,
                                    0, 1, 0,
                                       0 })]
        [InlineData(new object[] {  1, 3, 0,
                                    0, 0, 500,
                                       0 })]
        [InlineData(new object[] {  3, 0, 0,
                                    3, 0, 0,
                                       3*3 })]
        [InlineData(new object[] {  0, 4, 0,
                                    0, 4, 0,
                                       4*4 })]
        [InlineData(new object[] {  0, 0, 5,
                                    0, 0, 5,
                                       5*5 })]
        [InlineData(new object[] {  1, 0, 5,
                                    1, 0, 5,
                                       1 + (5*5) })]
        [InlineData(new object[] {  1, 2, 3,
                                    1, 2, 3,
                                       1 + (2*2) + (3*3) })]
        [InlineData(new object[] {  1, 2, 3,
                                    4, 5, 6,
                                       (1*4) + (2*5) + (3*6) })]
        public void dotProduct(float x1, float y1, float z1, float x2, float y2, float z2, float expectedResult)
        {
            vec3 a = new vec3(x1, y1, z1);
            vec3 b = new vec3(x2, y2, z2);

            float result = a.dot(b);

            Assert.True(Math.Abs(result - expectedResult) < REALLY_SMALL_VALUE);
        }

        [Theory]
        [InlineData(new object[] {  0, 0, 0,
                                    0, 0, 0,
                                    0, 0, 0 })]


        [InlineData(new object[] {  1, 0, 0,
                                    0, 1, 0,
                                    0, 0, 1 })]
        [InlineData(new object[] {  0, 1, 0,
                                    0, 0, 1,
                                    1, 0, 0 })]
        [InlineData(new object[] {  0, 0, 1,
                                    1, 0, 0,
                                    0, 1, 0 })]


        [InlineData(new object[] {  1, 0, 0,
                                    0, -1, 0,
                                    0, 0, -1 })]
        [InlineData(new object[] {  0, 1, 0,
                                    0, 0, -1,
                                    -1, 0, 0 })]
        [InlineData(new object[] {  0, 0, 1,
                                    -1, 0, 0,
                                    0, -1, 0 })]


        [InlineData(new object[] {  -1, 0, 0,
                                    0, 1, 0,
                                    0, 0, -1 })]
        [InlineData(new object[] {  0, -1, 0,
                                    0, 0, 1,
                                    -1, 0, 0 })]
        [InlineData(new object[] {  0, 0, -1,
                                    1, 0, 0,
                                    0, -1, 0 })]



        [InlineData(new object[] {  -1, 0, 0,
                                    0, -1, 0,
                                    0, 0, 1 })]
        [InlineData(new object[] {  0, -1, 0,
                                    0, 0, -1,
                                    1, 0, 0 })]
        [InlineData(new object[] {  0, 0, -1,
                                    -1, 0, 0,
                                    0, 1, 0 })]


        [InlineData(new object[] {  0, 0, 1,
                                    0, 1, 0,
                                    -1, 0, 0 })]
        [InlineData(new object[] {  0, 1, 0,
                                    1, 0, 0,
                                    0, 0, -1 })]
        [InlineData(new object[] {  1, 0, 0,
                                    0, 0, 1,
                                    0, -1, 0 })]
        public void crossProduct(float x1, float y1, float z1, float x2, float y2, float z2, float resultX, float resultY, float resultZ)
        {
            vec3 a = new vec3(x1, y1, z1);
            vec3 b = new vec3(x2, y2, z2);

            vec3 result = a.cross(b);

            Assert.True(result == new vec3(resultX, resultY, resultZ));
        }

        [Fact]
        public void cardinalNormalisation()
        {
            vec3 north = new vec3(0, -100, 0);
            Assert.Equal(0, north.normalised.x);
            Assert.Equal(-1, north.normalised.y);
            Assert.Equal(0, north.normalised.z);

            vec3 south = new vec3(0, 25, 0);
            Assert.Equal(0, south.normalised.x);
            Assert.Equal(1, south.normalised.y);
            Assert.Equal(0, south.normalised.z);

            vec3 east = new vec3(5.23487927342f, 0, 0);
            Assert.Equal(1, east.normalised.x);
            Assert.Equal(0, east.normalised.y);
            Assert.Equal(0, east.normalised.z);

            vec3 west = new vec3(-1, 0, 0);
            Assert.Equal(-1, west.normalised.x);
            Assert.Equal(0, west.normalised.y);
            Assert.Equal(0, west.normalised.z);

            vec3 forward = new vec3(0, 0, 10);
            Assert.Equal(0, forward.normalised.x);
            Assert.Equal(0, forward.normalised.y);
            Assert.Equal(1, forward.normalised.z);

            vec3 backward = new vec3(0, 0, -0.0001f);
            Assert.Equal(0, backward.normalised.x);
            Assert.Equal(0, backward.normalised.y);
            Assert.Equal(-1, backward.normalised.z);
        }

    }
}
