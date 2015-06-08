using System;

using Xamarin.Forms;

namespace SocialBanks.Shared
{
	public class AppSocialBanks : Application
	{
		public AppSocialBanks ()
		{
			MainPage = new RootPage();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

