using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Core
{
    /// <summary>
    /// Interace to a double-precision floating point, 4x4 (16 element) matrix.
    /// </summary>
    public interface idmat4 : idmat3
    {
        new idmat4 transposed{ get; }
        void assign(idmat4 other);
    }
}
