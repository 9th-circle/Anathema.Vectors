using System;
using Xunit;
using Anathema.Vectors.Core;
#pragma warning disable CS1718 // Comparison made to same variable
namespace Anathema.Vectors.Tests.FloatVectors
{
    public class vec4Constructors
    {
        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 300000000, 2, 1.5, 22.22f })]
        [InlineData(new object[] { -1, 2.2342, 0.00001f, 13.0f })]
        public void indices(float x, float y, float z, float w)
        {
            vec4 a = new vec4(x, y, z, w);
            Assert.Equal(a[0], x);
            Assert.Equal(a[1], y);
            Assert.Equal(a[2], z);
            Assert.Equal(a.ToArray()[0], a[0]);
            Assert.Equal(a.ToArray()[1], a[1]);
            Assert.Equal(a.ToArray()[2], a[2]);
            a[0] = 1;
            a[1] = 2;
            a[2] = 3;
            Assert.Equal(1, a[0]);
            Assert.Equal(2, a[1]);
            Assert.Equal(3, a[2]);

            Assert.Throws<IndexOutOfRangeException>(delegate () { a[59] = 4; });
            Assert.Throws<IndexOutOfRangeException>(delegate () { float f = a[-1]; });
        }

        [Fact]
        public void construct()
        {
            vec4 defaultConstructed = new vec4();
            Assert.Equal(0, defaultConstructed.x);
            Assert.Equal(0, defaultConstructed.y);
            Assert.Equal(0, defaultConstructed.z);
            Assert.Equal(0, defaultConstructed.w);

            vec4 specifiedComponents = new vec4(1, 2, 3, 4);
            Assert.Equal(1, specifiedComponents.x);
            Assert.Equal(2, specifiedComponents.y);
            Assert.Equal(3, specifiedComponents.z);
            Assert.Equal(4, specifiedComponents.w);

            vec4 fromArray = new vec4(new float[] { 1, 2, 3, 4 });
            Assert.Equal(1, fromArray.x);
            Assert.Equal(2, fromArray.y);
            Assert.Equal(3, fromArray.z);
            Assert.Equal(4, fromArray.w);

            vec4 fromVec3 = new vec4(specifiedComponents);
            Assert.Equal(1, fromVec3.x);
            Assert.Equal(2, fromVec3.y);
            Assert.Equal(3, fromVec3.z);
            Assert.Equal(4, fromVec3.w);

            dvec4 source = new dvec4(8, 5, -1, 1);
            vec4 fromDVec3 = new vec4(source);
            Assert.Equal(8, fromDVec3.x);
            Assert.Equal(5, fromDVec3.y);
            Assert.Equal(-1, fromDVec3.z);
            Assert.Equal(1, fromDVec3.w);

            vec4 vec2AndScalar = new vec4(new vec2(1, 2), 3, 4);
            Assert.Equal(1, vec2AndScalar.x);
            Assert.Equal(2, vec2AndScalar.y);
            Assert.Equal(3, vec2AndScalar.z);
            Assert.Equal(4, vec2AndScalar.w);

            vec4 scalarAndVec2 = new vec4(1, new vec2(2, 3), 4);
            Assert.Equal(1, scalarAndVec2.x);
            Assert.Equal(2, scalarAndVec2.y);
            Assert.Equal(3, scalarAndVec2.z);
            Assert.Equal(4, scalarAndVec2.w);

            vec4 scalar2AndVec2 = new vec4(1, 2, new vec2(3, 4));
            Assert.Equal(1, scalar2AndVec2.x);
            Assert.Equal(2, scalar2AndVec2.y);
            Assert.Equal(3, scalar2AndVec2.z);
            Assert.Equal(4, scalar2AndVec2.w);

            vec4 twoVec2s = new vec4(new vec2(1,2), new vec2(3, 4));
            Assert.Equal(1, twoVec2s.x);
            Assert.Equal(2, twoVec2s.y);
            Assert.Equal(3, twoVec2s.z);
            Assert.Equal(4, twoVec2s.w);

            vec4 vec3AndScalar = new vec4(new vec3(1, 2, 3), 4);
            Assert.Equal(1, vec3AndScalar.x);
            Assert.Equal(2, vec3AndScalar.y);
            Assert.Equal(3, vec3AndScalar.z);
            Assert.Equal(4, vec3AndScalar.w);

            vec4 scalarAndVec3 = new vec4(1, new vec3(2, 3, 4));
            Assert.Equal(1, scalarAndVec3.x);
            Assert.Equal(2, scalarAndVec3.y);
            Assert.Equal(3, scalarAndVec3.z);
            Assert.Equal(4, scalarAndVec3.w);
        }

        [Fact]
        public void capitals()
        {
            vec4 a = new vec4(1, 2, 3, 4);

            Assert.Equal(a.x, a.X);
            Assert.Equal(a.y, a.Y);
            Assert.Equal(a.z, a.Z);
            Assert.Equal(a.w, a.W);
        }
        
        [Fact]
        public void equality()
        {
            vec4 a = new vec4(1, 2, 3, 4);
            vec4 b = new vec4((1 / 3.0f) * 3.0f, 2, 3, 4);
            vec4 c = new vec4(5, 2, 3, 1);
            vec4 nullvec = null;

            Assert.True(nullvec == null);
            Assert.True(null == nullvec);
            Assert.False(nullvec == a);
            Assert.False(a == nullvec);
            Assert.False(nullvec != null);
            Assert.False(null != nullvec);
            Assert.True(nullvec != a);
            Assert.True(a != nullvec);

            Assert.True(a.Equals(b));
            Assert.False(a.Equals(c));
            Assert.False(a.Equals("text"));

            Assert.False(a != a);
            Assert.False(b != b);
            Assert.False(c != c);

            Assert.True(a == a);
            Assert.True(b == b);
            Assert.True(c == c);

            Assert.True(a == b);
            Assert.True(b == a);

            Assert.True(a != c);
            Assert.True(c != a);

            Assert.True(b != c);
            Assert.True(c != b);

            Assert.False(a == c);
            Assert.False(c == a);

            Assert.False(b == c);
            Assert.False(c == b);
        }
        
    }
}
