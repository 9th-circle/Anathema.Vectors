using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.TemplateVectors
{
    public class tvec2DoubleOperatorTests
    {
        [Fact]
        public void negation()
        {
            tvec2<double> a = new tvec2<double>(1, 2);
            tvec2<double> b = -a;

            Assert.Equal(-1, b.x);
            Assert.Equal(-2, b.y);
        }
        [Fact]
        public void equality()
        {
            tvec2<double> a = new tvec2<double>(1, 2);
            tvec2<double> b = new tvec2<double>(1, 2);
            tvec2<double> c = new tvec2<double>(3, 4);
            tvec2<double> n = null;
            Assert.True(a == b);
            Assert.False(a == c);
            Assert.False(a != b);
            Assert.True(a != c);
            Assert.False(a == n);
            Assert.False(n == a);
        }
        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void tvec2Addition(double x1, double y1, double x2, double y2)
        {
            tvec2<double> a = new tvec2<double>(x1, y1);
            tvec2<double> b = new tvec2<double>(x2, y2);

            tvec2<double> c = a + b;
            tvec2<double> d = b + a;

            Assert.Equal(x1 + x2, c.x);
            Assert.Equal(x1 + x2, d.x);
            Assert.Equal(y1 + y2, c.y);
            Assert.Equal(y1 + y2, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void tvec2Subtraction(double x1, double y1, double x2, double y2)
        {
            tvec2<double> a = new tvec2<double>(x1, y1);
            tvec2<double> b = new tvec2<double>(x2, y2);

            tvec2<double> c = a - b;
            tvec2<double> d = b - a;

            Assert.Equal(x1 - x2, c.x);
            Assert.Equal(x2 - x1, d.x);
            Assert.Equal(y1 - y2, c.y);
            Assert.Equal(y2 - y1, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void tvec2Multiplication(double x1, double y1, double x2, double y2)
        {
            tvec2<double> a = new tvec2<double>(x1, y1);
            tvec2<double> b = new tvec2<double>(x2, y2);

            tvec2<double> c = a * b;
            tvec2<double> d = b * a;

            Assert.Equal(x1 * x2, c.x);
            Assert.Equal(x1 * x2, d.x);
            Assert.Equal(y1 * y2, c.y);
            Assert.Equal(y1 * y2, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void tvec2MutatorMultiplication(double x1, double y1, double x2, double y2)
        {
            tvec2<double> a = new tvec2<double>(x1, y1);
            tvec2<double> b = new tvec2<double>(x2, y2);

            a *= b;

            Assert.True(x1 * x2 == a.x);
            Assert.True(y1 * y2 == a.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void vec2Division(double x1, double y1, double x2, double y2)
        {
            tvec2<double> a = new tvec2<double>(x1, y1);
            tvec2<double> b = new tvec2<double>(x2, y2);

            tvec2<double> c = a / b;
            tvec2<double> d = b / a;

            Assert.Equal(x1 / x2, c.x);
            Assert.Equal(y1 / y2, c.y);
            Assert.Equal(x2 / x1, d.x);
            Assert.Equal(y2 / y1, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2 })]
        public void scalarMultiplication(double x, double y, double scalar)
        {
            tvec2<double> a = new tvec2<double>(x, y);

            tvec2<double> c = a * scalar;
            tvec2<double> d = scalar * a;

            Assert.Equal(x * scalar, c.x);
            Assert.Equal(x * scalar, d.x);
            Assert.Equal(y * scalar, c.y);
            Assert.Equal(y * scalar, d.y);
        }


        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2 })]
        public void scalarDivision(double x, double y, double scalar)
        {
            tvec2<double> a = new tvec2<double>(x, y);

            tvec2<double> c = a / scalar;
            tvec2<double> d = scalar / a;

            Assert.Equal(x / scalar, c.x);
            Assert.Equal(y / scalar, c.y);
            Assert.Equal(scalar / x, d.x);
            Assert.Equal(scalar / y, d.y);
        }
        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2 })]
        public void scalarAddition(double x, double y, double scalar)
        {
            tvec2<double> a = new tvec2<double>(x, y);

            tvec2<double> c = a + scalar;
            tvec2<double> d = scalar + a;

            Assert.Equal(x + scalar, c.x);
            Assert.Equal(x + scalar, d.x);
            Assert.Equal(y + scalar, c.y);
            Assert.Equal(y + scalar, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2 })]
        public void scalarSubtraction(double x, double y, double scalar)
        {
            tvec2<double> a = new tvec2<double>(x, y);

            tvec2<double> c = a - scalar;
            tvec2<double> d = scalar - a;

            Assert.Equal(x - scalar, c.x);
            Assert.Equal(y - scalar, c.y);
            Assert.Equal(scalar - x, d.x);
            Assert.Equal(scalar - y, d.y);
        }
    }
}
