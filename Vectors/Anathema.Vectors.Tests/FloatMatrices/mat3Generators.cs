using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.FloatMatrices
{
    public class mat3Generators
    {
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
    }
}
