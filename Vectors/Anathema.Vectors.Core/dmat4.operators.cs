using System;
using System.Collections.Generic;
using System.Text;

namespace Anathema.Vectors.Core
{
    public partial class dmat4
    {
        public new dmat4 transposed
        {
            get
            {
                dmat4 output = new dmat4();
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

        public void assign(dmat4 other)
        {
            for (int i = 0; i < other.data.Length && i < data.Length; i++)
                data[i] = other.data[i];
        }

    }
}
