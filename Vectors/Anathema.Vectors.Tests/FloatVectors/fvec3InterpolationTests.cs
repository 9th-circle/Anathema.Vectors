using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.FloatVectors
{
    public class fvec3InterpolationTests
    {
        [Fact]
        public void linearInterpolateTo()
        {
            fvec3 a = new fvec3(10, 20, 30);
            fvec3 c = new fvec3(20, 30, 40);

            for (int i = 0; i < 100; i++)
            {
                float f = i / 100.0f;
                float expectedX = (i / 10.0f) + 10;
                float expectedY = (i / 10.0f) + 20;
                float expectedZ = (i / 10.0f) + 30;
                Assert.True(Math.Abs(expectedX - a.linearInterpolateTo(c, f).x) < scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(expectedY - a.linearInterpolateTo(c, f).y) < scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(expectedZ - a.linearInterpolateTo(c, f).z) < scalar.floatComparisonTolerance);
            }
        }
        [Fact]
        public void degenerateQuadraticBezierTo()
        {
            fvec3 a = new fvec3(10, 20, 30);
            fvec3 b = new fvec3(15, 25, 35);
            fvec3 c = new fvec3(20, 30, 40);

            for (int i = 0; i < 100; i++)
            {
                float f = i / 100.0f;
                float expectedX = (i / 10.0f) + 10;
                float expectedY = (i / 10.0f) + 20;
                float expectedZ = (i / 10.0f) + 30;
                Assert.True(Math.Abs(expectedX - a.quadraticBezierInterpolateTo(b, c, f).x) < scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(expectedY - a.quadraticBezierInterpolateTo(b, c, f).y) < scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(expectedZ - a.quadraticBezierInterpolateTo(b, c, f).z) < scalar.floatComparisonTolerance);

            }
        }
        [Fact]
        public void degenerateCubicBezier()
        {
            fvec3 a = new fvec3(10, 10, 10);
            fvec3 b = new fvec3(15, 15, 15);
            fvec3 c = new fvec3(20, 20, 20);
            fvec3 d = new fvec3(25, 25, 25);

            for (int i = 0; i < 100; i++)
            {
                float f = i / 100.0f;
                Assert.True(Math.Abs(fvec3.cubicBezierInterpolate(a, b, c, d, f).x -
                                     fvec3.cubicBezierInterpolate(a, b, c, d, f).y) < scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(fvec3.cubicBezierInterpolate(a, b, c, d, f).x -
                                     fvec3.cubicBezierInterpolate(a, b, c, d, f).z) < scalar.floatComparisonTolerance);

            }
        }
        [Fact]
        public void nonDegenerateCubicBezier()
        {
            fvec3 a = new fvec3(10, 10, 10);
            fvec3 b = new fvec3(20, 10, 20);
            fvec3 c = new fvec3(10, 15, 10);
            fvec3 d = new fvec3(25, 25, 25);

            for (int i = 10; i < 90; i++)
            {
                float f = i / 100.0f;
                Assert.True(Math.Abs(fvec3.cubicBezierInterpolate(a, b, c, d, f).x -
                                     fvec3.cubicBezierInterpolate(a, b, c, d, f).y) > scalar.floatComparisonTolerance);
            }
        }
        [Fact]
        public void degenerateCubicBezierTo()
        {
            fvec3 a = new fvec3(10, 10, 10);
            fvec3 b = new fvec3(15, 15, 15);
            fvec3 c = new fvec3(20, 20, 20);
            fvec3 d = new fvec3(25, 25, 25);

            for (int i = 0; i < 100; i++)
            {
                float f = i / 100.0f;
                Assert.True(Math.Abs(a.cubicBezierInterpolateTo(b, c, d, f).x -
                                     a.cubicBezierInterpolateTo(b, c, d, f).y) < scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(a.cubicBezierInterpolateTo(b, c, d, f).x -
                                     a.cubicBezierInterpolateTo(b, c, d, f).z) < scalar.floatComparisonTolerance);
            }
        }
        [Fact]
        public void degenerateQuadraticBezier()
        {
            fvec3 a = new fvec3(10, 20, 30);
            fvec3 b = new fvec3(15, 25, 35);
            fvec3 c = new fvec3(20, 30, 40);

            for (int i = 0; i < 100; i++)
            {
                float f = i / 100.0f;
                float expectedX = (i / 10.0f) + 10;
                float expectedY = (i / 10.0f) + 20;
                float expectedZ = (i / 10.0f) + 30;
                Assert.True(Math.Abs(expectedX - fvec3.quadraticBezierInterpolate(a, b, c, f).x) < scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(expectedY - fvec3.quadraticBezierInterpolate(a, b, c, f).y) < scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(expectedZ - fvec3.quadraticBezierInterpolate(a, b, c, f).z) < scalar.floatComparisonTolerance);

            }
        }
        [Fact]
        public void nonDegenerateQuadraticBezier()
        {
            fvec3 a = new fvec3(10, 20, 30);
            fvec3 b = new fvec3(30, 40, 50);
            fvec3 c = new fvec3(20, 30, 40);

            for (int i = 10; i < 90; i++)
            {
                float f = i / 100.0f;
                float expectedX = (i / 10.0f) + 10;
                float expectedY = (i / 10.0f) + 20;
                float expectedZ = (i / 10.0f) + 30;
                Assert.True(Math.Abs(expectedX - fvec3.quadraticBezierInterpolate(a, b, c, f).x) > scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(expectedY - fvec3.quadraticBezierInterpolate(a, b, c, f).y) > scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(expectedZ - fvec3.quadraticBezierInterpolate(a, b, c, f).z) > scalar.floatComparisonTolerance);
            }
        }
    }
}
