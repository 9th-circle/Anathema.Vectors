﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Anathema.Vectors.Core
{
    public partial class fvec4
    {
        public fvec3 scaledToFVec3()
        {
            return new fvec3(x / w, y / w, z / w);
        }

        /// <summary>
        /// How far the vector is from (0,0,0).
        /// </summary>
        public override float length
        {
            get
            {
                return (float)Math.Sqrt((x * x) + (y * y) + (z * z) + (w * w));
            }
        }
        /// <summary>
        /// Returns a vector facing the same direction as this one, but with a length of 1.0.
        /// </summary>
        public new fvec4 normalised
        {
            get
            {
                return this / length;
            }
        }

        /// <summary>
        /// Preserves this vector's direction, but sets its length to 1.0.
        /// </summary>
        public override void normalise()
        {
            float f = length;
            x /= f;
            y /= f;
            z /= f;
        }
    }
}
