using System;

using UIKit;
using MvvmCross.iOS.Views;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.Binding.BindingContext;
using System.Collections.Generic;

namespace PokerHands.iOS
{
    public partial class HandsView : MvxViewController
    {
        public HandsView()
            : base("HandsView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            //we need to add a cell as well
            var source = new MvxSimpleTableViewSource(TableView, typeof(HandCell), HandCell.Key);
            this.AddBindings(new Dictionary<object, string>
                {
                    { source, "ItemsSource Hands" }
                });

            TableView.Source = source;
            TableView.ReloadData();       
        }
    }
}