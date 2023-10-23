using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.TemplateVectors
{
    public class tvec3SwizzleTests
    {

        [Fact]
        public void swizzles()
        {
            tvec3<int> a = new tvec3<int>(1, 2, 3);

            Assert.Equal(1, a.xyz.x);
            Assert.Equal(2, a.xyz.y);
            Assert.Equal(3, a.xyz.z);

            Assert.Equal(1, a.xzy.x);
            Assert.Equal(3, a.xzy.y);
            Assert.Equal(2, a.xzy.z);

            Assert.Equal(3, a.zyx.x);
            Assert.Equal(2, a.zyx.y);
            Assert.Equal(1, a.zyx.z);

            Assert.Equal(3, a.zxy.x);
            Assert.Equal(1, a.zxy.y);
            Assert.Equal(2, a.zxy.z);

            Assert.Equal(2, a.yxz.x);
            Assert.Equal(1, a.yxz.y);
            Assert.Equal(3, a.yxz.z);

            Assert.Equal(2, a.yzx.x);
            Assert.Equal(3, a.yzx.y);
            Assert.Equal(1, a.yzx.z);
        }
    }
}