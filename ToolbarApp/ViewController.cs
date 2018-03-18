using System;

using UIKit;

namespace ToolbarApp
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void BarAdd_Activated(UIBarButtonItem sender)
        {
            var alert = UIAlertController.Create("Alert", "You pressed Add.", UIAlertControllerStyle.Alert);
            alert.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));
            PresentViewController(alert, true, null);
        }

        partial void BarSearch_Activated(UIBarButtonItem sender)
        {
            var alert = UIAlertController.Create("Alert", "You pressed Search.", UIAlertControllerStyle.Alert);
            alert.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));
            PresentViewController(alert, true, null);
        }

        partial void BarRefresh_Activated(UIBarButtonItem sender)
        {
            var alert = UIAlertController.Create("Alert", "You pressed Refresh.", UIAlertControllerStyle.Alert);
            alert.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));
            PresentViewController(alert, true, null);
        }

        partial void BarLike_Activated(UIBarButtonItem sender)
        {
            var alert = UIAlertController.Create("Alert", "You pressed Like.", UIAlertControllerStyle.Alert);
            alert.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));
            PresentViewController(alert, true, null);
        }

        partial void BarStop_Activated(UIBarButtonItem sender)
        {
            var alert = UIAlertController.Create("Alert", "You pressed Stop.", UIAlertControllerStyle.Alert);
            alert.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));
            PresentViewController(alert, true, null);
        }
    }
}
