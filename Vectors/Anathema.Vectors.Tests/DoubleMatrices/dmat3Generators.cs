using Anathema.Vectors.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Anathema.Vectors.Tests.DoubleMatrices
{
    public class dmat3Generators
    {
        [Fact]
        public void scalarScale()
        {
            dvec3 v = new dvec3(1, 2, 3);
            dmat3 m = dmat3.scale(2.0f);

            dvec3 up = m * v;

            Assert.Equal(2, up.x);
            Assert.Equal(4, up.y);
            Assert.Equal(6, up.z);
        }
        [Fact]
        public void basisScale()
        {
            dvec3 v = new dvec3(1, 2, 3);
            dmat3 m = dmat3.scale(new dvec3(0, 2, 4));

            dvec3 up = m * v;

            Assert.Equal(0, up.x);
            Assert.Equal(4, up.y);
            Assert.Equal(12, up.z);
        }
        [Fact]
        public void eulerZRotate()
        {
            dvec3 v = new dvec3(1, 0, 0);
            dmat3 m = dmat3.rotateDegrees(0, 0, 90);

            dvec3 counterClockwise = v * m;

            Assert.True(Math.Abs(0- counterClockwise.x) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(-1 - counterClockwise.y) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(0 - counterClockwise.z) < scalar.floatComparisonTolerance);

            dvec3 clockwise = m * v;

            Assert.True(Math.Abs(0 - clockwise.x) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(1 - clockwise.y) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(0 - clockwise.z) < scalar.floatComparisonTolerance);
        }
    }
}
