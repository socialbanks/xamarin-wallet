using System;
using Xamarin.Forms;

namespace SocialBanks.Shared
{
	public class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			this.BindingContext = new LoginViewModel(this.Navigation);

			this.BackgroundColor = AppStyle.BackgroundColor;

			var layout = new StackLayout { Padding = 10 };

			var label = new Label
			{
				Text = "Connect with Your Data",
				FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
				TextColor = AppStyle.TextColor,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				XAlign = TextAlignment.Center, // Center the text in the blue box.
				YAlign = TextAlignment.Center, // Center the text in the blue box.
			};

			layout.Children.Add(label);

			var username = new Entry { Placeholder = "Username" };
			username.SetBinding(Entry.TextProperty, LoginViewModel.UsernamePropertyName);
			layout.Children.Add(username);

			var password = new Entry { Placeholder = "Password", IsPassword = true };
			password.SetBinding(Entry.TextProperty, LoginViewModel.PasswordPropertyName);
			layout.Children.Add(password);



			var button = new Button { Text = "Sign In", TextColor = AppStyle.TextColor };
			button.SetBinding(Button.CommandProperty, LoginViewModel.LoginCommandPropertyName);

			layout.Children.Add(button);

			this.Content = new ScrollView { Content = layout };
		}
	}
}


