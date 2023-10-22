using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.FloatVectorMatrixOperations
{
    public class fvec3fmat4
    {
        [Fact]
        public void identityMultiply()
        {
            fvec3 a = new fvec3(1, 2, 3);
            fmat4 m = fmat4.identity();

            fvec3 b = m * a;
            fvec3 c = a * m;

            Assert.Equal(1, b.x);
            Assert.Equal(2, b.y);
            Assert.Equal(3, b.z);

            Assert.Equal(1, c.x);
            Assert.Equal(2, c.y);
            Assert.Equal(3, c.z);
        }
    }
}
