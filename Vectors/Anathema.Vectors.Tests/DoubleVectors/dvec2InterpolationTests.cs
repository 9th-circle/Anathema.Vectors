using System;
using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.FloatVectors
{
    public class dvec2InterpolationTests
    {

        [Fact]
        public void linearInterpolateTo()
        {
            dvec2 a = new dvec2(10, 20);
            dvec2 c = new dvec2(20, 30);

            for (int i = 0; i < 100; i++)
            {
                double f = i / 100.0f;
                double expectedX = (i / 10.0f) + 10;
                double expectedY = (i / 10.0f) + 20;
                Assert.True(Math.Abs(expectedX - a.linearInterpolateTo(c, f).x) < scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(expectedY - a.linearInterpolateTo(c, f).y) < scalar.floatComparisonTolerance);
            }
        }
        [Fact]
        public void degenerateQuadraticBezierTo()
        {
            dvec2 a = new dvec2(10, 20);
            dvec2 b = new dvec2(15, 25);
            dvec2 c = new dvec2(20, 30);

            for (int i = 0; i < 100; i++)
            {
                double f = i / 100.0f;
                double expectedX = (i / 10.0f) + 10;
                double expectedY = (i / 10.0f) + 20;
                Assert.True(Math.Abs(expectedX - a.quadraticBezierInterpolateTo(b, c, f).x) < scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(expectedY - a.quadraticBezierInterpolateTo(b, c, f).y) < scalar.floatComparisonTolerance);
            }
        }
        [Fact]
        public void degenerateCubicBezier()
        {
            dvec2 a = new dvec2(10, 10);
            dvec2 b = new dvec2(15, 15);
            dvec2 c = new dvec2(20, 20);
            dvec2 d = new dvec2(25, 25);

            for (int i = 0; i < 100; i++)
            {
                double f = i / 100.0f;
                Assert.True(Math.Abs(dvec2.cubicBezierInterpolate(a, b, c, d, f).x -
                                     dvec2.cubicBezierInterpolate(a, b, c, d, f).y) < scalar.floatComparisonTolerance);
            }
        }
        [Fact]
        public void nonDegenerateCubicBezier()
        {
            dvec2 a = new dvec2(10, 10);
            dvec2 b = new dvec2(20, 10);
            dvec2 c = new dvec2(20, 10);
            dvec2 d = new dvec2(25, 25);

            for (int i = 10; i < 90; i++)
            {
                double f = i / 100.0f;
                Assert.True(Math.Abs(dvec2.cubicBezierInterpolate(a, b, c, d, f).x -
                                     dvec2.cubicBezierInterpolate(a, b, c, d, f).y) > scalar.floatComparisonTolerance);
            }
        }
        [Fact]
        public void degenerateCubicBezierTo()
        {
            dvec2 a = new dvec2(10, 10);
            dvec2 b = new dvec2(15, 15);
            dvec2 c = new dvec2(20, 20);
            dvec2 d = new dvec2(25, 25);

            for (int i = 0; i < 100; i++)
            {
                double f = i / 100.0f;
                Assert.True(Math.Abs(a.cubicBezierInterpolateTo(b, c, d, f).x -
                                     a.cubicBezierInterpolateTo(b, c, d, f).y) < scalar.floatComparisonTolerance);
            }
        }
        [Fact]
        public void degenerateQuadraticBezier()
        {
            dvec2 a = new dvec2(10, 20);
            dvec2 b = new dvec2(15, 25);
            dvec2 c = new dvec2(20, 30);

            for (int i = 0; i < 100; i++)
            {
                double f = i / 100.0f;
                double expectedX = (i / 10.0f) + 10;
                double expectedY = (i / 10.0f) + 20;
                Assert.True(Math.Abs(expectedX - dvec2.quadraticBezierInterpolate(a, b, c, f).x) < scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(expectedY - dvec2.quadraticBezierInterpolate(a, b, c, f).y) < scalar.floatComparisonTolerance);
            }
        }
        [Fact]
        public void nonDegenerateQuadraticBezier()
        {
            dvec2 a = new dvec2(10, 20);
            dvec2 b = new dvec2(30, 40);
            dvec2 c = new dvec2(20, 30);

            for (int i = 10; i < 90; i++)
            {
                double f = i / 100.0f;
                double expectedX = (i / 10.0f) + 10;
                double expectedY = (i / 10.0f) + 20;
                Assert.True(Math.Abs(expectedX - dvec2.quadraticBezierInterpolate(a, b, c, f).x) > scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(expectedY - dvec2.quadraticBezierInterpolate(a, b, c, f).y) > scalar.floatComparisonTolerance);
            }
        }
    }
}