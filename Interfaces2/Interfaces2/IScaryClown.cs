using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces2
{
    interface IScaryClown : IClown
    {
        public string ScaryThingIHave { get; }
        public void ScareLittleChildren();
    }
}
