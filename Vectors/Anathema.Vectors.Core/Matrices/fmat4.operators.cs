using System;
using System.Collections.Generic;
using System.Text;

namespace Anathema.Vectors.Core
{
    public partial class fmat4
    {
        public new fmat4 transposed
        {
            get
            {
                fmat4 output = new fmat4();
                for (int x = 0; x < rowCount; x++)
                    for (int y = 0; y < columnCount; y++)
                        output.setValue(x, y, getValue(y, x));
                return output;
            }
        }
        public override void transpose()
        {
            assign(transposed);
        }

        public void assign(fmat4 other)
        {
            for (int i = 0; i < other.data.Length && i < data.Length; i++)
                data[i] = other.data[i];
        }

    }
}
