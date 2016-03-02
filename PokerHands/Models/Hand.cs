using System;

namespace PokerHands.Core
{
    /// <summary>
    /// Poker hand
    /// </summary>
    public class Hand
    {
        //we might need a proper constructor
        public Hand()
        {
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>The title.</value>
        public string Title {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the full description.
        /// </summary>
        /// <value>The description.</value>
        public string Description
        {
            get;
            set;
        }   

        /// <summary>
        /// Gets or sets the short description.
        /// </summary>
        /// <value>The short description.</value>
        public string ShortDescription
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the order.
        /// </summary>
        /// <value>The order.</value>
        public int Order
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the image URL.
        /// </summary>
        /// <value>The image URL.</value>
        public string ImageUrl
        {
            get;
            set;
        }
    }
}

