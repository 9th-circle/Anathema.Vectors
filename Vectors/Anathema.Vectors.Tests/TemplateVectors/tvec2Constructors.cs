using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.TemplateVectors
{
    public class tvec2Constructors
    {
        [Fact]
        public void floatConstruct()
        {
            tvec2<float> defaultConstructed = new tvec2<float>();
            Assert.Equal(0, defaultConstructed.x);
            Assert.Equal(0, defaultConstructed.y);

            tvec2<float> specifiedComponents = new tvec2<float>(1, 2);
            Assert.Equal(1, specifiedComponents.x);
            Assert.Equal(2, specifiedComponents.y);

            tvec2<float> fromArray = new tvec2<float>(new float[] { 1, 2 });
            Assert.Equal(1, fromArray.x);
            Assert.Equal(2, fromArray.y);
        }

        [Fact]
        public void equalsNull()
        {
            tvec2<float> defaultConstructed = new tvec2<float>();
            tvec2<float> nullValue = null;

            Assert.False(defaultConstructed.Equals(nullValue));
            Assert.False(nullValue == defaultConstructed);
        }

        [Fact]
        public void intConstruct()
        {
            tvec2<int> defaultConstructed = new tvec2<int>();
            Assert.Equal(0, defaultConstructed.x);
            Assert.Equal(0, defaultConstructed.y);

            tvec2<int> specifiedComponents = new tvec2<int>(1, 2);
            Assert.Equal(1, specifiedComponents.x);
            Assert.Equal(2, specifiedComponents.y);

            tvec2<int> fromArray = new tvec2<int>(new[] { 1, 2 });
            Assert.Equal(1, fromArray.x);
            Assert.Equal(2, fromArray.y);
        }

    }
}
