using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Interfaces
{
    /// <summary>
    /// A single-precision floating point, 4x4 (16 element) matrix.
    /// </summary>
    public interface ifmat4 : ifmat3
    {
        new ifmat4 transposed
        {
            get;
        }

        void assign(ifmat4 other);
    }
}
