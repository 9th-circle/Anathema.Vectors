using Anathema.Vectors.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Anathema.Vectors.Tests.DoubleVectorMatrixOperations
{
    public class dvec4dmat4
    {
        [Fact]
        public void identityMultiply()
        {
            dvec4 a = new dvec4(1, 2, 3, 4);
            dmat4 m = dmat4.identity();
            mat4 m2 = mat4.identity();
            tvec4<tvec4<double>> t = tvec4<tvec4<double>>.fromDMat4(m);
            dvec4 b = t * a;
            dvec4 c = a * t;
            dvec4 d = m * a;
            dvec4 e = a * m;
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