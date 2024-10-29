
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
        /// <summary>
        /// Meter to Inch
        /// </summary>
        /// <param name="m">Meter</param>
        /// <returns>Inch</returns>
        public static float MToIn( float m ) => m * mtoin;
        /// <summary>
        /// Meter to Centimeter
        /// </summary>
        /// <param name="m">Meter</param>
        /// <returns>Centimeter</returns>
        public static float MToCm( float m ) => m * mtocm;
        /// <summary>
        /// Centimeter to Inch
        /// </summary>
        /// <param name="cm">Centimeter</param>
        /// <returns>Inch</returns>
        public static float CmToIn( float cm ) => cm * cmtoin;
        /// <summary>
        /// Centimeter to Meter
        /// </summary>
        /// <param name="cm">Centimeter</param>
        /// <returns>Meter</returns>
        public static float CmToM( float cm ) => cm * cmtom;
        /// <summary>
        /// Inch to Meter
        /// </summary>
        /// <param name="inch">Inch</param>
        /// <returns>Meter</returns>
        public static float InToM( float inch ) => inch * intom;
        /// <summary>
        /// Inch to Centimeter
        /// </summary>
        /// <param name="inch">Inch</param>
        /// <returns>Centimeter</returns>
        public static float InToCm( float inch ) => inch * intocm;
        /// <summary>
        /// Meter to Inch
        /// </summary>
        /// <param name="m">Meter</param>
        /// <returns>Inch</returns>
        public static Vector3 MToIn( Vector3 m ) => m * mtoin;
        /// <summary>
        /// Meter to Centimeter
        /// </summary>
        /// <param name="m">Meter</param>
        /// <returns>Centimeter</returns>
        public static Vector3 MToCm( Vector3 m ) => m * mtocm;
        /// <summary>
        /// Centimeter to Inch
        /// </summary>
        /// <param name="cm">Centimeter</param>
        /// <returns>Inch</returns>
        public static Vector3 CmToIn( Vector3 cm ) => cm * cmtoin;
        /// <summary>
        /// Centimeter to Meter
        /// </summary>
        /// <param name="cm">Centimeter</param>
        /// <returns>Meter</returns>
        public static Vector3 CmToM( Vector3 cm ) => cm * cmtom;
        /// <summary>
        /// Inch to Meter
        /// </summary>
        /// <param name="inch">Inch</param>
        /// <returns>Meter</returns>
        public static Vector3 InToM( Vector3 inch ) => inch * intom;
        /// <summary>
        /// Inch to Centimeter
        /// </summary>
        /// <param name="inch">Inch</param>
        /// <returns>Centimeter</returns>
        public static Vector3 InToCm( Vector3 inch ) => inch * intocm;
        /// <summary>
        /// Meter to Inch
        /// </summary>
        /// <param name="m">Meter</param>
        /// <returns>Inch</returns>
        public static Vector2 MToIn( Vector2 m ) => m * mtoin;
        /// <summary>
        /// Meter to Centimeter
        /// </summary>
        /// <param name="m">Meter</param>
        /// <returns>Centimeter</returns>
        public static Vector2 MToCm( Vector2 m ) => m * mtocm;
        /// <summary>
        /// Centimeter to Inch
        /// </summary>
        /// <param name="cm">Centimeter</param>
        /// <returns>Inch</returns>
        public static Vector2 CmToIn( Vector2 cm ) => cm * cmtoin;
        /// <summary>
        /// Centimeter to Meter
        /// </summary>
        /// <param name="cm">Centimeter</param>
        /// <returns>Meter</returns>
        public static Vector2 CmToM( Vector2 cm ) => cm * cmtom;
        /// <summary>
        /// Inch to Meter
        /// </summary>
        /// <param name="inch">Inch</param>
        /// <returns>Meter</returns>
        public static Vector2 InToM( Vector2 inch ) => inch * intom;
        /// <summary>
        /// Inch to Centimeter
        /// </summary>
        /// <param name="inch">Inch</param>
        /// <returns>Centimeter</returns>
        public static Vector2 InToCm( Vector2 inch ) => inch * intocm;
        /// <summary>
        /// Inch to Meter
        /// </summary>
        /// <returns>Meter</returns>
        public static Vector3 ToM( this Vector3 inch ) => inch * intom;
        /// <summary>
        /// Meter to Inch
        /// </summary>
        /// <returns>Inch</returns>
        public static Vector3 ToIn( this Vector3 m ) => m * mtoin;
        /// <summary>
        /// Inch to Meter
        /// </summary>
        /// <returns>Meter</returns>
        public static Vector2 ToM( this Vector2 inch ) => inch * intom;
        /// <summary>
        /// Meter to Inch
        /// </summary>
        /// <returns>Inch</returns>
        public static Vector2 ToIn( this Vector2 m ) => m * mtoin;
        /// <summary>
        /// Inch to Meter
        /// </summary>
        /// <returns>Meter</returns>
        public static float ToM( this float inch ) => inch * intom;
        /// <summary>
        /// Meter to Inch
        /// </summary>
        /// <returns>Inch</returns>
        public static float ToIn( this float m ) => m * mtoin;
    }
}
