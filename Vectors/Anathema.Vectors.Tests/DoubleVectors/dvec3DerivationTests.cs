using Anathema.Vectors.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Anathema.Vectors.Tests.DoubleVectors
{
    public class dvec3DerivationTests
    {
        const double REALLY_SMALL_VALUE = 0.00005f;


        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 12.345346356f })]
        [InlineData(new object[] { -37, 0, 11 })]
        [InlineData(new object[] { 3, 4, -4 })]
        [InlineData(new object[] { 15.23f, 20.99999999999f, 100000000000.0f })]
        [InlineData(new object[] { 2, -5, 0.1f })]
        public void arbitaryNormalisation(double x, double y, double z)
        {
            dvec3 original = new dvec3(x, y, z);
            dvec3 normalised = original.normalised;
            dvec3 reconstructed = normalised * original.length;

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
        public void arbitaryNormalisationImperative(double x, double y, double z)
        {
            dvec3 working = new dvec3(x, y, z);
            double length = working.length;
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
        public void dotProduct(double x1, double y1, double z1, double x2, double y2, double z2, double expectedResult)
        {
            dvec3 a = new dvec3(x1, y1, z1);
            dvec3 b = new dvec3(x2, y2, z2);

            double result = a.dot(b);

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
        public void crossProduct(double x1, double y1, double z1, double x2, double y2, double z2, double resultX, double resultY, double resultZ)
        {
            dvec3 a = new dvec3(x1, y1, z1);
            dvec3 b = new dvec3(x2, y2, z2);

            dvec3 result = a.cross(b);

            Assert.True(result == new dvec3(resultX, resultY, resultZ));
        }

        [Fact]
        public void cardinalNormalisation()
        {
            dvec3 north = new dvec3(0, -100, 0);
            Assert.Equal(0, north.normalised.x);
            Assert.Equal(-1, north.normalised.y);
            Assert.Equal(0, north.normalised.z);

            dvec3 south = new dvec3(0, 25, 0);
            Assert.Equal(0, south.normalised.x);
            Assert.Equal(1, south.normalised.y);
            Assert.Equal(0, south.normalised.z);

            dvec3 east = new dvec3(5.23487927342f, 0, 0);
            Assert.Equal(1, east.normalised.x);
            Assert.Equal(0, east.normalised.y);
            Assert.Equal(0, east.normalised.z);

            dvec3 west = new dvec3(-1, 0, 0);
            Assert.Equal(-1, west.normalised.x);
            Assert.Equal(0, west.normalised.y);
            Assert.Equal(0, west.normalised.z);

            dvec3 forward = new dvec3(0, 0, 10);
            Assert.Equal(0, forward.normalised.x);
            Assert.Equal(0, forward.normalised.y);
            Assert.Equal(1, forward.normalised.z);

            dvec3 backward = new dvec3(0, 0, -0.0001f);
            Assert.Equal(0, backward.normalised.x);
            Assert.Equal(0, backward.normalised.y);
            Assert.Equal(-1, backward.normalised.z);
        }

    }
}
