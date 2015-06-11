using System;

namespace SocialBanks.Shared
{
	public class Wallet : BaseObject
	{
		public string SocialBankId { get; set; }
		public string SocialBankName { get; set; }
		public string SocialBankLogoUrl { get; set; }
		public int BalanceInCents { get; set; }
		public string SocialBankPubKey { get; set; }
		public string LocalCurrency { 
			//TODO Get from Repository (API)
			get {
				return "R$";
			}
		}

		public string Balance {
			get {
				return ((decimal)BalanceInCents / 100m).ToString ("##.##");
			}
		}
	}
}

