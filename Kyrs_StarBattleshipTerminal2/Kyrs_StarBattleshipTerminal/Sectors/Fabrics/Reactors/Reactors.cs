using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Reactors
{
    [Serializable]
    class MainReactor : TerminalInfoGetter
    {
        private string Name = "Главный реактор";
        private double ElectricityProduction { get; set; }
        private double FuelConsumption { get; set; }
        private double Strenght { get; set; }
        private int QuantityOfReactors { get; set; }
        public MainReactor() 
        {
            ElectricityProduction = 800;
            FuelConsumption = 70;
            Strenght = 95000;
        }
        public override void SetStrength(double new_strenght)
        {
            this.Strenght = new_strenght;
        }
        public override string GetInfo()
        {
            return $"{Name}\nХарактеристики:\n" +
                $"    -прочность: {Strenght}\n" +
                $"    -выработка электричества: {ElectricityProduction} кВт/ч\n" +
                $"    -потребление топлива: {FuelConsumption} л/ч";
        }
        public override string GetMainInfo()
        {
            return $"Название: {Name}, кол-во реакторов: {QuantityOfReactors}";
        }
    }
}
