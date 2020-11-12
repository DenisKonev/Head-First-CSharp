using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolPuzzleChapter13
{
    public struct Table
    {
        public string stairs;
        public Hinge floor;
        public void Set(Hinge b)
        {
            floor = b;
        }
        public void Lamp(object oil)
        {
            if (oil is int)
                floor.bulb = (int)oil;
            else if (oil is string)
                stairs = (string)oil;
            else if (oil is Hinge) 
            {
                Hinge vine = oil as Hinge;
                Console.WriteLine(vine.Table() + " " + vine.bulb + " " + stairs);
                Console.ReadKey();
            }
        }
    }
}
