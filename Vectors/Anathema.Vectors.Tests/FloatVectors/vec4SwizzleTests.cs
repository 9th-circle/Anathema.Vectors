using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.TemplateVectors
{
    public class vec4SwizzleTests
    {

        [Fact]
        public void swizzleWrites()
        {
            vec4 a = new vec4(1, 2, 3, 4);

            a.w = 5;
            Assert.Equal(5, a.w);

            a.xyzw = new vec4(4, 5, 6, 7);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.xywz = new vec4(4, 5, 7, 6);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.xzyw = new vec4(4, 6, 5, 7);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.xzwy = new vec4(4, 6, 7, 5);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.xwzy = new vec4(4, 7, 6, 5);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.xwyz = new vec4(4, 7, 5, 6);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);



            a.wxyz = new vec4(7, 4, 5, 6);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.wxzy = new vec4(7, 4, 6, 5);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.wyxz = new vec4(7, 5, 4, 6);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.wyzx = new vec4(7, 5, 6, 4);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.wzyx = new vec4(7, 6, 5, 4);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.wzxy = new vec4(7, 6, 4, 5);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);



            a.zxyw = new vec4(6, 4, 5, 7);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.zxwy = new vec4(6, 4, 7, 5);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.zwxy = new vec4(6, 7, 4, 5);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.zwyx = new vec4(6, 7, 5, 4);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.zywx = new vec4(6, 5, 7, 4);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.zyxw = new vec4(6, 5, 4, 7);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);


            a.yzxw = new vec4(5, 6, 4, 7);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.yxwz = new vec4(5, 4, 7, 6);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.yzxw = new vec4(5, 6, 4, 7);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.yzwx = new vec4(5, 6, 7, 4);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.ywzx = new vec4(5, 7, 6, 4);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.ywxz = new vec4(5, 7, 4, 6);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

            a.yxzw = new vec4(5, 4, 6, 7);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);
        }

        [Fact]
        public void colourSwizzleWrites()
        {
            vec4 a = new vec4(1, 2, 3, 4);

            a.a = 5;
            Assert.Equal(5, a.a);

            a.rgba = new vec4(4, 5, 6, 7);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.rgab = new vec4(4, 5, 7, 6);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.rbga = new vec4(4, 6, 5, 7);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.rbag = new vec4(4, 6, 7, 5);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.rabg = new vec4(4, 7, 6, 5);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.ragb = new vec4(4, 7, 5, 6);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);



            a.argb = new vec4(7, 4, 5, 6);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.arbg = new vec4(7, 4, 6, 5);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.agrb = new vec4(7, 5, 4, 6);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.agbr = new vec4(7, 5, 6, 4);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.abgr = new vec4(7, 6, 5, 4);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.abrg = new vec4(7, 6, 4, 5);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);



            a.brga = new vec4(6, 4, 5, 7);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.brag = new vec4(6, 4, 7, 5);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.barg = new vec4(6, 7, 4, 5);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.bagr = new vec4(6, 7, 5, 4);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.bgar = new vec4(6, 5, 7, 4);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.bgra = new vec4(6, 5, 4, 7);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);


            a.gbra = new vec4(5, 6, 4, 7);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.grab = new vec4(5, 4, 7, 6);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.gbra = new vec4(5, 6, 4, 7);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.gbar = new vec4(5, 6, 7, 4);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.gabr = new vec4(5, 7, 6, 4);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.garb = new vec4(5, 7, 4, 6);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);

            a.grba = new vec4(5, 4, 6, 7);
            Assert.Equal(4, a.r);
            Assert.Equal(5, a.g);
            Assert.Equal(6, a.b);
            Assert.Equal(7, a.a);
        }

        [Fact]
        public void swizzles()
        {
            vec4 a = new vec4(1, 2, 3, 4);

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


            Assert.Equal(3, a.zxyw.x);
            Assert.Equal(1, a.zxyw.y);
            Assert.Equal(2, a.zxyw.z);
            Assert.Equal(4, a.zxyw.w);

            Assert.Equal(3, a.zxwy.x);
            Assert.Equal(1, a.zxwy.y);
            Assert.Equal(4, a.zxwy.z);
            Assert.Equal(2, a.zxwy.w);

            Assert.Equal(3, a.zyxw.x);
            Assert.Equal(2, a.zyxw.y);
            Assert.Equal(1, a.zyxw.z);
            Assert.Equal(4, a.zyxw.w);

            Assert.Equal(3, a.zywx.x);
            Assert.Equal(2, a.zywx.y);
            Assert.Equal(4, a.zywx.z);
            Assert.Equal(1, a.zywx.w);

            Assert.Equal(3, a.zwxy.x);
            Assert.Equal(4, a.zwxy.y);
            Assert.Equal(1, a.zwxy.z);
            Assert.Equal(2, a.zwxy.w);

            Assert.Equal(3, a.zwyx.x);
            Assert.Equal(4, a.zwyx.y);
            Assert.Equal(2, a.zwyx.z);
            Assert.Equal(1, a.zwyx.w);


            Assert.Equal(4, a.wxyz.x);
            Assert.Equal(1, a.wxyz.y);
            Assert.Equal(2, a.wxyz.z);
            Assert.Equal(3, a.wxyz.w);

            Assert.Equal(4, a.wxzy.x);
            Assert.Equal(1, a.wxzy.y);
            Assert.Equal(3, a.wxzy.z);
            Assert.Equal(2, a.wxzy.w);

            Assert.Equal(4, a.wyxz.x);
            Assert.Equal(2, a.wyxz.y);
            Assert.Equal(1, a.wyxz.z);
            Assert.Equal(3, a.wyxz.w);

            Assert.Equal(4, a.wyzx.x);
            Assert.Equal(2, a.wyzx.y);
            Assert.Equal(3, a.wyzx.z);
            Assert.Equal(1, a.wyzx.w);

            Assert.Equal(4, a.wzxy.x);
            Assert.Equal(3, a.wzxy.y);
            Assert.Equal(1, a.wzxy.z);
            Assert.Equal(2, a.wzxy.w);

            Assert.Equal(4, a.wzyx.x);
            Assert.Equal(3, a.wzyx.y);
            Assert.Equal(2, a.wzyx.z);
            Assert.Equal(1, a.wzyx.w);
        }
        [Fact]
        public void colourSwizzles()
        {
            vec4 a = new vec4(1, 2, 3, 4);

            Assert.Equal(1, a.rgba.r);
            Assert.Equal(2, a.rgba.g);
            Assert.Equal(3, a.rgba.b);
            Assert.Equal(4, a.rgba.a);

            Assert.Equal(1, a.rgab.r);
            Assert.Equal(2, a.rgab.g);
            Assert.Equal(4, a.rgab.b);
            Assert.Equal(3, a.rgab.a);

            Assert.Equal(1, a.rbag.r);
            Assert.Equal(3, a.rbag.g);
            Assert.Equal(4, a.rbag.b);
            Assert.Equal(2, a.rbag.a);

            Assert.Equal(1, a.rbga.r);
            Assert.Equal(3, a.rbga.g);
            Assert.Equal(2, a.rbga.b);
            Assert.Equal(4, a.rbga.a);

            Assert.Equal(1, a.ragb.r);
            Assert.Equal(4, a.ragb.g);
            Assert.Equal(2, a.ragb.b);
            Assert.Equal(3, a.ragb.a);

            Assert.Equal(1, a.rabg.r);
            Assert.Equal(4, a.rabg.g);
            Assert.Equal(3, a.rabg.b);
            Assert.Equal(2, a.rabg.a);


            Assert.Equal(2, a.grba.r);
            Assert.Equal(1, a.grba.g);
            Assert.Equal(3, a.grba.b);
            Assert.Equal(4, a.grba.a);

            Assert.Equal(2, a.grab.r);
            Assert.Equal(1, a.grab.g);
            Assert.Equal(4, a.grab.b);
            Assert.Equal(3, a.grab.a);

            Assert.Equal(2, a.garb.r);
            Assert.Equal(4, a.garb.g);
            Assert.Equal(1, a.garb.b);
            Assert.Equal(3, a.garb.a);

            Assert.Equal(2, a.gabr.r);
            Assert.Equal(4, a.gabr.g);
            Assert.Equal(3, a.gabr.b);
            Assert.Equal(1, a.gabr.a);

            Assert.Equal(2, a.gbra.r);
            Assert.Equal(3, a.gbra.g);
            Assert.Equal(1, a.gbra.b);
            Assert.Equal(4, a.gbra.a);

            Assert.Equal(2, a.gbar.r);
            Assert.Equal(3, a.gbar.g);
            Assert.Equal(4, a.gbar.b);
            Assert.Equal(1, a.gbar.a);


            Assert.Equal(3, a.brga.r);
            Assert.Equal(1, a.brga.g);
            Assert.Equal(2, a.brga.b);
            Assert.Equal(4, a.brga.a);

            Assert.Equal(3, a.brag.r);
            Assert.Equal(1, a.brag.g);
            Assert.Equal(4, a.brag.b);
            Assert.Equal(2, a.brag.a);

            Assert.Equal(3, a.bgra.r);
            Assert.Equal(2, a.bgra.g);
            Assert.Equal(1, a.bgra.b);
            Assert.Equal(4, a.bgra.a);

            Assert.Equal(3, a.bgar.r);
            Assert.Equal(2, a.bgar.g);
            Assert.Equal(4, a.bgar.b);
            Assert.Equal(1, a.bgar.a);

            Assert.Equal(3, a.barg.r);
            Assert.Equal(4, a.barg.g);
            Assert.Equal(1, a.barg.b);
            Assert.Equal(2, a.barg.a);

            Assert.Equal(3, a.bagr.r);
            Assert.Equal(4, a.bagr.g);
            Assert.Equal(2, a.bagr.b);
            Assert.Equal(1, a.bagr.a);


            Assert.Equal(4, a.argb.r);
            Assert.Equal(1, a.argb.g);
            Assert.Equal(2, a.argb.b);
            Assert.Equal(3, a.argb.a);

            Assert.Equal(4, a.arbg.r);
            Assert.Equal(1, a.arbg.g);
            Assert.Equal(3, a.arbg.b);
            Assert.Equal(2, a.arbg.a);

            Assert.Equal(4, a.agrb.r);
            Assert.Equal(2, a.agrb.g);
            Assert.Equal(1, a.agrb.b);
            Assert.Equal(3, a.agrb.a);

            Assert.Equal(4, a.agbr.r);
            Assert.Equal(2, a.agbr.g);
            Assert.Equal(3, a.agbr.b);
            Assert.Equal(1, a.agbr.a);

            Assert.Equal(4, a.abrg.r);
            Assert.Equal(3, a.abrg.g);
            Assert.Equal(1, a.abrg.b);
            Assert.Equal(2, a.abrg.a);

            Assert.Equal(4, a.abgr.r);
            Assert.Equal(3, a.abgr.g);
            Assert.Equal(2, a.abgr.b);
            Assert.Equal(1, a.abgr.a);
        }
    }
}