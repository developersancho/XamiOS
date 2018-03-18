using System;
using System.Collections.Generic;
using UIKit;

namespace TableViewCellApp
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
            var employees = new List<Employee>
            {
                new Employee {
                    FullName = "Ahmed",
                    Department = "Finance",
                    Description="Controlling expenditures and obligations(including operations)"
                },
                new Employee {
                    FullName = "Mehmed",
                    Department = "Accounting",
                    Description="Controlling expenditures and obligations(including operations)"
                },
                new Employee {
                    FullName = "Hasan",
                    Department = "Legal",
                    Description="Controlling expenditures and obligations(including operations)"
                },
                new Employee {
                    FullName = "Mazlum",
                    Department = "IT",
                    Description="Controlling expenditures and obligations(including operations)"
                },
                new Employee {
                    FullName = "Mekin",
                    Department = "Sales",
                    Description="Controlling expenditures and obligations(including operations)"
                }
            };
            EmployeesTableView.Source = new EmployeeTVS(employees);
            EmployeesTableView.RowHeight = UITableView.AutomaticDimension;
            EmployeesTableView.EstimatedRowHeight = 60f;
            EmployeesTableView.ReloadData();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
