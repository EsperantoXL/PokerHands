﻿using System;

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

            //we need to set the navigation bar to be non trancelucent 
            NavigationController.NavigationBar.Translucent = false;

            var source = new HandsTableViewSource(TableView);
            this.AddBindings(new Dictionary<object, string>
                {
                    { source, "ItemsSource Hands;SelectionChangedCommand NavigationCommand" }
                });

            TableView.Source = source;
            TableView.ReloadData();       
        }
    }
}