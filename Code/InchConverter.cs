
namespace Sonic853.InchConverterLib
{
    public static class InchConverter
    {
        const float mtocm = 100f;
        const float cmtom = 0.01f;
        const float intom = 0.0254f;
        const float intocm = 2.54f;
        const float mtoin = 100 / intocm;
        const float cmtoin = 1 / intocm;
        public static float MToIn( float m ) => m * mtoin;
        public static float MToCm( float m ) => m * mtocm;
        public static float CmToIn( float cm ) => cm * cmtoin;
        public static float CmToM( float cm ) => cm * cmtom;
        public static float InToM( float inch ) => inch * intom;
        public static float InToCm( float inch ) => inch * intocm;
        public static Vector3 MToIn( Vector3 m ) => m * mtoin;
        public static Vector3 MToCm( Vector3 m ) => m * mtocm;
        public static Vector3 CmToIn( Vector3 cm ) => cm * cmtoin;
        public static Vector3 CmToM( Vector3 cm ) => cm * cmtom;
        public static Vector3 InToM( Vector3 inch ) => inch * intom;
        public static Vector3 InToCm( Vector3 inch ) => inch * intocm;
        public static Vector2 MToIn( Vector2 m ) => m * mtoin;
        public static Vector2 MToCm( Vector2 m ) => m * mtocm;
        public static Vector2 CmToIn( Vector2 cm ) => cm * cmtoin;
        public static Vector2 CmToM( Vector2 cm ) => cm * cmtom;
        public static Vector2 InToM( Vector2 inch ) => inch * intom;
        public static Vector2 InToCm( Vector2 inch ) => inch * intocm;
        public static Vector3 ToM( this Vector3 inch ) => inch * intom;
        public static Vector3 ToIn( this Vector3 m ) => m * mtoin;
    }
}
