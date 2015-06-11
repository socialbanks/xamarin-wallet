using System;
using Xamarin.Forms;

namespace SocialBanks.Shared
{
	public class MenuViewCell: ViewCell
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

