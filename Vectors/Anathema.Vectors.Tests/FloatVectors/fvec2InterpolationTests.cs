using System;
using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.FloatVectors
{
    public class fvec2InterpolationTests
    {

        [Fact]
        public void linearInterpolateTo()
        {
            fvec2 a = new fvec2(10, 20);
            fvec2 c = new fvec2(20, 30);

            for (int i = 0; i < 100; i++)
            {
                float f = i / 100.0f;
                float expectedX = (i / 10.0f) + 10;
                float expectedY = (i / 10.0f) + 20;
                Assert.True(Math.Abs(expectedX - a.linearInterpolateTo(c, f).x) < scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(expectedY - a.linearInterpolateTo(c, f).y) < scalar.floatComparisonTolerance);
            }
        }
        [Fact]
        public void degenerateQuadraticBezierTo()
        {
            fvec2 a = new fvec2(10, 20);
            fvec2 b = new fvec2(15, 25);
            fvec2 c = new fvec2(20, 30);

            for (int i = 0; i < 100; i++)
            {
                float f = i / 100.0f;
                float expectedX = (i / 10.0f) + 10;
                float expectedY = (i / 10.0f) + 20;
                Assert.True(Math.Abs(expectedX - a.quadraticBezierInterpolateTo(b, c, f).x) < scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(expectedY - a.quadraticBezierInterpolateTo(b, c, f).y) < scalar.floatComparisonTolerance);
            }
        }
        [Fact]
        public void degenerateQuadraticBezier()
        {
            fvec2 a = new fvec2(10, 20);
            fvec2 b = new fvec2(15, 25);
            fvec2 c = new fvec2(20, 30);

            for (int i = 0; i < 100; i++)
            {
                float f = i / 100.0f;
                float expectedX = (i / 10.0f) + 10;
                float expectedY = (i / 10.0f) + 20;
                Assert.True(Math.Abs(expectedX - fvec2.quadraticBezierInterpolate(a, b, c, f).x) < scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(expectedY - fvec2.quadraticBezierInterpolate(a, b, c, f).y) < scalar.floatComparisonTolerance);
            }
        }
        [Fact]
        public void nonDegenerateQuadraticBezier()
        {
            fvec2 a = new fvec2(10, 20);
            fvec2 b = new fvec2(30, 40);
            fvec2 c = new fvec2(20, 30);

            for (int i = 10; i < 90; i++)
            {
                float f = i / 100.0f;
                float expectedX = (i / 10.0f) + 10;
                float expectedY = (i / 10.0f) + 20;
                Assert.True(Math.Abs(expectedX - fvec2.quadraticBezierInterpolate(a, b, c, f).x) > scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(expectedY - fvec2.quadraticBezierInterpolate(a, b, c, f).y) > scalar.floatComparisonTolerance);
            }
        }
    }
}