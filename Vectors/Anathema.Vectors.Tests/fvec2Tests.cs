#pragma warning disable CS1718 // Comparison made to same variable
using System;
using Xunit;
using Anathema.Vectors.Core;

namespace Anathema.Vectors.Tests
{

    public class fvec2Tests
    {
        const float REALLY_SMALL_VALUE = 0.00005f;

        //Todo: Mutator operators (+= etc)

        [Theory]
        [InlineData(new object[] { 1, 2 })]
        [InlineData(new object[] { 300000000, 2 })]
        [InlineData(new object[] { -1, 2.2342 })]
        public void indices(float x, float y)
        {
            fvec2 a = new fvec2(x, y);
            Assert.Equal(a[0], x);
            Assert.Equal(a[1], y);
        }

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
            Assert.True(Math.Abs(north.y+1) < REALLY_SMALL_VALUE);

            fvec2 south = fvec2.fromAngleDegrees(180);
            Assert.True(Math.Abs(south.x) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(south.y-1) < REALLY_SMALL_VALUE);

            fvec2 east = fvec2.fromAngleDegrees(90);
            Assert.True(Math.Abs(east.x-1) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(east.y) < REALLY_SMALL_VALUE);

            fvec2 west = fvec2.fromAngleDegrees(270);
            Assert.True(Math.Abs(west.x + 1) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(west.y) < REALLY_SMALL_VALUE);
        }
        [Fact]
        public void fromCardinalAnglesAndLengthDegrees()
        {
            //todo: convert to theory
            fvec2 north = fvec2.fromAngleDegreesAndLength(0, 20);
            Assert.True(Math.Abs(north.x) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(north.y + 20) < REALLY_SMALL_VALUE);

            fvec2 south = fvec2.fromAngleDegreesAndLength(180,123);
            Assert.True(Math.Abs(south.x) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(south.y - 123) < REALLY_SMALL_VALUE);

            fvec2 east = fvec2.fromAngleDegreesAndLength(90,-10);
            Assert.True(Math.Abs(east.x + 10) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(east.y) < REALLY_SMALL_VALUE);

            fvec2 west = fvec2.fromAngleDegreesAndLength(270,0.1f);
            Assert.True(Math.Abs(west.x + 0.1) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(west.y) < REALLY_SMALL_VALUE);
        }

        [Fact]
        public void fromCardinalAnglesAndLengthRadians()
        {
            //todo: convert to theory
            fvec2 north = fvec2.fromAngleRadiansAndLength(0, 20);
            Assert.True(Math.Abs(north.x) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(north.y + 20) < REALLY_SMALL_VALUE);

            fvec2 south = fvec2.fromAngleRadiansAndLength((float)Math.PI, 123);
            Assert.True(Math.Abs(south.x) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(south.y - 123) < REALLY_SMALL_VALUE);

            fvec2 east = fvec2.fromAngleRadiansAndLength((float)Math.PI/2.0f, -10);
            Assert.True(Math.Abs(east.x + 10) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(east.y) < REALLY_SMALL_VALUE);

            fvec2 west = fvec2.fromAngleRadiansAndLength((float)(float)Math.PI * (3/2.0f), 0.1f);
            Assert.True(Math.Abs(west.x + 0.1) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(west.y) < REALLY_SMALL_VALUE);
        }

        [Fact]
        public void getCardinalAnglesRadians()
        {
            fvec2 north = new fvec2(0, -1);
            Assert.Equal(0, north.angleRadians);

            fvec2 south = new fvec2(0, 1);
            Assert.True(south.angleRadians-Math.PI < REALLY_SMALL_VALUE);

            fvec2 east = new fvec2(1, 0);
            Assert.True(east.angleRadians - (Math.PI/2) < REALLY_SMALL_VALUE);

            fvec2 west = new fvec2(-1, 0);
            Assert.True(west.angleRadians - (Math.PI * (3/2.0)) < REALLY_SMALL_VALUE);
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

            fvec2 east = fvec2.fromAngleRadians((float)(Math.PI/2.0));
            Assert.True(Math.Abs(east.x - 1) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(east.y) < REALLY_SMALL_VALUE);

            fvec2 west = fvec2.fromAngleRadians((float)(Math.PI * (3/2.0f)));
            Assert.True(Math.Abs(west.x + 1) < REALLY_SMALL_VALUE);
            Assert.True(Math.Abs(west.y) < REALLY_SMALL_VALUE);
        }


        [Fact]
        public void construct()
        {
            fvec2 defaultConstructed = new fvec2();
            Assert.Equal(0, defaultConstructed.x);
            Assert.Equal(0, defaultConstructed.y);

            fvec2 specifiedComponents = new fvec2(1, 2);
            Assert.Equal(1, specifiedComponents.x);
            Assert.Equal(2, specifiedComponents.y);

            fvec2 fromFVec2 = new fvec2(specifiedComponents);
            Assert.Equal(1, fromFVec2.x);
            Assert.Equal(2, fromFVec2.y);

            dvec2 source = new dvec2(8, 5);
            fvec2 fromDVec2 = new fvec2(source);
            Assert.Equal(8, fromDVec2.x);
            Assert.Equal(5, fromDVec2.y);
        }


        [Fact]
        public void equality()
        {
            float a = 1.0f;
            float b = a / 3.0f;
            float c = b * 3.0f;
            float d = 0.999999999999f;

            fvec2 x = new fvec2(a, c);
            fvec2 y = new fvec2(c, a);
            fvec2 z = new fvec2(d, d);
            fvec2 w = new fvec2(1.1f, a);

            Assert.True(x == y);
            Assert.True(y == z);
            Assert.True(z == x);
            Assert.False(w == x);
            Assert.False(w == y);
            Assert.False(w == z);
            Assert.True(w == w);

            Assert.False(x != y);
            Assert.False(y != z);
            Assert.False(z != x);
            Assert.True(w != x);
            Assert.True(w != y);
            Assert.True(w != z);
            Assert.False(w != w);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void fvec2Addition(float x1, float y1, float x2, float y2)
        {
            fvec2 a = new fvec2(x1, y1);
            fvec2 b = new fvec2(x2, y2);

            fvec2 c = a + b;
            fvec2 d = b + a;

            Assert.Equal(x1 + x2, c.x);
            Assert.Equal(x1 + x2, d.x);
            Assert.Equal(y1 + y2, c.y);
            Assert.Equal(y1 + y2, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2 })]
        [InlineData(new object[] { 5.2f, 10.00001f })]
        [InlineData(new object[] { -37, 0 })]
        public void swizzles(float x1, float y1)
        {
            fvec2 a = new fvec2(x1, y1);

            Assert.Equal(a.xy.x, a.x);
            Assert.Equal(a.xy.y, a.y);

            Assert.Equal(a.yx.x, a.y);
            Assert.Equal(a.yx.y, a.x);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void dvec2Addition(float x1, float y1, double x2, double y2)
        {
            fvec2 a = new fvec2(x1, y1);
            dvec2 b = new dvec2(x2, y2);

            dvec2 c = a + b;
            dvec2 d = b + a;

            Assert.True(x1 + x2 == c.x);
            Assert.True(x1 + x2 == d.x);
            Assert.True(y1 + y2 == c.y);
            Assert.True(y1 + y2 == d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2 })]
        public void scalarAddition(float x, float y, float scalar)
        {
            fvec2 a = new fvec2(x, y);

            fvec2 c = a + scalar;
            fvec2 d = scalar + a;

            Assert.Equal(x + scalar, c.x);
            Assert.Equal(x + scalar, d.x);
            Assert.Equal(y + scalar, c.y);
            Assert.Equal(y + scalar, d.y);
        }


        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void vec2Subtraction(float x1, float y1, float x2, float y2)
        {
            fvec2 a = new fvec2(x1, y1);
            fvec2 b = new fvec2(x2, y2);

            fvec2 c = a - b;
            fvec2 d = b - a;

            Assert.Equal(x1 - x2, c.x);
            Assert.Equal(x2 - x1, d.x);
            Assert.Equal(y1 - y2, c.y);
            Assert.Equal(y2 - y1, d.y);
        }


        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void dvec2Subtraction(float x1, float y1, double x2, double y2)
        {
            fvec2 a = new fvec2(x1, y1);
            dvec2 b = new dvec2(x2, y2);

            dvec2 c = a - b;
            dvec2 d = b - a;

            Assert.True(x1 - x2 == c.x);
            Assert.True(y1 - y2 == c.y);
            Assert.True(x2 - x1 == d.x);
            Assert.True(y2 - y1 == d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2 })]
        public void scalarSubtraction(float x, float y, float scalar)
        {
            fvec2 a = new fvec2(x, y);

            fvec2 c = a - scalar;
            fvec2 d = scalar - a;

            Assert.Equal(x - scalar, c.x);
            Assert.Equal(y - scalar, c.y);
            Assert.Equal(scalar - x, d.x);
            Assert.Equal(scalar - y, d.y);
        }




        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void vec2Multiplication(float x1, float y1, float x2, float y2)
        {
            fvec2 a = new fvec2(x1, y1);
            fvec2 b = new fvec2(x2, y2);

            fvec2 c = a * b;
            fvec2 d = b * a;

            Assert.Equal(x1 * x2, c.x);
            Assert.Equal(x1 * x2, d.x);
            Assert.Equal(y1 * y2, c.y);
            Assert.Equal(y1 * y2, d.y);
        }


        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void dvec2Multiplication(float x1, float y1, double x2, double y2)
        {
            fvec2 a = new fvec2(x1, y1);
            dvec2 b = new dvec2(x2, y2);

            dvec2 c = a * b;
            dvec2 d = b * a;

            Assert.True(x1 * x2 == c.x);
            Assert.True(x1 * x2 == d.x);
            Assert.True(y1 * y2 == c.y);
            Assert.True(y1 * y2 == d.y);
        }


        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2 })]
        public void scalarMultiplication(float x, float y, float scalar)
        {
            fvec2 a = new fvec2(x, y);

            fvec2 c = a * scalar;
            fvec2 d = scalar * a;

            Assert.Equal(x * scalar, c.x);
            Assert.Equal(x * scalar, d.x);
            Assert.Equal(y * scalar, c.y);
            Assert.Equal(y * scalar, d.y);
        }




        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void vec2Division(float x1, float y1, float x2, float y2)
        {
            fvec2 a = new fvec2(x1, y1);
            fvec2 b = new fvec2(x2, y2);

            fvec2 c = a / b;
            fvec2 d = b / a;

            Assert.Equal(x1 / x2, c.x);
            Assert.Equal(y1 / y2, c.y);
            Assert.Equal(x2 / x1, d.x);
            Assert.Equal(y2 / y1, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void dvec2Division(float x1, float y1, double x2, double y2)
        {
            fvec2 a = new fvec2(x1, y1);
            dvec2 b = new dvec2(x2, y2);

            dvec2 c = a / b;
            dvec2 d = b / a;

            Assert.True(x1 / x2 == c.x);
            Assert.True(y1 / y2 == c.y);
            Assert.True(x2 / x1 == d.x);
            Assert.True(y2 / y1 == d.y);
        }



        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2 })]
        public void scalarDivision(float x, float y, float scalar)
        {
            fvec2 a = new fvec2(x, y);

            fvec2 c = a / scalar;
            fvec2 d = scalar / a;

            Assert.Equal(x / scalar, c.x);
            Assert.Equal(y / scalar, c.y);
            Assert.Equal(scalar / x, d.x);
            Assert.Equal(scalar / y, d.y);
        }
    }
}
