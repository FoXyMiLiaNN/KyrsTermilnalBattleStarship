using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Batterys
{
    internal class Batteries_Fabric : Compartments_Factory
    {
        public override TerminalInfoGetter CreateInfoGetter()
        {
            return new Batteries();
        }
    }
}
