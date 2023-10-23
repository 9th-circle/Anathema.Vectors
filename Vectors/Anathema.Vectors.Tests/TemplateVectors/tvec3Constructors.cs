using System;
using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.TemplateVectors
{
    public class tvec3Constructors
    {
        [Fact]
        public void indices()
        {
            tvec3<float> vec = new tvec3<float>(1, 2, 3);
            Assert.Equal(1, vec[0]);
            Assert.Equal(2, vec[1]);
            Assert.Equal(3, vec[2]);
            vec[0] = 3;
            Assert.Equal(3, vec[0]);
            Assert.Throws<IndexOutOfRangeException>(delegate { var x = vec[-1]; });
            Assert.Throws<IndexOutOfRangeException>(delegate { vec[10] = 10; });
        }
        [Fact]
        public void array()
        {
            tvec3<float> vec = new tvec3<float>(1, 2, 3);
            float[] a = vec.ToArray();
            Assert.Equal(1, a[0]);
            Assert.Equal(2, a[1]);
            Assert.Equal(3, a[2]);
        }
        [Fact]
        public void floatConstruct()
        {
            tvec3<float> defaultConstructed = new tvec3<float>();
            Assert.Equal(0, defaultConstructed.x);
            Assert.Equal(0, defaultConstructed.y);
            Assert.Equal(0, defaultConstructed.z);

            tvec3<float> copied = new tvec3<float>(defaultConstructed);
            Assert.Equal(0, copied.x);
            Assert.Equal(0, copied.y);
            Assert.Equal(0, copied.z);

            tvec3<float> specifiedComponents = new tvec3<float>(1, 2, 3);
            Assert.Equal(1, specifiedComponents.x);
            Assert.Equal(2, specifiedComponents.y);
            Assert.Equal(3, specifiedComponents.z);

            tvec3<float> fromArray = new tvec3<float>(new float[] { 1, 2, 3 });
            Assert.Equal(1, fromArray.x);
            Assert.Equal(2, fromArray.y);
            Assert.Equal(3, fromArray.z);

            Assert.Equal(1, fromArray[0]);
            Assert.Equal(2, fromArray[1]);
            Assert.Equal(3, fromArray[2]);

            fromArray[0] = 10;
            fromArray[1] = 20;
            fromArray[2] = 30;

            Assert.Equal(10, fromArray.x);
            Assert.Equal(20, fromArray.y);
            Assert.Equal(30, fromArray.z);

            Assert.Throws<IndexOutOfRangeException>(delegate { fromArray[10] = 5; });
            Assert.Throws<IndexOutOfRangeException>(delegate { var x = fromArray[5]; });
        }

        [Fact]
        public void equalsNull()
        {
            tvec3<float> defaultConstructed = new tvec3<float>();
            tvec3<float> nullValue = null;
            tvec3<float> same = new tvec3<float>();

            Assert.False(defaultConstructed.Equals(nullValue));
            Assert.False(defaultConstructed.Equals("not even the right type"));
            Assert.False(nullValue == defaultConstructed);
            Assert.True(defaultConstructed.Equals(same));
        }

        [Fact]
        public void intConstruct()
        {
            tvec3<int> defaultConstructed = new tvec3<int>();
            Assert.Equal(0, defaultConstructed.x);
            Assert.Equal(0, defaultConstructed.y);
            Assert.Equal(0, defaultConstructed.z);

            tvec3<int> specifiedComponents = new tvec3<int>(1, 2, 3);
            Assert.Equal(1, specifiedComponents.x);
            Assert.Equal(2, specifiedComponents.y);
            Assert.Equal(3, specifiedComponents.z);

            tvec3<int> fromArray = new tvec3<int>(new[] { 1, 2, 3 });
            Assert.Equal(1, fromArray.x);
            Assert.Equal(2, fromArray.y);
            Assert.Equal(3, fromArray.z);
        }

    }
}
