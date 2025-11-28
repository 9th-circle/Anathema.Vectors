using Anathema.Vectors.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Anathema.Vectors.Tests.FloatVectors
{
    public class vec2SwizzleTests
    {


        [Theory]
        [InlineData(new object[] { 1, 2 })]
        [InlineData(new object[] { 5.2f, 10.00001f })]
        [InlineData(new object[] { -37, 0 })]
        public void swizzles(float x1, float y1)
        {
            vec2 a = new vec2(x1, y1);

            Assert.Equal(x1, a.X);
            Assert.Equal(y1, a.Y);

            Assert.Equal(a.xy.x, a.x);
            Assert.Equal(a.xy.y, a.y);

            Assert.Equal(a.yx.x, a.y);
            Assert.Equal(a.yx.y, a.x);
        }

        [Fact]
        public void swizzleAssign()
        {
            vec2 a = new vec2(1, 2);
            Assert.Equal(1, a.x);
            Assert.Equal(2, a.y);

            a.X = 3;
            a.Y = 4;
            Assert.Equal(3, a.x);
            Assert.Equal(4, a.y);

            a.xy = new vec2(3, 4);
            Assert.Equal(3, a.x);
            Assert.Equal(4, a.y);

            a.yx = new vec2(6, 5);
            Assert.Equal(5, a.x);
            Assert.Equal(6, a.y);

            vec2 b = new vec2(8, 7);
            a.yx = b;
            Assert.Equal(7, a.x);
            Assert.Equal(8, a.y);

        }


        [Fact]
        public void colourSwizzleAssign()
        {
            vec2 a = new vec2(-1, -2);

            a.r = 1;
            a.g = 2;
            Assert.Equal(1, a.x);
            Assert.Equal(2, a.y);

            a.R = 10;
            a.G = 20;
            Assert.Equal(10, a.x);
            Assert.Equal(20, a.y);
            Assert.Equal(10, a.R);
            Assert.Equal(20, a.G);

            a.rg = new vec2(3, 4);
            Assert.Equal(3, a.x);
            Assert.Equal(4, a.y);

            a.gr = new vec2(6, 5);
            Assert.Equal(5, a.x);
            Assert.Equal(6, a.y);

            vec2 b = new vec2(8, 7);
            a.gr = b;
            Assert.Equal(7, a.x);
            Assert.Equal(8, a.y);
        }




        [Theory]
        [InlineData(new object[] { 1, 2 })]
        [InlineData(new object[] { 5.2f, 10.00001f })]
        [InlineData(new object[] { -37, 0 })]
        public void colourSwizzles(float x1, float y1)
        {
            vec2 a = new vec2(x1, y1);

            Assert.Equal(a.rg.r, a.x);
            Assert.Equal(a.rg.g, a.y);

            Assert.Equal(a.gr.r, a.y);
            Assert.Equal(a.gr.g, a.x);
        }

        [Theory]
        [InlineData(new object[] { 1, 2 })]
        [InlineData(new object[] { 5.2f, 10.00001f })]
        [InlineData(new object[] { -37, 0 })]
        public void duplicateSwizzles_ALL(float x1, float y1)
        {
            vec2 a = new vec2(x1, y1);

            // Test ALL 2 coordinate duplicate swizzles
            Assert.Equal(a.xx.x, a.x);
            Assert.Equal(a.xx.y, a.x);
            Assert.Equal(a.yy.x, a.y);
            Assert.Equal(a.yy.y, a.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2 })]
        [InlineData(new object[] { 5.2f, 10.00001f })]
        [InlineData(new object[] { -37, 0 })]
        public void duplicateColourSwizzles_ALL(float x1, float y1)
        {
            vec2 a = new vec2(x1, y1);

            // Test ALL 2 color duplicate swizzles
            Assert.Equal(a.rr.r, a.r);
            Assert.Equal(a.rr.g, a.r);
            Assert.Equal(a.gg.r, a.g);
            Assert.Equal(a.gg.g, a.g);
        }

        [Fact]
        public void duplicateSwizzleAssign()
        {

            vec2 a = new vec2(1, 2);
            a.xx = new vec2(5, 6);
            Assert.Equal(6, a.x);
            Assert.Equal(2, a.y);

        }
    }
}