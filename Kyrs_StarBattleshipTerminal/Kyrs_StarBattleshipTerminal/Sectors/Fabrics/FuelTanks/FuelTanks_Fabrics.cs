using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrs_StarBattleshipTerminal.Sectors.Fabrics.FuelTanks
{
    internal abstract class FuelTanks_Fabrics : Compartments_Factory
    {
        public abstract override TerminalInfoGetter CreateInfoGetter();
    }
    class IonGaseTanks_Fabric : FuelTanks_Fabrics
    {
        public override TerminalInfoGetter CreateInfoGetter()
        {
            return new IonGaseTanks();
        }
    }
    class KerasinTanks_Fabric : FuelTanks_Fabrics
    {
        public override TerminalInfoGetter CreateInfoGetter()
        {
            return new KerasinTanks();
        }
    }
    class DarkMateryTanks_Fabric : FuelTanks_Fabrics
    {
        public override TerminalInfoGetter CreateInfoGetter()
        {
            return new DarkMateryTanks();
        }
    }
}
