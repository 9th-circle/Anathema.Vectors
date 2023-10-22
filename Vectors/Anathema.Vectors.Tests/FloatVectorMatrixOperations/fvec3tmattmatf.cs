using Anathema.Vectors.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Anathema.Vectors.Tests.FloatVectorMatrixOperations
{
    public class fvec3tmattmatf
    {
        [Fact]
        public void identityMultiplyTVec()
        {
            fvec3 a = new fvec3(1, 2, 3);
            fmat3 m = fmat3.identity();
            tvec3<tvec3<float>> n = tvec3<tvec3<float>>.fromFMat3(m);

            fvec3 b = n * a;
            fvec3 c = a * n;

            Assert.Equal(1, b.x);
            Assert.Equal(2, b.y);
            Assert.Equal(3, b.z);

            Assert.Equal(1, c.x);
            Assert.Equal(2, c.y);
            Assert.Equal(3, c.z);
        }
    }
}
