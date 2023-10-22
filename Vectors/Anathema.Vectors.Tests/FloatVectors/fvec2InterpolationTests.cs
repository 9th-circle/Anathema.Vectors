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
            vec2 a = new vec2(10, 20);
            vec2 c = new vec2(20, 30);

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
            vec2 a = new vec2(10, 20);
            vec2 b = new vec2(15, 25);
            vec2 c = new vec2(20, 30);

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
        public void degenerateCubicBezier()
        {
            vec2 a = new vec2(10, 10);
            vec2 b = new vec2(15, 15);
            vec2 c = new vec2(20, 20);
            vec2 d = new vec2(25, 25);

            for (int i = 0; i < 100; i++)
            {
                float f = i / 100.0f;
                Assert.True(Math.Abs(vec2.cubicBezierInterpolate(a, b, c, d, f).x -
                                     vec2.cubicBezierInterpolate(a, b, c, d, f).y) < scalar.floatComparisonTolerance);
            }
        }
        [Fact]
        public void nonDegenerateCubicBezier()
        {
            vec2 a = new vec2(10, 10);
            vec2 b = new vec2(20, 10);
            vec2 c = new vec2(20, 10);
            vec2 d = new vec2(25, 25);

            for (int i = 10; i < 90; i++)
            {
                float f = i / 100.0f;
                Assert.True(Math.Abs(vec2.cubicBezierInterpolate(a, b, c, d, f).x -
                                     vec2.cubicBezierInterpolate(a, b, c, d, f).y) > scalar.floatComparisonTolerance);
            }
        }
        [Fact]
        public void degenerateCubicBezierTo()
        {
            vec2 a = new vec2(10, 10);
            vec2 b = new vec2(15, 15);
            vec2 c = new vec2(20, 20);
            vec2 d = new vec2(25, 25);

            for (int i = 0; i < 100; i++)
            {
                float f = i / 100.0f;
                Assert.True(Math.Abs(a.cubicBezierInterpolateTo(b, c, d, f).x -
                                     a.cubicBezierInterpolateTo(b, c, d, f).y) < scalar.floatComparisonTolerance);
            }
        }
        [Fact]
        public void degenerateQuadraticBezier()
        {
            vec2 a = new vec2(10, 20);
            vec2 b = new vec2(15, 25);
            vec2 c = new vec2(20, 30);

            for (int i = 0; i < 100; i++)
            {
                float f = i / 100.0f;
                float expectedX = (i / 10.0f) + 10;
                float expectedY = (i / 10.0f) + 20;
                Assert.True(Math.Abs(expectedX - vec2.quadraticBezierInterpolate(a, b, c, f).x) < scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(expectedY - vec2.quadraticBezierInterpolate(a, b, c, f).y) < scalar.floatComparisonTolerance);
            }
        }
        [Fact]
        public void nonDegenerateQuadraticBezier()
        {
            vec2 a = new vec2(10, 20);
            vec2 b = new vec2(30, 40);
            vec2 c = new vec2(20, 30);

            for (int i = 10; i < 90; i++)
            {
                float f = i / 100.0f;
                float expectedX = (i / 10.0f) + 10;
                float expectedY = (i / 10.0f) + 20;
                Assert.True(Math.Abs(expectedX - vec2.quadraticBezierInterpolate(a, b, c, f).x) > scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(expectedY - vec2.quadraticBezierInterpolate(a, b, c, f).y) > scalar.floatComparisonTolerance);
            }
        }
    }
}