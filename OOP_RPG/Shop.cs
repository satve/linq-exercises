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
        public string Name { get; set; }
        public string OriginalValue { get; set; }
        public int itemNumber { get; set; }
        public Hero hero { get; set; }
        public IItem item { get; set; }
        public Game game;
        public int p { get; set; }

        public Shop()
        {
            this.Armor = new List<Armor>();
            this.Weapons = new List<Weapon>();
            this.Potions = new List<Potion>();

            this.Armor.Add(new Armor("Wooden Armor", 10, 2, 3));
            this.Armor.Add(new Armor("Metal Armor", 20, 5, 7));
            this.Weapons.Add(new Weapon("Sword", 10, 2, 3));
            this.Weapons.Add(new Weapon("Axe", 12, 3, 4));
            this.Weapons.Add(new Weapon("Longsword", 20, 5, 7));
            this.Potions.Add(new Potion("Healing Potion", 5, 5, 2));
        }

        public Shop(Hero hero, Game game)
        {
            this.hero = hero;
            this.game = game;
        }

        public void Menu(Hero hero, Game game)
        {
            Console.WriteLine("Welcome to my shop! What would you like to do?");
            Console.WriteLine("1. Buy Item");
            Console.WriteLine("2. Sell Item");
            Console.WriteLine("3. Return to Game Menu");
            var input1 = Console.ReadLine();
            if (input1 == "1")
            {
                this.ShowInventory();
            }
            else if (input1 == "2")
            {
                this.BuyFromUser();
            }
            else
            {
                return;
            }
        }

        public void ShowInventory()
        {
            var c = 1;
            Console.WriteLine("WEAPONS SHOP");
            for (p = 0; p < this.Weapons.Count(); p++)
            {
                Console.WriteLine(c + " " + this.Weapons[p].Name + " has original value " + +this.Weapons[p].OriginalValue);
                c++;
            }



            Console.WriteLine("POTIONS SHOP");
            for (p = 0; p < this.Potions.Count(); p++)
            {
                Console.WriteLine(c + " " + this.Potions[p].Name + " has original value " + +this.Potions[p].OriginalValue);
                c++;
            }
            Console.WriteLine("ARMORS SHOP");
            for (p = 0; p < this.Armor.Count(); p++)
            {
                Console.WriteLine(c + " " + this.Armor[p].Name + " has original value " + +this.Armor[p].OriginalValue);
                c++;
            }
            Console.WriteLine("Please press r or any digit to return");
            Console.WriteLine("Please type a number");

            var output = int.TryParse(Console.ReadLine(), out int result);
            if (output)
            {
                Console.WriteLine("You choose" + c);
                this.SellFromUser(itemNumber);
            }
            else
            {
                Console.WriteLine("Please press any key to return to  main menu");
                return;
            }
        }

        public void BuyFromUser()
        {
            var counter = 1;
            Console.WriteLine("RESELL WEAPONS");
            for (p = 0; p < this.Weapons.Count(); p++)
            {
                Console.WriteLine(counter + " " + this.Weapons[p].Name + " has resell value " + this.Weapons[p].ResellValue);
                counter++;
            }
            Console.WriteLine("RESELL ARMORS");
            for (p = 0; p < this.Armor.Count(); p++)
            {
                Console.WriteLine(counter + " " + this.Armor[p].Name + " has resell value " + this.Armor[p].ResellValue);
                counter++;
            }
            Console.WriteLine("RESELL POTIONS");
            for (p = 0; p < this.Potions.Count(); p++)
            {
                Console.WriteLine(counter + " " + this.Potions[p].Name + " has resell value " + this.Potions[p].ResellValue);
                counter++;
            }
            Console.WriteLine("Please press r or any key to return to menu");
            Console.WriteLine("Please type a number");

            var type = int.TryParse(Console.ReadLine(), out int result);
            if (result == p)
            {
                this.SellFromUser(itemNumber);
            }
            else
            {
                Console.WriteLine("please press any key return to main menu");
                return;
            }


        }

        public void Sell(IItem item)
        {

            if (hero.Gold >= item.OriginalValue)
            {
                Console.WriteLine(hero.Gold = hero.Gold - Weapons[p].OriginalValue);
            }
            else
            {
                Console.WriteLine("You do not have enough money to buy weapon");
                return;
            }
            Console.ReadLine();

        }

        public void SellFromUser(int itemNumber)
        {
            Console.WriteLine("remove item");
            return;

        }
    }
}
