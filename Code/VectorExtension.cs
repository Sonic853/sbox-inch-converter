namespace Sonic853.InchConverterLib.Extensions
{
    public static class VectorExtension
    {
        extension(ref Vector3 vector3)
        {
            /// <summary>
            /// Get: Inch to Meter<br />
            /// Set: Meter to Inch
            /// </summary>
            public Vector3 Meter
            {
                get => vector3.ToM();
                set => vector3 = value.ToIn();
            }
        }
        extension(ref Vector2 vector2)
        {
            /// <summary>
            /// Get: Inch to Meter<br />
            /// Set: Meter to Inch
            /// </summary>
            public Vector2 Meter
            {
                get => vector2.ToM();
                set => vector2 = value.ToIn();
            }
        }
    }
}