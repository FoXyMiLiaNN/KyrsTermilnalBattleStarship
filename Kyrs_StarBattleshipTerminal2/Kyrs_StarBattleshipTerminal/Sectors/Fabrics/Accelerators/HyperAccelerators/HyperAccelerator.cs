using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Accelerators.HyperAccelerators
{
    [Serializable]
    class MainConverter : TerminalInfoGetter
    {
        private string Name = "Главный преобразователь";
        private double Strenght { get; set; }
        private double ElectricityConsumption { get; set; }
        private double CountOfAccelerators { get; set; }
        public MainConverter() 
        {
            Strenght = 45000;
            ElectricityConsumption = 750;
            CountOfAccelerators = 1;
        }
        public override void SetStrength(double new_strenght)
        {
            this.Strenght = new_strenght;
        }
        public override string GetInfo()
        {
            return $"{Name}\nХарактеристики:\n" +
                $"    -прочность: {Strenght}\n" +
                $"    -потребление электричества: {ElectricityConsumption} киловатт-часов\n" +
                $"    -кол-во преобразователей: {CountOfAccelerators}";
        }
        public override string GetMainInfo()
        {
            return $"Название: {Name}, кол-во двигателей: {CountOfAccelerators}";
        }
    }
}
