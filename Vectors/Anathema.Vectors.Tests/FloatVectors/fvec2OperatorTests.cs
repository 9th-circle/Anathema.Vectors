﻿using Anathema.Vectors.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Anathema.Vectors.Tests.FloatVectors
{
    public class fvec2OperatorTests
    {

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void fvec2Addition(float x1, float y1, float x2, float y2)
        {
            fvec2 a = new fvec2(x1, y1);
            fvec2 b = new fvec2(x2, y2);

            fvec2 c = a + b;
            fvec2 d = b + a;

            Assert.Equal(x1 + x2, c.x);
            Assert.Equal(x1 + x2, d.x);
            Assert.Equal(y1 + y2, c.y);
            Assert.Equal(y1 + y2, d.y);
        }


        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void vec2Subtraction(float x1, float y1, float x2, float y2)
        {
            fvec2 a = new fvec2(x1, y1);
            fvec2 b = new fvec2(x2, y2);

            fvec2 c = a - b;
            fvec2 d = b - a;

            Assert.Equal(x1 - x2, c.x);
            Assert.Equal(x2 - x1, d.x);
            Assert.Equal(y1 - y2, c.y);
            Assert.Equal(y2 - y1, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void vec2Multiplication(float x1, float y1, float x2, float y2)
        {
            fvec2 a = new fvec2(x1, y1);
            fvec2 b = new fvec2(x2, y2);

            fvec2 c = a * b;
            fvec2 d = b * a;

            Assert.Equal(x1 * x2, c.x);
            Assert.Equal(x1 * x2, d.x);
            Assert.Equal(y1 * y2, c.y);
            Assert.Equal(y1 * y2, d.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void fvec2MutatorMultiplication(float x1, float y1, float x2, float y2)
        {
            fvec2 a = new fvec2(x1, y1);
            fvec2 b = new fvec2(x2, y2);

            a *= b;

            Assert.True(x1 * x2 == a.x);
            Assert.True(y1 * y2 == a.y);
        }

        [Theory]
        [InlineData(new object[] { 1, 2, 3, 4 })]
        [InlineData(new object[] { 5.2f, 10.00001f, 15.23f, 20.99999999999f })]
        [InlineData(new object[] { -37, 0, 2, -5 })]
        public void vec2Division(float x1, float y1, float x2, float y2)
        {
            fvec2 a = new fvec2(x1, y1);
            fvec2 b = new fvec2(x2, y2);

            fvec2 c = a / b;
            fvec2 d = b / a;

            Assert.Equal(x1 / x2, c.x);
            Assert.Equal(y1 / y2, c.y);
            Assert.Equal(x2 / x1, d.x);
            Assert.Equal(y2 / y1, d.y);
        }

    }
}