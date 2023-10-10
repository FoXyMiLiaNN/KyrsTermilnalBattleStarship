using Kyrs_StarBattleshipTerminal.Sectors.Fabrics.MedicineFabric;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrs_StarBattleshipTerminal.Sectors.Fabrics
{
    internal class MedicineCompartments_Fabric : Compartments_Factory
    {
        public override TerminalInfoGetter CreateInfoGetter()
        {
            return new MedicineCompartments();
        }
    }
}
