// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace DZNEmptyDataSetSample
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIBarButtonItem clearColors { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIBarButtonItem loadColors { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISearchBar searchBar { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UISearchDisplayController searchDisplayController { get; set; }

		[Action ("OnToggleData:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void OnToggleData (UIBarButtonItem sender);

		void ReleaseDesignerOutlets ()
		{
			if (clearColors != null) {
				clearColors.Dispose ();
				clearColors = null;
			}
			if (loadColors != null) {
				loadColors.Dispose ();
				loadColors = null;
			}
			if (searchBar != null) {
				searchBar.Dispose ();
				searchBar = null;
			}
			if (searchDisplayController != null) {
				searchDisplayController.Dispose ();
				searchDisplayController = null;
			}
		}
	}
}
