using System;
using Xunit;
using Anathema.Vectors.Core;
#pragma warning disable CS1718 // Comparison made to same variable
namespace Anathema.Vectors.Tests.FloatVectors
{
    public class dvec4Constructors
    {
        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 300000000, 2, 1.5, 22.22f })]
        [InlineData(new object[] { -1, 2.2342, 0.00001f, 13.0f })]
        public void indices(double x, double y, double z, double w)
        {
            dvec4 a = new dvec4(x, y, z, w);
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
            Assert.Throws<IndexOutOfRangeException>(delegate () { double f = a[-1]; });
        }

        [Fact]
        public void construct()
        {
            dvec4 defaultConstructed = new dvec4();
            Assert.Equal(0, defaultConstructed.x);
            Assert.Equal(0, defaultConstructed.y);
            Assert.Equal(0, defaultConstructed.z);
            Assert.Equal(0, defaultConstructed.w);

            dvec4 specifiedComponents = new dvec4(1, 2, 3, 4);
            Assert.Equal(1, specifiedComponents.x);
            Assert.Equal(2, specifiedComponents.y);
            Assert.Equal(3, specifiedComponents.z);
            Assert.Equal(4, specifiedComponents.w);

            dvec4 fromArray = new dvec4(new double[] { 1, 2, 3, 4 });
            Assert.Equal(1, fromArray.x);
            Assert.Equal(2, fromArray.y);
            Assert.Equal(3, fromArray.z);
            Assert.Equal(4, fromArray.w);

            dvec4 fromVec3 = new dvec4(specifiedComponents);
            Assert.Equal(1, fromVec3.x);
            Assert.Equal(2, fromVec3.y);
            Assert.Equal(3, fromVec3.z);
            Assert.Equal(4, fromVec3.w);

            dvec4 dvec2AndScalar = new dvec4(new dvec2(1, 2), 3, 4);
            Assert.Equal(1, dvec2AndScalar.x);
            Assert.Equal(2, dvec2AndScalar.y);
            Assert.Equal(3, dvec2AndScalar.z);
            Assert.Equal(4, dvec2AndScalar.w);

            dvec4 scalarAndVec2 = new dvec4(1, new dvec2(2, 3), 4);
            Assert.Equal(1, scalarAndVec2.x);
            Assert.Equal(2, scalarAndVec2.y);
            Assert.Equal(3, scalarAndVec2.z);
            Assert.Equal(4, scalarAndVec2.w);

            dvec4 scalar2AndVec2 = new dvec4(1, 2, new dvec2(3, 4));
            Assert.Equal(1, scalar2AndVec2.x);
            Assert.Equal(2, scalar2AndVec2.y);
            Assert.Equal(3, scalar2AndVec2.z);
            Assert.Equal(4, scalar2AndVec2.w);

            dvec4 dvec3AndScalar = new dvec4(new dvec3(1, 2, 3), 4);
            Assert.Equal(1, dvec3AndScalar.x);
            Assert.Equal(2, dvec3AndScalar.y);
            Assert.Equal(3, dvec3AndScalar.z);
            Assert.Equal(4, dvec3AndScalar.w);

            dvec4 scalarAndVec3 = new dvec4(1, new dvec3(2, 3, 4));
            Assert.Equal(1, scalarAndVec3.x);
            Assert.Equal(2, scalarAndVec3.y);
            Assert.Equal(3, scalarAndVec3.z);
            Assert.Equal(4, scalarAndVec3.w);
        }

        [Fact]
        public void capitals()
        {
            dvec4 a = new dvec4(1, 2, 3, 4);

            Assert.Equal(a.x, a.X);
            Assert.Equal(a.y, a.Y);
            Assert.Equal(a.z, a.Z);
            Assert.Equal(a.w, a.W);
        }
        
        [Fact]
        public void equality()
        {
            dvec4 a = new dvec4(1, 2, 3, 4);
            dvec4 b = new dvec4((1 / 3.0f) * 3.0f, 2, 3, 4);
            dvec4 c = new dvec4(5, 2, 3, 1);
            dvec4 nulldvec = null;

            Assert.True(nulldvec == null);
            Assert.True(null == nulldvec);
            Assert.False(nulldvec == a);
            Assert.False(a == nulldvec);
            Assert.False(nulldvec != null);
            Assert.False(null != nulldvec);
            Assert.True(nulldvec != a);
            Assert.True(a != nulldvec);

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
