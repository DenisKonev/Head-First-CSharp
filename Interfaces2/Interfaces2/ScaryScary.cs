using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces2
{
    class ScaryScary : FunnyFunny, IScaryClown
    {
        public ScaryScary(string funnyThingIHave, int numberOfScaryThings)
        : base(funnyThingIHave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }
        private int numberOfScaryThings;
        public string ScaryThingIHave { get { return "I have " + numberOfScaryThings + " spiders"; } }
        public void ScareLittleChildren() { Console.WriteLine("Boo! Gotcha!"); }
    }
}
