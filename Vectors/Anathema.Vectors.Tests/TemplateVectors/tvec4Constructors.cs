using System;
using Xunit;
using Anathema.Vectors.Core;
#pragma warning disable CS1718 // Comparison made to same variable
namespace Anathema.Vectors.Tests.FloatVectors
{
    public class tvec4Constructors
    {
        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 300000000, 2, 1.5, 22.22f })]
        [InlineData(new object[] { -1, 2.2342, 0.00001f, 13.0f })]
        public void indices(float x, float y, float z, float w)
        {
            tvec4<float> a = new tvec4<float>(x, y, z, w);
            Assert.Equal(a[0], x);
            Assert.Equal(a[1], y);
            Assert.Equal(a[2], z);
            Assert.Equal(a[3], w);
            Assert.Equal(a.ToArray()[0], a[0]);
            Assert.Equal(a.ToArray()[1], a[1]);
            Assert.Equal(a.ToArray()[2], a[2]);
            Assert.Equal(a.ToArray()[3], a[3]);
            a[0] = 1;
            a[1] = 2;
            a[2] = 3;
            a[3] = 4;
            Assert.Equal(1, a[0]);
            Assert.Equal(2, a[1]);
            Assert.Equal(3, a[2]);
            Assert.Equal(4, a[3]);

            Assert.Throws<IndexOutOfRangeException>(delegate () { a[59] = 4; });
            Assert.Throws<IndexOutOfRangeException>(delegate () { float f = a[-1]; });
        }

        [Fact]
        public void construct()
        {
            tvec4<float> defaultConstructed = new tvec4<float>();
            Assert.Equal(0, defaultConstructed.x);
            Assert.Equal(0, defaultConstructed.y);
            Assert.Equal(0, defaultConstructed.z);
            Assert.Equal(0, defaultConstructed.w);

            tvec4<float> specifiedComponents = new tvec4<float>(1, 2, 3, 4);
            Assert.Equal(1, specifiedComponents.x);
            Assert.Equal(2, specifiedComponents.y);
            Assert.Equal(3, specifiedComponents.z);
            Assert.Equal(4, specifiedComponents.w);

            tvec4<float> fromArray = new tvec4<float>(new float[] { 1, 2, 3, 4 });
            Assert.Equal(1, fromArray.x);
            Assert.Equal(2, fromArray.y);
            Assert.Equal(3, fromArray.z);
            Assert.Equal(4, fromArray.w);

            tvec4<float> fromVec3 = new tvec4<float>(specifiedComponents);
            Assert.Equal(1, fromVec3.x);
            Assert.Equal(2, fromVec3.y);
            Assert.Equal(3, fromVec3.z);
            Assert.Equal(4, fromVec3.w);

            tvec4<float> vec2AndScalar = new tvec4<float>(new tvec2<float>(1, 2), 3, 4);
            Assert.Equal(1, vec2AndScalar.x);
            Assert.Equal(2, vec2AndScalar.y);
            Assert.Equal(3, vec2AndScalar.z);
            Assert.Equal(4, vec2AndScalar.w);

            tvec4<float> scalarAndVec2 = new tvec4<float>(1, new tvec2<float>(2, 3), 4);
            Assert.Equal(1, scalarAndVec2.x);
            Assert.Equal(2, scalarAndVec2.y);
            Assert.Equal(3, scalarAndVec2.z);
            Assert.Equal(4, scalarAndVec2.w);

            tvec4<float> scalar2AndVec2 = new tvec4<float>(1, 2, new tvec2<float>(3, 4));
            Assert.Equal(1, scalar2AndVec2.x);
            Assert.Equal(2, scalar2AndVec2.y);
            Assert.Equal(3, scalar2AndVec2.z);
            Assert.Equal(4, scalar2AndVec2.w);

            tvec4<float> vec3AndScalar = new tvec4<float>(new tvec3<float>(1, 2, 3), 4);
            Assert.Equal(1, vec3AndScalar.x);
            Assert.Equal(2, vec3AndScalar.y);
            Assert.Equal(3, vec3AndScalar.z);
            Assert.Equal(4, vec3AndScalar.w);

            tvec4<float> scalarAndVec3 = new tvec4<float>(1, new tvec3<float>(2, 3, 4));
            Assert.Equal(1, scalarAndVec3.x);
            Assert.Equal(2, scalarAndVec3.y);
            Assert.Equal(3, scalarAndVec3.z);
            Assert.Equal(4, scalarAndVec3.w);
        }

        [Fact]
        public void convert()
        {
            tvec4<float> vec = new tvec4<float>(1, 2, 3, 4);
            vec4 fvec = vec.floatTVec4ToVec4();

            Assert.Equal(1, fvec[0]);
            Assert.Equal(2, fvec[1]);
            Assert.Equal(3, fvec[2]);
            Assert.Equal(4, fvec[3]);

            tvec4<double> dvec = new tvec4<double>(1, 2, 3, 4);
            dvec4 ddvec = dvec.doubleTVec4ToDVec4();

            Assert.Equal(1, ddvec[0]);
            Assert.Equal(2, ddvec[1]);
            Assert.Equal(3, ddvec[2]);

            Assert.Throws<ArgumentException>(delegate { var x = new tvec4<string>().doubleTVec4ToDVec4(); });
            Assert.Throws<ArgumentException>(delegate { var x = new tvec4<string>().floatTVec4ToVec4(); });
        }
        [Fact]
        public void capitals()
        {
            //todo: implement capitals
            tvec4<float> a = new tvec4<float>(1, 2, 3, 4);
            /*
            Assert.Equal(a.x, a.X);
            Assert.Equal(a.y, a.Y);
            Assert.Equal(a.z, a.Z);
            Assert.Equal(a.w, a.W);*/
        }
        
        [Fact]
        public void equality()
        {
            tvec4<float> a = new tvec4<float>(1, 2, 3, 4);
            tvec4<float> b = new tvec4<float>((1 / 3.0f) * 3.0f, 2, 3, 4);
            tvec4<float> c = new tvec4<float>(5, 2, 3, 1);
            tvec4<float> nullvec = null;

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
