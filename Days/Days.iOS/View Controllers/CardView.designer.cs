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
	[Register ("CardView")]
	partial class CardView
	{
		[Outlet]
		UIKit.UITextView descriptionTextView { get; set; }

		[Outlet]
		UIKit.UILabel titleLabel { get; set; }

		[Outlet]
		UIKit.UILabel yearLabel { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (yearLabel != null) {
				yearLabel.Dispose ();
				yearLabel = null;
			}

			if (titleLabel != null) {
				titleLabel.Dispose ();
				titleLabel = null;
			}

			if (descriptionTextView != null) {
				descriptionTextView.Dispose ();
				descriptionTextView = null;
			}
		}
	}
}
