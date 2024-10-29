# s&box Inch Converter

![Snipaste_2024-10-29_22-59-42](https://github.com/user-attachments/assets/36c73d74-9e48-4e43-825c-a3d429dd8d10)

![Snipaste_2024-10-29_22-48-35](https://github.com/user-attachments/assets/19d3192d-05ff-428d-860e-13387710cd24)

## How to use?
```CSharp
using Sonic853.InchConverterLib;

var m = InchConverter.InToM(1);
Log.Info($"m:{m}");
var inch = InchConverter.MToIn(1);
Log.Info($"in:{inch}");

Log.Info($"LocalPosition(M):{LocalPosition.ToM()}");

LocalPosition = new Vector3( 1, 1, 1 ).ToIn();
Log.Info($"new Position:{LocalPosition}");

var distance = Vector3.Direction(pointA, pointB);
Log.Info($"distance(M):{distance.ToM()}");
```
