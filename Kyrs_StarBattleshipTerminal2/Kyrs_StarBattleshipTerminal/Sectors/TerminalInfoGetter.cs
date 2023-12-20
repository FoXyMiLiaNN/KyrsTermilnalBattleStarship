using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrs_StarBattleshipTerminal.Sectors
{
    internal abstract class TerminalInfoGetter
    {
        public abstract string GetInfo(); //все характеристики отсека
        public abstract string GetMainInfo(); //краткие характеристики всего корабля
        public abstract void SetStrength(double new_strength); //установщик показателя прочности(для урона по кораблю)
    }
}