using Anathema.Vectors.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Anathema.Vectors.Tests.DoubleMatrices
{
    public class dmat4Generators
    {

        [Fact]
        public void transpose()
        {
            dmat4 m = new dmat4(new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 });
            dmat4 t = m.transposed;

            Assert.Equal(1, t[0]);
            Assert.Equal(5, t[1]);
            Assert.Equal(9, t[2]);
            Assert.Equal(13, t[3]);

            Assert.Equal(2, t[4]);
            Assert.Equal(6, t[5]);
            Assert.Equal(10, t[6]);
            Assert.Equal(14, t[7]);

            Assert.Equal(3, t[8]);
            Assert.Equal(7, t[9]);
            Assert.Equal(11, t[10]);
            Assert.Equal(15, t[11]);

            Assert.Equal(4, t[12]);
            Assert.Equal(8, t[13]);
            Assert.Equal(12, t[14]);
            Assert.Equal(16, t[15]);

            m.transpose();

            Assert.True(m == t);
            Assert.False(m != t);
        }
        [Fact]
        public void toMat2()
        {
            dmat4 m = new dmat4(new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 });
            dmat2 t = m;

            Assert.Equal(1, t[0, 0]);
            Assert.Equal(2, t[1, 0]);
            Assert.Equal(5, t[0, 1]);
            Assert.Equal(6, t[1, 1]);
        }
        [Fact]
        public void toMat3()
        {
            dmat4 m = new dmat4(new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 });
            dmat3 d = m;

            Assert.Equal(1, d[0, 0]);
            Assert.Equal(2, d[1, 0]);
            Assert.Equal(3, d[2, 0]);

            Assert.Equal(5, d[0, 1]);
            Assert.Equal(6, d[1, 1]);
            Assert.Equal(7, d[2, 1]);

            Assert.Equal(9, d[0, 2]);
            Assert.Equal(10, d[1, 2]);
            Assert.Equal(11, d[2, 2]);
        }
        [Fact]
        public void scalarScale()
        {
            dvec3 v = new dvec3(1, 2, 3);
            dmat4 m = dmat4.scale(2.0f);

            dvec3 up = m * v;

            Assert.Equal(2, up.x);
            Assert.Equal(4, up.y);
            Assert.Equal(6, up.z);
        }
        [Fact]
        public void basisScale()
        {
            dvec3 v = new dvec3(1, 2, 3);
            dmat4 m = dmat4.scale(new dvec4(0, 2, 4, 1));

            dvec3 up = m * v;

            Assert.Equal(0, up.x);
            Assert.Equal(4, up.y);
            Assert.Equal(12, up.z);
        }

        [Fact]
        public void eulerZRotate()
        {
            dvec3 v = new dvec3(1, 0, 0);
            dmat4 m = dmat4.rotateDegrees(0, 0, 90);

            dvec3 counterClockwise = v * m;

            Assert.True(Math.Abs(0 - counterClockwise.x) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(-1 - counterClockwise.y) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(0 - counterClockwise.z) < scalar.floatComparisonTolerance);

            dvec3 clockwise = m * v;

            Assert.True(Math.Abs(0 - clockwise.x) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(1 - clockwise.y) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(0 - clockwise.z) < scalar.floatComparisonTolerance);
        }

        [Fact]
        public void eulerXIdentity()
        {
            dvec3 v = new dvec3(1, 0, 0);
            dmat4 m = dmat4.rotateDegrees(90, 0, 0);

            dvec3 counterClockwise = v * m;

            Assert.True(Math.Abs(1 - counterClockwise.x) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(0 - counterClockwise.y) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(0 - counterClockwise.z) < scalar.floatComparisonTolerance);

            dvec3 clockwise = m * v;

            Assert.True(Math.Abs(1 - clockwise.x) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(0 - clockwise.y) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(0 - clockwise.z) < scalar.floatComparisonTolerance);
        }
        [Fact]
        public void eulerXRotate()
        {
            dvec3 v = new dvec3(0, 1, 0);
            dmat4 m = dmat4.rotateDegrees(90, 0, 0);

            dvec3 counterClockwise = v * m;

            Assert.True(Math.Abs(0 - counterClockwise.x) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(0 - counterClockwise.y) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(-1 - counterClockwise.z) < scalar.floatComparisonTolerance);

            dvec3 clockwise = m * v;

            Assert.True(Math.Abs(0 - clockwise.x) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(0 - clockwise.y) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(1 - clockwise.z) < scalar.floatComparisonTolerance);
        }
        [Fact]
        public void eulerYRotate()
        {
            dvec3 v = new dvec3(1, 0, 0);
            dmat4 m = dmat4.rotateDegrees(0, 90, 0);

            dvec3 counterClockwise = v * m;

            Assert.True(Math.Abs(0 - counterClockwise.x) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(0 - counterClockwise.y) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(1 - counterClockwise.z) < scalar.floatComparisonTolerance);

            dvec3 clockwise = m * v;

            Assert.True(Math.Abs(0 - clockwise.x) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(0 - clockwise.y) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(-1 - clockwise.z) < scalar.floatComparisonTolerance);
        }
        [Fact]
        public void axisAngleYRotate()
        {
            dvec3 v = new dvec3(1, 0, 0);
            dmat4 m = dmat4.rotateDegrees(new dvec3(0, 1, 0), 90);

            dvec3 counterClockwise = v * m;

            Assert.True(Math.Abs(0 - counterClockwise.x) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(0 - counterClockwise.y) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(1 - counterClockwise.z) < scalar.floatComparisonTolerance);

            dvec3 clockwise = m * v;

            Assert.True(Math.Abs(0 - clockwise.x) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(0 - clockwise.y) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(-1 - clockwise.z) < scalar.floatComparisonTolerance);
        }


        [Fact]
        public void axisAngleXRotate()
        {
            dvec3 v = new dvec3(0, 1, 0);
            dmat4 m = dmat4.rotateDegrees(new dvec3(1, 0, 0), 90); // <- problem

            dvec3 counterClockwise = v * m;

            Assert.True(Math.Abs(0 - counterClockwise.x) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(0 - counterClockwise.y) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(-1 - counterClockwise.z) < scalar.floatComparisonTolerance);

            dvec3 clockwise = m * v;

            Assert.True(Math.Abs(0 - clockwise.x) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(0 - clockwise.y) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(1 - clockwise.z) < scalar.floatComparisonTolerance);
        }

        [Fact]
        public void axisAngleZRotate()
        {
            dvec3 v = new dvec3(1, 0, 0);
            dmat4 m = dmat4.rotateDegrees(new dvec3(0, 0, 1), 90);

            dvec3 counterClockwise = v * m;

            Assert.True(Math.Abs(0 - counterClockwise.x) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(-1 - counterClockwise.y) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(0 - counterClockwise.z) < scalar.floatComparisonTolerance);

            dvec3 clockwise = m * v;

            Assert.True(Math.Abs(0 - clockwise.x) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(1 - clockwise.y) < scalar.floatComparisonTolerance);
            Assert.True(Math.Abs(0 - clockwise.z) < scalar.floatComparisonTolerance);
        }
    }
}
