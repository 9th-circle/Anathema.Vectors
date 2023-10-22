using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.DoubleVectors
{
    public class dvec3tvec3ConversionTests
    {
        [Fact]
        public void dvec3toTemplate()
        {
            dvec3 a = new dvec3(1, 2, 3);
            tvec3<double> b = a.toTVec3();

            Assert.Equal(1, b.x);
            Assert.Equal(2, b.y);
            Assert.Equal(3, b.z);
        }
    }
}
