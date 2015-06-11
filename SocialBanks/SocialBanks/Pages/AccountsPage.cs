using System;
using Xamarin.Forms;
using System.Collections.Generic;

namespace SocialBanks.Shared
{
	public class AccountsPage : ContentPage
	{
		IList<Wallet> MyWallets;

		public AccountsPage ()
		{
			MyWallets = ServiceProvider.Instance.SocialBankAPI.FindMyWallets ("TODO: <user id>");


			//this.BackgroundColor = AppStyle.DesktopAreaColor;

			this.Content = new StackLayout {
				Children = {
					BuildListView()
				}
			};

		}

		ListView BuildListView ()
		{
			// Create ListView for the master page.
			var walletListView = new ListView {
				BackgroundColor = AppStyle.DesktopAreaColor,
				HasUnevenRows = true,
				ItemTemplate = new DataTemplate (typeof(AccountViewCell)),
				ItemsSource = MyWallets,
				SeparatorColor = AppStyle.DesktopAreaColor,
				IsPullToRefreshEnabled = true,
			};

			walletListView.ItemTapped += (sender, args) =>
			{
				if (args == null) return;

				((ListView)sender).SelectedItem = null;
			};


			walletListView.Refreshing += (sender, args) =>
			{
				//TODO Reload my accounts (wallets)
				System.Threading.Thread.Sleep(1000);

				((ListView)sender).IsRefreshing = false;
			};

			//Cancel the selection highlight 
			//walletListView.ItemSelected += (sender, args) =>
			//{
			//	walletListView.SelectedItem = null;
			//};


			return walletListView;
		}
	}
}

