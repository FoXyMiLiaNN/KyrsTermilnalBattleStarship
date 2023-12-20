using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Weapons.MainWeapons.Canons
{
    internal abstract class Canons_Fabric : Compartments_Factory
    {
        public abstract override TerminalInfoGetter CreateInfoGetter();
    }
    class Canon1_Fabric : Canons_Fabric
    {
        public override TerminalInfoGetter CreateInfoGetter()
        {
            return new Canon1();
        }
    }
}
