using System;
using System.Collections.Generic;
using UIKit;

namespace TableViewApp
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
            List<string> names = new List<string>
            {
                "Sanchez","Ahmet","Salah", "Samir","Mutlu","Mesut",
                "Ziya", "Şaban","Atilla", "Mete",  "Alparslan","Muhteşem"
            };

            NamesTableView.Source = new NamesTableViewSource(names);
            NamesTableView.Delegate = new CarsDelegate();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
