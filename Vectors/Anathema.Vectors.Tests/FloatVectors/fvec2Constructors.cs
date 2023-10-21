#pragma warning disable CS1718 // Comparison made to same variable
using System;
using Xunit;
using Anathema.Vectors.Core;

namespace Anathema.Vectors.Tests.FloatVectors
{
    public class fvec2Constructors
    {
        //todo: replace InlineData with MemberData

        [Theory]
        [InlineData(new object[] { 1, 2 })]
        [InlineData(new object[] { 300000000, 2 })]
        [InlineData(new object[] { -1, 2.2342 })]
        public void indices(float x, float y)
        {
            fvec2 a = new fvec2(x, y);
            Assert.Equal(a[0], x);
            Assert.Equal(a[1], y);
            Assert.Equal(a.ToArray()[0], a[0]);
            Assert.Equal(a.ToArray()[1], a[1]);
        }

        [Fact]
        public void construct()
        {
            fvec2 defaultConstructed = new fvec2();
            Assert.Equal(0, defaultConstructed.x);
            Assert.Equal(0, defaultConstructed.y);

            fvec2 specifiedComponents = new fvec2(1, 2);
            Assert.Equal(1, specifiedComponents.x);
            Assert.Equal(2, specifiedComponents.y);

            fvec2 fromArray = new fvec2(new float[] { 1, 2 });
            Assert.Equal(1, fromArray.x);
            Assert.Equal(2, fromArray.y);

            fvec2 fromFVec2 = new fvec2(specifiedComponents);
            Assert.Equal(1, fromFVec2.x);
            Assert.Equal(2, fromFVec2.y);

            dvec2 source = new dvec2(8, 5);
            fvec2 fromDVec2 = new fvec2(source);
            Assert.Equal(8, fromDVec2.x);
            Assert.Equal(5, fromDVec2.y);
        }


        [Fact]
        public void equality()
        {
            float a = 1.0f;
            float b = a / 3.0f;
            float c = b * 3.0f;
            float d = 0.999999999999f;

            fvec2 x = new fvec2(a, c);
            fvec2 y = new fvec2(c, a);
            fvec2 z = new fvec2(d, d);
            fvec2 w = new fvec2(1.1f, a);

            Assert.False(x == null);
            Assert.False(null == x);
            Assert.True(x != null);
            Assert.True(null != x);

            Assert.True(x == y);
            Assert.True(y == z);
            Assert.True(z == x);
            Assert.False(w == x);
            Assert.False(w == y);
            Assert.False(w == z);
            Assert.True(w == w);

            Assert.False(x != y);
            Assert.False(y != z);
            Assert.False(z != x);

            Assert.True(w != x);
            Assert.True(w != y);
            Assert.True(w != z);
            Assert.False(w != w);
        }

    }
}
