using Anathema.Vectors.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Anathema.Vectors.Tests.Scalars
{
    public class scalarInterpolationTests
    {
        [Fact]
        public void simplestInterpolation()
        {
            for (int i = 0; i < 100; i++)
            {
                float f = i / 100.0f;
                Assert.Equal(f, scalar.linearInterpolate(0, 1, f));
            }
        }
        [Fact]
        public void negativeInterpolation()
        {
            for (int i = 0; i < 100; i++)
            {
                float f = i / 100.0f;
                Assert.Equal(f * -100, scalar.linearInterpolate(0, -100, f));
            }
        }
        [Fact]
        public void nonZeroStart()
        {
            for (int i = 0; i < 100; i++)
            {
                float f = i / 100.0f;
                Assert.True((f*10)+20 - scalar.linearInterpolate(20, 30, f) < scalar.floatComparisonTolerance);
            }
        }
    }
}
