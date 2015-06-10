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
				Text = TitleText,
				Font = Font.SystemFontOfSize (30)
					.WithAttributes (FontAttributes.Bold),
				HorizontalOptions = LayoutOptions.Center
			};

		}

		private View BuildListView() {

			// Assemble an array of NamedColor objects.
			string[] menuItems = 
			{
				"My Accounts",
				"Profile",
				"Logout",
			};

			// Create ListView for the master page.
			var listView = new ListView
			{
				ItemsSource = menuItems
			};

			// Define a selected handler for the ListView.
			listView.ItemSelected += (sender, args) =>
			{
				// Set the BindingContext of the detail page.
				this.DetailPage.BindingContext = args.SelectedItem;

				// Show the detail page.
				this.RootPage.IsPresented = false;
			};

			// Initialize the ListView selection.
			listView.SelectedItem = menuItems[0];

			return listView;
		}
	}
}

