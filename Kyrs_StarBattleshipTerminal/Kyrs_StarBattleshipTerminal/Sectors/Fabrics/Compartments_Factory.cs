using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrs_StarBattleshipTerminal.Sectors
{
    internal abstract class Compartments_Factory
    {
        public abstract TerminalInfoGetter CreateInfoGetter();
    }
}
