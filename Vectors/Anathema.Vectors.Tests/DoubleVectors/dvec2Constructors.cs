#pragma warning disable CS1718 // Comparison made to same variable
using System;
using Xunit;
using Anathema.Vectors.Core;

namespace Anathema.Vectors.Tests.DoubleVectors
{
    public class dvec2Constructors
    {
        //todo: include some cross tests for fvec2 conversions
        //todo: replace InlineData with MemberData


        [Theory]
        [InlineData(new object[] { 1, 2 })]
        [InlineData(new object[] { 300000000, 2 })]
        [InlineData(new object[] { -1, 2.2342 })]
        public void indices(double x, double y)
        {
            dvec2 a = new dvec2(x, y);
            Assert.Equal(a[0], x);
            Assert.Equal(a[1], y);
            Assert.Equal(a.ToArray()[0], a[0]);
            Assert.Equal(a.ToArray()[1], a[1]);

            a[0] = 2;
            a[1] = 2;
            Assert.Throws<IndexOutOfRangeException>(delegate { a[5] = 1; });
            Assert.Throws<IndexOutOfRangeException>(delegate { double d = a[4]; });
        }


        [Fact]
        public void construct()
        {
            dvec2 defaultConstructed = new dvec2();
            Assert.Equal(0, defaultConstructed.x);
            Assert.Equal(0, defaultConstructed.y);

            dvec2 specifiedComponents = new dvec2(1, 2);
            Assert.Equal(1, specifiedComponents.x);
            Assert.Equal(2, specifiedComponents.y);

            dvec2 fromdvec2 = new dvec2(specifiedComponents);
            Assert.Equal(1, fromdvec2.x);
            Assert.Equal(2, fromdvec2.y);

            dvec2 source = new dvec2(8, 5);
            dvec2 fromDVec2 = new dvec2(source);
            Assert.Equal(8, fromDVec2.x);
            Assert.Equal(5, fromDVec2.y);
        }

    }
}
