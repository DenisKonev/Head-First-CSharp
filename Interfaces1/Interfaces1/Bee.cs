using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces1
{
    class Bee : IStingPatrol
    {
        public int AlertLevel { get; }
        public int StingerLenght { get; set; }
        public bool LookForEnemies() { return true; }
        public int SharpenStinger(int lenght) { return lenght; }
    }
}
