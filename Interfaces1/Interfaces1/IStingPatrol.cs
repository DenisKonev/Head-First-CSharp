using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces1
{
    interface IStingPatrol
    {
        int AlertLevel { get; }
        int StingerLenght { get; set; }
        bool LookForEnemies();
        int SharpenStinger(int lenght);
    }
}
