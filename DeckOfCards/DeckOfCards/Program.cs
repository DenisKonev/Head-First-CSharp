using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            do
            {
                int numberBeetwen0and3 = random.Next(4);
                int numberBeetwen1and13 = random.Next(1, 14);
                Card card = new Card((Suits)numberBeetwen0and3, (Values)numberBeetwen1and13);
                Console.WriteLine(card.Name);
                Thread.Sleep(1000);
            } while (true);
        }
    }
}
