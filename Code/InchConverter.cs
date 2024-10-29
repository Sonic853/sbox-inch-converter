
namespace Sonic853.InchConverterLib
{
    public class InchConverter
    {
        public static float MToIn( float m )
        {
            return m * 39.3701f;
        }
        public static float MToCm( float m )
        {
            return m * 100f;
        }
        public static float CmToIn( float cm )
        {
            return cm * 0.393701f;
        }
        public static float CmToM( float cm )
        {
            return cm * 0.01f;
        }
        public static float InToM( float inch )
        {
            return inch * 0.0254f;
        }
        public static float InToCm( float inch )
        {
            return inch * 2.54f;
        }
    }
}
