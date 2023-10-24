using Anathema.Vectors.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Anathema.Vectors.Tests.DoubleVectorMatrixOperations
{
    public class dvec4tvec4
    {
        [Fact]
        public void identityMultiply()
        {
            dvec4 a = new dvec4(1, 2, 3, 4);
            dmat4 m = dmat4.identity();
            tvec4<tvec4<double>> t = tvec4<tvec4<double>>.fromDMat4(m);
            dvec4 b = t * a;
            dvec4 c = a * t;

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
