using System;
namespace OOP_RPG
{
    public class Weapon : Item
    {
        public Weapon(string name, int strength, int OriginalValue, int ResellValue)
        {
            this.Name = name;
            this.Strength = strength;
            this.OriginalValue = OriginalValue;
            this.ResellValue = ResellValue;
        }

        public string Name { get; set; }
        public int Strength { get; set; }
        public int OriginalValue { get; set; }
        public int ResellValue { get; set; }
    }
}