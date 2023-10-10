using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Weapons.MainWeapons.RocketTurets
{
    internal abstract class RocketTurrets_Fabric : Compartments_Factory
    {
        public abstract override TerminalInfoGetter CreateInfoGetter();
    }
    class RocketTurret1_Fabric : RocketTurrets_Fabric
    {
        public override TerminalInfoGetter CreateInfoGetter()
        {
            return new RocketTurret1();
        }
    }
}
