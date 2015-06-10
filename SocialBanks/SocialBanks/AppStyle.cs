using System;

namespace SocialBanks.Shared
{
	public static class AppStyle
	{
		private const int SOCIALBANKS_GREEN_RGB = 0x44BEB1;
		private const int LIGHT_GRAY = 0xCCCCCC;


		public static Xamarin.Forms.Color DesktopAreaColor = Helpers.Color.FromHex(LIGHT_GRAY).ToFormsColor();
		public static Xamarin.Forms.Color BackgroundColor = Helpers.Color.FromHex(SOCIALBANKS_GREEN_RGB).ToFormsColor();
		public static Xamarin.Forms.Color TextColor = Xamarin.Forms.Color.White;
	}
}

