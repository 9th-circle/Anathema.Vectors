using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Core
{

    /// <summary>
    /// A 3x3 (9 element) matrix where each element is a templated type. Nesting is allowed.
    /// </summary>
    internal class tmat3 <T> : tmat2<T>
    {
        public tmat3()
        {
            data = new T[9];
        }






    }
}
