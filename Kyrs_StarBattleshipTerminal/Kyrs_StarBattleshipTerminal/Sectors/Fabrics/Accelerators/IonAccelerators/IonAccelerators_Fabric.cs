using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Accelerators
{
    internal abstract class IonAccelerators_Fabric : Compartments_Factory
    {
        public abstract override TerminalInfoGetter CreateInfoGetter();
    }
    class LeftManevrators_Fabric : IonAccelerators_Fabric
    {
        public override TerminalInfoGetter CreateInfoGetter()
        {
            return new LeftManevrators();
        }
    }
    class RightManevrators_Fabric : IonAccelerators_Fabric
    {
        public override TerminalInfoGetter CreateInfoGetter()
        {
            return new RightManevrators();
        }
    }
    class FrontManevrators_Fabric : IonAccelerators_Fabric
    {
        public override TerminalInfoGetter CreateInfoGetter()
        {
            return new FrontManevrators();
        }
    }
    class BackManevrators_Fabric : IonAccelerators_Fabric
    {
        public override TerminalInfoGetter CreateInfoGetter()
        {
            return new BackManevrators();
        }
    }
}
