using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Weapons.Experimentals.Railgun
{
    internal abstract class Railgun_Factory : Compartments_Factory
    {
        public abstract override TerminalInfoGetter CreateInfoGetter();
    }
    class Railgun1_Factory : Railgun_Factory
    {
        public override TerminalInfoGetter CreateInfoGetter()
        {
            return new Railgun1();
        }
    }
}
