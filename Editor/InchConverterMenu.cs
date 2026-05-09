using Editor;

namespace Sonic853.InchConverterLib.Editors
{
	public static class InchConverterMenu
	{
		[Menu( "Editor", "853Lab/Inch Converter" )]
		public static void OpenMyMenu()
		{
			var inchConverterWidget = InchConverterWidget.Instance;
			inchConverterWidget.Show();
		}
	}
}
