using System;
using MvvmCross.Core.ViewModels;
using System.Collections.ObjectModel;

namespace PokerHands.Core
{
    /// <summary>
    /// ViewModel that shows the possible hands and the ranking order
    /// </summary>
    public class HandsViewModel : MvxViewModel
    {
        private readonly IHandService _handService;

        public HandsViewModel(IHandService handService)
        {
            _handService = handService;
        }

        private ObservableCollection<Hand> _hands;

        /// <summary>
        /// Gets or sets the collection of poker hands.
        /// </summary>
        /// <value>The hands.</value>
        public ObservableCollection<Hand> Hands
        {
            get { return _hands; }
            set
            {
                _hands = value;
                RaisePropertyChanged(() => Hands);
            }
        }

        //We need to capture the moment a hand is pressed
    }
}