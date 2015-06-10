using System;

using Xamarin.Forms;

//http://developer.xamarin.com/guides/cross-platform/xamarin-forms/controls/pages/

namespace SocialBanks.Shared
{
	public class MainPage : ContentPage
	{
		public MainPage ()
		{
			this.BackgroundColor = AppStyle.BackgroundColor;

			ShowLoginDialog();    


			Content = new StackLayout {
				VerticalOptions = LayoutOptions.Center,
				Children = {
					new Label {
						TextColor = AppStyle.TextColor,
						XAlign = TextAlignment.Center,
						Text = "Hello, I'm MainPage!"
					}
				}
			};

		}

		async void ShowLoginDialog()
		{
			var loginPage = new LoginPage();

			await Navigation.PushModalAsync(loginPage);
		}

	}

}


