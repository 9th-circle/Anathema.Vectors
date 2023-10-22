using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.DoubleVectors
{
    public class dvec2DerivationTests
    {
        const double REALLY_SMALL_VALUE = 0.00005f;

        [Theory]
        [InlineData(new object[] { 1, 2 })]
        [InlineData(new object[] { 5.2f, 10.00001f })]
        [InlineData(new object[] { -37, 0 })]
        [InlineData(new object[] { 3, 4 })]
        [InlineData(new object[] { 15.23f, 20.99999999999f })]
        [InlineData(new object[] { 2, -5 })]
        public void arbitaryNormalisation(double x, double y)
        {
            dvec2 original = new dvec2(x, y);
            dvec2 normalised = original.normalised;
            dvec2 reconstructed = normalised * original.length;

            Assert.Equal(original.length, original.Length);
            Assert.Equal(original.length * original.length, original.LengthSquared);

            Assert.True(Math.Abs(reconstructed.x - original.x) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(reconstructed.y - original.y) < REALLY_SMALL_VALUE);
        }

        [Theory]
        [InlineData(new object[] { 1, 2 })]
        [InlineData(new object[] { 5.2f, 10.00001f })]
        [InlineData(new object[] { -37, 0 })]
        [InlineData(new object[] { 3, 4 })]
        [InlineData(new object[] { 15.23f, 20.99999999999f })]
        [InlineData(new object[] { 2, -5 })]
        public void normaliseImperative(double x, double y)
        {
            dvec2 working = new dvec2(x, y);
            double length = working.length;
            working.normalise();
            Assert.True(Math.Abs(working.length - 1) < REALLY_SMALL_VALUE);
            working *= length;
            Assert.True(Math.Abs(working.length - length) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(x - working.x) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(y - working.y) < REALLY_SMALL_VALUE);
        }


        [Theory]
        [InlineData(new object[] { 0, 0, 0, 0, 0 })]
        [InlineData(new object[] { 6, 0, 0, 1, 0 })]
        [InlineData(new object[] { 5, 0, 5, 0, 25 })]
        [InlineData(new object[] { 5, 0, -10, 0, -50 })]
        [InlineData(new object[] { 1, 0, 0, 1, 0 })]
        [InlineData(new object[] { 1, 0, 1, 0, 1 })]
        [InlineData(new object[] { 0, 1, 0, 1, 1 })]
        [InlineData(new object[] { 0, 1, 0, -1, -1 })]
        [InlineData(new object[] { -1, 0, 1, 0, -1 })]
        public void dotProduct(double x1, double y1, double x2, double y2, double expectedResult)
        {
            dvec2 a = new dvec2(x1, y1);
            dvec2 b = new dvec2(x2, y2);

            double result = a.dot(b);

            Assert.True(Math.Abs(result - expectedResult) < REALLY_SMALL_VALUE);
        }

        [Theory]
        [InlineData(new object[] { 0, 0, 0, 0 })]
        [InlineData(new object[] { 0, 1, 1, 0 })]
        [InlineData(new object[] { 0, -1, -1, 0 })]
        [InlineData(new object[] { 1, 0, 0, 1 })]
        [InlineData(new object[] { -1, 0, 0, -1 })]
        public void crossProduct(double x, double y, double expectedX, double expectedY)
        {
            dvec2 a = new dvec2(x, y);
            dvec2 b = a.cross();

            Assert.True(Math.Abs(b.x - expectedX) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(b.y - expectedY) < REALLY_SMALL_VALUE);
        }

        [Fact]
        public void cardinalNormalisation()
        {
            dvec2 north = new dvec2(0, -100);
            Assert.Equal(0, north.normalised.x);
            Assert.Equal(-1, north.normalised.y);

            dvec2 south = new dvec2(0, 25);
            Assert.Equal(0, south.normalised.x);
            Assert.Equal(1, south.normalised.y);

            dvec2 east = new dvec2(5.23487927342f, 0);
            Assert.Equal(1, east.normalised.x);
            Assert.Equal(0, east.normalised.y);

            dvec2 west = new dvec2(-1, 0);
            Assert.Equal(-1, west.normalised.x);
            Assert.Equal(0, west.normalised.y);
        }


        [Fact]
        public void getCardinalAnglesDegrees()
        {
            dvec2 north = new dvec2(0, -1);
            Assert.Equal(0, north.angleDegrees);

            dvec2 south = new dvec2(0, 1);
            Assert.Equal(180, south.angleDegrees);

            dvec2 east = new dvec2(1, 0);
            Assert.Equal(90, east.angleDegrees);

            dvec2 west = new dvec2(-1, 0);
            Assert.Equal(270, west.angleDegrees);
        }


        [Fact]
        public void fromCardinalAnglesDegrees()
        {
            dvec2 north = dvec2.fromAngleDegrees(0);
            Assert.True(Math.Abs(north.x) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(north.y + 1) < REALLY_SMALL_VALUE);

            dvec2 south = dvec2.fromAngleDegrees(180);
            Assert.True(Math.Abs(south.x) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(south.y - 1) < REALLY_SMALL_VALUE);

            dvec2 east = dvec2.fromAngleDegrees(90);
            Assert.True(Math.Abs(east.x - 1) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(east.y) < REALLY_SMALL_VALUE);

            dvec2 west = dvec2.fromAngleDegrees(270);
            Assert.True(Math.Abs(west.x + 1) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(west.y) < REALLY_SMALL_VALUE);
        }


        [Theory]
        [InlineData(new object[] { 0, 20, 0, -20 })]
        [InlineData(new object[] { 90, 500, 500, 0 })]
        [InlineData(new object[] { 180, 123, 0, 123 })]
        [InlineData(new object[] { 270, 0.1, -0.1, 0 })]
        public void fromCardinalAnglesAndLengthDegrees(double direction, double length,
            double expectedX, double expectedY)
        {
            dvec2 vector = dvec2.fromAngleDegreesAndLength(direction, length);
            Assert.True(Math.Abs(vector.x - expectedX) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(vector.y - expectedY) < REALLY_SMALL_VALUE);
        }


        [Theory]
        [InlineData(new object[] { 0, 20, 0, -20 })]
        [InlineData(new object[] { Math.PI, 123, 0, 123 })]
        [InlineData(new object[] { Math.PI / 2, -10, -10, 0 })]
        [InlineData(new object[] { Math.PI / 2, 3, 3, 0 })]
        [InlineData(new object[] { Math.PI * (3 / 2.0f), 0.1f, -0.1f, 0 })]
        public void fromCardinalAnglesAndLengthRadians(double direction, double length,
            double expectedX, double expectedY)
        {
            dvec2 vector = dvec2.fromAngleRadiansAndLength(direction, length);
            Assert.True(Math.Abs(vector.x - expectedX) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(vector.y - expectedY) < REALLY_SMALL_VALUE);
        }

        [Fact]
        public void getCardinalAnglesRadians()
        {
            dvec2 north = new dvec2(0, -1);
            Assert.Equal(0, north.angleRadians);

            dvec2 south = new dvec2(0, 1);
            Assert.True(south.angleRadians - Math.PI < REALLY_SMALL_VALUE);

            dvec2 east = new dvec2(1, 0);
            Assert.True(east.angleRadians - Math.PI / 2 < REALLY_SMALL_VALUE);

            dvec2 west = new dvec2(-1, 0);
            Assert.True(west.angleRadians - Math.PI * (3 / 2.0) < REALLY_SMALL_VALUE);
        }


        [Fact]
        public void fromCardinalAnglesRadians()
        {
            dvec2 north = dvec2.fromAngleRadians(0);
            Assert.True(Math.Abs(north.x) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(north.y + 1) < REALLY_SMALL_VALUE);

            dvec2 south = dvec2.fromAngleRadians(Math.PI);
            Assert.True(Math.Abs(south.x) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(south.y - 1) < REALLY_SMALL_VALUE);

            dvec2 east = dvec2.fromAngleRadians((double)(Math.PI / 2.0));
            Assert.True(Math.Abs(east.x - 1) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(east.y) < REALLY_SMALL_VALUE);

            dvec2 west = dvec2.fromAngleRadians((double)(Math.PI * (3 / 2.0f)));
            Assert.True(Math.Abs(west.x + 1) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(west.y) < REALLY_SMALL_VALUE);
        }
    }
}
