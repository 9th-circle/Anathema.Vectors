using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.FloatVectors
{
    public class vec3tvec3ConversionTests
    {
        [Fact]
        public void basicTemplateConversion()
        {
            vec3 a = new vec3(10, 20, 30);
            tvec3<float> t = a.toTVec3();

            Assert.Equal(10, t.x);
            Assert.Equal(20, t.y);
            Assert.Equal(30, t.z);
        }
    }
}