// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace Slider
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel myLabel { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UISlider mySlider { get; set; }

        [Action ("ChangeSliderValue:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ChangeSliderValue (UIKit.UISlider sender);

        void ReleaseDesignerOutlets ()
        {
            if (myLabel != null) {
                myLabel.Dispose ();
                myLabel = null;
            }

            if (mySlider != null) {
                mySlider.Dispose ();
                mySlider = null;
            }
        }
    }
}