// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace AlertControlApp
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnActionSheet { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnSimpleAlert { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel MyLabel { get; set; }

        [Action ("BtnActionSheet_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnActionSheet_TouchUpInside (UIKit.UIButton sender);

        [Action ("BtnSimpleAlert_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnSimpleAlert_TouchUpInside (UIKit.UIButton sender);

        [Action ("UIButton206_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void UIButton206_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnActionSheet != null) {
                btnActionSheet.Dispose ();
                btnActionSheet = null;
            }

            if (btnSimpleAlert != null) {
                btnSimpleAlert.Dispose ();
                btnSimpleAlert = null;
            }

            if (MyLabel != null) {
                MyLabel.Dispose ();
                MyLabel = null;
            }
        }
    }
}