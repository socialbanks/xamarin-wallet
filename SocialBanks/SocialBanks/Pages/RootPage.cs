using System;

using Xamarin.Forms;

namespace SocialBanks
{
	public class RootPage : ContentPage
	{
		public RootPage ()
		{
			Content = new StackLayout { 
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


