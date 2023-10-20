using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Anathema.Vectors.Core;

namespace Anathema.Vectors.Tests
{
    public class fvec3Tests
    {
        const float REALLY_SMALL_VALUE = 0.00005f;


        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 300000000, 2, 1.5 })]
        [InlineData(new object[] { -1, 2.2342, 0.00001f })]
        public void indices(float x, float y, float z)
        {
            fvec3 a = new fvec3(x, y, z);
            Assert.Equal(a[0], x);
            Assert.Equal(a[1], y);
            Assert.Equal(a[1], y);
            Assert.Equal(a.ToArray()[0], a[0]);
            Assert.Equal(a.ToArray()[1], a[1]);
            Assert.Equal(a.ToArray()[2], a[2]);
        }



        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 12.345346356f })]
        [InlineData(new object[] { -37, 0, 11 })]
        [InlineData(new object[] { 3, 4, -4 })]
        [InlineData(new object[] { 15.23f, 20.99999999999f, 100000000000.0f })]
        [InlineData(new object[] { 2, -5, 0.1f })]
        public void arbitaryNormalisation(float x, float y, float z)
        {
            fvec3 original = new fvec3(x, y, z);
            fvec3 normalised = original.normalised;
            fvec3 reconstructed = normalised * original.length;

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
            fvec3 working = new fvec3(x, y, z);
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
                                       9 })]
        [InlineData(new object[] {  0, 4, 0,
                                    0, 4, 0,
                                       16 })]
        [InlineData(new object[] {  0, 0, 5,
                                    0, 0, 5,
                                       25 })]
        [InlineData(new object[] {  1, 0, 5,
                                    1, 0, 5,
                                       1 + 25 })]
        [InlineData(new object[] {  1, 2, 3,
                                    1, 2, 3,
                                       1 + 4 + 9 })]
        [InlineData(new object[] {  1, 2, 3,
                                    4, 5, 6,
                                       (1*4) + (2*5) + (3*6) })]
        public void dotProduct(float x1, float y1, float z1, float x2, float y2, float z2, float expectedResult)
        {
            fvec3 a = new fvec3(x1, y1, z1);
            fvec3 b = new fvec3(x2, y2, z2);

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
            fvec3 a = new fvec3(x1, y1, z1);
            fvec3 b = new fvec3(x2, y2, z2);

            fvec3 result = a.cross(b);

            Assert.True(result == new fvec3(resultX, resultY, resultZ));
        }

        [Fact]
        public void cardinalNormalisation()
        {
            fvec3 north = new fvec3(0, -100, 0);
            Assert.Equal(0, north.normalised.x);
            Assert.Equal(-1, north.normalised.y);

            fvec3 south = new fvec3(0, 25, 0);
            Assert.Equal(0, south.normalised.x);
            Assert.Equal(1, south.normalised.y);

            fvec3 east = new fvec3(5.23487927342f, 0, 0);
            Assert.Equal(1, east.normalised.x);
            Assert.Equal(0, east.normalised.y);

            fvec3 west = new fvec3(-1, 0, 0);
            Assert.Equal(-1, west.normalised.x);
            Assert.Equal(0, west.normalised.y);

            fvec3 forward = new fvec3(0, 0, 10);
            Assert.Equal(0, forward.normalised.x);
            Assert.Equal(0, forward.normalised.y);
            Assert.Equal(1, forward.normalised.z);

            fvec3 backward = new fvec3(0, 0, -0.0001f);
            Assert.Equal(0, backward.normalised.x);
            Assert.Equal(0, backward.normalised.y);
            Assert.Equal(-1, backward.normalised.z);
        }






        [Fact]
        public void construct()
        {
            fvec3 defaultConstructed = new fvec3();
            Assert.Equal(0, defaultConstructed.x);
            Assert.Equal(0, defaultConstructed.y);
            Assert.Equal(0, defaultConstructed.z);

            fvec3 specifiedComponents = new fvec3(1, 2, 3);
            Assert.Equal(1, specifiedComponents.x);
            Assert.Equal(2, specifiedComponents.y);
            Assert.Equal(3, specifiedComponents.z);

            fvec3 fromArray = new fvec3(new float[] { 1, 2, 3 });
            Assert.Equal(1, fromArray.x);
            Assert.Equal(2, fromArray.y);
            Assert.Equal(3, fromArray.z);

            fvec3 fromFVec3 = new fvec3(specifiedComponents);
            Assert.Equal(1, fromFVec3.x);
            Assert.Equal(2, fromFVec3.y);
            Assert.Equal(3, fromFVec3.z);

            dvec3 source = new dvec3(8, 5, -1);
            fvec3 fromDVec3 = new fvec3(source);
            Assert.Equal(8, fromDVec3.x);
            Assert.Equal(5, fromDVec3.y);
            Assert.Equal(-1, fromDVec3.z);
        }




        [Fact]
        public void equality()
        {
            fvec3 a = new fvec3(1, 2, 3);
            fvec3 b = new fvec3((1 / 3.0f) * 3.0f, 2, 3);
            fvec3 c = new fvec3(5, 2, 3);

            Assert.False(a != a);
            Assert.False(b != b);
            Assert.False(c != c);

            Assert.True(a == a);
            Assert.True(b == b);
            Assert.True(c == c);

            Assert.True(a == b);
            Assert.True(b == a);

            Assert.True(a != c);
            Assert.True(c != a);

            Assert.True(b != c);
            Assert.True(c != b);

            Assert.False(a == c);
            Assert.False(c == a);

            Assert.False(b == c);
            Assert.False(c == b);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4, 5, 6 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f, -10000.0f, 20.0f })]
        [InlineData(new object[] { -37, 0, 2, -5, 0, 10})]
        public void fvec3Addition(float x1, float y1, float z1, float x2, float y2, float z2)
        {
            fvec3 a = new fvec3(x1, y1, z1);
            fvec3 b = new fvec3(x2, y2, z2);

            fvec3 c = a + b;
            fvec3 d = b + a;

            Assert.Equal(x1 + x2, c.x);
            Assert.Equal(x1 + x2, d.x);
            Assert.Equal(y1 + y2, c.y);
            Assert.Equal(y1 + y2, d.y);
            Assert.Equal(z1 + z2, c.z);
            Assert.Equal(z1 + z2, d.z);
        }


    }
}
