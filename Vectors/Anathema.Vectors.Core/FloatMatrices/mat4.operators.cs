﻿
#if FLOATS_ENABLED
#if THREED_ENABLED

namespace Anathema.Vectors.Core
{
    public partial class mat4
    {
        public new mat4 transposed
        {
            get
            {
                mat4 output = new mat4();
                for (int x = 0; x < xLength; x++)
                    for (int y = 0; y < yLength; y++)
                        output.setValue(x, y, getValue(y, x));
                return output;
            }
        }
        public override void transpose()
        {
            assign(transposed);
        }
        //todo: ==/!= operators


        public void assign(mat4 other)
        {
            for (int i = 0; i < other.data.Length && i < data.Length; i++)
                data[i] = other.data[i];
        }

    }
}
#endif
#endif