using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Frame
{
    internal class Frame_Fabric : Compartments_Factory
    {
        public override TerminalInfoGetter CreateInfoGetter()
        {
            return new Frame();
        }
    }
}
