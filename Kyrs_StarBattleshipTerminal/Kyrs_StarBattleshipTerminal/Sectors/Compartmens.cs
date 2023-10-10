using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrs_StarBattleshipTerminal.Sectors
{
    internal class Compartments
    {
        private TerminalInfoGetter infoGetter;
        public Compartments(Compartments_Factory factory)
        {
            infoGetter = factory.CreateInfoGetter();
        }

        public string GetInfo()
        {
            return infoGetter.GetInfo();
        }
    }
}
