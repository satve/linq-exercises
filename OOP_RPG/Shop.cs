using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RPG
{
    public class Shop
    {

        public List<Armor> Armor { get; set; }
        public List<Weapon> Weapons { get; set; }
        public List<Potion> Potions { get; set; }

        public Shop()
        {
            this.Armor = new List<Armor>();
            this.Weapons = new List<Weapon>();
            this.Potions = new List<Potion>();
        }
    }
}
