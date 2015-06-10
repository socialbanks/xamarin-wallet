using System;
using Xamarin.Forms;

namespace SocialBanks.Shared
{
	public class AccountsPage : ContentPage //PageWithMenuBase
	{
		public AccountsPage ()
		{
			this.BackgroundColor = AppStyle.DesktopAreaColor;

			this.Content = new StackLayout {
				VerticalOptions = LayoutOptions.Center,
				Children = {
					new Label {
						TextColor = AppStyle.TextColor,
						XAlign = TextAlignment.Center,
						Text = "Hello, I'm Accounts Page!"
					}
				}
			};

		}
	}
}

