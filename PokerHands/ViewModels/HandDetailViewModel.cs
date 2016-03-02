using System;
using MvvmCross.Core.ViewModels;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace PokerHands.Core
{
	public class HandDetailViewModel : MvxViewModel
	{
        protected override void InitFromBundle(IMvxBundle parameters)
        {
            base.InitFromBundle(parameters);
            Hand = parameters.Read<Hand>();
        }

        Hand _hand;

        public Hand Hand
        {
            get { return _hand; }
            set
            {
                _hand = value;
                RaisePropertyChanged(() => Hand);
            }
        }
	}
}