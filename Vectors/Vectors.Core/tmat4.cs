#if TEMPLATES_ENABLED
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Core
{
    /// <summary>
    /// A 4x4 (16 element) matrix where each element is a templated type. Nesting is allowed.
    /// </summary>
    internal class tmat4<T> : tmat3<T>
    {
        public tmat4()
        {
            data = new T[16];
        }






    }
}
#endif