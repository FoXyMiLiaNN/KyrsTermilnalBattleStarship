using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrs_StarBattleshipTerminal.Sectors.Fabrics.MotorsFabric
{
    internal abstract class Motors_Fabric : Compartments_Factory
    {
        public abstract override TerminalInfoGetter CreateInfoGetter();
    }

    class IonMotors_Fabric : Motors_Fabric
    {
        public override TerminalInfoGetter CreateInfoGetter()
        {
            return new IonMotors();
        }
    }
    class ReactiveMotors_Fabric : Motors_Fabric
    {
        public override TerminalInfoGetter CreateInfoGetter()
        {
            return new ReactiveMotors();
        }
    }
    class HyperMotors_Fabric : Motors_Fabric
    {
        public override TerminalInfoGetter CreateInfoGetter()
        {
            return new HyperMotors();
        }
    }
}
