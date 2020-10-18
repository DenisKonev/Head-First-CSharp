﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    class RedPotion : Weapon, iPotion
    {
        public RedPotion(Game game, Point location)
            : base(game, location) { }
        public bool Used { get; }
        public override string Name { get { return "Red Potion"; } }
        public override void Attack(Direction direction, Random random)
        {
            // Your code goes here
        }
    }
}