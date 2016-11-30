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
	[Register ("AddCardViewController")]
	partial class AddCardViewController
	{
		[Outlet]
		UIKit.UIDatePicker datePicker { get; set; }

		[Outlet]
		UIKit.UITextView descriptionTextView { get; set; }

		[Outlet]
		UIKit.UITextField titleTextField { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (datePicker != null) {
				datePicker.Dispose ();
				datePicker = null;
			}

			if (descriptionTextView != null) {
				descriptionTextView.Dispose ();
				descriptionTextView = null;
			}

			if (titleTextField != null) {
				titleTextField.Dispose ();
				titleTextField = null;
			}
		}
	}
}
