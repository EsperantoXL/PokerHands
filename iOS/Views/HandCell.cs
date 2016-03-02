using System;

using Foundation;
using UIKit;
using MvvmCross.Binding.iOS.Views;
using MvvmCross.Binding.BindingContext;
using PokerHands.Core;

namespace PokerHands.iOS
{
    public partial class HandCell : MvxTableViewCell
    {
        public static readonly NSString Key = new NSString("HandCell");
        public static readonly UINib Nib;
        private readonly MvxImageViewLoader _imageLoader;

        static HandCell()
        {
            Nib = UINib.FromName("HandCell", NSBundle.MainBundle);
        }

        public HandCell(IntPtr handle)
            : base(handle)
        {
            _imageLoader = new MvxImageViewLoader(() => Image);
            this.DelayBind(() =>
                {
                    var binding = this.CreateBindingSet<HandCell, Hand>();
                    binding.Bind(_imageLoader).For(il => il.ImageUrl).To(h => h.ImageUrl);
                    binding.Bind(Title).To(h => h.Title);
                    binding.Bind(ShortDescription).To(h => h.ShortDescription);
                    binding.Apply();
                });
        }

        public HandCell()
        {
        }
    }
}
