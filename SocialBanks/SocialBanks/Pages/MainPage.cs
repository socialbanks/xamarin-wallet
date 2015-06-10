using System;

using Xamarin.Forms;

//http://developer.xamarin.com/guides/cross-platform/xamarin-forms/controls/pages/

namespace SocialBanks.Shared
{
	public class MainPage : MasterDetailPage
	{
		public MainPage ()
		{
			this.BackgroundColor = AppStyle.BackgroundColor;

			// Create the detail page using NamedColorPage and wrap it in a
			// navigation page to provide a NavigationBar and Toggle button
			/*
			this.Detail = new NavigationPage(new AccountsPage()) 
			{
				BarBackgroundColor = AppStyle.BackgroundColor,
				BarTextColor = Color.White
			};
			*/
			// Create the master page with the ListView of menu items
			this.Master = new MenuMasterPage(this);

//			ShowLoginDialog();    

		}

		async void ShowLoginDialog()
		{
			var loginPage = new LoginPage();

			await Navigation.PushModalAsync(loginPage);
		}

	}

}


