using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Weapons.MainWeapons.LaserTurrets
{
    internal abstract class LaserTurrets_Fabric : Compartments_Factory
    {
        public abstract override TerminalInfoGetter CreateInfoGetter();
    }
    class LaserTurret1_Fabric : LaserTurrets_Fabric
    {
        public override TerminalInfoGetter CreateInfoGetter()
        {
            return new LaserTurret1();
        }
    }
}
