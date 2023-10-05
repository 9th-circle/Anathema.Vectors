using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Interfaces
{

    /// <summary>
    /// A 3x3 (9 element) matrix where each element is a templated type. Nesting is allowed.
    /// </summary>
    public interface itmat3 <T> : itmat2<T>
    {

    }
}
