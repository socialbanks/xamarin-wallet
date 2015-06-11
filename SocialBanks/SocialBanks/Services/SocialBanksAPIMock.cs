using System;
using System.Collections.Generic;

namespace SocialBanks.Shared
{
	public class SocialBanksAPIMock : ISocialBanksAPI
	{
		private IList<Wallet> MyWallets = new List<Wallet>();


		public SocialBanksAPIMock ()
		{
			LoadMyWallets ();
		}

		public IList<Wallet> FindMyWallets (string userId)
		{
			return MyWallets;
		}


		private void LoadMyWallets ()
		{
			MyWallets.Add (new Wallet {
				SocialBankId = "wRYoCHo6Bq",
				SocialBankName = "Brazuca Bank",
				SocialBankLogoUrl = "http://files.parsetfss.com/0844077a-6f3b-462c-9a12-45e6b9f433e0/tfss-008938e9-124e-43e6-b7cb-e4d57c2e8d11-Brazuca.jpg",
				BalanceInCents = 494,
				SocialBankPubKey = "0213cc3e8aa13da9fdced6ac55737984b71a0ea6a9c1817cc15f687163813e44c8" 					
			});

			MyWallets.Add (new Wallet {
				SocialBankId = "928iOJTp8y",
				SocialBankName = "Pank Coin",
				SocialBankLogoUrl = "http://files.parsetfss.com/0844077a-6f3b-462c-9a12-45e6b9f433e0/tfss-feba9f97-126e-4dd4-9712-97ba32566bec-Punkcoin.jpg",
				BalanceInCents = 2301,
				SocialBankPubKey = "0241372cb7c022554a88f2d338ef721539108d985fa5f48ed950ffecfd337f2ae7" 					
			});
		}
	}
}

