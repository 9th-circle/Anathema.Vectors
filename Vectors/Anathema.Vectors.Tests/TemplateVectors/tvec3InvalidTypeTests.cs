using Anathema.Vectors.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Anathema.Vectors.Tests.TemplateVectors
{
    public class tvec3InvalidTypeTests
    {
        [Fact]
        public void invalidOperators()
        {
            tvec3<string> a = new tvec3<string>("a", "b", "c");
            tvec3<string> b = new tvec3<string>("c", "d", "e");

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
