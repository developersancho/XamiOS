// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace ToolbarApp
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem barAdd { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem barLike { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem barRefresh { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem barSearch { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIBarButtonItem barStop { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIToolbar MyToolBar { get; set; }

        [Action ("BarAdd_Activated:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BarAdd_Activated (UIKit.UIBarButtonItem sender);

        [Action ("BarLike_Activated:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BarLike_Activated (UIKit.UIBarButtonItem sender);

        [Action ("BarRefresh_Activated:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BarRefresh_Activated (UIKit.UIBarButtonItem sender);

        [Action ("BarSearch_Activated:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BarSearch_Activated (UIKit.UIBarButtonItem sender);

        [Action ("BarStop_Activated:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void BarStop_Activated (UIKit.UIBarButtonItem sender);

        void ReleaseDesignerOutlets ()
        {
            if (barAdd != null) {
                barAdd.Dispose ();
                barAdd = null;
            }

            if (barLike != null) {
                barLike.Dispose ();
                barLike = null;
            }

            if (barRefresh != null) {
                barRefresh.Dispose ();
                barRefresh = null;
            }

            if (barSearch != null) {
                barSearch.Dispose ();
                barSearch = null;
            }

            if (barStop != null) {
                barStop.Dispose ();
                barStop = null;
            }

            if (MyToolBar != null) {
                MyToolBar.Dispose ();
                MyToolBar = null;
            }
        }
    }
}