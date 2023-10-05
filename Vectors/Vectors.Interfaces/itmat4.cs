using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Interfaces
{
    /// <summary>
    /// A 4x4 (16 element) matrix where each element is a templated type. Nesting is allowed.
    /// </summary>
    public interface itmat4<T> : itmat3<T>
    {

    }
}
