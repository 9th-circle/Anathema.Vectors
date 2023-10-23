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
    }
}
