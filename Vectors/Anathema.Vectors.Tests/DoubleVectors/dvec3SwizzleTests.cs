using Anathema.Vectors.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Anathema.Vectors.Tests.DoubleVectors
{
    public class dvec3SwizzleTests
    {


        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 17 })]
        [InlineData(new object[] { -37, 0, 2 })]
        public void swizzles(double x1, double y1, double z1)
        {
            dvec3 a = new dvec3(x1, y1, z1);

            Assert.Equal(x1, a.X);
            Assert.Equal(y1, a.Y);
            Assert.Equal(z1, a.Z);

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



        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 17 })]
        [InlineData(new object[] { -37, 0, 2 })]
        public void colourSwizzles(double x1, double y1, double z1)
        {
            dvec3 a = new dvec3(x1, y1, z1);

            Assert.Equal(z1, a.B);
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


        [Fact]
        public void swizzleWrite()
        {
            dvec3 a = new dvec3(1, 2, 5);

            a.Z = 3;

            a.xy = new dvec2(4, 5);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(3, a.z);

            a.B = 4;

            a.yx = new dvec2(7, 6);
            Assert.Equal(6, a.x);
            Assert.Equal(7, a.y);
            Assert.Equal(4, a.z);

            a.xz = new dvec2(8, 9);
            Assert.Equal(8, a.x);
            Assert.Equal(7, a.y);
            Assert.Equal(9, a.z);

            a.zx = new dvec2(11, 10);
            Assert.Equal(10, a.x);
            Assert.Equal(7, a.y);
            Assert.Equal(11, a.z);

            a.xyz = new dvec3(1, 2, 3);
            Assert.Equal(1, a.x);
            Assert.Equal(2, a.y);
            Assert.Equal(3, a.z);

            a.xzy = new dvec3(4, 6, 5);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);

            a.yxz = new dvec3(8, 7, 9);
            Assert.Equal(7, a.x);
            Assert.Equal(8, a.y);
            Assert.Equal(9, a.z);

            a.yzx = new dvec3(2, 3, 1);
            Assert.Equal(1, a.x);
            Assert.Equal(2, a.y);
            Assert.Equal(3, a.z);

            a.zyx = new dvec3(3, 2, 1);
            Assert.Equal(1, a.x);
            Assert.Equal(2, a.y);
            Assert.Equal(3, a.z);

            a.zxy = new dvec3(3, 1, 2);
            Assert.Equal(1, a.x);
            Assert.Equal(2, a.y);
            Assert.Equal(3, a.z);
        }


        [Fact]
        public void colourSwizzleWrite()
        {
            dvec3 a = new dvec3(1, 2, 3);

            a.rg = new dvec2(4, 5);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(3, a.b);

            a.gr = new dvec2(7, 6);
            Assert.Equal(6, a.r);
            Assert.Equal(7, a.g);
            Assert.Equal(3, a.b);

            a.rb = new dvec2(8, 9);
            Assert.Equal(8, a.r);
            Assert.Equal(7, a.g);
            Assert.Equal(9, a.b);

            a.br = new dvec2(11, 10);
            Assert.Equal(10, a.r);
            Assert.Equal(7, a.g);
            Assert.Equal(11, a.b);

            a.rgb = new dvec3(1, 2, 3);
            Assert.Equal(1, a.r);
            Assert.Equal(2, a.g);
            Assert.Equal(3, a.b);

            a.rbg = new dvec3(4, 6, 5);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);

            a.grb = new dvec3(8, 7, 9);
            Assert.Equal(7, a.r);
            Assert.Equal(8, a.g);
            Assert.Equal(9, a.b);

            a.gbr = new dvec3(2, 3, 1);
            Assert.Equal(1, a.r);
            Assert.Equal(2, a.g);
            Assert.Equal(3, a.b);

            a.bgr = new dvec3(3, 2, 1);
            Assert.Equal(1, a.r);
            Assert.Equal(2, a.g);
            Assert.Equal(3, a.b);

            a.brg = new dvec3(3, 1, 2);
            Assert.Equal(1, a.r);
            Assert.Equal(2, a.g);
            Assert.Equal(3, a.b);

            a.b = 0;
            Assert.Equal(0, a.b);
        }


    
        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 5.2, 10.00001, -3.7 })]
        [InlineData(new object[] { -37, 0, 42 })]
        public void duplicateSwizzles_ALL(double x1, double y1, double z1)
        {
            dvec3 a = new dvec3(x1, y1, z1);

            // Test ALL 21 coordinate duplicate swizzles
            Assert.Equal(a.xxx.x, a.x);
            Assert.Equal(a.xxx.y, a.x);
            Assert.Equal(a.xxx.z, a.x);
            Assert.Equal(a.xxy.x, a.x);
            Assert.Equal(a.xxy.y, a.x);
            Assert.Equal(a.xxy.z, a.y);
            Assert.Equal(a.xxz.x, a.x);
            Assert.Equal(a.xxz.y, a.x);
            Assert.Equal(a.xxz.z, a.z);
            Assert.Equal(a.xyx.x, a.x);
            Assert.Equal(a.xyx.y, a.y);
            Assert.Equal(a.xyx.z, a.x);
            Assert.Equal(a.xyy.x, a.x);
            Assert.Equal(a.xyy.y, a.y);
            Assert.Equal(a.xyy.z, a.y);
            Assert.Equal(a.xzx.x, a.x);
            Assert.Equal(a.xzx.y, a.z);
            Assert.Equal(a.xzx.z, a.x);
            Assert.Equal(a.xzz.x, a.x);
            Assert.Equal(a.xzz.y, a.z);
            Assert.Equal(a.xzz.z, a.z);
            Assert.Equal(a.yxx.x, a.y);
            Assert.Equal(a.yxx.y, a.x);
            Assert.Equal(a.yxx.z, a.x);
            Assert.Equal(a.yxy.x, a.y);
            Assert.Equal(a.yxy.y, a.x);
            Assert.Equal(a.yxy.z, a.y);
            Assert.Equal(a.yyx.x, a.y);
            Assert.Equal(a.yyx.y, a.y);
            Assert.Equal(a.yyx.z, a.x);
            Assert.Equal(a.yyy.x, a.y);
            Assert.Equal(a.yyy.y, a.y);
            Assert.Equal(a.yyy.z, a.y);
            Assert.Equal(a.yyz.x, a.y);
            Assert.Equal(a.yyz.y, a.y);
            Assert.Equal(a.yyz.z, a.z);
            Assert.Equal(a.yzy.x, a.y);
            Assert.Equal(a.yzy.y, a.z);
            Assert.Equal(a.yzy.z, a.y);
            Assert.Equal(a.yzz.x, a.y);
            Assert.Equal(a.yzz.y, a.z);
            Assert.Equal(a.yzz.z, a.z);
            Assert.Equal(a.zxx.x, a.z);
            Assert.Equal(a.zxx.y, a.x);
            Assert.Equal(a.zxx.z, a.x);
            Assert.Equal(a.zxz.x, a.z);
            Assert.Equal(a.zxz.y, a.x);
            Assert.Equal(a.zxz.z, a.z);
            Assert.Equal(a.zyy.x, a.z);
            Assert.Equal(a.zyy.y, a.y);
            Assert.Equal(a.zyy.z, a.y);
            Assert.Equal(a.zyz.x, a.z);
            Assert.Equal(a.zyz.y, a.y);
            Assert.Equal(a.zyz.z, a.z);
            Assert.Equal(a.zzx.x, a.z);
            Assert.Equal(a.zzx.y, a.z);
            Assert.Equal(a.zzx.z, a.x);
            Assert.Equal(a.zzy.x, a.z);
            Assert.Equal(a.zzy.y, a.z);
            Assert.Equal(a.zzy.z, a.y);
            Assert.Equal(a.zzz.x, a.z);
            Assert.Equal(a.zzz.y, a.z);
            Assert.Equal(a.zzz.z, a.z);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 5.2, 10.00001, -3.7 })]
        [InlineData(new object[] { -37, 0, 42 })]
        public void duplicateColourSwizzles_ALL(double x1, double y1, double z1)
        {
            dvec3 a = new dvec3(x1, y1, z1);

            // Test ALL 21 color duplicate swizzles
            Assert.Equal(a.rrr.r, a.r);
            Assert.Equal(a.rrr.g, a.r);
            Assert.Equal(a.rrr.b, a.r);
            Assert.Equal(a.rrg.r, a.r);
            Assert.Equal(a.rrg.g, a.r);
            Assert.Equal(a.rrg.b, a.g);
            Assert.Equal(a.rrb.r, a.r);
            Assert.Equal(a.rrb.g, a.r);
            Assert.Equal(a.rrb.b, a.b);
            Assert.Equal(a.rgr.r, a.r);
            Assert.Equal(a.rgr.g, a.g);
            Assert.Equal(a.rgr.b, a.r);
            Assert.Equal(a.rgg.r, a.r);
            Assert.Equal(a.rgg.g, a.g);
            Assert.Equal(a.rgg.b, a.g);
            Assert.Equal(a.rbr.r, a.r);
            Assert.Equal(a.rbr.g, a.b);
            Assert.Equal(a.rbr.b, a.r);
            Assert.Equal(a.rbb.r, a.r);
            Assert.Equal(a.rbb.g, a.b);
            Assert.Equal(a.rbb.b, a.b);
            Assert.Equal(a.grr.r, a.g);
            Assert.Equal(a.grr.g, a.r);
            Assert.Equal(a.grr.b, a.r);
            Assert.Equal(a.grg.r, a.g);
            Assert.Equal(a.grg.g, a.r);
            Assert.Equal(a.grg.b, a.g);
            Assert.Equal(a.ggr.r, a.g);
            Assert.Equal(a.ggr.g, a.g);
            Assert.Equal(a.ggr.b, a.r);
            Assert.Equal(a.ggg.r, a.g);
            Assert.Equal(a.ggg.g, a.g);
            Assert.Equal(a.ggg.b, a.g);
            Assert.Equal(a.ggb.r, a.g);
            Assert.Equal(a.ggb.g, a.g);
            Assert.Equal(a.ggb.b, a.b);
            Assert.Equal(a.gbg.r, a.g);
            Assert.Equal(a.gbg.g, a.b);
            Assert.Equal(a.gbg.b, a.g);
            Assert.Equal(a.gbb.r, a.g);
            Assert.Equal(a.gbb.g, a.b);
            Assert.Equal(a.gbb.b, a.b);
            Assert.Equal(a.brr.r, a.b);
            Assert.Equal(a.brr.g, a.r);
            Assert.Equal(a.brr.b, a.r);
            Assert.Equal(a.brb.r, a.b);
            Assert.Equal(a.brb.g, a.r);
            Assert.Equal(a.brb.b, a.b);
            Assert.Equal(a.bgg.r, a.b);
            Assert.Equal(a.bgg.g, a.g);
            Assert.Equal(a.bgg.b, a.g);
            Assert.Equal(a.bgb.r, a.b);
            Assert.Equal(a.bgb.g, a.g);
            Assert.Equal(a.bgb.b, a.b);
            Assert.Equal(a.bbr.r, a.b);
            Assert.Equal(a.bbr.g, a.b);
            Assert.Equal(a.bbr.b, a.r);
            Assert.Equal(a.bbg.r, a.b);
            Assert.Equal(a.bbg.g, a.b);
            Assert.Equal(a.bbg.b, a.g);
            Assert.Equal(a.bbb.r, a.b);
            Assert.Equal(a.bbb.g, a.b);
            Assert.Equal(a.bbb.b, a.b);
        }

        [Fact]
        public void duplicateSwizzleAssign()
        {

            dvec3 a = new dvec3(1, 2, 3);
            a.xxx = new dvec3(5, 6, 7);
            Assert.Equal(7, a.x);
            Assert.Equal(2, a.y);
            Assert.Equal(3, a.z);

        }
    }
}