using Anathema.Vectors.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Anathema.Vectors.Tests.DoubleVectors
{
    public class dddvec4DerivationTests
    {
        [Fact]
        public void length()
        {
            dvec4 a = new dvec4(0, 0, 0, 100);
            Assert.Equal(100, a.length);
        }
        [Fact]
        public void normalise()
        {
            dvec4 a = new dvec4(0, 0, 0, 100).normalised;
            Assert.Equal(1, a.length);
            dvec4 b = new dvec4(0, -50, 0, 0);
            b.normalise();
            Assert.Equal(1, b.length);
        }
        [Fact]
        public void dot()
        {
            dvec4 a = new dvec4(1, 1, 1, 1);
            dvec4 b = new dvec4(1, 1, 1, 1);
            Assert.Equal(1, a.dot(b));

            dvec4 c = new dvec4(1, 1, 1, 5);
            dvec4 d = new dvec4(1, 1, 1, 1);
            Assert.Equal(5, a.dot(b));
        }
    }
}
