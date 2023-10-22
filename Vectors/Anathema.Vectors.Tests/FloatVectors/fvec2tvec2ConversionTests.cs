using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.FloatVectors
{
    public class fvec2tvec2ConversionTests
    {
        [Fact]
        public void basicTemplateConversion()
        {
            fvec2 a = new fvec2(10, 20);
            tvec2<float> t = a.toTVec2();

            Assert.Equal(10, t.x);
            Assert.Equal(20, t.y);

        }
    }
}
