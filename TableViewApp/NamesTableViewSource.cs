using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace TableViewApp
{
    public class NamesTableViewSource : UITableViewSource
    {
        private List<string> names;

        public NamesTableViewSource(List<string> names)
        {
            this.names = names;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = new UITableViewCell(UITableViewCellStyle.Default, "");
            cell.TextLabel.Text = names[indexPath.Row];
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return names.Count;
        }

		public override void RowSelected(UITableView tableView, NSIndexPath indexPath)
		{
            var selectedName = names[indexPath.Row];

		}
	}
}
