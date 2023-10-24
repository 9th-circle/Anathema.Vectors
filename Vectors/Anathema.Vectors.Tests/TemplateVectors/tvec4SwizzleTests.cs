using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.TemplateVectors
{
    public class tvec4SwizzleTests
    {

        [Fact]
        public void swizzleWrites()
        {
            tvec4<int> a = new tvec4<int>(1, 2, 3, 4);

            a.w = 5;
            Assert.Equal(5, a.w);

            a.xyzw = new tvec4<int>(4, 5, 6, 7);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.xywz = new tvec4<int>(4, 5, 7, 6);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.xzyw = new tvec4<int>(4, 6, 5, 7);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.xzwy = new tvec4<int>(4, 6, 7, 5);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.xwzy = new tvec4<int>(4, 7, 6, 5);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.xwyz = new tvec4<int>(4, 7, 5, 6);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);



            a.wxyz = new tvec4<int>(7, 4, 5, 6);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.wxzy = new tvec4<int>(7, 4, 6, 5);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.wyxz = new tvec4<int>(7, 5, 4, 6);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.wyzx = new tvec4<int>(7, 5, 6, 4);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.wzyx = new tvec4<int>(7, 6, 5, 4);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.wzxy = new tvec4<int>(7, 6, 4, 5);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);



            a.zxyw = new tvec4<int>(6, 4, 5, 7);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.zxwy = new tvec4<int>(6, 4, 7, 5);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.zwxy = new tvec4<int>(6, 7, 4, 5);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.zwyx = new tvec4<int>(6, 7, 5, 4);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.zywx = new tvec4<int>(6, 5, 7, 4);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.zyxw = new tvec4<int>(6, 5, 4, 7);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);


            a.yzxw = new tvec4<int>(5, 6, 4, 7);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.yxwz = new tvec4<int>(5, 4, 7, 6);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.yzxw = new tvec4<int>(5, 6, 4, 7);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.yzwx = new tvec4<int>(5, 6, 7, 4);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.ywzx = new tvec4<int>(5, 7, 6, 4);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.ywxz = new tvec4<int>(5, 7, 4, 6);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.yxzw = new tvec4<int>(5, 4, 6, 7);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);
        }

        [Fact]
        public void colourSwizzleWrites()
        {
            tvec4<int> a = new tvec4<int>(1, 2, 3, 4);

            a.a = 5;
            Assert.Equal(5, a.a);

            a.rgba = new tvec4<int>(4, 5, 6, 7);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.rgab = new tvec4<int>(4, 5, 7, 6);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.rbga = new tvec4<int>(4, 6, 5, 7);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.rbag = new tvec4<int>(4, 6, 7, 5);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.rabg = new tvec4<int>(4, 7, 6, 5);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.ragb = new tvec4<int>(4, 7, 5, 6);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);



            a.argb = new tvec4<int>(7, 4, 5, 6);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.arbg = new tvec4<int>(7, 4, 6, 5);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.agrb = new tvec4<int>(7, 5, 4, 6);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.agbr = new tvec4<int>(7, 5, 6, 4);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.abgr = new tvec4<int>(7, 6, 5, 4);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.abrg = new tvec4<int>(7, 6, 4, 5);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);



            a.brga = new tvec4<int>(6, 4, 5, 7);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.brag = new tvec4<int>(6, 4, 7, 5);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.barg = new tvec4<int>(6, 7, 4, 5);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.bagr = new tvec4<int>(6, 7, 5, 4);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.bgar = new tvec4<int>(6, 5, 7, 4);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.bgra = new tvec4<int>(6, 5, 4, 7);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);


            a.gbra = new tvec4<int>(5, 6, 4, 7);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.grab = new tvec4<int>(5, 4, 7, 6);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.gbra = new tvec4<int>(5, 6, 4, 7);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.gbar = new tvec4<int>(5, 6, 7, 4);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.gabr = new tvec4<int>(5, 7, 6, 4);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.garb = new tvec4<int>(5, 7, 4, 6);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.grba = new tvec4<int>(5, 4, 6, 7);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);
        }

        [Fact]
        public void swizzles()
        {
            tvec4<int> a = new tvec4<int>(1, 2, 3, 4);

            Assert.Equal(1, a.xyzw.x);
            Assert.Equal(2, a.xyzw.y);
            Assert.Equal(3, a.xyzw.z);
            Assert.Equal(4, a.xyzw.w);

            Assert.Equal(1, a.xywz.x);
            Assert.Equal(2, a.xywz.y);
            Assert.Equal(4, a.xywz.z);
            Assert.Equal(3, a.xywz.w);

            Assert.Equal(1, a.xzwy.x);
            Assert.Equal(3, a.xzwy.y);
            Assert.Equal(4, a.xzwy.z);
            Assert.Equal(2, a.xzwy.w);

            Assert.Equal(1, a.xzyw.x);
            Assert.Equal(3, a.xzyw.y);
            Assert.Equal(2, a.xzyw.z);
            Assert.Equal(4, a.xzyw.w);

            Assert.Equal(1, a.xwyz.x);
            Assert.Equal(4, a.xwyz.y);
            Assert.Equal(2, a.xwyz.z);
            Assert.Equal(3, a.xwyz.w);

            Assert.Equal(1, a.xwzy.x);
            Assert.Equal(4, a.xwzy.y);
            Assert.Equal(3, a.xwzy.z);
            Assert.Equal(2, a.xwzy.w);


            Assert.Equal(2, a.yxzw.x);
            Assert.Equal(1, a.yxzw.y);
            Assert.Equal(3, a.yxzw.z);
            Assert.Equal(4, a.yxzw.w);

            Assert.Equal(2, a.yxwz.x);
            Assert.Equal(1, a.yxwz.y);
            Assert.Equal(4, a.yxwz.z);
            Assert.Equal(3, a.yxwz.w);

            Assert.Equal(2, a.ywxz.x);
            Assert.Equal(4, a.ywxz.y);
            Assert.Equal(1, a.ywxz.z);
            Assert.Equal(3, a.ywxz.w);

            Assert.Equal(2, a.ywzx.x);
            Assert.Equal(4, a.ywzx.y);
            Assert.Equal(3, a.ywzx.z);
            Assert.Equal(1, a.ywzx.w);

            Assert.Equal(2, a.yzxw.x);
            Assert.Equal(3, a.yzxw.y);
            Assert.Equal(1, a.yzxw.z);
            Assert.Equal(4, a.yzxw.w);

            Assert.Equal(2, a.yzwx.x);
            Assert.Equal(3, a.yzwx.y);
            Assert.Equal(4, a.yzwx.z);
            Assert.Equal(1, a.yzwx.w);
        }
        [Fact]
        public void colourSwizzles()
        {
            tvec4<int> a = new tvec4<int>(1, 2, 3, 4);

            Assert.Equal(1, a.rgba.r);
            Assert.Equal(2, a.rgba.g);
            Assert.Equal(3, a.rgba.b);
            Assert.Equal(4, a.rgba.a);
        }
    }
}