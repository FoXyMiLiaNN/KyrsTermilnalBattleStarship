using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Weapons.DeffenceTurrets
{
    [Serializable]
    class MainDeffenceTurrets : TerminalInfoGetter
    {
        private string Name = "Оборонительные турели";
        private double ElectricityConsumption { get; set; }
        private double Strenght { get; set; }
        private double DamageFrame { get; set; }
        private double DamageShields { get; set; }
        private string Distance { get; set; }
        private int Quantity { get; set; }
        private double FireRate1 { get; set; }
        private double FireRate2 { get; set; }
        public MainDeffenceTurrets()
        {
            ElectricityConsumption = 480;
            Strenght = 25000;
            DamageFrame = 4500;
            DamageShields = 3000;
            Quantity = 8;
            Distance = "близкая";
            FireRate1 = 6;
            FireRate2 = 1;
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
                $"    -кол-во турелей: {Quantity}\n" +
                $"    -урон по корпусу: {DamageFrame}\n" +
                $"    -урон по энергетическому полю: {DamageShields}\n" +
                $"    -дальность наведения: {Distance}\n" +
                $"    -скорострельность: {FireRate1} выстрелов/{FireRate2}с";
        }
        public override string GetMainInfo()
        {
            return $"Название: {Name}, кол-во турелей: {Quantity}";
        }
    }
}
