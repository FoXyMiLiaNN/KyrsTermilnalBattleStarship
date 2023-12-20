using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrs_StarBattleshipTerminal.Sectors.Fabrics.LocationSystems
{
    [Serializable]
    internal class LocationSystems : TerminalInfoGetter
    {
        private string Name = "Отсек обнаружения и идентификации";
        private double EnemyDetectionRadius { get; set; }
        private double HiddenEnemyDetectionRadius { get; set; }
        private double RocketsDetectionRadius { get; set; }
        private double EMPDetectionRadius { get; set; }
        private double EnemyElectricityConsumption { get; set; }
        private double OthersElectricityConsumption { get; set; }
        private double Strenght { get; set; }
        public LocationSystems()
        {
            EnemyDetectionRadius = 0.4;
            HiddenEnemyDetectionRadius = 1000000;
            RocketsDetectionRadius = 200000;
            EMPDetectionRadius = 0.6;
            EnemyElectricityConsumption = 320;
            OthersElectricityConsumption = 160;
            Strenght = 5000;
        }
        public override void SetStrength(double new_strenght)
        {
            this.Strenght = new_strenght;
        }
        public override string GetInfo()
        {
            return $"{Name}\nХарактеристики:\n" +
                $"    -прочность отска: {Strenght}\n" +
                $"    -общее потребление электричества: {EnemyElectricityConsumption + OthersElectricityConsumption} киловатт-часов\n" +
                $"    -потребление электричества системы обнаружения и идентификации противников и космических тел: {EnemyElectricityConsumption} киловатт-часов\n" +
                $"    -потребление электричества системы обнаружения и идентификации ракет и сигналов: {EnemyElectricityConsumption} киловатт-часов\n" +
                $"    -радиус обнаружения противников: {EnemyDetectionRadius} парсек\n" +
                $"    -радиус обнаружения скрытых/замаскированных целей: {HiddenEnemyDetectionRadius} км\n" +
                $"    -радиус обнаружения ракет: {RocketsDetectionRadius} км\n" +
                $"    -радиус обнаружения электромагнитных импульсов: {EMPDetectionRadius} парсек";
        }
        public override string GetMainInfo()
        {
            return $"Название: {Name}\n" +
                $"    Cистемы:" +
                $"    -Система обнаружения и идентификации противников и космических тел\n" +
                $"    -Система обнаружения и идентификации ракет и сигналов";
        }
    }
}
