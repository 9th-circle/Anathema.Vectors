using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Anathema.Vectors.Core;

namespace Anathema.Vectors.Tests
{

    public class fvec2Tests
    {
        [Fact]
        public void construct()
        {
            fvec2 defaultConstructed = new fvec2();
            Assert.Equal(0, defaultConstructed.x);
            Assert.Equal(0, defaultConstructed.y);

            fvec2 specifiedComponents = new fvec2(1, 2);
            Assert.Equal(1, specifiedComponents.x);
            Assert.Equal(2, specifiedComponents.y);

            fvec2 fromFVec2 = new fvec2(specifiedComponents);
            Assert.Equal(1, fromFVec2.x);
            Assert.Equal(2, fromFVec2.y);

            dvec2 source = new dvec2(8, 5);
            fvec2 fromDVec2 = new fvec2(source);
            Assert.Equal(8, fromDVec2.x);
            Assert.Equal(5, fromDVec2.y);
        }
        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void vec2addition(float x1, float y1, float x2, float y2)
        {
            fvec2 a = new fvec2(x1, y1);
            fvec2 b = new fvec2(x2, y2);

            fvec2 c = a + b;
            fvec2 d = b + a;

            Assert.Equal(x1 + x2, c.x);
            Assert.Equal(x1 + x2, d.x);
            Assert.Equal(y1 + y2, c.y);
            Assert.Equal(y1 + y2, d.y);
        }
        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2 })]
        public void scalarAddition(float x, float y, float scalar)
        {
            fvec2 a = new fvec2(x, y);

            fvec2 c = a + scalar;
            fvec2 d = scalar + a;

            Assert.Equal(x + scalar, c.x);
            Assert.Equal(x + scalar, d.x);
            Assert.Equal(y + scalar, c.y);
            Assert.Equal(y + scalar, d.y);
        }
    }
}
