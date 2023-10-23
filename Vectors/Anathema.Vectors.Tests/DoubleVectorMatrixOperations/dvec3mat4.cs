using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.DoubleVectorMatrixOperations
{
    public class dvec3mat4
    {
        [Fact]
        public void identityMultiply()
        {
            dvec3 a = new dvec3(1, 2, 3);
            mat4 m = mat4.identity();
            dvec3 b = m * a;
            dvec3 c = a * m;

            Assert.Equal(1, b[0]);
            Assert.Equal(2, b[1]);
            Assert.Equal(3, b[2]);

            Assert.Equal(1, c[0]);
            Assert.Equal(2, c[1]);
            Assert.Equal(3, c[2]);
        }
    }
}
