using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.FloatVectorMatrixOperations
{
    public class vec2mat2
    {
        [Theory]
        [InlineData(0,5,0,5,0)]
        [InlineData(90,1,0,0,-1)]
        [InlineData(180, 10, 0, -10, 0)]
        public void rotateDegrees(float angle, float startX, float startY, float endX, float endY)
        {
            vec2 start = new vec2(startX, startY);
            mat2 rotation = mat2.rotateDegrees(angle);
            vec2 end = rotation * start;
            vec2 reverse = end * rotation;

            Assert.True(Math.Abs(end.x - endX) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(end.y - endY) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(start.x - reverse.x) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(start.y - reverse.y) < scalar.floatComparisonTolerance);
        }
        [Theory]
        [InlineData(0, 5, 0, 5, 0)]
        [InlineData(90, 1, 0, 0, -1)]
        [InlineData(180, 10, 0, -10, 0)]
        public void rotateDegreesDMat(float angle, float startX, float startY, float endX, float endY)
        {
            vec2 start = new vec2(startX, startY);
            dmat2 rotation = dmat2.rotateDegrees(angle);
            dvec2 end = rotation * start;
            dvec2 reverse = end * rotation;

            Assert.True(Math.Abs(end.x - endX) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(end.y - endY) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(start.x - reverse.x) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(start.y - reverse.y) < scalar.floatComparisonTolerance);
        }
        [Theory]
        [InlineData(0, 5, 0, 5, 0)]
        [InlineData(90, 1, 0, 0, -1)]
        [InlineData(180, 10, 0, -10, 0)]
        public void rotateDegreesNested(float angle, float startX, float startY, float endX, float endY)
        {
            vec2 start = new vec2(startX, startY);
            tvec2<tvec2<float>> rotation = tvec2<tvec2<float>>.fromMat2(mat2.rotateDegrees(angle));
            vec2 end = rotation * start;
            vec2 reverse = end * rotation;

            Assert.True(Math.Abs(end.x - endX) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(end.y - endY) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(start.x - reverse.x) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(start.y - reverse.y) < scalar.floatComparisonTolerance);
        }
    }
}
