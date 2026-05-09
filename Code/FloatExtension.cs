namespace Sonic853.InchConverterLib.Extensions
{
    public static class FloatExtension
    {
        extension(ref float floatValue)
        {
            /// <summary>
            /// Get: Inch to Meter<br />
            /// Set: Meter to Inch
            /// </summary>
            public float Meter
            {
                get => floatValue.ToM();
                set => floatValue = value.ToIn();
            }
        }
    }
}
