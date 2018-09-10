using System;
using System.Linq;
using System.Collections.Generic;

namespace OOP_RPG
{
    public class Fight
    {
        List<Monster> Monsters { get; set; }
        public Game game { get; set; }
        public Hero hero { get; set; }
        public Monster monster { get; set; }
        
        public Fight(Hero hero, Game game) {
            this.Monsters = new List<Monster>();
            this.hero = hero;
            this.game = game;
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

            monster = enemy;
        }
        
        public void AddMonster(string name, int strength, int defense, int hp) {
            var monster = new Monster(name,strength,defense,hp);
            this.Monsters.Add(monster);
        }
        
        public void Start() {
          

            Console.WriteLine("You've encountered a " + monster.Name + "! " + monster.Strength + " Strength/" + monster.Defense + " Defense/" +
           monster.CurrentHP + " HP. What will you do?");
            Console.WriteLine("1. Fight");
            var input = Console.ReadLine();
            if (input == "1") {
                this.HeroTurn();
            }
            else { 
                this.game.Main();
            }
        }
        
        public void HeroTurn(){
           var enemy = monster;
           var compare = hero.Strength - enemy.Defense;
           int damage;
           
           if(compare <= 0) {
               damage = 1;
               enemy.CurrentHP -= damage;
           }
           else{
               damage = compare;
               enemy.CurrentHP -= damage;
           }
           Console.WriteLine("You did " + damage + " damage!");
           
           if(enemy.CurrentHP <= 0){
               this.Win();
           }
           else
           {
               this.MonsterTurn();
           }
           
        }
        
        public void MonsterTurn(){
           var enemy = monster;
           int damage;
           var compare = enemy.Strength - hero.Defense;
           if(compare <= 0) {
               damage = 1;
               hero.CurrentHP -= damage;
           }
           else{
               damage = compare;
               hero.CurrentHP -= damage;
           }
           Console.WriteLine(enemy.Name + " does " + damage + " damage!");
           if(hero.CurrentHP <= 0){
               this.Lose();
           }
           else
           {
               this.Start();
           }
        }
        
        public void Win() {
            var enemy = monster;
            Console.WriteLine(enemy.Name + " has been defeated! You win the battle!");
            game.Main();
        }
        
        public void Lose() {
            Console.WriteLine("You've been defeated! :( GAME OVER.");
            return;
        }
        
    }
    
}