using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_of_Ducks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>() 
            {
            new Duck() { Kind = KindOfDuck.Mallard, Size = 17 },
            new Duck() { Kind = KindOfDuck.Muscovy, Size = 18 },
            new Duck() { Kind = KindOfDuck.Decoy, Size = 14 },
            new Duck() { Kind = KindOfDuck.Muscovy, Size = 11 },
            new Duck() { Kind = KindOfDuck.Mallard, Size = 14 },
            new Duck() { Kind = KindOfDuck.Decoy, Size = 13 },
            };

            //Sorting by size with overridden CompareTo() in Duck class
            ducks.Sort();
            PrintDucks(ducks);

            DuckComparerBySize comparer = new DuckComparerBySize();

            //Sorting by size using IComparer<Duck>
            ducks.Sort(comparer);
            PrintDucks(ducks);

            //Sorting by size or kind depending on SortBy field
            DuckComparer comparerWithOptrions = new DuckComparer();

            comparerWithOptrions.SortBy = SortCriteria.KindThenSize;
            ducks.Sort(comparerWithOptrions);
            PrintDucks(ducks);

            comparerWithOptrions.SortBy = SortCriteria.SizeThenKind;
            ducks.Sort(comparerWithOptrions);
            PrintDucks(ducks);
        }
        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
                Console.WriteLine(duck);
            Console.WriteLine("End of ducks!");
            Console.ReadKey();
        }
    }
}
