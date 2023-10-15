namespace Anathema.Vectors.Core
{
    public partial class fmat3
    {
#if NESTING_ENABLED
        //todo: check if this causes a transpose
        public static fmat3 fromNestedVector(tvec3<tvec3<float>> input)
        {
            fmat4 output = new fmat4();
            output.setValue(0, 0, input.x.x);
            output.setValue(0, 1, input.x.y);
            output.setValue(0, 2, input.x.z);

            output.setValue(1, 0, input.y.x);
            output.setValue(1, 1, input.y.y);
            output.setValue(1, 2, input.y.z);

            output.setValue(2, 0, input.z.x);
            output.setValue(2, 1, input.z.y);
            output.setValue(2, 2, input.z.z);

            return output;
        }
#endif
    }
}
