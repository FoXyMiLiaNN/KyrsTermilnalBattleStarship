using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrs_StarBattleshipTerminal.Sectors.Fabrics.CapitansBridgeFabric
{
    [Serializable]
    internal class CapitansBridge : TerminalInfoGetter
    {
        private string Name = "Капитанский мостик";
        private int PersonalQuantity { get; set; }
        private int CapitanCount { get; set; }
        private int LocationOperatorsCount { get; set; }
        private int IngineersCount { get; set; }
        private int SteeringCount { get; set; } //рулевой
        private double Strenght { get; set; }
        private double ElectricityConsumption { get; set; }
        private int CountOf { get; set; }
        public CapitansBridge()
        {
            Strenght = 75000;
            ElectricityConsumption = 400;
            CountOf = 1;
            CapitanCount = 1;
            LocationOperatorsCount = 4;
            IngineersCount = 3;
            SteeringCount = 2;
        }
        public override void SetStrength(double new_strenght)
        {
            this.Strenght = new_strenght;
        }
        public override string GetInfo()
        {
            PersonalQuantity = CapitanCount + LocationOperatorsCount + IngineersCount + SteeringCount;
            return $"{Name}\nХарактеристики:\n" +
                $"    -прочность: {Strenght}\n" +
                $"    -потребление электричества: {ElectricityConsumption}\n" +
                $"    -кол-во помещений мостика: {CountOf}\n" +
                $"    -кол-во мест персонала: {PersonalQuantity}\n" +
                $"    -кол-во операторов локаторов: {LocationOperatorsCount}\n" +
                $"    -кол-во бортовых инженеров: {IngineersCount}\n" +
                $"    -кол-во рудевых: {SteeringCount}";
        }
        public override string GetMainInfo()
        {
            return $"Название: {Name}, кол-во помещений мостика: {CountOf}";
        }
    }
}
