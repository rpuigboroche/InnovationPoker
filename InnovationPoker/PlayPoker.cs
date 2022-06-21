using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using InnovationPoker.Entities;

namespace InnovationPoker
{
    internal class PlayPoker
    {
        public Player Game(Play play1, Play play2)
        {




            return Player.Player1;
        }

        private static Hand CalculateHand(Play play)
        {
            if (IsRoyalFlush(play))
            {
                return new Hand { HandType = HandType.RoyalFlush };
            }
            if (IsStraightFlush(play))
            {
                return new Hand { HandType = HandType.StraightFlush, HandValue = };
            }
            if (IsFourOfAKind(play))
            {
                return new Hand { HandType = HandType.FourOfAKind, HandValue = };
            }

        }

        //RoyalFlush, //Ten, Jack, Queen, King, Ace, in same suit.
        //StraightFlush, //All cards are consecutive values of same suit.
        //FourOfAKind, //Four cards of the same value.
        //FullHouse, //Three of a kind and a pair.
        //Flush, //All cards of the same suit.
        //Straight, //All cards are consecutive values.
        //ThreeOfAKind, //Three cards of the same value.
        //TwoPairs, //Two different pairs.
        //OnePair, //Two cards of the same value.
        //HighCard, //Highest value card.
        
        private static bool IsRoyalFlush(Play play) 
            => play.Cards.SameSuit()
               && play.Cards.ContainsValue(Value.A)
               && play.Cards.ContainsValue(Value.K)
               && play.Cards.ContainsValue(Value.Q)
               && play.Cards.ContainsValue(Value.J)
               && play.Cards.ContainsValue(Value.Ten);


        private static bool IsStraightFlush(Play play)
        {
            var sortedCards = play.Cards.Select(x => x.Value).OrderBy(x => (int)x).ToList();
            return play.Cards.SameSuit() && sortedCards.IsConsecutive();
        }

        private static bool IsFourOfAKind(Play play)
            => play.Cards.FourOfAKind();

        private static bool IsFullHouse(Play play)
            => play.Cards.FourOfAKind();

    }
}
