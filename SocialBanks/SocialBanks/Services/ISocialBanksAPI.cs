using System;
using System.Collections.Generic;

namespace SocialBanks.Shared
{
	public interface ISocialBanksAPI
	{
		IList<Wallet> FindMyWallets (string userId);
	}
}

