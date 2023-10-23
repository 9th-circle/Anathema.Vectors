using System;
using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.TemplateVectors
{
    public class tvec2Conversions
    {
        [Fact]
        public void toVec2()
        {
            tvec2<float> vec = new tvec2<float>(1, 2);
            vec2 fvec = vec.floatTVec2ToVec2();
            Assert.Equal(1, fvec.x);
            Assert.Equal(2, fvec.y);
        }
        [Fact]
        public void toDVec2()
        {
            tvec2<double> vec = new tvec2<double>(1, 2);
            dvec2 dvec = vec.doubleTVec2ToDVec2();
            Assert.Equal(1, dvec.x);
            Assert.Equal(2, dvec.y);
        }
        [Fact]
        public void toVec2InvalidType()
        {
            tvec2<string> vec = new tvec2<string>("a", "b");
            Assert.Throws<ArgumentException>(delegate { vec2 fvec = vec.floatTVec2ToVec2(); });
        }
        [Fact]
        public void toDVec2InvalidType()
        {
            tvec2<float> vec = new tvec2<float>(1, 2);
            Assert.Throws<ArgumentException>(delegate { dvec2 dvec = vec.doubleTVec2ToDVec2(); });
        }
    }
}
