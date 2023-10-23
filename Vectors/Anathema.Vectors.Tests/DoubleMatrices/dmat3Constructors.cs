using Anathema.Vectors.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Anathema.Vectors.Tests.DoubleMatrices
{
    public class dmat3Constructors
    {
        [Fact]
        public void assign()
        {
            dmat3 a = new dmat3(new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            dmat3 b = new dmat3(new double[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 });

            Assert.False(a == b);
            Assert.True(a != b);

            a.assign(b);
            Assert.Equal(9, a[0]);
            Assert.Equal(8, a[1]);
            Assert.Equal(7, a[2]);
            Assert.Equal(6, a[3]);
            Assert.Equal(5, a[4]);
            Assert.Equal(4, a[5]);
            Assert.Equal(3, a[6]);
            Assert.Equal(2, a[7]);
            Assert.Equal(1, a[8]);
        }
        [Fact]
        public void copy()
        {
            dmat3 b = new dmat3(new double[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 });
            dmat3 a = new dmat3(b);
            Assert.Equal(9, a[0]);
            Assert.Equal(8, a[1]);
            Assert.Equal(7, a[2]);
            Assert.Equal(6, a[3]);
            Assert.Equal(5, a[4]);
            Assert.Equal(4, a[5]);
            Assert.Equal(3, a[6]);
            Assert.Equal(2, a[7]);
            Assert.Equal(1, a[8]);
        }
    }
}
