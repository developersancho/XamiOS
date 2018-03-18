using Foundation;
using System;
using UIKit;

namespace TableViewCellApp
{
    public partial class EmployeeCell : UITableViewCell
    {
        public EmployeeCell(IntPtr handle) : base(handle)
        {
        }

        internal void UpdateCell(Employee employee)
        {
            labelName.Text = employee.FullName;
            labelDeparment.Text = employee.Department;
            labelDescription.Text = employee.Description;
        }
    }
}