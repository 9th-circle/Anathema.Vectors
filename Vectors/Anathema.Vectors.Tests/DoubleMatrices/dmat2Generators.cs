using System;
using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.DoubleMatrices
{
    public class dmat2Generators
    {
        [Fact]
        public void identity()
        {
            dmat2 def = dmat2.identity();
            Assert.Equal(1, def[0]);
            Assert.Equal(0, def[1]);
            Assert.Equal(0, def[2]);
            Assert.Equal(1, def[3]);
        }
        [Fact]
        public void fromNested()
        {
            tvec2<tvec2<double>> nested = new tvec2<tvec2<double>>();
            nested.x = new tvec2<double>();
            nested.y = new tvec2<double>();
            nested.x.x = 1;
            nested.x.y = 2;
            nested.y.x = 3;
            nested.y.y = 4;
            dmat2 output = dmat2.fromNestedVector(nested);
            Assert.Equal(1, output[0]);
            Assert.Equal(3, output[1]);
            Assert.Equal(2, output[2]);
            Assert.Equal(4, output[3]);
        }
        [Fact]
        public void array()
        {
            double[] array = dmat2.identity().ToArray();
            Assert.Equal(1, array[0]);
            Assert.Equal(0, array[1]);
            Assert.Equal(0, array[2]);
            Assert.Equal(1, array[3]);
        }
        [Fact]
        public void equal()
        {
            dmat2 a = new dmat2(new double[] { 1, 2, 3, 4 });
            dmat2 b = new dmat2(new double[] { 1, 2, 3, 4 });
            dmat2 c = new dmat2(new double[] { 2, 2, 3, 4 });
            dmat2 d = null;
            Assert.True(a == b);
            Assert.True(a != c);
            Assert.False(a != b);
            Assert.False(a == c);
            Assert.True(d == null);
        }
        [Fact]
        public void transposeImperative()
        {
            dmat2 def = new dmat2(new double[] { 1, 2, 3, 4 });
            def.transpose();
            Assert.Equal(1, def[0]);
            Assert.Equal(3, def[1]);
            Assert.Equal(2, def[2]);
            Assert.Equal(4, def[3]);
        }
        [Fact]
        public void copy()
        {
            dmat2 original = new dmat2(new double[] { 1, 2, 3, 4 });
            dmat2 copy = new dmat2(original);
            Assert.Equal(1, copy[0]);
            Assert.Equal(2, copy[1]);
            Assert.Equal(3, copy[2]);
            Assert.Equal(4, copy[3]);
        }
        [Fact]
        public void scaleUniform()
        {
            dmat2 def = dmat2.scale(5.0f);
            Assert.Equal(5, def[0]);
            Assert.Equal(0, def[1]);
            Assert.Equal(0, def[2]);
            Assert.Equal(5, def[3]);
        }
        [Fact]
        public void scaleBasis()
        {
            dmat2 def = dmat2.scale(new dvec2(2, 3));
            Assert.Equal(2, def[0]);
            Assert.Equal(0, def[1]);
            Assert.Equal(0, def[2]);
            Assert.Equal(3, def[3]);
        }

        [Theory]
        [InlineData(0, 1, 0, 0, 1)]
        [InlineData(90, 0, 1, -1, 0)]
        [InlineData(180, -1, 0, 0, -1)]
        [InlineData(270, 0, -1, 1, 0)]
        public void rotationDegrees(double angle, double expected0, double expected1, double expected2, double expected3)
        {
            dmat2 matrix = dmat2.rotateDegrees(angle);
            Assert.True(Math.Abs(expected0 - matrix[0]) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(expected1 - matrix[1]) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(expected2 - matrix[2]) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(expected3 - matrix[3]) < scalar.floatComparisonTolerance);
        }
        [Theory]
        [InlineData(0, 1, 0, 0, 1)]
        [InlineData(Math.PI / 2, 0, 1, -1, 0)]
        [InlineData(Math.PI, -1, 0, 0, -1)]
        [InlineData(Math.PI * 3.0f / 2, 0, -1, 1, 0)]
        public void rotationRadians(double angle, double expected0, double expected1, double expected2, double expected3)
        {
            dmat2 matrix = dmat2.rotateRadians(angle);
            Assert.True(Math.Abs(expected0 - matrix[0]) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(expected1 - matrix[1]) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(expected2 - matrix[2]) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(expected3 - matrix[3]) < scalar.floatComparisonTolerance);
        }
    }
}
