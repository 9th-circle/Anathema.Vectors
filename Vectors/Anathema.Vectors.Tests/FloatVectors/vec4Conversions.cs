using Anathema.Vectors.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Anathema.Vectors.Tests.FloatVectors
{
    public class vec4Conversions
    {
        [Fact]
        public void basicTemplateConversion()
        {
            vec4 a = new vec4(10, 20, 30, 40);
            tvec4<float> t = a.toTVec4();

            Assert.Equal(10, t.x);
            Assert.Equal(20, t.y);
            Assert.Equal(30, t.z);
            Assert.Equal(40, t.w);
        }
    }
}
