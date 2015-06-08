﻿using System;
using System.Collections.Generic;
using System.Linq;

using SocialBanks.Shared;

using Foundation;
using UIKit;

namespace SocialBanks.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();

			LoadApplication (new AppSocialBanks ());

			return base.FinishedLaunching (app, options);
		}
	}
}

