using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.FloatVectors
{
    public class dvec3InterpolationTests
    {
        [Fact]
        public void linearInterpolateTo()
        {
            dvec3 a = new dvec3(10, 20, 30);
            dvec3 c = new dvec3(20, 30, 40);

            for (int i = 0; i < 100; i++)
            {
                double f = i / 100.0f;
                double expectedX = (i / 10.0f) + 10;
                double expectedY = (i / 10.0f) + 20;
                double expectedZ = (i / 10.0f) + 30;
                Assert.True(Math.Abs(expectedX - a.linearInterpolateTo(c, f).x) < scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(expectedY - a.linearInterpolateTo(c, f).y) < scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(expectedZ - a.linearInterpolateTo(c, f).z) < scalar.floatComparisonTolerance);
            }
        }
        [Fact]
        public void degenerateQuadraticBezierTo()
        {
            dvec3 a = new dvec3(10, 20, 30);
            dvec3 b = new dvec3(15, 25, 35);
            dvec3 c = new dvec3(20, 30, 40);

            for (int i = 0; i < 100; i++)
            {
                double f = i / 100.0f;
                double expectedX = (i / 10.0f) + 10;
                double expectedY = (i / 10.0f) + 20;
                double expectedZ = (i / 10.0f) + 30;
                Assert.True(Math.Abs(expectedX - a.quadraticBezierInterpolateTo(b, c, f).x) < scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(expectedY - a.quadraticBezierInterpolateTo(b, c, f).y) < scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(expectedZ - a.quadraticBezierInterpolateTo(b, c, f).z) < scalar.floatComparisonTolerance);

            }
        }
        [Fact]
        public void degenerateCubicBezier()
        {
            dvec3 a = new dvec3(10, 10, 10);
            dvec3 b = new dvec3(15, 15, 15);
            dvec3 c = new dvec3(20, 20, 20);
            dvec3 d = new dvec3(25, 25, 25);

            for (int i = 0; i < 100; i++)
            {
                double f = i / 100.0f;
                Assert.True(Math.Abs(dvec3.cubicBezierInterpolate(a, b, c, d, f).x -
                                     dvec3.cubicBezierInterpolate(a, b, c, d, f).y) < scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(dvec3.cubicBezierInterpolate(a, b, c, d, f).x -
                                     dvec3.cubicBezierInterpolate(a, b, c, d, f).z) < scalar.floatComparisonTolerance);

            }
        }
        [Fact]
        public void nonDegenerateCubicBezier()
        {
            dvec3 a = new dvec3(10, 10, 10);
            dvec3 b = new dvec3(20, 10, 20);
            dvec3 c = new dvec3(10, 15, 10);
            dvec3 d = new dvec3(25, 25, 25);

            for (int i = 10; i < 90; i++)
            {
                double f = i / 100.0f;
                Assert.True(Math.Abs(dvec3.cubicBezierInterpolate(a, b, c, d, f).x -
                                     dvec3.cubicBezierInterpolate(a, b, c, d, f).y) > scalar.floatComparisonTolerance);
            }
        }
        [Fact]
        public void degenerateCubicBezierTo()
        {
            dvec3 a = new dvec3(10, 10, 10);
            dvec3 b = new dvec3(15, 15, 15);
            dvec3 c = new dvec3(20, 20, 20);
            dvec3 d = new dvec3(25, 25, 25);

            for (int i = 0; i < 100; i++)
            {
                double f = i / 100.0f;
                Assert.True(Math.Abs(a.cubicBezierInterpolateTo(b, c, d, f).x -
                                     a.cubicBezierInterpolateTo(b, c, d, f).y) < scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(a.cubicBezierInterpolateTo(b, c, d, f).x -
                                     a.cubicBezierInterpolateTo(b, c, d, f).z) < scalar.floatComparisonTolerance);
            }
        }
        [Fact]
        public void degenerateQuadraticBezier()
        {
            dvec3 a = new dvec3(10, 20, 30);
            dvec3 b = new dvec3(15, 25, 35);
            dvec3 c = new dvec3(20, 30, 40);

            for (int i = 0; i < 100; i++)
            {
                double f = i / 100.0f;
                double expectedX = (i / 10.0f) + 10;
                double expectedY = (i / 10.0f) + 20;
                double expectedZ = (i / 10.0f) + 30;
                Assert.True(Math.Abs(expectedX - dvec3.quadraticBezierInterpolate(a, b, c, f).x) < scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(expectedY - dvec3.quadraticBezierInterpolate(a, b, c, f).y) < scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(expectedZ - dvec3.quadraticBezierInterpolate(a, b, c, f).z) < scalar.floatComparisonTolerance);

            }
        }
        [Fact]
        public void nonDegenerateQuadraticBezier()
        {
            dvec3 a = new dvec3(10, 20, 30);
            dvec3 b = new dvec3(30, 40, 50);
            dvec3 c = new dvec3(20, 30, 40);

            for (int i = 10; i < 90; i++)
            {
                double f = i / 100.0f;
                double expectedX = (i / 10.0f) + 10;
                double expectedY = (i / 10.0f) + 20;
                double expectedZ = (i / 10.0f) + 30;
                Assert.True(Math.Abs(expectedX - dvec3.quadraticBezierInterpolate(a, b, c, f).x) > scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(expectedY - dvec3.quadraticBezierInterpolate(a, b, c, f).y) > scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(expectedZ - dvec3.quadraticBezierInterpolate(a, b, c, f).z) > scalar.floatComparisonTolerance);
            }
        }
    }
}
