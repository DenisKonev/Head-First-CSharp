using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_Class_Overloaded_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Card cardToCheck = new Card(Suits.Clubs, Values.Three);
            bool doesItMatchSuit = Card.DoesCardMatch(cardToCheck, Suits.Spades);
            bool doesItMatchValue = Card.DoesCardMatch(cardToCheck, Values.Ten);
            Console.WriteLine(doesItMatchSuit);
            Console.WriteLine(doesItMatchValue);
            Console.ReadKey();
        }
    }
}
