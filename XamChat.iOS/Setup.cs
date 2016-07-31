﻿using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.Core.ViewModels;
using MvvmCross.iOS.Platform;
using MvvmCross.Platform.Platform;
using UIKit;
using XamChat.iOS.Utilities;

namespace XamChat.iOS
{
	public class Setup : MvxIosSetup
	{
		public Setup(MvxApplicationDelegate applicationDelegate, UIWindow window)
			: base(applicationDelegate, window)
		{
		}

		/// <summary>Creates the application.</summary>
		/// <returns>The IMvxApplication <see langword="object"/></returns>
		protected override IMvxApplication CreateApp()
		{
			return new Core.App();
		}

		/// <summary>Creates the debug trace.</summary>
		/// <returns>The IMvxTrace <see langword="object"/></returns>
		protected override IMvxTrace CreateDebugTrace()
		{
			return new DebugTrace();
		}
	}
}