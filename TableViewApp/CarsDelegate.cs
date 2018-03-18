using Foundation;
using UIKit;

namespace TableViewApp
{
    internal class CarsDelegate : UITableViewDelegate
    {
        public override UITableViewRowAction[] EditActionsForRow(UITableView tableView, NSIndexPath indexPath)
        {
            var action = UITableViewRowAction.Create(
                UITableViewRowActionStyle.Default,
                 "like",
                 (arg1, arg2) =>
                 {
                     var cell = tableView.CellAt(arg2);
                     cell.TextLabel.Text += "{liked}";
                 });
            return new UITableViewRowAction[] { action };
        }
    }
}