using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_RPG
{
    public class Potion : Item
    {
        public string Name { get; set; }
        public int HP { get; set; }
        public int OriginalValue { get; set; }
        public int ResellValue { get; set; }

        public Potion(string Name, int HP, int OriginalValue, int ResellValue)
        {
            this.Name = Name;
            this.HP = HP;
            this.OriginalValue = OriginalValue;
            this.ResellValue = ResellValue;
        }
    }
}
