﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.TemplateVectors
{
    public class tvec2Conversions
    {
        [Fact]
        public void toFVec2()
        {
            tvec2<float> vec = new tvec2<float>(1, 2);
            vec2 fvec = vec.floatTVec2ToFVec2();
            Assert.Equal(1, fvec.x);
            Assert.Equal(2, fvec.y);
        }
        [Fact]
        public void toDVec2()
        {
            tvec2<double> vec = new tvec2<double>(1, 2);
            dvec2 dvec = vec.doubleTVec2ToDVec2();
            Assert.Equal(1, dvec.x);
            Assert.Equal(2, dvec.y);
        }
        [Fact]
        public void toFVec2InvalidType()
        {
            tvec2<string> vec = new tvec2<string>("a", "b");
            Assert.Throws<TypeLoadException>(delegate { vec2 fvec = vec.floatTVec2ToFVec2(); });
        }
        [Fact]
        public void toDVec2InvalidType()
        {
            tvec2<float> vec = new tvec2<float>(1, 2);
            Assert.Throws<TypeLoadException>(delegate { dvec2 dvec = vec.doubleTVec2ToDVec2(); });
        }
    }
}