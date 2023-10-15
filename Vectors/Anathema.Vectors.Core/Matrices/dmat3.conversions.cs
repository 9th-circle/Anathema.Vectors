#if DOUBLES_ENABLED
#if THREED_ENABLED
namespace Anathema.Vectors.Core
{
    public partial class dmat3
    {
        //todo: check if this causes a transpose
#if NESTING_ENABLED
#if TEMPLATES_ENABLED
        public static dmat3 fromNestedVector(tvec3<tvec3<double>> input)
        {
            dmat4 output = new dmat4();
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
#endif
    }
}
#endif
#endif