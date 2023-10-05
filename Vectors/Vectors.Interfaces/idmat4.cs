using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors.Core
{
    /// <summary>
    /// A double-precision floating point, 4x4 (16 element) matrix.
    /// </summary>
    public interface idmat4 : idmat3
    {
        public new idmat4 transposed{ get; }
        public void assign(idmat4 other);
    }
}
