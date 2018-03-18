using System;

using UIKit;

namespace SegmentedControlApp
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
            MySegmentedControl.InsertSegment("Yellow", 3, true);
            labelResult.Text = "Green";
            labelResult.TextColor = UIColor.Green;
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void SegmentedControl_ValueChanged(UISegmentedControl sender)
        {
            var index = MySegmentedControl.SelectedSegment;
            if (index == 0)
            {
                labelResult.Text = "Green";
                labelResult.TextColor = UIColor.Green;
            }
            else if (index == 1)
            {
                labelResult.Text = "Red";
                labelResult.TextColor = UIColor.Red;
            }
            else if (index == 2)
            {
                labelResult.Text = "Blue";
                labelResult.TextColor = UIColor.Blue;
            }
            else if (index == 3)
            {
                labelResult.Text = "Yellow";
                labelResult.TextColor = UIColor.Yellow;
            }
        }
    }
}
