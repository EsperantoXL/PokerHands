using System;
using System.Collections.Generic;

namespace PokerHands.Core
{
    /// <summary>
    /// Hand service provides a collection of hands
    /// </summary>
    public class HandService : IHandService
    {
        private List<Hand> _hands;
        public HandService()
        {
            _hands = new List<Hand>();
            _hands.Add(new Hand(){
                Order = 1,
                Title = "Card High",
                ShortDescription = "Highest card in your hand",
                Description = "High Card; When only the Bluff will win. Over 2,500,000 combinations of winning with a High Card. There is a 50% if hitting this over played poker hand.",
                ImageUrl = "http://www.deepstackpoker.com.au/images/poker-hand-card-high-big.png"
            });
            _hands.Add(new Hand(){
                Order = 2,
                Title = "Pair",
                ShortDescription = "Any 2 cards of the same rank",
                Description = "Any two cards of the same rank. Here pocket aces are shown. There are over 1,000,000 combnations of a pair. 42.5% chance of hitting 1 of your hole cards or pairing the board.",
                ImageUrl = "http://www.deepstackpoker.com.au/images/poker-hand-pair-big.png"
            });
            _hands.Add(new Hand(){
                Order = 3,
                Title = "Two Pair",
                ShortDescription = "2 times any 2 cards of the same rank",
                Description = "If i'm going to loose a tournament I hold 2 pair. You either have a pocket pair and the board pairs or your 2 hole cards pair on the board. Learn to fold two pair. There are 123,552 possible two pair combinations available. 4.75% chance if hitting 2 pair.",
                ImageUrl = "http://www.deepstackpoker.com.au/images/poker-hand-two-pair-big.png"
            });
            _hands.Add(new Hand(){
                Order = 4,
                Title = "Three of a Kind",
                ShortDescription = "Any 3 of the same ranked cards",
                Description = "Or better known as Trips or a Set. Any 3 of the same ranked cards, can be from a pocket pair or draw too 2 on the board. Watch out your trips aren't trumped by a full boat. 54,912 different possibilities of Three of a Kind are available. There is 2.1% chance of hitting trips.",
                ImageUrl = "http://www.deepstackpoker.com.au/images/poker-hand-three-of-a-kind-big.png"
            });
            _hands.Add(new Hand(){
                Order = 5,
                Title = "Straight",
                ShortDescription = "Any 5 consecutive ranked cards in multiple suits",
                Description = "Also known as The Wheel, Any 5 consecutive ranked cards in multiple suits where the ace can be high or low. An ace high straight is also called Broadway. 10240 different straight combinations are possible. There is 0.39% chance if hitting a straight.",
                ImageUrl = "http://www.deepstackpoker.com.au/images/poker-hand-straight-big.png"
            });
            _hands.Add(new Hand(){
                Order = 6,
                Title = "Flush",
                ShortDescription = "Any 5 cards of the same suit, non consecutive",
                Description = "Any 5 cards of the same suit, non consecutive. The winning hand is decided by the highest individual card held eg As beats Js. 5148 different combinations of a flush are available. There is a 0.20% chance of hitting a flush.",
                ImageUrl = "http://www.deepstackpoker.com.au/images/poker-hand-flush-big.png"
            });
            _hands.Add(new Hand(){
                Order = 7,
                Title = "Full House",
                ShortDescription = "3 cards of the same rank and 2 cards of the same rank",
                Description = "Also Called a Full Boat. Nothing worse then when your full house gets beaten by a bigger full house. This is made up of 3 cards of the same rank and 2 cards of the same rank. 3744 different full house combinations are available. There is about 0.14% chance of hitting 1 of these combinations",
                ImageUrl = "http://www.deepstackpoker.com.au/images/poker-hand-full-house-big.png"
            });
            _hands.Add(new Hand(){
                Order = 8,
                Title = "4 of a Kind",
                ShortDescription = "Any 4 of the same rank card",
                Description = "Also called Quads. Your eyes light up your pulse races when you flop Quads, Check I Hear you call. Any 4 of the same rank card. if 2 players have 4 of a kind the hand will be decided by the Kicker. There is 0.0024% chance of hitting this hand.",
                ImageUrl = "http://www.deepstackpoker.com.au/images/poker-hand-four-of-a-kind-big.png"
            });
            _hands.Add(new Hand(){
                Order = 9,
                Title = "Straight Flush",
                ShortDescription = "Any 5 cards suited in sequence",
                Description = "You would have to be unlucky to be beaten if you held a straight flush, Any 5 cards in suit in sequence. There are 40 different straight flush possibilities. There is about 0.0015% chance of hitting this.",
                ImageUrl = "http://www.deepstackpoker.com.au/images/poker-hand-straight-flush-big.png"
            });
            _hands.Add(new Hand(){
                Order = 10,
                Title = "Royal Flush",
                ShortDescription = "Ace to the 10 suited",
                Description = "The absolute nuts, also called a Royal Routine, A Royal Flush can not be beaten. Ace to the 10 in suit. The art is to get your opponents to commit there chips to this unbeatable hand. You have less then 0.0015% chance of hitting this winning hand.",
                ImageUrl = "http://www.deepstackpoker.com.au/images/poker-hand-royal-flush-big.png"
            });

        }

        #region IHandService implementation

        public System.Collections.IEnumerable GetHands()
        {
            return _hands;
        }

        #endregion
    }
}

