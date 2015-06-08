using System;

namespace SocialBanks.Shared
{
	public static class AppStyle
	{
		private const int SOCIALBANKS_GREEN_RGB = 0x44BEB1;


		public static Xamarin.Forms.Color BackgroundColor = Helpers.Color.FromHex(SOCIALBANKS_GREEN_RGB).ToFormsColor();
		public static Xamarin.Forms.Color TextColor = Xamarin.Forms.Color.White;
	}
}

