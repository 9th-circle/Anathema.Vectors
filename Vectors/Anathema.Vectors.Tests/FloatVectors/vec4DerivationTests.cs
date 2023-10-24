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
        [Fact]
        public void dot()
        {
            vec4 a = new vec4(1, 1, 1, 1);
            vec4 b = new vec4(1, 1, 1, 1);
            Assert.Equal(1, a.dot(b));

            vec4 c = new vec4(1, 1, 1, 5);
            vec4 d = new vec4(1, 1, 1, 1);
            Assert.Equal(5, a.dot(b));
        }
    }
}