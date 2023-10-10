using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Weapons.DeffenceTurrets
{
    internal abstract class DeffenceTurrets_Fabric : Compartments_Factory
    {
        public abstract override TerminalInfoGetter CreateInfoGetter();
    }
    class MainDeffenceTurret_Fabric : DeffenceTurrets_Fabric
    {
        public override TerminalInfoGetter CreateInfoGetter()
        {
            return new MainDeffenceTurrets();
        }
    }
}
