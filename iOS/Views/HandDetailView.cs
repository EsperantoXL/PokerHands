using System;

using UIKit;
using MvvmCross.iOS.Views;
using MvvmCross.Binding.BindingContext;
using PokerHands.Core;
using MvvmCross.Binding.iOS.Views;

namespace PokerHands.iOS
{
    public partial class HandDetailView : MvxViewController
    {
        private readonly MvxImageViewLoader _imageLoader;

        public HandDetailView()
            : base("HandDetailView", null)
        {
            _imageLoader = new MvxImageViewLoader(() => Image);
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var set = this.CreateBindingSet<HandDetailView, HandDetailViewModel>();
            set.Bind(Title).To(vm => vm.Hand.Title);
            set.Bind(Description).To(vm => vm.Hand.Description);
            set.Bind(_imageLoader).For(il => il.ImageUrl).To(vm => vm.Hand.ImageUrl);
            set.Apply();
        }
    }
}


