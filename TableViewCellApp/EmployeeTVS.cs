﻿using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace TableViewCellApp
{
    internal class EmployeeTVS : UITableViewSource
    {
        private List<Employee> employees;

        public EmployeeTVS(List<Employee> employees)
        {
            this.employees = employees;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = (EmployeeCell)tableView.DequeueReusableCell("cell_id", indexPath);

            var employee = employees[indexPath.Row];
            cell.UpdateCell(employee);
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return employees.Count;
        }
    }
}