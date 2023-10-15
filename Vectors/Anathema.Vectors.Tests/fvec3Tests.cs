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













    }
}
