using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Weapons.MainWeapons.AntiAirTurret
{
    internal abstract class AntiAirTurret_Fabric : Compartments_Factory
    {
        public abstract override TerminalInfoGetter CreateInfoGetter();
    }
    class AntiAirTurret1_Fabric : AntiAirTurret_Fabric
    {
        public override TerminalInfoGetter CreateInfoGetter()
        {
            return new AntiAirTurret1();
        }
    }
}
