using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Anathema.Vectors.Core;
using Xunit;

namespace Anathema.Vectors.Tests.TemplateVectors
{
    public class tvec2InvalidTypeTests
    {
        [Fact]
        public void invalidOperators()
        {
            tvec2<string> a = new tvec2<string>("a", "b");
            tvec2<string> b = new tvec2<string>("c", "d");

            //Assert.Throws<TypeLoadException>(delegate () { var v = -a; });

            Assert.Throws<TypeLoadException>(delegate () { var v = a + b; });
            Assert.Throws<TypeLoadException>(delegate () { var v = a - b; });
            Assert.Throws<TypeLoadException>(delegate () { var v = a / b; });
            Assert.Throws<TypeLoadException>(delegate () { var v = a * b; });

            Assert.Throws<TypeLoadException>(delegate () { var v = a + "z"; });
            Assert.Throws<TypeLoadException>(delegate () { var v = a - "z"; });
            Assert.Throws<TypeLoadException>(delegate () { var v = a / "z"; });
            Assert.Throws<TypeLoadException>(delegate () { var v = a * "z"; });
        }

    }
}

