using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovationPoker.Entities
{
    internal class Hand
    {
        public Hand(HandType handType, Value handValue)
        {
            this.HandType = handType;
            this.HandValue = handValue;
        }

        internal HandType HandType { get; }
        internal Value HandValue { get; }
    }
}
