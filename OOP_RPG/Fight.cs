using System;
using System.Linq;
using System.Collections.Generic;

namespace OOP_RPG
{
    public class Fight
    {
        List<Monster> Monsters { get; set; }
        public Game Game { get; set; }
        public Hero Hero { get; set; }
        public Monster Monster { get; set; }

        public Fight(Hero hero, Game game)
        {
            this.Monsters = new List<Monster>();
            this.Hero = hero;
            this.Game = game;
            this.AddMonster("Squid", 9, 8, 20);
            this.AddMonster("Hkus", 8, 7, 12);
            this.AddMonster("Peed", 12, 5, 19);
            this.AddMonster("Uhdis", 10, 8, 22);

            var enemy2 = this.Monsters[1];
            var enemyLast = this.Monsters.Last();
            var randomMonster = Monsters.OrderBy(p => Guid.NewGuid()).FirstOrDefault();
            Console.WriteLine(randomMonster);
            var lessHit = (from p in this.Monsters where p.CurrentHP < 20 select p).First();
            var moreStrength = (from p in this.Monsters where p.Strength >= 11 select p).First();
            var enemy = randomMonster;

            Monster = enemy;
        }

        public void AddMonster(string name, int strength, int defense, int hp)
        {
            var monster = new Monster(name, strength, defense, hp);
            this.Monsters.Add(monster);
        }

        public void Start()
        {


            Console.WriteLine("You've encountered a " + Monster.Name + "! " + Monster.Strength + " Strength/" + Monster.Defense + " Defense/" +
           Monster.CurrentHP + " HP. What will you do?");
            Console.WriteLine("1. Fight");
            var input = Console.ReadLine();
            if (input == "1")
            {
                this.HeroTurn();
            }
            else
            {
                this.Game.Main();
            }
        }

        public void HeroTurn()
        {
            var enemy = Monster;
            var compare = Hero.Strength - enemy.Defense;
            int damage;

            if (compare <= 0)
            {
                damage = 1;
                enemy.CurrentHP -= damage;
            }
            else
            {
                damage = compare;
                enemy.CurrentHP -= damage;
            }
            Console.WriteLine("You did " + damage + " damage!");

            if (enemy.CurrentHP <= 0)
            {
                this.Win();
            }
            else
            {
                this.MonsterTurn();
            }

        }

        public void MonsterTurn()
        {
            var enemy = Monster;
            int damage;
            var compare = enemy.Strength - Hero.Defense;
            if (compare <= 0)
            {
                damage = 1;
                Hero.CurrentHP -= damage;
            }
            else
            {
                damage = compare;
                Hero.CurrentHP -= damage;
            }
            Console.WriteLine(enemy.Name + " does " + damage + " damage!");
            if (Hero.CurrentHP <= 0)
            {
                this.Lose();
            }
            else
            {
                this.Start();
            }
        }

        public void Win()
        {
            var enemy = Monster;
            Console.WriteLine(enemy.Name + " has been defeated! You win the battle!");
            this.Hero.Gold += this.Monster.Gold;
            Console.WriteLine("Gold is = " + this.Hero.Gold);
            Game.Main();
        }

        public void Lose()
        {
            Console.WriteLine("You've been defeated! :( GAME OVER.");
            return;
        }

    }

}