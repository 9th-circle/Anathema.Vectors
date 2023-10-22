using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.FloatVectorMatrixOperations
{
    public class dvec2dmat2
    {
        [Theory]
        [InlineData(0, 5, 0, 5, 0)]
        [InlineData(90, 1, 0, 0, -1)]
        [InlineData(180, 10, 0, -10, 0)]
        public void rotateDegrees(double angle, double startX, double startY, double endX, double endY)
        {
            dvec2 start = new dvec2(startX, startY);
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
        public void rotateDegreesDMat(double angle, double startX, double startY, double endX, double endY)
        {
            dvec2 start = new dvec2(startX, startY);
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
        public void rotateDegreesNested(double angle, double startX, double startY, double endX, double endY)
        {
            dvec2 start = new dvec2(startX, startY);
            tvec2<tvec2<double>> rotation = tvec2<tvec2<double>>.fromDMat2(dmat2.rotateDegrees(angle));
            dvec2 end = rotation * start;
            dvec2 reverse = end * rotation;

            Assert.True(Math.Abs(end.x - endX) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(end.y - endY) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(start.x - reverse.x) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(start.y - reverse.y) < scalar.floatComparisonTolerance);
        }
    }
}
