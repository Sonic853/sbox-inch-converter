namespace Sonic853.InchConverterLib.Extensions;

public static class Transformxtension
{
    extension(Transform transform)
    {
        /// <summary>
        /// Get: Inch to Meter<br />
        /// Set: Meter to Inch
        /// </summary>
        public Vector3 PositionMeter
        {
            get => transform.Position.ToM();
            set => transform.Position = value.ToIn();
        }
    }
}
