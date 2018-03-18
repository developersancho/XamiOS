// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace HelloWorld
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton btnDsc { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelDsc { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISwitch switchDsc { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField textDsc { get; set; }

        [Action ("BtnDsc_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BtnDsc_TouchUpInside (UIKit.UIButton sender);

        [Action ("MySwitchValueChanged:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void MySwitchValueChanged (UIKit.UISwitch sender);

        void ReleaseDesignerOutlets ()
        {
            if (btnDsc != null) {
                btnDsc.Dispose ();
                btnDsc = null;
            }

            if (labelDsc != null) {
                labelDsc.Dispose ();
                labelDsc = null;
            }

            if (switchDsc != null) {
                switchDsc.Dispose ();
                switchDsc = null;
            }

            if (textDsc != null) {
                textDsc.Dispose ();
                textDsc = null;
            }
        }
    }
}