using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces2
{
    class TallGuy : IClown
    {
        public string Name;
        public int Height;
        public string FunnyThingIHave { 
            get { return "big shoes"; }
        }
        public void TalkAboutYourself()
        {
            Console.WriteLine("My name is " + Name + " and I'm " + Height + " inches tall.");
        }
        public void Honk()
        {
            Console.WriteLine("Honk honk!");
        }
    }
}
