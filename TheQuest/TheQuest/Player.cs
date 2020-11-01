using System;
using System.Collections.Generic;
using System.Drawing;

namespace TheQuest
{
    internal class Player : Mover
    {
        private Weapon equippedWeapon;
        public int HitPoints { get; private set; }
        private List<Weapon> inventory = new List<Weapon>();
        public IEnumerable<string> Weapons
        {
            get
            {
                List<string> names = new List<string>();
                foreach (Weapon weapon in inventory)
                    names.Add(weapon.Name);
                return names;
            }
        }
        public Player(Game game, Point location)
        : base(game, location)
        {
            HitPoints = 10;
        }
        public void Hit(int maxDamage, Random random)
        {
            HitPoints -= random.Next(1, maxDamage);
        }
        public void IncreaseHealth(int health, Random random)
        {
            HitPoints += random.Next(1, health);
        }
        public void Equip(string weaponName)
        {
            foreach (Weapon weapon in inventory)
            {
                if (weapon.Name == weaponName)
                    equippedWeapon = weapon;
            }
        }
        public bool CheckPotionUsed(string potionName)
        {
            IPotion potionToCheck;
            bool checkUsed = false;
            foreach (Weapon weapon in inventory)
                if ((weapon.Name == potionName) && (weapon is Weapon))
                {
                    potionToCheck = weapon as IPotion;
                    if (potionToCheck.Used == true)
                        checkUsed = true;
                    else
                        checkUsed = false;
                }
            return checkUsed;
        }
        public void Move(Direction direction)
        {
            base.location = Move(direction, game.Boundaries);
            if (!game.WeaponInRoom.PickedUp)
            {
                if (this.Nearby(game.WeaponInRoom.Location, 20))
                {
                    inventory.Add(game.WeaponInRoom);
                    game.WeaponInRoom.PickUpWeapon();
                }
            }
        }
        internal void Attack(Direction direction, Random random)
        {
            if (equippedWeapon != null)
            {
                equippedWeapon.Attack(direction, random);
                if (equippedWeapon is IPotion)
                    inventory.RemoveAt(inventory.IndexOf(equippedWeapon));
            }
        }
    }
}