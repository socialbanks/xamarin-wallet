using System;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace SocialBanks.Shared
{
	public class MenuMasterPage : ContentPage
	{
		public const string TitleText = "Menu";
		private MasterDetailPage RootPage;

		private ListView MenuListView;
		private MenuItem[] MenuItems;

		public MenuMasterPage (MasterDetailPage rootPage)
		{
			//if (detailPage == null)
			//	throw new Exception ("ERROR: MenuMasterPage can't have a null detailPage");
			if (rootPage == null)
				throw new Exception ("ERROR: MenuMasterPage can't have a null rootPage");

			//this.DetailPage = detailPage;
			RootPage = rootPage;

			Title = TitleText;
			BackgroundColor = Color.White;
			Icon = Device.OS == TargetPlatform.iOS ? "menu.png" : null;
			BuildListView ();

			this.Content = new StackLayout {
				Children = {
					BuildHeader(), 
					MenuListView
				}
			};

		}

		private View BuildHeader() {
			return new Label
			{
				Text = " ",
				FontSize = 30,
				FontAttributes = FontAttributes.Bold,
				HorizontalOptions = LayoutOptions.Center
			};
		}

		private ListView BuildListView() {

			// Assemble an array of NamedColor objects.
			MenuItems = new MenuItem[3];
			MenuItems [0] = new MenuItem { Index = 0, Text = "My Accounts" };
			MenuItems [1] = new MenuItem { Index = 1, Text = "Profile" };
			MenuItems [2] = new MenuItem { Index = 2, Text = "Logout" };


			// Create ListView for the master page.
			MenuListView = new ListView {
				HasUnevenRows = true,
				ItemTemplate = new DataTemplate (typeof(MenuViewCell)),
				ItemsSource = MenuItems,
				SeparatorColor = Color.FromHex ("#ddd"),
			};

			// Define a selected handler for the ListView.
			MenuListView.ItemSelected += (sender, args) =>
			{
				var menuItem = args.SelectedItem as MenuItem;

				switch (menuItem.Index) 
				{
					case 0: 
						RootPage.Detail = new NavigationPage(new AccountsPage()) 
						{
							BarBackgroundColor = AppStyle.BackgroundColor,
							BarTextColor = Color.White
						};
						RootPage.IsPresented = false;
						break;
					case 1:
						RootPage.Detail = new NavigationPage(new ProfilePage()) 
						{
							BarBackgroundColor = AppStyle.BackgroundColor,
							BarTextColor = Color.White
						};
						RootPage.IsPresented = false;
						break;
					case 2:
						RootPage.IsPresented = false;
						Logout();
						break;
				}

			};

			// Initialize the ListView selection.
			MenuListView.SelectedItem = MenuItems[0];

			return MenuListView;
		}

		public void Logout ()
		{
			//TODO Logout - Clear authentication and private data

			//After login returns to the AccountsPage (the default item)
			MenuListView.SelectedItem = MenuItems[0];

			var loginPage = new LoginPage();
			Navigation.PushModalAsync(loginPage);

		}
	}

	public class MenuItem
	{
		public int Index { get; set; }
		public string Text { get; set; }
	}

	public class MenuViewCell:ViewCell
	{
		public MenuViewCell ()
		{
			/*
			var vetProfileImage = new CircleImage {
				BorderColor = App.BrandColor,
				BorderThickness = 2,
				HeightRequest = 50,
				WidthRequest = 50,
				Aspect = Aspect.AspectFill,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
			};
			vetProfileImage.SetBinding (Image.SourceProperty, "ImageSource");
			*/

			var textLabel = new Label () {
				FontFamily = "HelveticaNeue-Medium",
				FontSize = 18,
				TextColor = Color.Black
			};
			textLabel.SetBinding (Label.TextProperty, "Text");


			var cellLayout = new StackLayout {
				Spacing = 0,
				Padding = new Thickness (10, 5, 10, 5),
				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Children = { textLabel }
			};

			this.View = cellLayout;
		}
	}
}

