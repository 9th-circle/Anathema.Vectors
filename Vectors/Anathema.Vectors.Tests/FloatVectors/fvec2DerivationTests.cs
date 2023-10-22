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
            vec2 original = new vec2(x, y);
            vec2 normalised = original.normalised;
            vec2 reconstructed = normalised * original.length;

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
        public void normaliseImperative(float x, float y)
        {
            vec2 working = new vec2(x, y);
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
            vec2 a = new vec2(x1, y1);
            vec2 b = new vec2(x2, y2);

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
            vec2 a = new vec2(x, y);
            vec2 b = a.cross();


            Assert.True(Math.Abs(b.x - expectedX) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(b.y - expectedY) < REALLY_SMALL_VALUE);
        }

        [Fact]
        public void cardinalNormalisation()
        {
            vec2 north = new vec2(0, -100);
            Assert.Equal(0, north.normalised.x);
            Assert.Equal(-1, north.normalised.y);

            vec2 south = new vec2(0, 25);
            Assert.Equal(0, south.normalised.x);
            Assert.Equal(1, south.normalised.y);

            vec2 east = new vec2(5.23487927342f, 0);
            Assert.Equal(1, east.normalised.x);
            Assert.Equal(0, east.normalised.y);

            vec2 west = new vec2(-1, 0);
            Assert.Equal(-1, west.normalised.x);
            Assert.Equal(0, west.normalised.y);
        }


        [Fact]
        public void getCardinalAnglesDegrees()
        {
            vec2 north = new vec2(0, -1);
            Assert.Equal(0, north.angleDegrees);

            vec2 south = new vec2(0, 1);
            Assert.Equal(180, south.angleDegrees);

            vec2 east = new vec2(1, 0);
            Assert.Equal(90, east.angleDegrees);

            vec2 west = new vec2(-1, 0);
            Assert.Equal(270, west.angleDegrees);
        }


        [Fact]
        public void fromCardinalAnglesDegrees()
        {
            vec2 north = vec2.fromAngleDegrees(0);
            Assert.True(Math.Abs(north.x) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(north.y + 1) < REALLY_SMALL_VALUE);

            vec2 south = vec2.fromAngleDegrees(180);
            Assert.True(Math.Abs(south.x) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(south.y - 1) < REALLY_SMALL_VALUE);

            vec2 east = vec2.fromAngleDegrees(90);
            Assert.True(Math.Abs(east.x - 1) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(east.y) < REALLY_SMALL_VALUE);

            vec2 west = vec2.fromAngleDegrees(270);
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
            vec2 vector = vec2.fromAngleDegreesAndLength(direction, length);
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
            vec2 vector = vec2.fromAngleRadiansAndLength(direction, length);
            Assert.True(Math.Abs(vector.x - expectedX) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(vector.y - expectedY) < REALLY_SMALL_VALUE);
        }

        [Fact]
        public void getCardinalAnglesRadians()
        {
            vec2 north = new vec2(0, -1);
            Assert.Equal(0, north.angleRadians);

            vec2 south = new vec2(0, 1);
            Assert.True(south.angleRadians - Math.PI < REALLY_SMALL_VALUE);

            vec2 east = new vec2(1, 0);
            Assert.True(east.angleRadians - Math.PI / 2 < REALLY_SMALL_VALUE);

            vec2 west = new vec2(-1, 0);
            Assert.True(west.angleRadians - Math.PI * (3 / 2.0) < REALLY_SMALL_VALUE);
        }


        [Fact]
        public void fromCardinalAnglesRadians()
        {
            vec2 north = vec2.fromAngleRadians(0);
            Assert.True(Math.Abs(north.x) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(north.y + 1) < REALLY_SMALL_VALUE);

            vec2 south = vec2.fromAngleRadians((float)Math.PI);
            Assert.True(Math.Abs(south.x) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(south.y - 1) < REALLY_SMALL_VALUE);

            vec2 east = vec2.fromAngleRadians((float)(Math.PI / 2.0));
            Assert.True(Math.Abs(east.x - 1) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(east.y) < REALLY_SMALL_VALUE);

            vec2 west = vec2.fromAngleRadians((float)(Math.PI * (3 / 2.0f)));
            Assert.True(Math.Abs(west.x + 1) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(west.y) < REALLY_SMALL_VALUE);
        }


    }
}
