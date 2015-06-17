using System;
using Xamarin.Forms;

namespace SocialBanks.Shared
{
	public static class AppStyle
	{
		private const int SOCIALBANKS_GREEN = 0x44BEB1;
		private const int LIGHT_GRAY = 0xCCCCCC;
		private const int DARK_GRAY = 0x333333;
		private const int GREEN = 0x83CB71;


		public static Xamarin.Forms.Color DesktopAreaColor = Helpers.Color.FromHex(LIGHT_GRAY).ToFormsColor();
		public static Xamarin.Forms.Color BackgroundColor = Helpers.Color.FromHex(SOCIALBANKS_GREEN).ToFormsColor();
		public static Xamarin.Forms.Color TextColor = Xamarin.Forms.Color.White;
		public static Xamarin.Forms.Color AdditionalButtonBackgroundColor = Helpers.Color.FromHex(DARK_GRAY).ToFormsColor();
		public static Xamarin.Forms.Color BalanceColor = Helpers.Color.FromHex(GREEN).ToFormsColor();
		public static string DefaultFontName {
			get {
				//return Device.OS == TargetPlatform.iOS ? "DINCondensed-Bold" : "Droid Sans Mono";
				return "DINCondensed-Bold";
			}
		}
	}
}

