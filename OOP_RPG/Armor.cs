using System;
namespace OOP_RPG
{
    public class Armor : Item
    {
        public Armor(string name, int defense, int OriginalValue, int ResellValue)
        {
            this.Name = name;
            this.Defense = defense;
            this.OriginalValue = OriginalValue;
            this.ResellValue = ResellValue;
        }

        public string Name { get; set; }
        public int Defense { get; set; }
        public int OriginalValue { get; set; }
        public int ResellValue { get; set; }
    }
}