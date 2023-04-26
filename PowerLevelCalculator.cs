using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonballZ
{
    public class PowerLevelCalculator
    {
        public int CalculatePowerLevel(Character character)
        {
            return character.KiLevel * character.FightingStrength;
        }
    }
}
