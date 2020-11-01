using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    class BluePotion : Weapon, IPotion
    {
        public BluePotion(Game game, Point location)
            : base(game, location) { }
        public bool Used { get; private set; }
        public override string Name { get { return "Blue Potion"; } }
        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(5, random);
            Used = true;
        }
    }
}
