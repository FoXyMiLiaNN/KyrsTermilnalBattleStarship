using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Accelerators.HyperAccelerators
{
    internal abstract class HyperAccelerators_Factory : Compartments_Factory
    {
        public abstract override TerminalInfoGetter CreateInfoGetter();
    }
    class MainCoverter_Fabric : HyperAccelerators_Factory
    {
        public override TerminalInfoGetter CreateInfoGetter()
        {
            return new MainConverter();
        }
    }
}
