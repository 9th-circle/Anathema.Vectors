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

            a.xyzw = new tvec4<int>(4, 5, 6, 7);
            Assert.Equal(4, a.x);
            Assert.Equal(5, a.y);
            Assert.Equal(6, a.z);
            Assert.Equal(7, a.w);

        }

        [Fact]
        public void colourSwizzleWrites()
        {
            tvec4<int> a = new tvec4<int>(1, 2, 3, 4);

            a.w = 5;
            Assert.Equal(5, a.w);

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
        }

        [Fact]
        public void swizzles()
        {
            tvec4<int> a = new tvec4<int>(1, 2, 3, 4);

            Assert.Equal(1, a.xyzw.x);
            Assert.Equal(2, a.xyzw.y);
            Assert.Equal(3, a.xyzw.z);
            Assert.Equal(3, a.xyzw.w);
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