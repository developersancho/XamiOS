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

namespace TableViewCellApp
{
    [Register ("EmployeeCell")]
    partial class EmployeeCell
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelDeparment { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelDescription { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel labelName { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (labelDeparment != null) {
                labelDeparment.Dispose ();
                labelDeparment = null;
            }

            if (labelDescription != null) {
                labelDescription.Dispose ();
                labelDescription = null;
            }

            if (labelName != null) {
                labelName.Dispose ();
                labelName = null;
            }
        }
    }
}