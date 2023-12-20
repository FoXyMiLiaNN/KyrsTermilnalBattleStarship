using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrs_StarBattleshipTerminal.Sectors.Fabrics.StorageCompartments
{
    internal abstract class Storage_Fabric : Compartments_Factory
    {
        public abstract override TerminalInfoGetter CreateInfoGetter();
    }
    class LargeStorage_Fabric : Storage_Fabric
    {
        public override TerminalInfoGetter CreateInfoGetter()
        {
            return new LargeStorage();
        }
    }
    class MiddleStorage_Fabric : Storage_Fabric
    {
        public override TerminalInfoGetter CreateInfoGetter()
        {
            return new MiddleStorage();
        }
    }
    class SmallStorage_Fabric : Storage_Fabric
    {
        public override TerminalInfoGetter CreateInfoGetter()
        {
            return new SmallStorage();
        }
    }
}
