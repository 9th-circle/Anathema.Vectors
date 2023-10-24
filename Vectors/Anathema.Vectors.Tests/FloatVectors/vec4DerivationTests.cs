using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.FloatVectors
{
    public class vec4DerivationTests
    {
        [Fact]
        public void length()
        {
            vec4 a = new vec4(0, 0, 0, 100);
            Assert.Equal(100, a.length);
        }
    }
}