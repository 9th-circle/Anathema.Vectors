using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.TemplateVectors
{
    public class tvec2LongOperatorTests
    {
        //todo: implement tvec2.negation
        /*
        [Fact]
        public void negation()
        {
            tvec2<long> a = new tvec2<long>(1, 2);
            tvec2<long> b = -a;

            Assert.Equal(-1, b.x);
            Assert.Equal(-2, b.y);
        }*/

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        public void tvec2Addition(long x1, long y1, long x2, long y2)
        {
            tvec2<long> a = new tvec2<long>(x1, y1);
            tvec2<long> b = new tvec2<long>(x2, y2);

            tvec2<long> c = a + b;
            tvec2<long> d = b + a;

            Assert.Equal(x1 + x2, c.x);
            Assert.Equal(x1 + x2, d.x);
            Assert.Equal(y1 + y2, c.y);
            Assert.Equal(y1 + y2, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        public void tvec2Subtraction(long x1, long y1, long x2, long y2)
        {
            tvec2<long> a = new tvec2<long>(x1, y1);
            tvec2<long> b = new tvec2<long>(x2, y2);

            tvec2<long> c = a - b;
            tvec2<long> d = b - a;

            Assert.Equal(x1 - x2, c.x);
            Assert.Equal(x2 - x1, d.x);
            Assert.Equal(y1 - y2, c.y);
            Assert.Equal(y2 - y1, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        public void tvec2Multiplication(long x1, long y1, long x2, long y2)
        {
            tvec2<long> a = new tvec2<long>(x1, y1);
            tvec2<long> b = new tvec2<long>(x2, y2);

            tvec2<long> c = a * b;
            tvec2<long> d = b * a;

            Assert.Equal(x1 * x2, c.x);
            Assert.Equal(x1 * x2, d.x);
            Assert.Equal(y1 * y2, c.y);
            Assert.Equal(y1 * y2, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { -37, 1, 2, -5 })]
        public void tvec2MutatorMultiplication(long x1, long y1, long x2, long y2)
        {
            tvec2<long> a = new tvec2<long>(x1, y1);
            tvec2<long> b = new tvec2<long>(x2, y2);

            a *= b;

            Assert.True(x1 * x2 == a.x);
            Assert.True(y1 * y2 == a.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { -37, 1, 2, -5 })]
        public void vec2Division(long x1, long y1, long x2, long y2)
        {
            tvec2<long> a = new tvec2<long>(x1, y1);
            tvec2<long> b = new tvec2<long>(x2, y2);

            tvec2<long> c = a / b;
            tvec2<long> d = b / a;

            Assert.Equal(x1 / x2, c.x);
            Assert.Equal(y1 / y2, c.y);
            Assert.Equal(x2 / x1, d.x);
            Assert.Equal(y2 / y1, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { -37, 1, 2 })]
        public void scalarMultiplication(long x, long y, long scalar)
        {
            tvec2<long> a = new tvec2<long>(x, y);

            tvec2<long> c = a * scalar;
            tvec2<long> d = scalar * a;

            Assert.Equal(x * scalar, c.x);
            Assert.Equal(x * scalar, d.x);
            Assert.Equal(y * scalar, c.y);
            Assert.Equal(y * scalar, d.y);
        }


        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { -37, 1, 2 })]
        public void scalarDivision(long x, long y, long scalar)
        {
            tvec2<long> a = new tvec2<long>(x, y);

            tvec2<long> c = a / scalar;
            tvec2<long> d = scalar / a;

            Assert.Equal(x / scalar, c.x);
            Assert.Equal(y / scalar, c.y);
            Assert.Equal(scalar / x, d.x);
            Assert.Equal(scalar / y, d.y);
        }
        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { -37, 1, 2 })]
        public void scalarAddition(long x, long y, long scalar)
        {
            tvec2<long> a = new tvec2<long>(x, y);

            tvec2<long> c = a + scalar;
            tvec2<long> d = scalar + a;

            Assert.Equal(x + scalar, c.x);
            Assert.Equal(x + scalar, d.x);
            Assert.Equal(y + scalar, c.y);
            Assert.Equal(y + scalar, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { -37, 1, 2 })]
        public void scalarSubtraction(long x, long y, long scalar)
        {
            tvec2<long> a = new tvec2<long>(x, y);

            tvec2<long> c = a - scalar;
            tvec2<long> d = scalar - a;

            Assert.Equal(x - scalar, c.x);
            Assert.Equal(y - scalar, c.y);
            Assert.Equal(scalar - x, d.x);
            Assert.Equal(scalar - y, d.y);
        }
    }
}
