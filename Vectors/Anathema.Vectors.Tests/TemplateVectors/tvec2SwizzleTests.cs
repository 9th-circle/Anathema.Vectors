using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.TemplateVectors
{
    public class tvec2SwizzleTests
    {
        [Fact]
        public void swizzles()
        {
            tvec2<int> a = new tvec2<int>(1,2);

            Assert.Equal(1, a.xy.x);
            Assert.Equal(2, a.xy.y);

            Assert.Equal(1, a.yx.y);
            Assert.Equal(2, a.yx.x);

            Assert.Equal(1, a.r);
            Assert.Equal(2, a.g);

            Assert.Equal(1, a.rg.x);
            Assert.Equal(2, a.rg.y);

            Assert.Equal(1, a.gr.y);
            Assert.Equal(2, a.gr.x);

            a.xy = new tvec2<int>(3,4);
            Assert.Equal(3, a.x);
            Assert.Equal(4, a.y);

            a.yx = new tvec2<int>(6, 5);
            Assert.Equal(5, a.x);
            Assert.Equal(6, a.y);

            a.rg = new tvec2<int>(3, 4);
            Assert.Equal(3, a.x);
            Assert.Equal(4, a.y);

            a.gr = new tvec2<int>(6, 5);
            Assert.Equal(5, a.x);
            Assert.Equal(6, a.y);

            a.r = 7;
            a.g = 8;
            Assert.Equal(7, a.x);
            Assert.Equal(8, a.y);
        }
    }
}
