using Anathema.Vectors.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Anathema.Vectors.Tests.DoubleVectors
{
    public class dvec4Conversions
    {
        [Fact]
        public void basicTemplateConversion()
        {
            dvec4 a = new dvec4(10, 20, 30, 40);
            tvec4<double> t = a.toTVec4();

            Assert.Equal(10, t.x);
            Assert.Equal(20, t.y);
            Assert.Equal(30, t.z);
            Assert.Equal(40, t.w);
        }
    }
}
