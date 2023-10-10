using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Weapons.Experimentals.Nuke
{
    internal abstract class Nuke_Fabric : Compartments_Factory
    {
        public abstract override TerminalInfoGetter CreateInfoGetter();
    }
    class Launcher1_Fabric : Nuke_Fabric
    {
        public override TerminalInfoGetter CreateInfoGetter()
        {
            return new Launcher1();
        }
    }
}
