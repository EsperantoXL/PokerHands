using System;
using MvvmCross.Core.ViewModels;
using System.Collections.ObjectModel;
using System.Windows.Input;

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
            
        public override void Start()
        {
            base.Start();
            var hands = _handService.GetHands();
            Hands = new ObservableCollection<Hand>(hands);
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

        /// <summary>
        /// Gets the hand command.
        /// </summary>
        /// <value>The hand command.</value>
        public ICommand NavigationCommand
        {
            get
            {
                return new MvxCommand<Hand>(hand =>
                    {
                        //how are we going to pass the selected item to this view
                        ShowViewModel<HandDetailViewModel>(hand);
                    });
            }
        }
    }
}