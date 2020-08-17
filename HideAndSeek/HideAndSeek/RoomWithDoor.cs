using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HideAndSeek
{
    class RoomWithDoor : RoomWithHidingPlace, IHasExteriorDoor
    {
        public RoomWithDoor(string name, string decoration, string hidingPlaceName, string doorSescription)
            : base(name, decoration, hidingPlaceName)
        {
            DoorDescription = doorSescription;
        }
        public string DoorDescription { get; private set; }
        public Location DoorLocation { get; set; }
    }

}
