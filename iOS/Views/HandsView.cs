using System;

using UIKit;
using MvvmCross.iOS.Views;

namespace PokerHands.iOS
{
    //Do we still need a mvx view controller
    public partial class HandsView : MvxViewController
    {
        public HandsView()
            : base("HandsView", null)
        {
        }

        //we migth want to do some things with a table here
    }
}


