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
        [InlineData(1, 2)]
        [InlineData(300000000, 2)]
        [InlineData(-1, 2.2342)]
        public void indices(float x, float y)
        {
            vec2 a = new vec2(x, y);
            Assert.Equal(a[0], x);
            Assert.Equal(a[1], y);
            Assert.Equal(a.ToArray()[0], a[0]);
            Assert.Equal(a.ToArray()[1], a[1]);
            Assert.Throws<IndexOutOfRangeException>(delegate { a[4] = 1; });
            Assert.Throws<IndexOutOfRangeException>(delegate { float z = a[4]; });
        }

        [Fact]
        public void construct()
        {
            vec2 defaultConstructed = new vec2();
            Assert.Equal(0, defaultConstructed.x);
            Assert.Equal(0, defaultConstructed.y);

            vec2 specifiedComponents = new vec2(1, 2);
            Assert.Equal(1, specifiedComponents.x);
            Assert.Equal(2, specifiedComponents.y);

            vec2 fromArray = new vec2(new float[] { 1, 2 });
            Assert.Equal(1, fromArray.x);
            Assert.Equal(2, fromArray.y);

            vec2 fromFVec2 = new vec2(specifiedComponents);
            Assert.Equal(1, fromFVec2.x);
            Assert.Equal(2, fromFVec2.y);

            dvec2 source = new dvec2(8, 5);
            vec2 fromDVec2 = new vec2(source);
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

            vec2 x = new vec2(a, c);
            vec2 y = new vec2(c, a);
            vec2 z = new vec2(d, d);
            vec2 w = new vec2(1.1f, a);
            vec2 nullvec = null;

            Assert.True(x.Equals(y));
            Assert.False(x.Equals(nullvec));
            Assert.False(x.Equals("String"));
            Assert.True(nullvec == null);
            Assert.True(null == nullvec);
            Assert.False(nullvec == x);
            Assert.False(x == nullvec);
            Assert.False(nullvec != null);
            Assert.False(null != nullvec);
            Assert.True(nullvec != x);
            Assert.True(x != nullvec);

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
