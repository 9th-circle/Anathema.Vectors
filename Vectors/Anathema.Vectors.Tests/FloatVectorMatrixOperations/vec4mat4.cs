using Anathema.Vectors.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Anathema.Vectors.Tests.FloatVectorMatrixOperations
{
    public class vec4mat4
    {
        [Fact]
        public void identityMultiply()
        {
            vec4 a = new vec4(1, 2, 3, 4);
            mat4 m = mat4.identity();
            tvec4<tvec4<float>> t = tvec4<tvec4<float>>.fromMat4(m);
            vec4 b = t * a;
            vec4 c = a * t;

            Assert.Equal(1, b[0]);
            Assert.Equal(2, b[1]);
            Assert.Equal(3, b[2]);
            Assert.Equal(4, b[3]);

            Assert.Equal(1, c[0]);
            Assert.Equal(2, c[1]);
            Assert.Equal(3, c[2]);
            Assert.Equal(4, c[3]);
        }
    }
}
