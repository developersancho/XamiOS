using System;

using UIKit;

namespace AlertControlApp
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

        partial void BtnSimpleAlert_TouchUpInside(UIButton sender)
        {
            var alert = UIAlertController.Create("ALERT", "Background is White!", UIAlertControllerStyle.Alert);
            alert.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));
            ShowViewController(alert, null);
        }

        partial void BtnActionSheet_TouchUpInside(UIButton sender)
        {
            var alert = UIAlertController.Create("ALERT", "Background is White!", UIAlertControllerStyle.Alert);
            alert.AddAction(UIAlertAction.Create("Refuse", UIAlertActionStyle.Default, (UIAlertAction obj) =>
            {
                MyLabel.Text = "Choice: Refuse";
            }));
            alert.AddAction(UIAlertAction.Create("Accept", UIAlertActionStyle.Default, (UIAlertAction obj) =>
            {
                MyLabel.Text = "Choice: Accept";
            }));
            ShowViewController(alert, null);
        }

        partial void UIButton206_TouchUpInside(UIButton sender)
        {
            var alert = UIAlertController.Create("ALERT", "Background is White!", UIAlertControllerStyle.ActionSheet);
            alert.AddAction(UIAlertAction.Create("Green", UIAlertActionStyle.Default, (UIAlertAction obj) =>
            {
                MyLabel.Text = "Choice: Green";
            }));
            alert.AddAction(UIAlertAction.Create("Blue", UIAlertActionStyle.Default, (UIAlertAction obj) =>
            {
                MyLabel.Text = "Choice: Blue";
            }));
            alert.AddAction(UIAlertAction.Create("Red", UIAlertActionStyle.Default, (UIAlertAction obj) =>
            {
                MyLabel.Text = "Choice: Red";
            }));
            ShowViewController(alert, null);
        }
    }
}
