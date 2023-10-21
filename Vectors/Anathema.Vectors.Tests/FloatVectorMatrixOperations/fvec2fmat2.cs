using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.FloatVectorMatrixOperations
{
    public class fvec2fmat2
    {
        [Theory]
        [InlineData(0,5,0,5,0)]
        [InlineData(90,1,0,0,-1)]
        [InlineData(180, 10, 0, -10, 0)]
        public void rotateDegrees(float angle, float startX, float startY, float endX, float endY)
        {
            fvec2 start = new fvec2(startX, startY);
            fmat2 rotation = fmat2.rotateDegrees(angle);
            fvec2 end = rotation * start;
            fvec2 reverse = end * rotation;

            Assert.True(Math.Abs(end.x - endX) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(end.y - endY) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(start.x - reverse.x) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(start.y - reverse.y) < scalar.floatComparisonTolerance);
        }
    }
}
