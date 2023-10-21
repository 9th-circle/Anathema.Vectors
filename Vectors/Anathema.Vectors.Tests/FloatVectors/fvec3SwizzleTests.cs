using Anathema.Vectors.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Anathema.Vectors.Tests.FloatVectors
{
    public class fvec3SwizzleTests
    {

        //todo: write to swizzles

        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 17 })]
        [InlineData(new object[] { -37, 0, 2 })]
        public void swizzles(float x1, float y1, float z1)
        {
            fvec3 a = new fvec3(x1, y1, z1);

            Assert.Equal(a.xy.x, a.x);
            Assert.Equal(a.xy.y, a.y);

            Assert.Equal(a.yx.x, a.y);
            Assert.Equal(a.yx.y, a.x);

            Assert.Equal(a.xz.x, a.x);
            Assert.Equal(a.xz.y, a.z);

            Assert.Equal(a.zx.x, a.z);
            Assert.Equal(a.zx.y, a.x);


            Assert.Equal(a.xyz.x, a.x);
            Assert.Equal(a.xyz.y, a.y);
            Assert.Equal(a.xyz.z, a.z);

            Assert.Equal(a.xzy.x, a.x);
            Assert.Equal(a.xzy.y, a.z);
            Assert.Equal(a.xzy.z, a.y);

            Assert.Equal(a.yxz.x, a.y);
            Assert.Equal(a.yxz.y, a.x);
            Assert.Equal(a.yxz.z, a.z);

            Assert.Equal(a.yzx.x, a.y);
            Assert.Equal(a.yzx.y, a.z);
            Assert.Equal(a.yzx.z, a.x);

            Assert.Equal(a.zyx.x, a.z);
            Assert.Equal(a.zyx.y, a.y);
            Assert.Equal(a.zyx.z, a.x);

            Assert.Equal(a.zxy.x, a.z);
            Assert.Equal(a.zxy.y, a.x);
            Assert.Equal(a.zxy.z, a.y);
        }
        [Fact]
        public void swizzleWrite()
        {
            fvec3 a = new fvec3(1,2,3);

            a.xy = new fvec2(4,5);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(3, a.z);

            a.yx = new fvec2(7, 6);
            Assert.Equal(6, a.x);
            Assert.Equal(7, a.y);
            Assert.Equal(3, a.z);


            a.xz = new fvec2(8, 9);
            Assert.Equal(8, a.x);
            Assert.Equal(7, a.y);
            Assert.Equal(9, a.z);

            a.zx = new fvec2(11, 10);
            Assert.Equal(10, a.x);
            Assert.Equal(7, a.y);
            Assert.Equal(11, a.z);
            /*
            Assert.Equal(a.xyz.x, a.x);
            Assert.Equal(a.xyz.y, a.y);
            Assert.Equal(a.xyz.z, a.z);

            Assert.Equal(a.xzy.x, a.x);
            Assert.Equal(a.xzy.y, a.z);
            Assert.Equal(a.xzy.z, a.y);

            Assert.Equal(a.yxz.x, a.y);
            Assert.Equal(a.yxz.y, a.x);
            Assert.Equal(a.yxz.z, a.z);

            Assert.Equal(a.yzx.x, a.y);
            Assert.Equal(a.yzx.y, a.z);
            Assert.Equal(a.yzx.z, a.x);

            Assert.Equal(a.zyx.x, a.z);
            Assert.Equal(a.zyx.y, a.y);
            Assert.Equal(a.zyx.z, a.x);

            Assert.Equal(a.zxy.x, a.z);
            Assert.Equal(a.zxy.y, a.x);
            Assert.Equal(a.zxy.z, a.y);*/
        }


        //todo: write to colour swizzles

        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 17 })]
        [InlineData(new object[] { -37, 0, 2 })]
        public void colourSwizzles(float x1, float y1, float z1)
        {
            fvec3 a = new fvec3(x1, y1, z1);

            Assert.Equal(a.rg.r, a.r);
            Assert.Equal(a.rg.g, a.g);

            Assert.Equal(a.gr.r, a.g);
            Assert.Equal(a.gr.g, a.r);

            Assert.Equal(a.rb.r, a.r);
            Assert.Equal(a.rb.g, a.b);

            Assert.Equal(a.br.r, a.b);
            Assert.Equal(a.br.g, a.r);


            Assert.Equal(a.rgb.r, a.r);
            Assert.Equal(a.rgb.g, a.g);
            Assert.Equal(a.rgb.b, a.b);

            Assert.Equal(a.rbg.r, a.r);
            Assert.Equal(a.rbg.g, a.b);
            Assert.Equal(a.rbg.b, a.g);

            Assert.Equal(a.grb.r, a.g);
            Assert.Equal(a.grb.g, a.r);
            Assert.Equal(a.grb.b, a.b);

            Assert.Equal(a.gbr.r, a.g);
            Assert.Equal(a.gbr.g, a.b);
            Assert.Equal(a.gbr.b, a.r);

            Assert.Equal(a.bgr.r, a.b);
            Assert.Equal(a.bgr.g, a.g);
            Assert.Equal(a.bgr.b, a.r);

            Assert.Equal(a.brg.r, a.b);
            Assert.Equal(a.brg.g, a.r);
            Assert.Equal(a.brg.b, a.g);
        }
    }
}
