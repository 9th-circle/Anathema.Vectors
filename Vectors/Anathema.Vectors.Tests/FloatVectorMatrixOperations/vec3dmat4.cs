using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.FloatVectorMatrixOperations
{
    public class vec3dmat4
    {
        [Fact]
        public void identityMultiply()
        {
            vec3 a = new vec3(1, 2, 3);
            dmat4 m = dmat4.identity();

            dvec3 b = m * a;
            dvec3 c = a * m;

            Assert.Equal(1, b.x);
            Assert.Equal(2, b.y);
            Assert.Equal(3, b.z);

            Assert.Equal(1, c.x);
            Assert.Equal(2, c.y);
            Assert.Equal(3, c.z);
        }
    }
}
