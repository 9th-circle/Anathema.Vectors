using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.TemplateVectors
{
    public class tvec3SwizzleTests
    {

        [Fact]
        public void swizzleWrites()
        {
            tvec3<int> a = new tvec3<int>(1, 2, 3);

            a.xyz = new tvec3<int>(4, 5, 6);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);

            a.xzy = new tvec3<int>(7, 9, 8);
            Assert.Equal(7, a.x);
            Assert.Equal(8, a.y);
            Assert.Equal(9, a.z);

            a.yzx = new tvec3<int>(2, 3, 1);
            Assert.Equal(1, a.x);
            Assert.Equal(2, a.y);
            Assert.Equal(3, a.z);

            a.yxz = new tvec3<int>(5, 4, 6);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);

            a.zxy = new tvec3<int>(3, 1, 2);
            Assert.Equal(1, a.x);
            Assert.Equal(2, a.y);
            Assert.Equal(3, a.z);

            a.zyx = new tvec3<int>(6, 5, 4);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
        }

        [Fact]
        public void colourSwizzleWrites()
        {
            tvec3<int> a = new tvec3<int>(1, 2, 3);

            a.b = 5;
            Assert.Equal(5, a.b);

            a.rgb = new tvec3<int>(4, 5, 6);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);

            a.rbg = new tvec3<int>(7, 9, 8);
            Assert.Equal(7, a.r);
            Assert.Equal(8, a.g);
            Assert.Equal(9, a.b);

            a.gbr = new tvec3<int>(2, 3, 1);
            Assert.Equal(1, a.r);
            Assert.Equal(2, a.g);
            Assert.Equal(3, a.b);

            a.grb = new tvec3<int>(5, 4, 6);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);

            a.brg = new tvec3<int>(3, 1, 2);
            Assert.Equal(1, a.r);
            Assert.Equal(2, a.g);
            Assert.Equal(3, a.b);

            a.bgr = new tvec3<int>(6, 5, 4);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
        }

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
        [Fact]
        public void colourSwizzles()
        {
            tvec3<int> a = new tvec3<int>(1, 2, 3);

            Assert.Equal(1, a.rgb.r);
            Assert.Equal(2, a.rgb.g);
            Assert.Equal(3, a.rgb.b);

            Assert.Equal(1, a.rbg.r);
            Assert.Equal(3, a.rbg.g);
            Assert.Equal(2, a.rbg.b);

            Assert.Equal(3, a.bgr.r);
            Assert.Equal(2, a.bgr.g);
            Assert.Equal(1, a.bgr.b);

            Assert.Equal(3, a.brg.r);
            Assert.Equal(1, a.brg.g);
            Assert.Equal(2, a.brg.b);

            Assert.Equal(2, a.grb.r);
            Assert.Equal(1, a.grb.g);
            Assert.Equal(3, a.grb.b);

            Assert.Equal(2, a.gbr.r);
            Assert.Equal(3, a.gbr.g);
            Assert.Equal(1, a.gbr.b);
        }
    }
}