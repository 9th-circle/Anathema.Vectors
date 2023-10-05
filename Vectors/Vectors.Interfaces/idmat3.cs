using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Interfaces
{
    /// <summary>
    /// Interface to a double-precision floating point, 3x3 (9 element) matrix.
    /// </summary>
    public interface idmat3 : idmat2
    {
        void assign(idmat3 other);

    }
}
