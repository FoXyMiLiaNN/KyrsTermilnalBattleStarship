using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Reactors
{
    internal abstract class Reactors_Fabric : Compartments_Factory
    {
        public abstract override TerminalInfoGetter CreateInfoGetter();
    }
    class MainReactor_Fabric : Reactors_Fabric
    {
        public override TerminalInfoGetter CreateInfoGetter()
        {
            return new MainReactor();
        }
    }
}
