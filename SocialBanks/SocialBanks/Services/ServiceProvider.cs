using System;

namespace SocialBanks.Shared
{
	public class ServiceProvider
	{
		readonly SocialBanksAPIMock SocialBanksAPIMock = new SocialBanksAPIMock (); 

		static ServiceProvider mInstance;
		public static ServiceProvider Instance {
			get {
				if (ServiceProvider.mInstance == null)
					ServiceProvider.mInstance = new ServiceProvider ();

				return ServiceProvider.mInstance;
			}
		}


		public ISocialBanksAPI SocialBankAPI {
			get {
				return SocialBanksAPIMock;
			}
		}
	}
}

