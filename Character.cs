using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonballZ
{
    public class Character
    {
        public string Name { get; set; }
        public int KiLevel { get; set; }
        public int FightingStrength { get; set; }

        public Character(string name, int kiLevel, int fightingStrength)
        {
            this.Name = name;
            this.KiLevel = kiLevel;
            this.FightingStrength = fightingStrength;
        }
    }
}
