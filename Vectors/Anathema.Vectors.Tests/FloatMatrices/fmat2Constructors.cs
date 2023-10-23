using Anathema.Vectors.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Anathema.Vectors.Tests.FloatMatrices
{
    public class mat2Constructors
    {
        [Fact]
        public void defaultConstructor()
        {
            mat2 def = new mat2();
            Assert.Equal(0, def[0]);
            Assert.Equal(0, def[1]);
            Assert.Equal(0, def[2]);
            Assert.Equal(0, def[3]);
        }
        [Fact]
        public void outOfRangeException()
        {
            mat2 def = new mat2();
            Assert.Throws<IndexOutOfRangeException>(delegate () { def.setValue(1, 2, 0); });
            Assert.Equal(0,def.getValue(2, 1));
        }
        [Fact]
        public void readColumnOrder()
        {
            mat2 def = new mat2(new float[] { 1, 2, 3, 4 });

            Assert.Equal(1, def.getValue(0, 0));
            Assert.Equal(2, def.getValue(1, 0));
            Assert.Equal(3, def.getValue(0, 1));
            Assert.Equal(4, def.getValue(1, 1));

            Assert.Equal(1, def[0, 0]);
            Assert.Equal(2, def[1, 0]);
            Assert.Equal(3, def[0, 1]);
            Assert.Equal(4, def[1, 1]);

            Assert.Equal(1, def[0]);
            Assert.Equal(2, def[1]);
            Assert.Equal(3, def[2]);
            Assert.Equal(4, def[3]);
        }
        [Fact]
        public void writeColumnOrder()
        {
            mat2 def = new mat2();

            def.setValue(0, 0, 1);
            def.setValue(1, 0, 2);
            def.setValue(0, 1, 3);
            def.setValue(1, 1, 4);

            Assert.Equal(1, def.getValue(0, 0));
            Assert.Equal(2, def.getValue(1, 0));
            Assert.Equal(3, def.getValue(0, 1));
            Assert.Equal(4, def.getValue(1, 1));

            def[0] = 10;
            def[1] = 11;
            def[2] = 12;
            def[3] = 13;

            Assert.Equal(10, def[0, 0]);
            Assert.Equal(11, def[1, 0]);
            Assert.Equal(12, def[0, 1]);
            Assert.Equal(13, def[1, 1]);

            def[0, 0] = 9;
            def[1, 0] = 8;
            def[0, 1] = 7;
            def[1, 1] = 6;

            Assert.Equal(9, def[0]);
            Assert.Equal(8, def[1]);
            Assert.Equal(7, def[2]);
            Assert.Equal(6, def[3]);
        }
    }
}