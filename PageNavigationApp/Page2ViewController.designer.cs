// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace PageNavigationApp
{
    [Register ("Page2ViewController")]
    partial class Page2ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField fieldName { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (fieldName != null) {
                fieldName.Dispose ();
                fieldName = null;
            }
        }
    }
}