using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoFish
{
    class Card
    {
        public Suits Suit { get; set; }
        public Values Value { get; set; }
        public Card(Suits suit, Values value)
        {
            this.Suit = suit;
            this.Value = value;
        }
        public string Name { get { return Value.ToString() + " of " + Suit.ToString(); } }
        public static string Plural(Values value)
        {
            if (value == Values.Six)
                return "Sixes";
            else
                return value.ToString() + "s";
        }
    }
}
