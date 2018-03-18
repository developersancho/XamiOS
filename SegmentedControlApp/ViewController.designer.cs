// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace SegmentedControlApp
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelResult { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISegmentedControl MySegmentedControl { get; set; }

        [Action ("SegmentedControl_ValueChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void SegmentedControl_ValueChanged (UIKit.UISegmentedControl sender);

        void ReleaseDesignerOutlets ()
        {
            if (labelResult != null) {
                labelResult.Dispose ();
                labelResult = null;
            }

            if (MySegmentedControl != null) {
                MySegmentedControl.Dispose ();
                MySegmentedControl = null;
            }
        }
    }
}