using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrs_StarBattleshipTerminal.Sectors.Fabrics.LivingCompartments
{
    internal abstract class LivingCompartments_Fabric : Compartments_Factory
    {
        public abstract override TerminalInfoGetter CreateInfoGetter();
    }
    class Room1_Fabric : LivingCompartments_Fabric
    {
        public override TerminalInfoGetter CreateInfoGetter()
        {
            return new Room1();
        }
    }
    class Room2_Fabric : LivingCompartments_Fabric
    {
        public override TerminalInfoGetter CreateInfoGetter()
        {
            return new Room2();
        }
    }
    class Room3_Fabric : LivingCompartments_Fabric
    {
        public override TerminalInfoGetter CreateInfoGetter()
        {
            return new Room3();
        }
    }
    class Room4_Fabric : LivingCompartments_Fabric
    {
        public override TerminalInfoGetter CreateInfoGetter()
        {
            return new Room4();
        }
    }
}
