using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Anathema.Vectors.Core;

namespace Anathema.Vectors.Tests.DoubleVectors
{
    public class dvec3Constructors
    {
        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 300000000, 2, 1.5 })]
        [InlineData(new object[] { -1, 2.2342, 0.00001f })]
        public void indices(double x, double y, double z)
        {
            dvec3 a = new dvec3(x, y, z);
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
            dvec3 defaultConstructed = new dvec3();
            Assert.Equal(0, defaultConstructed.x);
            Assert.Equal(0, defaultConstructed.y);
            Assert.Equal(0, defaultConstructed.z);

            dvec3 specifiedComponents = new dvec3(1, 2, 3);
            Assert.Equal(1, specifiedComponents.x);
            Assert.Equal(2, specifiedComponents.y);
            Assert.Equal(3, specifiedComponents.z);

            dvec3 fromArray = new dvec3(new double[] { 1, 2, 3 });
            Assert.Equal(1, fromArray.x);
            Assert.Equal(2, fromArray.y);
            Assert.Equal(3, fromArray.z);

            dvec3 fromdvec3 = new dvec3(specifiedComponents);
            Assert.Equal(1, fromdvec3.x);
            Assert.Equal(2, fromdvec3.y);
            Assert.Equal(3, fromdvec3.z);

            dvec3 source = new dvec3(8, 5, -1);
            dvec3 fromDVec3 = new dvec3(source);
            Assert.Equal(8, fromDVec3.x);
            Assert.Equal(5, fromDVec3.y);
            Assert.Equal(-1, fromDVec3.z);

            dvec3 vec2AndScalar = new dvec3(new dvec2(1, 2), 3);
            Assert.Equal(1, vec2AndScalar.x);
            Assert.Equal(2, vec2AndScalar.y);
            Assert.Equal(3, vec2AndScalar.z);

            dvec3 scalarAndVec2 = new dvec3(1, new dvec2(2, 3));
            Assert.Equal(1, scalarAndVec2.x);
            Assert.Equal(2, scalarAndVec2.y);
            Assert.Equal(3, scalarAndVec2.z);
        }

    }
}
