using System;
using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.FloatMatrices
{
    public class mat3Generators
    {
        [Fact]
        public void transpose()
        {
            mat3 m = new mat3(new float[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            mat3 t = m.transposed;

            Assert.Equal(1, t[0]);
            Assert.Equal(4, t[1]);
            Assert.Equal(7, t[2]);

            Assert.Equal(2, t[3]);
            Assert.Equal(5, t[4]);
            Assert.Equal(8, t[5]);

            Assert.Equal(3, t[6]);
            Assert.Equal(6, t[7]);
            Assert.Equal(9, t[8]);

            m.transpose();

            Assert.True(m == t);
            Assert.False(m != t);
        }
        [Fact]
        public void toMat2()
        {
            mat3 m = new mat3(new float[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            mat2 t = m;

            Assert.Equal(1, t[0, 0]);
            Assert.Equal(2, t[1, 0]);
            Assert.Equal(3, t[0, 1]);
            Assert.Equal(4, t[1, 1]);
        }
        [Fact]
        public void toMat4()
        {
            mat3 m = new mat3(new float[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            mat4 d = m.toMat4();

            Assert.Equal(1, d[0, 0]);
            Assert.Equal(2, d[1, 0]);
            Assert.Equal(3, d[2, 0]);
            Assert.Equal(4, d[0, 1]);
            Assert.Equal(5, d[1, 1]);
            Assert.Equal(6, d[2, 1]);
            Assert.Equal(7, d[0, 2]);
            Assert.Equal(8, d[1, 2]);
            Assert.Equal(9, d[2, 2]);

            Assert.Equal(0, d[0, 3]);
            Assert.Equal(0, d[1, 3]);
            Assert.Equal(0, d[2, 3]);
            Assert.Equal(0, d[3, 3]);

            Assert.Equal(0, d[3, 0]);
            Assert.Equal(0, d[3, 1]);
            Assert.Equal(0, d[3, 2]);
            Assert.Equal(0, d[3, 3]);
        }
        [Fact]
        public void scalarScale()
        {
            vec3 v = new vec3(1, 2, 3);
            mat3 m = mat3.scale(2.0f);

            vec3 up = m * v;

            Assert.Equal(2, up.x);
            Assert.Equal(4, up.y);
            Assert.Equal(6, up.z);
        }
        [Fact]
        public void basisScale()
        {
            vec3 v = new vec3(1, 2, 3);
            mat3 m = mat3.scale(new vec3(0,2,4));

            vec3 up = m * v;

            Assert.Equal(0, up.x);
            Assert.Equal(4, up.y);
            Assert.Equal(12, up.z);
        }

        [Fact]
        public void eulerZRotate()
        {
            vec3 v = new vec3(1, 0, 0);
            mat3 m = mat3.rotateDegrees(0, 0, 90);

            vec3 counterClockwise = v * m;

            Assert.True(Math.Abs(0 - counterClockwise.x) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(-1 - counterClockwise.y) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(0 - counterClockwise.z) < scalar.floatComparisonTolerance);

            vec3 clockwise = m * v;

            Assert.True(Math.Abs(0 - clockwise.x) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(1 - clockwise.y) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(0 - clockwise.z) < scalar.floatComparisonTolerance);
        }

        [Fact]
        public void eulerXIdentity()
        {
            vec3 v = new vec3(1, 0, 0);
            mat3 m = mat3.rotateDegrees(90, 0, 0);

            vec3 counterClockwise = v * m;

            Assert.True(Math.Abs(1 - counterClockwise.x) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(0 - counterClockwise.y) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(0 - counterClockwise.z) < scalar.floatComparisonTolerance);

            vec3 clockwise = m * v;

            Assert.True(Math.Abs(1 - clockwise.x) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(0 - clockwise.y) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(0 - clockwise.z) < scalar.floatComparisonTolerance);
        }
        [Fact]
        public void eulerXRotate()
        {
            vec3 v = new vec3(0, 1, 0);
            mat3 m = mat3.rotateDegrees(90, 0, 0);

            vec3 counterClockwise = v * m;

            Assert.True(Math.Abs(0 - counterClockwise.x) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(0 - counterClockwise.y) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(-1 - counterClockwise.z) < scalar.floatComparisonTolerance);

            vec3 clockwise = m * v;

            Assert.True(Math.Abs(0 - clockwise.x) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(0 - clockwise.y) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(1 - clockwise.z) < scalar.floatComparisonTolerance);
        }
        [Fact]
        public void eulerYRotate()
        {
            vec3 v = new vec3(1, 0, 0);
            mat3 m = mat3.rotateDegrees(0, 90, 0);

            vec3 counterClockwise = v * m;

            Assert.True(Math.Abs(0 - counterClockwise.x) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(0 - counterClockwise.y) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(1 - counterClockwise.z) < scalar.floatComparisonTolerance);

            vec3 clockwise = m * v;

            Assert.True(Math.Abs(0 - clockwise.x) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(0 - clockwise.y) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(-1 - clockwise.z) < scalar.floatComparisonTolerance);
        }
        [Fact]
        public void axisAngleYRotate()
        {
            vec3 v = new vec3(1, 0, 0);
            mat3 m = mat3.rotateDegrees(new vec3(0, 1, 0), 90);

            vec3 counterClockwise = v * m;

            Assert.True(Math.Abs(0 - counterClockwise.x) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(0 - counterClockwise.y) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(1 - counterClockwise.z) < scalar.floatComparisonTolerance);

            vec3 clockwise = m * v;

            Assert.True(Math.Abs(0 - clockwise.x) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(0 - clockwise.y) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(-1 - clockwise.z) < scalar.floatComparisonTolerance);
        }


        [Fact]
        public void axisAngleXRotate()
        {
            vec3 v = new vec3(0, 1, 0);
            mat3 m = mat3.rotateDegrees(new vec3(1, 0, 0), 90); // <- problem

            vec3 counterClockwise = v * m;

            Assert.True(Math.Abs(0 - counterClockwise.x) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(0 - counterClockwise.y) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(1 - counterClockwise.z) < scalar.floatComparisonTolerance);

            vec3 clockwise = m * v;

            Assert.True(Math.Abs(0 - clockwise.x) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(0 - clockwise.y) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(-1 - clockwise.z) < scalar.floatComparisonTolerance);
        }

        [Fact]
        public void axisAngleZRotate()
        {
            vec3 v = new vec3(1, 0, 0);
            mat3 m = mat3.rotateDegrees(new vec3(0, 0, 1), 90);

            vec3 counterClockwise = v * m;

            Assert.True(Math.Abs(0 - counterClockwise.x) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(-1 - counterClockwise.y) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(0 - counterClockwise.z) < scalar.floatComparisonTolerance);

            vec3 clockwise = m * v;

            Assert.True(Math.Abs(0 - clockwise.x) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(1 - clockwise.y) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(0 - clockwise.z) < scalar.floatComparisonTolerance);
        }
    }
}
