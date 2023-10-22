#if FLOATS_ENABLED
namespace Anathema.Vectors.Core
{
    public partial class mat4
    {
#if NESTING_ENABLED
#if TEMPLATES_ENABLED
#if THREED_ENABLED
        //todo: check if this causes a transpose
        public static mat4 fromNestedVector(tvec4<tvec4<float>> input)
        {
            mat4 output = new mat4();
            output.setValue(0, 0, input.x.x);
            output.setValue(0, 1, input.x.y);
            output.setValue(0, 2, input.x.z);
            output.setValue(0, 3, input.x.w);

            output.setValue(1, 0, input.y.x);
            output.setValue(1, 1, input.y.y);
            output.setValue(1, 2, input.y.z);
            output.setValue(1, 3, input.y.w);

            output.setValue(2, 0, input.z.x);
            output.setValue(2, 1, input.z.y);
            output.setValue(2, 2, input.z.z);
            output.setValue(2, 3, input.z.w);

            output.setValue(3, 0, input.w.x);
            output.setValue(3, 1, input.w.y);
            output.setValue(3, 2, input.w.z);
            output.setValue(3, 3, input.w.w);

            return output;
        }
#endif
#endif
#endif
    }
}
#endif