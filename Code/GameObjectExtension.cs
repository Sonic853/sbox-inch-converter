using Sandbox;

namespace Sonic853.InchConverterLib.Extensions
{
    public static class GameObjectExtension
    {
        extension(GameObject gameObject)
        {
            /// <summary>
            /// Get: Inch to Meter<br />
            /// Set: Meter to Inch
            /// </summary>
            public Vector3 LocalPositionMeter
            {
                get => gameObject.LocalPosition.ToM();
                set => gameObject.LocalPosition = value.ToIn();
            }
            /// <summary>
            /// Get: Inch to Meter<br />
            /// Set: Meter to Inch
            /// </summary>
            public Vector3 WorldPositionMeter
            {
                get => gameObject.WorldPosition.ToM();
                set => gameObject.WorldPosition = value.ToIn();
            }
        }
    }
}
