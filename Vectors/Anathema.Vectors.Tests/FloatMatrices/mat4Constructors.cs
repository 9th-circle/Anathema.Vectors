using Anathema.Vectors.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Anathema.Vectors.Tests.FloatMatrices
{
    public class mat4Constructors
    {
        [Fact]
        public void defaultConstructor()
        {
            mat4 def = new mat4();
            Assert.Equal(0, def[0]);
            Assert.Equal(0, def[1]);
            Assert.Equal(0, def[2]);
            Assert.Equal(0, def[3]);
            Assert.Equal(0, def[4]);
            Assert.Equal(0, def[5]);
            Assert.Equal(0, def[6]);
            Assert.Equal(0, def[7]);
            Assert.Equal(0, def[8]);
            Assert.Equal(0, def[9]);
            Assert.Equal(0, def[10]);
            Assert.Equal(0, def[11]);
            Assert.Equal(0, def[12]);
            Assert.Equal(0, def[13]);
            Assert.Equal(0, def[14]);
            Assert.Equal(0, def[15]);
        }
        [Fact]
        public void outOfRangeException()
        {
            mat4 def = new mat4();
            Assert.Throws<IndexOutOfRangeException>(delegate () { def.setValue(1, 5, 0); });
            Assert.Equal(0, def.getValue(4, 1));
        }
        [Fact]
        public void assign()
        {
            mat4 a = new mat4(new float[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 });
            mat4 b = new mat4(new float[] { 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 });

            Assert.False(a == b);
            Assert.True(a != b);

            mat4 c = new mat4(a);
            Assert.True(a == c);
            Assert.False(a == null);
            mat4 d = null;
            Assert.True(d == null);

            a.assign(b);
            Assert.Equal(16, a[0]);
            Assert.Equal(15, a[1]);
            Assert.Equal(14, a[2]);
            Assert.Equal(13, a[3]);
            Assert.Equal(12, a[4]);
            Assert.Equal(11, a[5]);
            Assert.Equal(10, a[6]);
            Assert.Equal(9, a[7]);
            Assert.Equal(8, a[8]);
            Assert.Equal(7, a[9]);
            Assert.Equal(6, a[10]);
            Assert.Equal(5, a[11]);
            Assert.Equal(4, a[12]);
            Assert.Equal(3, a[13]);
            Assert.Equal(2, a[14]);
            Assert.Equal(1, a[15]);
        }
        [Fact]
        public void readColumnOrder()
        {
            mat4 def = new mat4(new float[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 });

            Assert.Equal(1, def.getValue(0, 0));
            Assert.Equal(2, def.getValue(1, 0));
            Assert.Equal(3, def.getValue(2, 0));
            Assert.Equal(4, def.getValue(3, 0));

            Assert.Equal(5, def.getValue(0, 1));
            Assert.Equal(6, def.getValue(1, 1));
            Assert.Equal(7, def.getValue(2, 1));
            Assert.Equal(8, def.getValue(3, 1));

            Assert.Equal(9, def.getValue(0, 2));
            Assert.Equal(10, def.getValue(1, 2));
            Assert.Equal(11, def.getValue(2, 2));
            Assert.Equal(12, def.getValue(3, 2));

            Assert.Equal(13, def.getValue(0, 3));
            Assert.Equal(14, def.getValue(1, 3));
            Assert.Equal(15, def.getValue(2, 3));
            Assert.Equal(16, def.getValue(3, 3));

            Assert.Equal(1, def[0, 0]);
            Assert.Equal(2, def[1, 0]);
            Assert.Equal(3, def[2, 0]);
            Assert.Equal(4, def[3, 0]);

            Assert.Equal(5, def[0, 1]);
            Assert.Equal(6, def[1, 1]);
            Assert.Equal(7, def[2, 1]);
            Assert.Equal(8, def[3, 1]);

            Assert.Equal(9, def[0, 2]);
            Assert.Equal(10, def[1, 2]);
            Assert.Equal(11, def[2, 2]);
            Assert.Equal(12, def[3, 2]);

            Assert.Equal(13, def[0, 3]);
            Assert.Equal(14, def[1, 3]);
            Assert.Equal(15, def[2, 3]);
            Assert.Equal(16, def[3, 3]);

            Assert.Equal(1, def[0]);
            Assert.Equal(2, def[1]);
            Assert.Equal(3, def[2]);
            Assert.Equal(4, def[3]);
            Assert.Equal(5, def[4]);
            Assert.Equal(6, def[5]);
            Assert.Equal(7, def[6]);
            Assert.Equal(8, def[7]);
            Assert.Equal(9, def[8]);
            Assert.Equal(10, def[9]);
            Assert.Equal(11, def[10]);
            Assert.Equal(12, def[11]);
            Assert.Equal(13, def[12]);
            Assert.Equal(14, def[13]);
            Assert.Equal(15, def[14]);
            Assert.Equal(16, def[15]);
        }
        
        [Fact]
        public void writeColumnOrder()
        {
            mat4 def = new mat4();

            def.setValue(0, 0, 1);
            def.setValue(1, 0, 2);
            def.setValue(2, 0, 3);
            def.setValue(3, 0, 4);

            def.setValue(0, 1, 5);
            def.setValue(1, 1, 6);
            def.setValue(2, 1, 7);
            def.setValue(3, 1, 8);

            def.setValue(0, 2, 9);
            def.setValue(1, 2, 10);
            def.setValue(2, 2, 11);
            def.setValue(3, 2, 12);

            def.setValue(0, 3, 13);
            def.setValue(1, 3, 14);
            def.setValue(2, 3, 15);
            def.setValue(3, 3, 16);

            Assert.Equal(1, def.getValue(0, 0));
            Assert.Equal(2, def.getValue(1, 0));
            Assert.Equal(3, def.getValue(2, 0));
            Assert.Equal(4, def.getValue(3, 0));

            Assert.Equal(5, def.getValue(0, 1));
            Assert.Equal(6, def.getValue(1, 1));
            Assert.Equal(7, def.getValue(2, 1));
            Assert.Equal(8, def.getValue(3, 1));

            Assert.Equal(9, def.getValue(0, 2));
            Assert.Equal(10, def.getValue(1, 2));
            Assert.Equal(11, def.getValue(2, 2));
            Assert.Equal(12, def.getValue(3, 2));

            Assert.Equal(13, def.getValue(0, 3));
            Assert.Equal(14, def.getValue(1, 3));
            Assert.Equal(15, def.getValue(2, 3));
            Assert.Equal(16, def.getValue(3, 3));

            def[0] = 10;
            def[1] = 11;
            def[2] = 12;
            def[3] = 13;
            def[4] = 14;
            def[5] = 15;
            def[6] = 16;
            def[7] = 17;
            def[8] = 18;
            def[9] = 19;
            def[10] = 20;
            def[11] = 21;
            def[12] = 22;
            def[13] = 23;
            def[14] = 24;
            def[15] = 25;

            Assert.Equal(10, def[0, 0]);
            Assert.Equal(11, def[1, 0]);
            Assert.Equal(12, def[2, 0]);
            Assert.Equal(13, def[3, 0]);

            Assert.Equal(14, def[0, 1]);
            Assert.Equal(15, def[1, 1]);
            Assert.Equal(16, def[2, 1]);
            Assert.Equal(17, def[3, 1]);

            Assert.Equal(18, def[0, 2]);
            Assert.Equal(19, def[1, 2]);
            Assert.Equal(20, def[2, 2]);
            Assert.Equal(21, def[3, 2]);

            Assert.Equal(22, def[0, 3]);
            Assert.Equal(23, def[1, 3]);
            Assert.Equal(24, def[2, 3]);
            Assert.Equal(25, def[3, 3]);

            def[0, 0] = 9;
            def[1, 0] = 8;
            def[2, 0] = 7;

            Assert.Equal(9, def[0]);
            Assert.Equal(8, def[1]);
            Assert.Equal(7, def[2]);
        }

    }
}
