using System;
using Xamarin.Forms;

namespace SocialBanks.Shared
{
	public class AccountViewCell: ViewCell
	{
		public AccountViewCell ()
		{
			var accountView = BuildViewForAccountData ();
			var commandsView = BuildViewForCommands ();

			var cellLayout = new StackLayout {
				Spacing = 0,
				Padding = new Thickness(10, 5, 10, 3),
				Orientation = StackOrientation.Vertical,
				Children = { accountView, commandsView },
			};
				
			this.View = cellLayout;

		}

		public View BuildViewForAccountData()
		{
			//SocialBankName
			var labelSocialBankName = new Label () {
				FontFamily = AppStyle.DefaultFontName,
				FontSize = 24,
				TextColor = Color.Gray,
			};
			labelSocialBankName.SetBinding (Label.TextProperty, "SocialBankName");

			var line = new StackLayout {
				HorizontalOptions = LayoutOptions.Center,
				Padding = new Thickness(0,0,0,10),
				Children = {
					new BoxView() { 
					Color = Color.Gray, 
					WidthRequest = AppSocialBanks.ScreenWidth - 40, 
					HeightRequest = 1 
					},
				},
			};

			//Caption "Balance"
			var labelCaptionBalance = new Label () {
				Text = "CURRENT BALANCE",
				FontFamily = AppStyle.DefaultFontName,
				FontSize = 12,
				TextColor = Color.Gray,
			};

			//LocalCurrency
			var labelLocalCurrency = new Label () {
				FontFamily = AppStyle.DefaultFontName,
				FontSize = 36,
				TextColor = Color.Black,
			};
			labelLocalCurrency.SetBinding (Label.TextProperty, "LocalCurrency");


			//Balance
			var labelBalance = new Label () {
				FontFamily = AppStyle.DefaultFontName,
				FontSize = 36,
				TextColor = AppStyle.BalanceColor,
			};
			labelBalance.SetBinding (Label.TextProperty, "Balance");

			//SocailBanks image logo
			var imageLogo = new Image {
				HeightRequest = 40,
				WidthRequest = 40,
				Aspect = Aspect.AspectFill,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
			};
			imageLogo.SetBinding (Image.SourceProperty, "SocialBankLogoUrl");

			//Compose the local currency with the balance (p.e., R$ 4.97)
			var layoutBalance = new StackLayout () {
				Padding = new Thickness(0, 5, 0, 0),
				Spacing = 10,
				Orientation = StackOrientation.Horizontal,
				Children = { labelLocalCurrency, labelBalance }
			};

			//Compose the balance with the socialbank logo
			var layoutBalanceWithLogo = new RelativeLayout ();
			layoutBalanceWithLogo.Children.Add(layoutBalance, 
				Constraint.RelativeToParent((parent) => 0)
			);			
			layoutBalanceWithLogo.Children.Add(imageLogo, 
				Constraint.RelativeToParent((parent) => parent.Width - imageLogo.Width - 35) //TODO This isnt working with all devices
			);

			//PAY NOW Button
			var buttonPayNow = new Button {
				Text = "PAY NOW",
				BackgroundColor = AppStyle.BalanceColor,
				TextColor = Color.White,
				FontFamily = AppStyle.DefaultFontName,
				FontSize = 18,
				HeightRequest = 32,
				VerticalOptions = LayoutOptions.Center,
				//Image = ...
			};

			var dataLayout = new StackLayout {
				Spacing = 0,
				BackgroundColor = Color.White,
				Children = { labelSocialBankName, line, labelCaptionBalance, layoutBalanceWithLogo, buttonPayNow },
				Orientation = StackOrientation.Vertical,
			};

			return new Frame {
				Content = dataLayout,
				Padding = new Thickness(10),
				HasShadow = false,
				HorizontalOptions = LayoutOptions.FillAndExpand,
			};

		}

		private View BuildViewForCommands()
		{

			var buttonWidth = (AppSocialBanks.ScreenWidth - 50) / 3;

			var buttonStyle = new Style (typeof(Button)) {
				Setters = {
					new Setter { Property = Button.FontFamilyProperty, Value = AppStyle.DefaultFontName },
					new Setter { Property = Button.FontSizeProperty, Value = 12 },
					new Setter { Property = Button.BackgroundColorProperty, Value = AppStyle.AdditionalButtonBackgroundColor },
					new Setter { Property = Button.TextColorProperty, Value = Color.White },
					new Setter { Property = Button.BorderColorProperty, Value = Color.Black },
					new Setter { Property = Button.BorderWidthProperty, Value = 1 },
					new Setter { Property = Button.HeightRequestProperty, Value = 70 },
					new Setter { Property = Button.WidthRequestProperty, Value = buttonWidth },
				}
			};


			var buttonReceive = new Button {
				Text = "Receive",
				Style = buttonStyle,
				//Image = ...
			};

			var buttonSend = new Button {
				Text = "Send",
				Style = buttonStyle,
				//Image = ...
			};

			var buttonHistory = new Button {
				Text = "History",
				Style = buttonStyle,
				//Image = ...
			};

			var commandsLayout = new StackLayout {
				BackgroundColor = Color.Black,
				Padding = new Thickness(0),
				Spacing = 0,
				Orientation = StackOrientation.Horizontal,
				Children = { buttonReceive, buttonSend, buttonHistory }

			};

			return new Frame {
				Padding = new Thickness(0),
				Content = commandsLayout,
				HasShadow = false,
				HorizontalOptions = LayoutOptions.Center,
			};
		}

	}
}

