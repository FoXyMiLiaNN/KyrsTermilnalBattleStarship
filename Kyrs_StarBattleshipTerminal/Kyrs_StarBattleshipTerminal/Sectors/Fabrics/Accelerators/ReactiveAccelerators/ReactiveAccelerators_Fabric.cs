using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Accelerators.ReactiveAccelerators
{
    internal abstract class ReactiveAccelerators_Fabrics : Compartments_Factory
    {
        public abstract override TerminalInfoGetter CreateInfoGetter();
    }
    class PrimaryAccelerators_Fabric : ReactiveAccelerators_Fabrics
    {
        public override TerminalInfoGetter CreateInfoGetter()
        {
            return new PrimaryAccelerators();
        }
    }
    class SecondaryAccelerators_Fabric : ReactiveAccelerators_Fabrics
    {
        public override TerminalInfoGetter CreateInfoGetter()
        {
            return new SecondaryAccelerators();
        }
    }
}
