using System;
using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.FloatVectors
{
    public class dvec4InterpolationTests
    {
        [Fact]
        public void linearInterpolateTo()
        {
            dvec4 a = new dvec4(10, 20, 30, 40);
            dvec4 c = new dvec4(20, 30, 40, 50);

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
            dvec4 a = new dvec4(10, 20, 30, 40);
            dvec4 b = new dvec4(15, 25, 35, 45);
            dvec4 c = new dvec4(20, 30, 40, 50);

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
            dvec4 a = new dvec4(10, 10, 10, 10);
            dvec4 b = new dvec4(15, 15, 15, 15);
            dvec4 c = new dvec4(20, 20, 20, 20);
            dvec4 d = new dvec4(25, 25, 25, 25);

            for (int i = 0; i < 100; i++)
            {
                float f = i / 100.0f;
                Assert.True(Math.Abs(dvec4.cubicBezierInterpolate(a, b, c, d, f).x -
                                     dvec4.cubicBezierInterpolate(a, b, c, d, f).y) < scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(dvec4.cubicBezierInterpolate(a, b, c, d, f).x -
                                     dvec4.cubicBezierInterpolate(a, b, c, d, f).z) < scalar.floatComparisonTolerance);

            }
        }
        [Fact]
        public void nonDegenerateCubicBezier()
        {
            dvec4 a = new dvec4(10, 10, 10, 10);
            dvec4 b = new dvec4(20, 10, 20, 20);
            dvec4 c = new dvec4(10, 15, 10, 10);
            dvec4 d = new dvec4(25, 25, 25, 25);

            for (int i = 10; i < 90; i++)
            {
                float f = i / 100.0f;
                Assert.True(Math.Abs(dvec4.cubicBezierInterpolate(a, b, c, d, f).x -
                                     dvec4.cubicBezierInterpolate(a, b, c, d, f).y) > scalar.floatComparisonTolerance);
            }
        }
        [Fact]
        public void degenerateCubicBezierTo()
        {
            dvec4 a = new dvec4(10, 10, 10, 10);
            dvec4 b = new dvec4(15, 15, 15, 15);
            dvec4 c = new dvec4(20, 20, 20, 20);
            dvec4 d = new dvec4(25, 25, 25, 25);

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
            dvec4 a = new dvec4(10, 20, 30, 40);
            dvec4 b = new dvec4(15, 25, 35, 45);
            dvec4 c = new dvec4(20, 30, 40, 50);

            for (int i = 0; i < 100; i++)
            {
                float f = i / 100.0f;
                float expectedX = (i / 10.0f) + 10;
                float expectedY = (i / 10.0f) + 20;
                float expectedZ = (i / 10.0f) + 30;
                Assert.True(Math.Abs(expectedX - dvec4.quadraticBezierInterpolate(a, b, c, f).x) < scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(expectedY - dvec4.quadraticBezierInterpolate(a, b, c, f).y) < scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(expectedZ - dvec4.quadraticBezierInterpolate(a, b, c, f).z) < scalar.floatComparisonTolerance);

            }
        }
        [Fact]
        public void nonDegenerateQuadraticBezier()
        {
            dvec4 a = new dvec4(10, 20, 30, 40);
            dvec4 b = new dvec4(30, 40, 50, 60);
            dvec4 c = new dvec4(20, 30, 40, 50);

            for (int i = 10; i < 90; i++)
            {
                float f = i / 100.0f;
                float expectedX = (i / 10.0f) + 10;
                float expectedY = (i / 10.0f) + 20;
                float expectedZ = (i / 10.0f) + 30;
                Assert.True(Math.Abs(expectedX - dvec4.quadraticBezierInterpolate(a, b, c, f).x) > scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(expectedY - dvec4.quadraticBezierInterpolate(a, b, c, f).y) > scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(expectedZ - dvec4.quadraticBezierInterpolate(a, b, c, f).z) > scalar.floatComparisonTolerance);
            }
        }
    }
}
