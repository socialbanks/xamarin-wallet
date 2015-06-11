﻿using System;

using Xamarin.Forms;

namespace SocialBanks.Shared
{
	public class AppSocialBanks : Application
	{
		static public int ScreenWidth;
		static public int ScreenHeight;

		public AppSocialBanks ()
		{
			this.MainPage = new MainPage();
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

