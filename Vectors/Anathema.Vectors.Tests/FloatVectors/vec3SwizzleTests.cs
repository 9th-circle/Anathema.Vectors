using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.FloatVectors
{
    public class vec3SwizzleTests
    {

        //todo: write to swizzles

        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 17 })]
        [InlineData(new object[] { -37, 0, 2 })]
        public void swizzles(float x1, float y1, float z1)
        {
            vec3 a = new vec3(x1, y1, z1);

            Assert.Equal(x1, a.X);
            Assert.Equal(y1, a.Y);
            Assert.Equal(z1, a.Z);

            Assert.Equal(z1, a.B);

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
            vec3 a = new vec3(1,2,5);

            a.Z = 3;

            a.xy = new vec2(4,5);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(3, a.z);

            a.B = 2;

            a.yx = new vec2(7, 6);
            Assert.Equal(6, a.x);
            Assert.Equal(7, a.y);
            Assert.Equal(2, a.z);

            a.xz = new vec2(8, 9);
            Assert.Equal(8, a.x);
            Assert.Equal(7, a.y);
            Assert.Equal(9, a.z);

            a.zx = new vec2(11, 10);
            Assert.Equal(10, a.x);
            Assert.Equal(7, a.y);
            Assert.Equal(11, a.z);

            a.xyz = new vec3(1, 2, 3);
            Assert.Equal(1, a.x);
            Assert.Equal(2, a.y);
            Assert.Equal(3, a.z);

            a.xzy = new vec3(4, 6, 5);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);

            a.yxz = new vec3(8, 7, 9);
            Assert.Equal(7, a.x);
            Assert.Equal(8, a.y);
            Assert.Equal(9, a.z);

            a.yzx = new vec3(2, 3, 1);
            Assert.Equal(1, a.x);
            Assert.Equal(2, a.y);
            Assert.Equal(3, a.z);

            a.zyx = new vec3(3, 2, 1);
            Assert.Equal(1, a.x);
            Assert.Equal(2, a.y);
            Assert.Equal(3, a.z);

            a.zxy = new vec3(3, 1, 2);
            Assert.Equal(1, a.x);
            Assert.Equal(2, a.y);
            Assert.Equal(3, a.z);
        }


        [Fact]
        public void colourSwizzleWrite()
        {
            vec3 a = new vec3(1, 2, 3);

            a.rg = new vec2(4, 5);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(3, a.b);

            a.gr = new vec2(7, 6);
            Assert.Equal(6, a.r);
            Assert.Equal(7, a.g);
            Assert.Equal(3, a.b);

            a.rb = new vec2(8, 9);
            Assert.Equal(8, a.r);
            Assert.Equal(7, a.g);
            Assert.Equal(9, a.b);

            a.br = new vec2(11, 10);
            Assert.Equal(10, a.r);
            Assert.Equal(7, a.g);
            Assert.Equal(11, a.b);

            a.rgb = new vec3(1, 2, 3);
            Assert.Equal(1, a.r);
            Assert.Equal(2, a.g);
            Assert.Equal(3, a.b);

            a.rbg = new vec3(4, 6, 5);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);

            a.grb = new vec3(8, 7, 9);
            Assert.Equal(7, a.r);
            Assert.Equal(8, a.g);
            Assert.Equal(9, a.b);

            a.gbr = new vec3(2, 3, 1);
            Assert.Equal(1, a.r);
            Assert.Equal(2, a.g);
            Assert.Equal(3, a.b);

            a.bgr = new vec3(3, 2, 1);
            Assert.Equal(1, a.r);
            Assert.Equal(2, a.g);
            Assert.Equal(3, a.b);

            a.brg = new vec3(3, 1, 2);
            Assert.Equal(1, a.r);
            Assert.Equal(2, a.g);
            Assert.Equal(3, a.b);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 17 })]
        [InlineData(new object[] { -37, 0, 2 })]
        public void colourSwizzles(float x1, float y1, float z1)
        {
            vec3 a = new vec3(x1, y1, z1);

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

            a.b = 0;
            Assert.Equal(0, a.b);
        }
    }
}
