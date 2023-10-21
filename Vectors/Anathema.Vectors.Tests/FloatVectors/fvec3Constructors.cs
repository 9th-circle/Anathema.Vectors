using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Anathema.Vectors.Core;

namespace Anathema.Vectors.Tests.FloatVectors
{
    public class fvec3Constructors
    {
        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 300000000, 2, 1.5 })]
        [InlineData(new object[] { -1, 2.2342, 0.00001f })]
        public void indices(float x, float y, float z)
        {
            fvec3 a = new fvec3(x, y, z);
            Assert.Equal(a[0], x);
            Assert.Equal(a[1], y);
            Assert.Equal(a[1], y);
            Assert.Equal(a.ToArray()[0], a[0]);
            Assert.Equal(a.ToArray()[1], a[1]);
            Assert.Equal(a.ToArray()[2], a[2]);
        }

        [Fact]
        public void construct()
        {
            fvec3 defaultConstructed = new fvec3();
            Assert.Equal(0, defaultConstructed.x);
            Assert.Equal(0, defaultConstructed.y);
            Assert.Equal(0, defaultConstructed.z);

            fvec3 specifiedComponents = new fvec3(1, 2, 3);
            Assert.Equal(1, specifiedComponents.x);
            Assert.Equal(2, specifiedComponents.y);
            Assert.Equal(3, specifiedComponents.z);

            fvec3 fromArray = new fvec3(new float[] { 1, 2, 3 });
            Assert.Equal(1, fromArray.x);
            Assert.Equal(2, fromArray.y);
            Assert.Equal(3, fromArray.z);

            fvec3 fromFVec3 = new fvec3(specifiedComponents);
            Assert.Equal(1, fromFVec3.x);
            Assert.Equal(2, fromFVec3.y);
            Assert.Equal(3, fromFVec3.z);

            dvec3 source = new dvec3(8, 5, -1);
            fvec3 fromDVec3 = new fvec3(source);
            Assert.Equal(8, fromDVec3.x);
            Assert.Equal(5, fromDVec3.y);
            Assert.Equal(-1, fromDVec3.z);

            fvec3 vec2AndScalar = new fvec3(new fvec2(1,2), 3);
            Assert.Equal(1, vec2AndScalar.x);
            Assert.Equal(2, vec2AndScalar.y);
            Assert.Equal(3, vec2AndScalar.z);

            fvec3 scalarAndVec2 = new fvec3(1, new fvec2(2, 3));
            Assert.Equal(1, scalarAndVec2.x);
            Assert.Equal(2, scalarAndVec2.y);
            Assert.Equal(3, scalarAndVec2.z);
        }

        [Fact]
        public void equality()
        {
            fvec3 a = new fvec3(1, 2, 3);
            fvec3 b = new fvec3((1 / 3.0f) * 3.0f, 2, 3);
            fvec3 c = new fvec3(5, 2, 3);

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
