using NUnit.Framework;
using System;

namespace FMBitcoinLib.Tests
{
	[TestFixture ()]
	public class Test
	{
		[Test ()]
		public void TransactionHelperClassExists ()
		{
			var transHelper = new TransactionHelper ();

			Assert.IsNotNull (transHelper);
		}
	}
}

