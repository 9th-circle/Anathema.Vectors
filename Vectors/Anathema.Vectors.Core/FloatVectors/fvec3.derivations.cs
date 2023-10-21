using System;
#if THREED_ENABLED

#if FLOATS_ENABLED

namespace Anathema.Vectors.Core
{
    public partial class fvec3
    {
        /// <summary>
        /// How far the vector is from (0,0,0).
        /// </summary>
        public override float length => (float)Math.Sqrt((x * x) + (y * y) + (z * z));

        /// <summary>
        /// Returns a vector facing the same direction as this one, but with a length of 1.0.
        /// </summary>
        public new fvec3 normalised => this / length;

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
#endif
#endif