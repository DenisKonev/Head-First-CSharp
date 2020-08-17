using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces2
{
    class FunnyFunny : IClown
    {
        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }
        private string funnyThingIHave;
        public string FunnyThingIHave { get { return "Hi kids! I have a " + funnyThingIHave; } }
        public void Honk() { Console.WriteLine(FunnyThingIHave); }
    }
}
