#pragma warning disable CS1718 // Comparison made to same variable
using System;
using Xunit;
using Anathema.Vectors.Core;

namespace Anathema.Vectors.Tests.DoubleVectors
{
    public class dvec2Tests
    {
        //todo: include some cross tests for fvec2 conversions
        //todo: replace InlineData with MemberData

        const double REALLY_SMALL_VALUE = 0.00005f;

        [Theory]
        [InlineData(new object[] { 1, 2 })]
        [InlineData(new object[] { 300000000, 2 })]
        [InlineData(new object[] { -1, 2.2342 })]
        public void indices(double x, double y)
        {
            dvec2 a = new dvec2(x, y);
            Assert.Equal(a[0], x);
            Assert.Equal(a[1], y);
            Assert.Equal(a.ToArray()[0], a[0]);
            Assert.Equal(a.ToArray()[1], a[1]);
        }

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


        [Fact]
        public void construct()
        {
            dvec2 defaultConstructed = new dvec2();
            Assert.Equal(0, defaultConstructed.x);
            Assert.Equal(0, defaultConstructed.y);

            dvec2 specifiedComponents = new dvec2(1, 2);
            Assert.Equal(1, specifiedComponents.x);
            Assert.Equal(2, specifiedComponents.y);

            dvec2 fromdvec2 = new dvec2(specifiedComponents);
            Assert.Equal(1, fromdvec2.x);
            Assert.Equal(2, fromdvec2.y);

            dvec2 source = new dvec2(8, 5);
            dvec2 fromDVec2 = new dvec2(source);
            Assert.Equal(8, fromDVec2.x);
            Assert.Equal(5, fromDVec2.y);
        }


        [Fact]
        public void equality()
        {
            double a = 1.0f;
            double b = a / 3.0f;
            double c = b * 3.0f;
            double d = 0.999999999999f;

            dvec2 x = new dvec2(a, c);
            dvec2 y = new dvec2(c, a);
            dvec2 z = new dvec2(d, d);
            dvec2 w = new dvec2(1.1f, a);

            Assert.False(x == null);
            Assert.False(null == x);
            Assert.True(x != null);
            Assert.True(null != x);

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
        public void dvec2Addition(double x1, double y1, double x2, double y2)
        {
            dvec2 a = new dvec2(x1, y1);
            dvec2 b = new dvec2(x2, y2);

            dvec2 c = a + b;
            dvec2 d = b + a;

            Assert.Equal(x1 + x2, c.x);
            Assert.Equal(x1 + x2, d.x);
            Assert.Equal(y1 + y2, c.y);
            Assert.Equal(y1 + y2, d.y);
        }

        [Fact]
        public void negation()
        {
            dvec2 a = new dvec2(1, 2);
            dvec2 b = -a;

            Assert.Equal(-1, b.x);
            Assert.Equal(-2, b.y);
        }


        [Fact]
        public void swizzleAssign()
        {
            dvec2 a = new dvec2(1, 2);
            Assert.Equal(1, a.x);
            Assert.Equal(2, a.y);

            a.xy = new dvec2(3, 4);
            Assert.Equal(3, a.x);
            Assert.Equal(4, a.y);

            a.yx = new dvec2(6, 5);
            Assert.Equal(5, a.x);
            Assert.Equal(6, a.y);

            dvec2 b = new dvec2(8, 7);
            a.yx = b;
            Assert.Equal(7, a.x);
            Assert.Equal(8, a.y);

        }


        [Fact]
        public void colourSwizzleAssign()
        {
            dvec2 a = new dvec2(1, 2);
            Assert.Equal(1, a.x);
            Assert.Equal(2, a.y);

            a.rg = new dvec2(3, 4);
            Assert.Equal(3, a.x);
            Assert.Equal(4, a.y);

            a.gr = new dvec2(6, 5);
            Assert.Equal(5, a.x);
            Assert.Equal(6, a.y);

            dvec2 b = new dvec2(8, 7);
            a.gr = b;
            Assert.Equal(7, a.x);
            Assert.Equal(8, a.y);
        }


        [Theory]
        [InlineData(new object[] { 1, 2 })]
        [InlineData(new object[] { 5.2f, 10.00001f })]
        [InlineData(new object[] { -37, 0 })]
        public void swizzles(double x1, double y1)
        {
            dvec2 a = new dvec2(x1, y1);

            Assert.Equal(a.xy.x, a.x);
            Assert.Equal(a.xy.y, a.y);

            Assert.Equal(a.yx.x, a.y);
            Assert.Equal(a.yx.y, a.x);
        }





        [Theory]
        [InlineData(new object[] { 1, 2 })]
        [InlineData(new object[] { 5.2f, 10.00001f })]
        [InlineData(new object[] { -37, 0 })]
        public void colourSwizzles(double x1, double y1)
        {
            dvec2 a = new dvec2(x1, y1);

            Assert.Equal(a.rg.r, a.x);
            Assert.Equal(a.rg.g, a.y);

            Assert.Equal(a.gr.r, a.y);
            Assert.Equal(a.gr.g, a.x);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2 })]
        public void scalarAddition(double x, double y, double scalar)
        {
            dvec2 a = new dvec2(x, y);

            dvec2 c = a + scalar;
            dvec2 d = scalar + a;

            Assert.Equal(x + scalar, c.x);
            Assert.Equal(x + scalar, d.x);
            Assert.Equal(y + scalar, c.y);
            Assert.Equal(y + scalar, d.y);
        }


        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void vec2Subtraction(double x1, double y1, double x2, double y2)
        {
            dvec2 a = new dvec2(x1, y1);
            dvec2 b = new dvec2(x2, y2);

            dvec2 c = a - b;
            dvec2 d = b - a;

            Assert.Equal(x1 - x2, c.x);
            Assert.Equal(x2 - x1, d.x);
            Assert.Equal(y1 - y2, c.y);
            Assert.Equal(y2 - y1, d.y);
        }


        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void dvec2Subtraction(double x1, double y1, double x2, double y2)
        {
            dvec2 a = new dvec2(x1, y1);
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
        public void scalarSubtraction(double x, double y, double scalar)
        {
            dvec2 a = new dvec2(x, y);

            dvec2 c = a - scalar;
            dvec2 d = scalar - a;

            Assert.Equal(x - scalar, c.x);
            Assert.Equal(y - scalar, c.y);
            Assert.Equal(scalar - x, d.x);
            Assert.Equal(scalar - y, d.y);
        }




        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void vec2Multiplication(double x1, double y1, double x2, double y2)
        {
            dvec2 a = new dvec2(x1, y1);
            dvec2 b = new dvec2(x2, y2);

            dvec2 c = a * b;
            dvec2 d = b * a;

            Assert.Equal(x1 * x2, c.x);
            Assert.Equal(x1 * x2, d.x);
            Assert.Equal(y1 * y2, c.y);
            Assert.Equal(y1 * y2, d.y);
        }


        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void dvec2Multiplication(double x1, double y1, double x2, double y2)
        {
            dvec2 a = new dvec2(x1, y1);
            dvec2 b = new dvec2(x2, y2);

            dvec2 c = a * b;
            dvec2 d = b * a;

            Assert.True(x1 * x2 == c.x);
            Assert.True(x1 * x2 == d.x);
            Assert.True(y1 * y2 == c.y);
            Assert.True(y1 * y2 == d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void fvec2MutatorMultiplication(double x1, double y1, double x2, double y2)
        {
            dvec2 a = new dvec2(x1, y1);
            dvec2 b = new dvec2(x2, y2);

            a *= b;

            Assert.True(x1 * x2 == a.x);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2 })]
        public void scalarMultiplication(double x, double y, double scalar)
        {
            dvec2 a = new dvec2(x, y);

            dvec2 c = a * scalar;
            dvec2 d = scalar * a;

            Assert.Equal(x * scalar, c.x);
            Assert.Equal(x * scalar, d.x);
            Assert.Equal(y * scalar, c.y);
            Assert.Equal(y * scalar, d.y);
        }




        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void vec2Division(double x1, double y1, double x2, double y2)
        {
            dvec2 a = new dvec2(x1, y1);
            dvec2 b = new dvec2(x2, y2);

            dvec2 c = a / b;
            dvec2 d = b / a;

            Assert.Equal(x1 / x2, c.x);
            Assert.Equal(y1 / y2, c.y);
            Assert.Equal(x2 / x1, d.x);
            Assert.Equal(y2 / y1, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void dvec2Division(double x1, double y1, double x2, double y2)
        {
            dvec2 a = new dvec2(x1, y1);
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
        public void scalarDivision(double x, double y, double scalar)
        {
            dvec2 a = new dvec2(x, y);

            dvec2 c = a / scalar;
            dvec2 d = scalar / a;

            Assert.Equal(x / scalar, c.x);
            Assert.Equal(y / scalar, c.y);
            Assert.Equal(scalar / x, d.x);
            Assert.Equal(scalar / y, d.y);
        }
    }
}
