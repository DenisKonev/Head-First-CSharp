using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LetsBuildAHouse
{
    class RoomWithDoor : Room, IHasExteriorDoor
    {
        public RoomWithDoor(string name, string decoration, string doorSescription)
            : base(name, decoration)
        {
            DoorDescription = doorSescription;
        }
        public string DoorDescription { get; private set; }
        public Location DoorLocation { get; set; }
    }

}
