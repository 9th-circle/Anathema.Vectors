using Anathema.Vectors.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Anathema.Vectors.Tests.FloatVectors
{
    public class fvec2DerivationTests
    {
        const float REALLY_SMALL_VALUE = 0.00005f;
        [Theory]
        [InlineData(new object[] { 1, 2 })]
        [InlineData(new object[] { 5.2f, 10.00001f })]
        [InlineData(new object[] { -37, 0 })]
        [InlineData(new object[] { 3, 4 })]
        [InlineData(new object[] { 15.23f, 20.99999999999f })]
        [InlineData(new object[] { 2, -5 })]
        public void arbitaryNormalisation(float x, float y)
        {
            fvec2 original = new fvec2(x, y);
            fvec2 normalised = original.normalised;
            fvec2 reconstructed = normalised * original.length;

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
        public void normaliseImperative(float x, float y)
        {
            fvec2 working = new fvec2(x, y);
            float length = working.length;
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
        public void dotProduct(float x1, float y1, float x2, float y2, float expectedResult)
        {
            fvec2 a = new fvec2(x1, y1);
            fvec2 b = new fvec2(x2, y2);

            float result = a.dot(b);

            Assert.True(Math.Abs(result - expectedResult) < REALLY_SMALL_VALUE);
        }

        [Theory]
        [InlineData(new object[] { 0, 0, 0, 0 })]
        [InlineData(new object[] { 0, 1, 1, 0 })]
        [InlineData(new object[] { 0, -1, -1, 0 })]
        [InlineData(new object[] { 1, 0, 0, 1 })]
        [InlineData(new object[] { -1, 0, 0, -1 })]
        public void crossProduct(float x, float y, float expectedX, float expectedY)
        {
            fvec2 a = new fvec2(x, y);
            fvec2 b = a.cross();


            Assert.True(Math.Abs(b.x - expectedX) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(b.y - expectedY) < REALLY_SMALL_VALUE);
        }

        [Fact]
        public void cardinalNormalisation()
        {
            fvec2 north = new fvec2(0, -100);
            Assert.Equal(0, north.normalised.x);
            Assert.Equal(-1, north.normalised.y);

            fvec2 south = new fvec2(0, 25);
            Assert.Equal(0, south.normalised.x);
            Assert.Equal(1, south.normalised.y);

            fvec2 east = new fvec2(5.23487927342f, 0);
            Assert.Equal(1, east.normalised.x);
            Assert.Equal(0, east.normalised.y);

            fvec2 west = new fvec2(-1, 0);
            Assert.Equal(-1, west.normalised.x);
            Assert.Equal(0, west.normalised.y);
        }


        [Fact]
        public void getCardinalAnglesDegrees()
        {
            fvec2 north = new fvec2(0, -1);
            Assert.Equal(0, north.angleDegrees);

            fvec2 south = new fvec2(0, 1);
            Assert.Equal(180, south.angleDegrees);

            fvec2 east = new fvec2(1, 0);
            Assert.Equal(90, east.angleDegrees);

            fvec2 west = new fvec2(-1, 0);
            Assert.Equal(270, west.angleDegrees);
        }


        [Fact]
        public void fromCardinalAnglesDegrees()
        {
            fvec2 north = fvec2.fromAngleDegrees(0);
            Assert.True(Math.Abs(north.x) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(north.y + 1) < REALLY_SMALL_VALUE);

            fvec2 south = fvec2.fromAngleDegrees(180);
            Assert.True(Math.Abs(south.x) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(south.y - 1) < REALLY_SMALL_VALUE);

            fvec2 east = fvec2.fromAngleDegrees(90);
            Assert.True(Math.Abs(east.x - 1) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(east.y) < REALLY_SMALL_VALUE);

            fvec2 west = fvec2.fromAngleDegrees(270);
            Assert.True(Math.Abs(west.x + 1) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(west.y) < REALLY_SMALL_VALUE);
        }


        [Theory]
        [InlineData(new object[] { 0, 20, 0, -20 })]
        [InlineData(new object[] { 90, 500, 500, 0 })]
        [InlineData(new object[] { 180, 123, 0, 123 })]
        [InlineData(new object[] { 270, 0.1, -0.1, 0 })]
        public void fromCardinalAnglesAndLengthDegrees(float direction, float length,
            float expectedX, float expectedY)
        {
            fvec2 vector = fvec2.fromAngleDegreesAndLength(direction, length);
            Assert.True(Math.Abs(vector.x - expectedX) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(vector.y - expectedY) < REALLY_SMALL_VALUE);
        }

        [Theory]
        [InlineData(new object[] { 0, 20, 0, -20 })]
        [InlineData(new object[] { (float)Math.PI, 123, 0, 123 })]
        [InlineData(new object[] { (float)Math.PI / 2, -10, -10, 0 })]
        [InlineData(new object[] { (float)Math.PI / 2, 3, 3, 0 })]
        [InlineData(new object[] { (float)Math.PI * (3 / 2.0f), 0.1f, -0.1f, 0 })]
        public void fromCardinalAnglesAndLengthRadians(float direction, float length,
            float expectedX, float expectedY)
        {
            fvec2 vector = fvec2.fromAngleRadiansAndLength(direction, length);
            Assert.True(Math.Abs(vector.x - expectedX) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(vector.y - expectedY) < REALLY_SMALL_VALUE);
        }

        [Fact]
        public void getCardinalAnglesRadians()
        {
            fvec2 north = new fvec2(0, -1);
            Assert.Equal(0, north.angleRadians);

            fvec2 south = new fvec2(0, 1);
            Assert.True(south.angleRadians - Math.PI < REALLY_SMALL_VALUE);

            fvec2 east = new fvec2(1, 0);
            Assert.True(east.angleRadians - Math.PI / 2 < REALLY_SMALL_VALUE);

            fvec2 west = new fvec2(-1, 0);
            Assert.True(west.angleRadians - Math.PI * (3 / 2.0) < REALLY_SMALL_VALUE);
        }


        [Fact]
        public void fromCardinalAnglesRadians()
        {
            fvec2 north = fvec2.fromAngleRadians(0);
            Assert.True(Math.Abs(north.x) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(north.y + 1) < REALLY_SMALL_VALUE);

            fvec2 south = fvec2.fromAngleRadians((float)Math.PI);
            Assert.True(Math.Abs(south.x) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(south.y - 1) < REALLY_SMALL_VALUE);

            fvec2 east = fvec2.fromAngleRadians((float)(Math.PI / 2.0));
            Assert.True(Math.Abs(east.x - 1) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(east.y) < REALLY_SMALL_VALUE);

            fvec2 west = fvec2.fromAngleRadians((float)(Math.PI * (3 / 2.0f)));
            Assert.True(Math.Abs(west.x + 1) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(west.y) < REALLY_SMALL_VALUE);
        }


    }
}
