using Anathema.Vectors.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Anathema.Vectors.Tests.FloatMatrices
{
    public class fmat2Constructors
    {
        [Fact]
        public void defaultConstructor()
        {
            fmat2 def = new fmat2();
            Assert.Equal(0, def[0]);
            Assert.Equal(0, def[1]);
            Assert.Equal(0, def[2]);
            Assert.Equal(0, def[3]);
        }
        [Fact]
        public void columnOrder()
        {
            fmat2 def = new fmat2(new float[] { 1, 2, 3, 4 });

            Assert.Equal(1, def.getValue(0, 0));
            Assert.Equal(2, def.getValue(0, 1));
            Assert.Equal(3, def.getValue(1, 0));
            Assert.Equal(4, def.getValue(1, 1));

            Assert.Equal(1, def[0, 0]);
            Assert.Equal(2, def[0, 1]);
            Assert.Equal(3, def[1, 0]);
            Assert.Equal(4, def[1, 1]);

            Assert.Equal(1, def[0]);
            Assert.Equal(2, def[1]);
            Assert.Equal(3, def[2]);
            Assert.Equal(4, def[3]);
        }
    }
}