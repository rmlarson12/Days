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
	[Register ("AddCardView")]
	partial class AddCardView
	{
		[Outlet]
		UIKit.UITextField descriptionTextField { get; set; }

		[Outlet]
		UIKit.UIDatePicker eventDatePicker { get; set; }

		[Outlet]
		UIKit.UITextField titleTextField { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (descriptionTextField != null) {
				descriptionTextField.Dispose ();
				descriptionTextField = null;
			}

			if (eventDatePicker != null) {
				eventDatePicker.Dispose ();
				eventDatePicker = null;
			}

			if (titleTextField != null) {
				titleTextField.Dispose ();
				titleTextField = null;
			}
		}
	}
}
