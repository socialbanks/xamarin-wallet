using System;

using Xamarin.Forms;

namespace SocialBanks.Shared
{
	public class RootPage : ContentPage
	{
		public RootPage ()
		{
			this.BackgroundColor = AppStyle.BackgroundColor;

			ShowLoginDialog();    


			Content = new StackLayout {
				VerticalOptions = LayoutOptions.Center,
				Children = {
					new Label {
						TextColor = AppStyle.TextColor,
						XAlign = TextAlignment.Center,
						Text = "Hello, I'm RootPage!"
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


