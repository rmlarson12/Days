// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Days.iOS
{
	[Register("DayViewController")]
	partial class DayViewController
	{
		[Outlet]
		UIKit.UIButton currentDateButton { get; set; }

		[Action("currentDateButtonClicked:")]
		partial void currentDateButtonClicked(Foundation.NSObject sender);

		void ReleaseDesignerOutlets()
		{
			if (currentDateButton != null)
			{
				currentDateButton.Dispose();
				currentDateButton = null;
			}
		}
	}
}
