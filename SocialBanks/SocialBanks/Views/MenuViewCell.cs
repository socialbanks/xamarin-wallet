using System;
using Xamarin.Forms;

namespace SocialBanks.Shared
{
	public class MenuViewCell: ViewCell
	{
		public MenuViewCell ()
		{
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

