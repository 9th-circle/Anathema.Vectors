using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.DoubleVectors
{
    public class dvec2SwizzleTests
    {
        [Fact]
        public void swizzleAssign()
        {
            dvec2 a = new dvec2(1, 2);
            Assert.Equal(1, a.x);
            Assert.Equal(2, a.y);

            a.X = 3;
            a.Y = 4;
            Assert.Equal(3, a.x);
            Assert.Equal(4, a.y);

            a.xy = new dvec2(3, 4);
            Assert.Equal(3, a.x);
            Assert.Equal(4, a.y);

            a.yx = new dvec2(6, 5);
            Assert.Equal(5, a.x);
            Assert.Equal(6, a.y);

            dvec2 b = new dvec2(8, 7);
            a.yx = b;
            Assert.Equal(7, a.x);
            Assert.Equal(8, a.y);

        }


        [Fact]
        public void colourSwizzleAssign()
        {
            dvec2 a = new dvec2(1, 2);
            Assert.Equal(1, a.x);
            Assert.Equal(2, a.y);

            a.R = 3;
            a.G = 4;
            Assert.Equal(3, a.r);
            Assert.Equal(4, a.g);

            a.r = 0;
            a.g = -1;
            Assert.Equal(0, a.R);
            Assert.Equal(-1, a.G);

            a.rg = new dvec2(3, 4);
            Assert.Equal(3, a.x);
            Assert.Equal(4, a.y);

            a.gr = new dvec2(6, 5);
            Assert.Equal(5, a.x);
            Assert.Equal(6, a.y);

            dvec2 b = new dvec2(8, 7);
            a.gr = b;
            Assert.Equal(7, a.x);
            Assert.Equal(8, a.y);
        }


        [Theory]
        [InlineData(new object[] { 1, 2 })]
        [InlineData(new object[] { 5.2f, 10.00001f })]
        [InlineData(new object[] { -37, 0 })]
        public void swizzles(double x1, double y1)
        {
            dvec2 a = new dvec2(x1, y1);

            Assert.Equal(x1, a.X);
            Assert.Equal(y1, a.Y);

            Assert.Equal(a.xy.x, a.x);
            Assert.Equal(a.xy.y, a.y);

            Assert.Equal(a.yx.x, a.y);
            Assert.Equal(a.yx.y, a.x);
        }





        [Theory]
        [InlineData(new object[] { 1, 2 })]
        [InlineData(new object[] { 5.2f, 10.00001f })]
        [InlineData(new object[] { -37, 0 })]
        public void colourSwizzles(double x1, double y1)
        {
            dvec2 a = new dvec2(x1, y1);

            Assert.Equal(a.rg.r, a.x);
            Assert.Equal(a.rg.g, a.y);

            Assert.Equal(a.gr.r, a.y);
            Assert.Equal(a.gr.g, a.x);
        } 
    
        [Theory]
        [InlineData(new object[] { 1, 2 })]
        [InlineData(new object[] { 5.2, 10.00001 })]
        [InlineData(new object[] { -37, 0 })]
        public void duplicateSwizzles_ALL(double x1, double y1)
        {
            dvec2 a = new dvec2(x1, y1);

            // Test ALL 2 coordinate duplicate swizzles
            Assert.Equal(a.xx.x, a.x);
            Assert.Equal(a.xx.y, a.x);
            Assert.Equal(a.yy.x, a.y);
            Assert.Equal(a.yy.y, a.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2 })]
        [InlineData(new object[] { 5.2, 10.00001 })]
        [InlineData(new object[] { -37, 0 })]
        public void duplicateColourSwizzles_ALL(double x1, double y1)
        {
            dvec2 a = new dvec2(x1, y1);

            // Test ALL 2 color duplicate swizzles
            Assert.Equal(a.rr.r, a.r);
            Assert.Equal(a.rr.g, a.r);
            Assert.Equal(a.gg.r, a.g);
            Assert.Equal(a.gg.g, a.g);
        }

        [Fact]
        public void duplicateSwizzleAssign()
        {

            dvec2 a = new dvec2(1, 2);
            a.xx = new dvec2(5, 6);
            Assert.Equal(6, a.x);
            Assert.Equal(2, a.y);

        }
    }
}