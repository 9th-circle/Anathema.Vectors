#if TEMPLATES_ENABLED
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Core
{
    /// <summary>
    /// A 2x2 (4 element) matrix where each element is a templated type. Nesting is allowed.
    /// </summary>
    public class tmat2<T>
    {
        public T[] data { get; set; } = new T[4];



    }
}
#endif