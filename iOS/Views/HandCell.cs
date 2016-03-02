using System;

using Foundation;
using UIKit;
using MvvmCross.Binding.iOS.Views;

namespace PokerHands.iOS
{
    public partial class HandCell : MvxTableViewCell
    {
        public static readonly NSString Key = new NSString("HandCell");
        public static readonly UINib Nib;

        static HandCell()
        {
            Nib = UINib.FromName("HandCell", NSBundle.MainBundle);
        }

        public HandCell(IntPtr handle)
            : base(handle)
        {
        }
    }
}
