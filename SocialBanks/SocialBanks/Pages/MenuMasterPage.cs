using System;
using Xamarin.Forms;

namespace SocialBanks.Shared
{
	public class MenuMasterPage : ContentPage
	{
		public const string TitleText = "Menu";
		private Page DetailPage;
		private MasterDetailPage RootPage;

		public MenuMasterPage (MasterDetailPage rootPage, Page detailPage)
		{
			if (detailPage == null)
				throw new Exception ("ERROR: MenuMasterPage can't have a null detailPage");
			if (rootPage == null)
				throw new Exception ("ERROR: MenuMasterPage can't have a null rootPage");

			this.DetailPage = detailPage;
			this.RootPage = rootPage;

			this.Title = TitleText;
			this.BackgroundColor = Color.White;
			this.Icon = Device.OS == TargetPlatform.iOS ? "menu.png" : null;

			this.Content = new StackLayout {
				Children = {
					BuildHeader(), 
					BuildListView()
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

		private View BuildListView() {

			// Assemble an array of NamedColor objects.
			MenuItem[] menuItems = 
			{
				new MenuItem { Index = 0, Text = "My Accounts" },
				new MenuItem { Index = 1, Text = "Profile" },
				new MenuItem { Index = 2, Text = "Logout" },
			};


			// Create ListView for the master page.
			var listView = new ListView {
				HasUnevenRows = true,
				ItemTemplate = new DataTemplate (typeof(MenuViewCell)),
				ItemsSource = menuItems,
				SeparatorColor = Color.FromHex ("#ddd"),
			};

			// Define a selected handler for the ListView.
			listView.ItemSelected += (sender, args) =>
			{
				var menuItem = args.SelectedItem as MenuItem;

				switch (menuItem.Index) 
				{
					case 0: 
						this.DetailPage.BindingContext = menuItem;
						break;
					case 1:
						this.DetailPage.BindingContext = menuItem;
						break;
					case 2:
						this.DetailPage.BindingContext = menuItem;
						break;
				}


				// Show the detail page.
				this.RootPage.IsPresented = false;
			};

			// Initialize the ListView selection.
			listView.SelectedItem = menuItems[0];

			return listView;
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

