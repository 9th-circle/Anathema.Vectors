using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.DoubleVectorMatrixOperations
{
    public class dvec3tvec3
    {

        [Fact]
        public void identityMultiply()
        {
            dvec3 a = new dvec3(1, 2, 3);
            dmat3 m = dmat3.identity();
            tvec3<tvec3<double>> t = tvec3<tvec3<double>>.fromDMat3(m);
            dvec3 b = t * a;
            dvec3 c = a * t;

            Assert.Equal(1, b[0]);
            Assert.Equal(2, b[1]);
            Assert.Equal(3, b[2]);

            Assert.Equal(1, c[0]);
            Assert.Equal(2, c[1]);
            Assert.Equal(3, c[2]);
        }
    }
}