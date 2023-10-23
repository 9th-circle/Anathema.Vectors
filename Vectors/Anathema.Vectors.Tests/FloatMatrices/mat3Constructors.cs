using System;
using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.FloatMatrices
{
    public class mat3Constructors
    {
        [Fact]
        public void defaultConstructor()
        {
            mat3 def = new mat3();
            Assert.Equal(0, def[0]);
            Assert.Equal(0, def[1]);
            Assert.Equal(0, def[2]);
            Assert.Equal(0, def[3]);
            Assert.Equal(0, def[4]);
            Assert.Equal(0, def[5]);
            Assert.Equal(0, def[6]);
            Assert.Equal(0, def[7]);
            Assert.Equal(0, def[8]);
        }
        [Fact]
        public void outOfRangeException()
        {
            mat3 def = new mat3();
            Assert.Throws<IndexOutOfRangeException>(delegate () { def.setValue(1, 5, 0); });
            Assert.Equal(0, def.getValue(4, 1));
        }
        [Fact]
        public void assign()
        {
            mat3 a = new mat3(new float[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            mat3 b = new mat3(new float[] { 9, 8, 7, 6, 5, 4, 3, 2, 1 });

            Assert.False(a == b);
            Assert.True(a != b);

            mat3 c = new mat3(a);
            Assert.True(a == c);

            a.assign(b);
            Assert.Equal(9, a[0]);
            Assert.Equal(8, a[1]);
            Assert.Equal(7, a[2]);
            Assert.Equal(6, a[3]);
            Assert.Equal(5, a[4]);
            Assert.Equal(4, a[5]);
            Assert.Equal(3, a[6]);
            Assert.Equal(2, a[7]);
            Assert.Equal(1, a[8]);
        }
        [Fact]
        public void readColumnOrder()
        {
            mat3 def = new mat3(new float[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

            Assert.Equal(1, def.getValue(0, 0));
            Assert.Equal(2, def.getValue(1, 0));
            Assert.Equal(3, def.getValue(2, 0));
            Assert.Equal(4, def.getValue(0, 1));
            Assert.Equal(5, def.getValue(1, 1));
            Assert.Equal(6, def.getValue(2, 1));
            Assert.Equal(7, def.getValue(0, 2));
            Assert.Equal(8, def.getValue(1, 2));
            Assert.Equal(9, def.getValue(2, 2));

            Assert.Equal(1, def[0, 0]);
            Assert.Equal(2, def[1, 0]);
            Assert.Equal(3, def[2, 0]);
            Assert.Equal(4, def[0, 1]);
            Assert.Equal(5, def[1, 1]);
            Assert.Equal(6, def[2, 1]);
            Assert.Equal(7, def[0, 2]);
            Assert.Equal(8, def[1, 2]);
            Assert.Equal(9, def[2, 2]);

            Assert.Equal(1, def[0]);
            Assert.Equal(2, def[1]);
            Assert.Equal(3, def[2]);
            Assert.Equal(4, def[3]);
            Assert.Equal(5, def[4]);
            Assert.Equal(6, def[5]);
            Assert.Equal(7, def[6]);
            Assert.Equal(8, def[7]);
            Assert.Equal(9, def[8]);
        }
        [Fact]
        public void writeColumnOrder()
        {
            mat3 def = new mat3();

            def.setValue(0, 0, 1);
            def.setValue(1, 0, 2);
            def.setValue(2, 0, 3);
            def.setValue(0, 1, 4);
            def.setValue(1, 1, 5);
            def.setValue(2, 1, 6);
            def.setValue(0, 2, 7);
            def.setValue(1, 2, 8);
            def.setValue(2, 2, 9);

            Assert.Equal(1, def.getValue(0, 0));
            Assert.Equal(2, def.getValue(1, 0));
            Assert.Equal(3, def.getValue(2, 0));
            Assert.Equal(4, def.getValue(0, 1));
            Assert.Equal(5, def.getValue(1, 1));
            Assert.Equal(6, def.getValue(2, 1));
            Assert.Equal(7, def.getValue(0, 2));
            Assert.Equal(8, def.getValue(1, 2));
            Assert.Equal(9, def.getValue(2, 2));

            def[0] = 10;
            def[1] = 11;
            def[2] = 12;
            def[3] = 13;
            def[4] = 14;
            def[5] = 15;
            def[6] = 16;
            def[7] = 17;
            def[8] = 18;

            Assert.Equal(10, def[0, 0]);
            Assert.Equal(11, def[1, 0]);
            Assert.Equal(12, def[2, 0]);
            Assert.Equal(13, def[0, 1]);
            Assert.Equal(14, def[1, 1]);
            Assert.Equal(15, def[2, 1]);
            Assert.Equal(16, def[0, 2]);
            Assert.Equal(17, def[1, 2]);
            Assert.Equal(18, def[2, 2]);

            def[0, 0] = 9;
            def[1, 0] = 8;
            def[2, 0] = 7;
            def[0, 1] = 6;
            def[1, 1] = 5;
            def[2, 1] = 4;
            def[0, 2] = 3;
            def[1, 2] = 2;
            def[2, 2] = 1;

            Assert.Equal(9, def[0]);
            Assert.Equal(8, def[1]);
            Assert.Equal(7, def[2]);
            Assert.Equal(6, def[3]);
            Assert.Equal(5, def[4]);
            Assert.Equal(4, def[5]);
            Assert.Equal(3, def[6]);
            Assert.Equal(2, def[7]);
            Assert.Equal(1, def[8]);
        }
    }
}
