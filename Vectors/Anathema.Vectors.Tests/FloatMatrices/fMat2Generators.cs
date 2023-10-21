using System;
using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.FloatMatrices
{
    public class fMat2Generators
    {
        [Fact]
        public void identity()
        {
            fmat2 def = fmat2.identity();
            Assert.Equal(1, def[0]);
            Assert.Equal(0, def[1]);
            Assert.Equal(0, def[2]);
            Assert.Equal(1, def[3]);
        }
        [Fact]
        public void fromNested()
        {
            tvec2<tvec2<float>> nested = new tvec2<tvec2<float>>();
            nested.x = new tvec2<float>();
            nested.y = new tvec2<float>();
            nested.x.x = 1;
            nested.x.y = 2;
            nested.y.x = 3;
            nested.y.y = 4;
            fmat2 output = fmat2.fromNestedVector(nested);
            Assert.Equal(1, output[0]);
            Assert.Equal(3, output[1]);
            Assert.Equal(2, output[2]);
            Assert.Equal(4, output[3]);
        }
        [Fact]
        public void array()
        {
            float[] array = fmat2.identity().ToArray();
            Assert.Equal(1, array[0]);
            Assert.Equal(0, array[1]);
            Assert.Equal(0, array[2]);
            Assert.Equal(1, array[3]);
        }
        [Fact]
        public void transposeImperative()
        {
            fmat2 def = new fmat2(new float[] { 1, 2, 3, 4 });
            def.transpose();
            Assert.Equal(1, def[0]);
            Assert.Equal(3, def[1]);
            Assert.Equal(2, def[2]);
            Assert.Equal(4, def[3]);
        }
        [Fact]
        public void copy()
        {
            fmat2 original = new fmat2(new float[] { 1, 2, 3, 4 });
            fmat2 copy = new fmat2(original);
            Assert.Equal(1, copy[0]);
            Assert.Equal(2, copy[1]);
            Assert.Equal(3, copy[2]);
            Assert.Equal(4, copy[3]);
        }
        [Fact]
        public void scaleUniform()
        {
            fmat2 def = fmat2.scale(5.0f);
            Assert.Equal(5, def[0]);
            Assert.Equal(0, def[1]);
            Assert.Equal(0, def[2]);
            Assert.Equal(5, def[3]);
        }
        [Fact]
        public void scaleBasis()
        {
            fmat2 def = fmat2.scale(new fvec2(2,3));
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
        public void rotationDegrees(float angle, float expected0, float expected1, float expected2, float expected3)
        {
            fmat2 matrix = fmat2.rotateDegrees(angle);
            Assert.True(Math.Abs(expected0-matrix[0]) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(expected1 - matrix[1]) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(expected2 - matrix[2]) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(expected3 - matrix[3]) < scalar.floatComparisonTolerance);
        }
        [Theory]
        [InlineData(0, 1, 0, 0, 1)]
        [InlineData(Math.PI/2, 0, 1, -1, 0)]
        [InlineData(Math.PI, -1, 0, 0, -1)]
        [InlineData(Math.PI * 3.0f / 2, 0, -1, 1, 0)]
        public void rotationRadians(float angle, float expected0, float expected1, float expected2, float expected3)
        {
            fmat2 matrix = fmat2.rotateRadians(angle);
            Assert.True(Math.Abs(expected0 - matrix[0]) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(expected1 - matrix[1]) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(expected2 - matrix[2]) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(expected3 - matrix[3]) < scalar.floatComparisonTolerance);
        }
    }
}
