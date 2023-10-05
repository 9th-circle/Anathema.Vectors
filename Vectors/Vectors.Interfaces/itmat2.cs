using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Interfaces
{
    /// <summary>
    /// A 2x2 (4 element) matrix where each element is a templated type. Nesting is allowed.
    /// </summary>
    public interface itmat2<T>
    {
        T[] data { get; set; }
    }
}
