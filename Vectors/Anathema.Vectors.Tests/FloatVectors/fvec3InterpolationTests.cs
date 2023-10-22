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
            vec3 a = new vec3(10, 20, 30);
            vec3 c = new vec3(20, 30, 40);

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
            vec3 a = new vec3(10, 20, 30);
            vec3 b = new vec3(15, 25, 35);
            vec3 c = new vec3(20, 30, 40);

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
            vec3 a = new vec3(10, 10, 10);
            vec3 b = new vec3(15, 15, 15);
            vec3 c = new vec3(20, 20, 20);
            vec3 d = new vec3(25, 25, 25);

            for (int i = 0; i < 100; i++)
            {
                float f = i / 100.0f;
                Assert.True(Math.Abs(vec3.cubicBezierInterpolate(a, b, c, d, f).x -
                                     vec3.cubicBezierInterpolate(a, b, c, d, f).y) < scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(vec3.cubicBezierInterpolate(a, b, c, d, f).x -
                                     vec3.cubicBezierInterpolate(a, b, c, d, f).z) < scalar.floatComparisonTolerance);

            }
        }
        [Fact]
        public void nonDegenerateCubicBezier()
        {
            vec3 a = new vec3(10, 10, 10);
            vec3 b = new vec3(20, 10, 20);
            vec3 c = new vec3(10, 15, 10);
            vec3 d = new vec3(25, 25, 25);

            for (int i = 10; i < 90; i++)
            {
                float f = i / 100.0f;
                Assert.True(Math.Abs(vec3.cubicBezierInterpolate(a, b, c, d, f).x -
                                     vec3.cubicBezierInterpolate(a, b, c, d, f).y) > scalar.floatComparisonTolerance);
            }
        }
        [Fact]
        public void degenerateCubicBezierTo()
        {
            vec3 a = new vec3(10, 10, 10);
            vec3 b = new vec3(15, 15, 15);
            vec3 c = new vec3(20, 20, 20);
            vec3 d = new vec3(25, 25, 25);

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
            vec3 a = new vec3(10, 20, 30);
            vec3 b = new vec3(15, 25, 35);
            vec3 c = new vec3(20, 30, 40);

            for (int i = 0; i < 100; i++)
            {
                float f = i / 100.0f;
                float expectedX = (i / 10.0f) + 10;
                float expectedY = (i / 10.0f) + 20;
                float expectedZ = (i / 10.0f) + 30;
                Assert.True(Math.Abs(expectedX - vec3.quadraticBezierInterpolate(a, b, c, f).x) < scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(expectedY - vec3.quadraticBezierInterpolate(a, b, c, f).y) < scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(expectedZ - vec3.quadraticBezierInterpolate(a, b, c, f).z) < scalar.floatComparisonTolerance);

            }
        }
        [Fact]
        public void nonDegenerateQuadraticBezier()
        {
            vec3 a = new vec3(10, 20, 30);
            vec3 b = new vec3(30, 40, 50);
            vec3 c = new vec3(20, 30, 40);

            for (int i = 10; i < 90; i++)
            {
                float f = i / 100.0f;
                float expectedX = (i / 10.0f) + 10;
                float expectedY = (i / 10.0f) + 20;
                float expectedZ = (i / 10.0f) + 30;
                Assert.True(Math.Abs(expectedX - vec3.quadraticBezierInterpolate(a, b, c, f).x) > scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(expectedY - vec3.quadraticBezierInterpolate(a, b, c, f).y) > scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(expectedZ - vec3.quadraticBezierInterpolate(a, b, c, f).z) > scalar.floatComparisonTolerance);
            }
        }
    }
}
