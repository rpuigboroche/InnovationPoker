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
            => cards.GroupBy(x => x.Value).Count() >= 4;

        internal static bool FullHouse(this List<Card> cards)
        {
            cards.GroupBy(x => x.Value).Count() >= 4;

        }
            
    }
}
