using Anathema.Vectors.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Anathema.Vectors.Tests.Scalars
{
    public class doubleScalarInterpolationTests
    {
        [Fact]
        public void isClose()
        {
            double negativeHalf = -scalar.floatComparisonTolerance / 2;
            double negativeTwice = -scalar.floatComparisonTolerance * 2;
            double zero = 0;
            double half = scalar.floatComparisonTolerance/2;
            double twice = scalar.floatComparisonTolerance * 2;

            Assert.True(scalar.isClose(zero, half));
            Assert.True(scalar.isClose(zero, negativeHalf));
            Assert.False(scalar.isClose(zero, twice));
            Assert.False(scalar.isClose(zero, negativeTwice));
        }
        [Fact]
        public void simplestInterpolation()
        {
            for (int i = 0; i < 100; i++)
            {
                double f = i / 100.0f;
                Assert.Equal(f, scalar.linearInterpolate(0, 1, f));
            }
        }
        [Fact]
        public void negativeInterpolation()
        {
            for (int i = 0; i < 100; i++)
            {
                double f = i / 100.0f;
                Assert.Equal(f * -100, scalar.linearInterpolate(0, -100, f));
            }
        }
        [Fact]
        public void nonZeroStart()
        {
            for (int i = 0; i < 100; i++)
            {
                double f = i / 100.0f;
                Assert.True((f*10)+20 - scalar.linearInterpolate(20, 30, f) < scalar.floatComparisonTolerance);
            }
        }
        [Fact]
        public void degenerate1DBezier()
        {
            for (int i = 0; i < 100; i++)
            {
                double f = i / 100.0f;
                Assert.True(f - scalar.quadraticBezierInterpolate(0,0.5,1,f) < scalar.floatComparisonTolerance);
            }
        }
        [Fact]
        public void nonDegenerate1DBezier()
        {
            for (int i = 10; i < 90; i++)
            {
                double f = i / 100.0f;
                Assert.True(Math.Abs(f - scalar.quadraticBezierInterpolate(0, 1, 1, f)) > scalar.floatComparisonTolerance);
                Assert.True(Math.Abs(f - scalar.quadraticBezierInterpolate(0, 0, 1, f)) > scalar.floatComparisonTolerance);

            }
        }
    }
}
