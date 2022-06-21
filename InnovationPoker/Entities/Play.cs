using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace InnovationPoker.Entities
{
    internal class Play
    {
        internal List<Card> Cards = new List<Card>();
    }

    internal static class MyExtensions
    {
        internal static bool SameSuit(this List<Card> cards) 
            => cards.All(x => x.Suit == cards[0].Suit);

        internal static bool ContainsValue(this List<Card> cards, Value value) 
            => cards.Exists(x => x.Value == value);

        internal static bool FourOfAKind(this List<Card> cards)
            => cards.GroupBy(x => x.Value).Any(o => o.Count() == 4);

        internal static bool FullHouse(this List<Card> cards)
        {
            var groups = cards.GroupBy(x => x.Value);
            return groups.Any(o => o.Count() == 3) & groups.Any(o => o.Count() == 2);
        }

        internal static bool Flush(this List<Card> cards)
            => false;

        internal static bool Straight(this List<Card> cards)
            => false;

        internal static bool ThreeOfAKind(this List<Card> cards)
            => cards.GroupBy(x => x.Value).Any(o => o.Count() == 3);

        internal static bool TwoPairs(this List<Card> cards)
            => cards.GroupBy(x => x.Value).Count(o => o.Count() == 2) == 2;

        internal static bool OnePair(this List<Card> cards)
            => cards.GroupBy(x => x.Value).Count(o => o.Count() == 2) == 1;

        internal static bool HighCard(this List<Card> cards)
            => false;

        internal static bool IsConsecutive(this List<Value> sortedValues)
        {
            if (sortedValues.Count <= 1)
            {
                return true;
            }

            if (sortedValues[0] > sortedValues[1])
            {
                return false;
            }

            sortedValues.RemoveAt(0);
            return IsConsecutive(sortedValues);
        }

    }
}
