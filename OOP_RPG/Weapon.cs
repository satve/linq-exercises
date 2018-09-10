using System;
namespace OOP_RPG
{
    public class Weapon
    {
        public Weapon(string name = "NO IDENTITY", int strength = 16) {

            this.Name = name;
            this.Strength = strength;
        }
        
        public string Name { get; set; }
        public int Strength { get; set; }
    }
}