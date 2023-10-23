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
        public void convert()
        {
            tvec3<float> vec = new tvec3<float>(1, 2, 3);
            vec3 fvec = vec.floatTVec3ToVec3();

            Assert.Equal(1, fvec[0]);
            Assert.Equal(2, fvec[1]);
            Assert.Equal(3, fvec[2]);

            tvec3<double> dvec = new tvec3<double>(1, 2, 3);
            dvec3 ddvec = dvec.doubleTVec3ToDVec3();

            Assert.Equal(1, ddvec[0]);
            Assert.Equal(2, ddvec[1]);
            Assert.Equal(3, ddvec[2]);

            Assert.Throws<ArgumentException>(delegate { var x = new tvec3<string>().doubleTVec3ToDVec3(); });
            Assert.Throws<ArgumentException>(delegate { var x = new tvec3<string>().floatTVec3ToVec3(); });
        }

        [Fact]
        public void capitals()
        {
            //todo: implement capitals
            tvec3<float> a = new tvec3<float>(1, 2, 3);
            /*
            Assert.Equal(a.x, a.X);
            Assert.Equal(a.y, a.Y);
            Assert.Equal(a.z, a.Z);*/
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

            tvec2<float> j = new tvec2<float>(1, 2);
            tvec3<float> jaggedFirst = new tvec3<float>(j, 3);
            tvec3<float> jaggedLast = new tvec3<float>(0, j);

            Assert.Equal(1, jaggedFirst.x);
            Assert.Equal(2, jaggedFirst.y);
            Assert.Equal(3, jaggedFirst.z);

            Assert.Equal(0, jaggedLast.x);
            Assert.Equal(1, jaggedLast.y);
            Assert.Equal(2, jaggedLast.z);

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
