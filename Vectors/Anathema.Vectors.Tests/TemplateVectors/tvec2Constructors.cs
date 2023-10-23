using System;
using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.TemplateVectors
{
    public class tvec2Constructors
    {
        [Fact]
        public void indices()
        {
            tvec2<float> vec = new tvec2<float>(1,2);
            Assert.Equal(1, vec[0]);
            Assert.Equal(2, vec[1]);
            vec[0] = 3;
            Assert.Equal(3, vec[0]);
            Assert.Throws<IndexOutOfRangeException>(delegate { var x = vec[-1]; });
            Assert.Throws<IndexOutOfRangeException>(delegate { vec[10] = 10; });
        }
        [Fact]
        public void array()
        {
            tvec2<float> vec = new tvec2<float>(1, 2);
            float[] a= vec.ToArray();
            Assert.Equal(1, a[0]);
            Assert.Equal(2, a[1]);
        }
        [Fact]
        public void floatConstruct()
        {
            tvec2<float> defaultConstructed = new tvec2<float>();
            Assert.Equal(0, defaultConstructed.x);
            Assert.Equal(0, defaultConstructed.y);

            tvec2<float> copied = new tvec2<float>(defaultConstructed);
            Assert.Equal(0, copied.x);
            Assert.Equal(0, copied.y);

            tvec2<float> specifiedComponents = new tvec2<float>(1, 2);
            Assert.Equal(1, specifiedComponents.x);
            Assert.Equal(2, specifiedComponents.y);

            tvec2<float> fromArray = new tvec2<float>(new float[] { 1, 2 });
            Assert.Equal(1, fromArray.x);
            Assert.Equal(2, fromArray.y);

            Assert.Equal(1, fromArray[0]);
            Assert.Equal(2, fromArray[1]);

            fromArray[0] = 10;
            fromArray[1] = 20;

            Assert.Equal(10, fromArray.x);
            Assert.Equal(20, fromArray.y);

            Assert.Throws<IndexOutOfRangeException>(delegate { fromArray[10] = 5; });
            Assert.Throws<IndexOutOfRangeException>(delegate { var x = fromArray[5]; });
        }

        [Fact]
        public void equalsNull()
        {
            tvec2<float> defaultConstructed = new tvec2<float>();
            tvec2<float> nullValue = null;
            tvec2<float> same = new tvec2<float>();

            Assert.False(defaultConstructed.Equals(nullValue));
            Assert.False(defaultConstructed.Equals("not even the right type"));
            Assert.False(nullValue == defaultConstructed);
            Assert.True(defaultConstructed.Equals(same));
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
