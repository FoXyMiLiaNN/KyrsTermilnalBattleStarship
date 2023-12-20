using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrs_StarBattleshipTerminal.Sectors.Fabrics.ShieldGenerators.ReserveShieldGenerator
{
    [Serializable]
    internal class ReserveShieldGenerator : TerminalInfoGetter
    {
        private string Name = "Резервный генератор защитного поля";
        private double ElectricityConsumption { get; set; }
        private double Strenght { get; set; }
        private double Power { get; set; }
        private double LitesuStainability { get; set; }
        private double HeavyStainability { get; set; }
        private int QuantityOfGenerators { get; set; }
        public ReserveShieldGenerator()
        {
            ElectricityConsumption = 160;
            Strenght = 10000;
            Power = 700;
            LitesuStainability = 70;
            HeavyStainability = 25;
            QuantityOfGenerators = 1;
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
                $"    -мощность генератора: {Power} кВт/ч\n" +
                $"    -устойчивость от лёгких повреждений: {LitesuStainability}%\n" +
                $"    -устойчивость от тяжёлых повреждений: {HeavyStainability}%";
        }
        public override string GetMainInfo()
        {
            return $"Название: {Name}, кол-во генераторов: {QuantityOfGenerators}";
        }
    }
}
