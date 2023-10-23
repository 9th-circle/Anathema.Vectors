using Anathema.Vectors.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Anathema.Vectors.Tests.TemplateVectors
{
    public class tvec4InvalidTypeTests
    {
        [Fact]
        public void invalidOperators()
        {
            tvec4<string> a = new tvec4<string>("a", "b", "c", "d");
            tvec4<string> b = new tvec4<string>("c", "d", "e", "f");

            Assert.Throws<TypeLoadException>(delegate { var v = -a; });

            Assert.Throws<TypeLoadException>(delegate { var v = a + b; });
            Assert.Throws<TypeLoadException>(delegate { var v = a - b; });
            Assert.Throws<TypeLoadException>(delegate { var v = a / b; });
            Assert.Throws<TypeLoadException>(delegate { var v = a * b; });

            Assert.Throws<TypeLoadException>(delegate { var v = a + "z"; });
            Assert.Throws<TypeLoadException>(delegate { var v = a - "z"; });
            Assert.Throws<TypeLoadException>(delegate { var v = a / "z"; });
            Assert.Throws<TypeLoadException>(delegate { var v = a * "z"; });

            Assert.Throws<TypeLoadException>(delegate { var v = "z" + a; });
            Assert.Throws<TypeLoadException>(delegate { var v = "z" - a; });
            Assert.Throws<TypeLoadException>(delegate { var v = "z" / a; });
            Assert.Throws<TypeLoadException>(delegate { var v = "z" * a; });
        }

    }
}
