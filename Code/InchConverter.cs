
namespace Sonic853.InchConverterLib
{
    public static class InchConverter
    {
        public static float MToIn( float m ) => m * 39.3701f;
        public static float MToCm( float m ) => m * 100f;
        public static float CmToIn( float cm ) => cm * 0.393701f;
        public static float CmToM( float cm ) => cm * 0.01f;
        public static float InToM( float inch ) => inch * 0.0254f;
        public static float InToCm( float inch ) => inch * 2.54f;
        public static Vector3 MToIn( Vector3 m ) => m * 39.3701f;
        public static Vector3 MToCm( Vector3 m ) => m * 100f;
        public static Vector3 CmToIn( Vector3 cm ) => cm * 0.393701f;
        public static Vector3 CmToM( Vector3 cm ) => cm * 0.01f;
        public static Vector3 InToM( Vector3 inch ) => inch * 0.0254f;
        public static Vector3 InToCm( Vector3 inch ) => inch * 2.54f;
        public static Vector2 MToIn( Vector2 m ) => m * 39.3701f;
        public static Vector2 MToCm( Vector2 m ) => m * 100f;
        public static Vector2 CmToIn( Vector2 cm ) => cm * 0.393701f;
        public static Vector2 CmToM( Vector2 cm ) => cm * 0.01f;
        public static Vector2 InToM( Vector2 inch ) => inch * 0.0254f;
        public static Vector2 InToCm( Vector2 inch ) => inch * 2.54f;
        public static Vector3 ToM( this Vector3 inch ) => inch * 0.0254f;
        public static Vector3 ToIn( this Vector3 m ) => m * 39.3701f;
    }
}
