using System;
using MvvmCross.Binding.iOS.Views;
using UIKit;
using Foundation;

namespace PokerHands.iOS
{
    public class HandsTableViewSource : MvxTableViewSource
    {
        public HandsTableViewSource(UITableView tableView)
            : base(tableView)
        {
            tableView.RegisterNibForCellReuse(HandCell.Nib, HandCell.Key);
        }

        protected override UITableViewCell GetOrCreateCellFor(UITableView tableView, NSIndexPath indexPath, object item)
        {
            var cell = tableView.DequeueReusableCell(HandCell.Key, indexPath); 
            return cell;
        }

        public override nfloat GetHeightForRow(UITableView tableView, NSIndexPath indexPath)
        {
            return 80f;
        }
    }
}

