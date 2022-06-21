using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovationPoker.Entities
{
    internal enum HandType
    {
        RoyalFlush, //Ten, Jack, Queen, King, Ace, in same suit.
        StraightFlush, //All cards are consecutive values of same suit.
        FourOfAKind, //Four cards of the same value.
        FullHouse, //Three of a kind and a pair.
        Flush, //All cards of the same suit.
        Straight, //All cards are consecutive values.
        ThreeOfAKind, //Three cards of the same value.
        TwoPairs, //Two different pairs.
        OnePair, //Two cards of the same value.
        HighCard, //Highest value card.
    }
}
