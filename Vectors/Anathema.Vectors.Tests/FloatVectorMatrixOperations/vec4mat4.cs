using Anathema.Vectors.Core;
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
            dmat4 m2 = dmat4.identity();
            tvec4<tvec4<float>> t = tvec4<tvec4<float>>.fromMat4(m);
            vec4 b = t * a;
            vec4 c = a * t;
            vec4 d = m * a;
            vec4 e = a * m;
            dvec4 f = m2 * a;
            dvec4 g = a * m2;

            Assert.Equal(1, b[0]);
            Assert.Equal(2, b[1]);
            Assert.Equal(3, b[2]);
            Assert.Equal(4, b[3]);

            Assert.Equal(1, c[0]);
            Assert.Equal(2, c[1]);
            Assert.Equal(3, c[2]);
            Assert.Equal(4, c[3]);

            Assert.Equal(1, d[0]);
            Assert.Equal(2, d[1]);
            Assert.Equal(3, d[2]);
            Assert.Equal(4, d[3]);

            Assert.Equal(1, e[0]);
            Assert.Equal(2, e[1]);
            Assert.Equal(3, e[2]);
            Assert.Equal(4, e[3]);

            Assert.Equal(1, f[0]);
            Assert.Equal(2, f[1]);
            Assert.Equal(3, f[2]);
            Assert.Equal(4, f[3]);

            Assert.Equal(1, g[0]);
            Assert.Equal(2, g[1]);
            Assert.Equal(3, g[2]);
            Assert.Equal(4, g[3]);
        }
    }
}
