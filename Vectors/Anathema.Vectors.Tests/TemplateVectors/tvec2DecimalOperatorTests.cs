using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.TemplateVectors
{
    public class tvec2DecimalOperatorTests
    {
        //todo: implement tvec2.negation
        /*
        [Fact]
        public void negation()
        {
            tvec2<decimal> a = new tvec2<decimal>(1, 2);
            tvec2<decimal> b = -a;

            Assert.Equal(-1, b.x);
            Assert.Equal(-2, b.y);
        }*/

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 1, 2, -5 })]
        public void tvec2Addition(decimal x1, decimal y1, decimal x2, decimal y2)
        {
            tvec2<decimal> a = new tvec2<decimal>(x1, y1);
            tvec2<decimal> b = new tvec2<decimal>(x2, y2);

            tvec2<decimal> c = a + b;
            tvec2<decimal> d = b + a;

            Assert.Equal(x1 + x2, c.x);
            Assert.Equal(x1 + x2, d.x);
            Assert.Equal(y1 + y2, c.y);
            Assert.Equal(y1 + y2, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 1, 2, -5 })]
        public void tvec2Subtraction(decimal x1, decimal y1, decimal x2, decimal y2)
        {
            tvec2<decimal> a = new tvec2<decimal>(x1, y1);
            tvec2<decimal> b = new tvec2<decimal>(x2, y2);

            tvec2<decimal> c = a - b;
            tvec2<decimal> d = b - a;

            Assert.Equal(x1 - x2, c.x);
            Assert.Equal(x2 - x1, d.x);
            Assert.Equal(y1 - y2, c.y);
            Assert.Equal(y2 - y1, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 1, 2, -5 })]
        public void tvec2Multiplication(decimal x1, decimal y1, decimal x2, decimal y2)
        {
            tvec2<decimal> a = new tvec2<decimal>(x1, y1);
            tvec2<decimal> b = new tvec2<decimal>(x2, y2);

            tvec2<decimal> c = a * b;
            tvec2<decimal> d = b * a;

            Assert.Equal(x1 * x2, c.x);
            Assert.Equal(x1 * x2, d.x);
            Assert.Equal(y1 * y2, c.y);
            Assert.Equal(y1 * y2, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 1, 2, -5 })]
        public void tvec2MutatorMultiplication(decimal x1, decimal y1, decimal x2, decimal y2)
        {
            tvec2<decimal> a = new tvec2<decimal>(x1, y1);
            tvec2<decimal> b = new tvec2<decimal>(x2, y2);

            a *= b;

            Assert.True(x1 * x2 == a.x);
            Assert.True(y1 * y2 == a.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 1, 2, -5 })]
        public void vec2Division(decimal x1, decimal y1, decimal x2, decimal y2)
        {
            tvec2<decimal> a = new tvec2<decimal>(x1, y1);
            tvec2<decimal> b = new tvec2<decimal>(x2, y2);

            tvec2<decimal> c = a / b;
            tvec2<decimal> d = b / a;

            Assert.Equal(x1 / x2, c.x);
            Assert.Equal(y1 / y2, c.y);
            Assert.Equal(x2 / x1, d.x);
            Assert.Equal(y2 / y1, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 20.99999999999f })]
        [InlineData(new object[] { -37, 1, 2 })]
        public void scalarMultiplication(decimal x, decimal y, decimal scalar)
        {
            tvec2<decimal> a = new tvec2<decimal>(x, y);

            tvec2<decimal> c = a * scalar;
            tvec2<decimal> d = scalar * a;

            Assert.Equal(x * scalar, c.x);
            Assert.Equal(x * scalar, d.x);
            Assert.Equal(y * scalar, c.y);
            Assert.Equal(y * scalar, d.y);
        }


        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 20.99999999999f })]
        [InlineData(new object[] { -37, 1, 2 })]
        public void scalarDivision(decimal x, decimal y, decimal scalar)
        {
            tvec2<decimal> a = new tvec2<decimal>(x, y);

            tvec2<decimal> c = a / scalar;
            tvec2<decimal> d = scalar / a;

            Assert.Equal(x / scalar, c.x);
            Assert.Equal(y / scalar, c.y);
            Assert.Equal(scalar / x, d.x);
            Assert.Equal(scalar / y, d.y);
        }
        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 20.99999999999f })]
        [InlineData(new object[] { -37, 1, 2 })]
        public void scalarAddition(decimal x, decimal y, decimal scalar)
        {
            tvec2<decimal> a = new tvec2<decimal>(x, y);

            tvec2<decimal> c = a + scalar;
            tvec2<decimal> d = scalar + a;

            Assert.Equal(x + scalar, c.x);
            Assert.Equal(x + scalar, d.x);
            Assert.Equal(y + scalar, c.y);
            Assert.Equal(y + scalar, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 20.99999999999f })]
        [InlineData(new object[] { -37, 1, 2 })]
        public void scalarSubtraction(decimal x, decimal y, decimal scalar)
        {
            tvec2<decimal> a = new tvec2<decimal>(x, y);

            tvec2<decimal> c = a - scalar;
            tvec2<decimal> d = scalar - a;

            Assert.Equal(x - scalar, c.x);
            Assert.Equal(y - scalar, c.y);
            Assert.Equal(scalar - x, d.x);
            Assert.Equal(scalar - y, d.y);
        }
    }
}
