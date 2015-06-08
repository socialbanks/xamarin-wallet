using System;
using Xamarin.Forms;
using System.Threading.Tasks;

namespace SocialBanks.Shared
{
	public class LoginViewModel : BaseViewModel
	{
		private INavigation navigation;
		public LoginViewModel(INavigation navigation)
		{
			this.navigation = navigation;
		}

		public const string UsernamePropertyName = "Username";
		private string username = string.Empty;
		public string Username
		{
			get { return username; }
			set { SetProperty(ref username, value, UsernamePropertyName); }
		}

		public const string PasswordPropertyName = "Password";
		private string password = string.Empty;
		public string Password
		{
			get { return password; }
			set { SetProperty(ref password, value, PasswordPropertyName); }
		}

		private Command loginCommand;
		public const string LoginCommandPropertyName = "LoginCommand";
		public Command LoginCommand
		{
			get
			{
				return loginCommand ?? (loginCommand = new Command(async () => await ExecuteLoginCommand()));
			}
		}

		protected async Task ExecuteLoginCommand()
		{
			//do something...

			await navigation.PopModalAsync();
		}

	}
}

