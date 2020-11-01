using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    class Bow : Weapon
    {
        public Bow(Game game, Point location)
            : base(game, location) { }
        public override string Name { get { return "Bow"; } }
        public override void Attack(Direction direction, Random random)
        {
            DamageEnemy(direction, 80, 1, random);
        }
    }
}
