using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Weapons.MainWeapons.RocketTurets
{
    [Serializable]
    class RocketTurret1 : TerminalInfoGetter
    {
        private string Name = "Ракеттные утановки";
        private double ElectricityConsumption { get; set; }
        private double Strenght { get; set; }
        private double DamageFrame { get; set; }
        private double DamageShields { get; set; }
        private string Distance { get; set; }
        private int Quantity { get; set; }
        private double FireRate1 { get; set; }
        private double FireRate2 { get; set; }
        public RocketTurret1()
        {
            ElectricityConsumption = 400;
            Strenght = 50000;
            DamageFrame = 4000;
            DamageShields = 2000;
            Quantity = 2;
            Distance = "дальняя";
            FireRate1 = 1;
            FireRate2 = 30;
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
                $"    -скорострельность: {FireRate1} выстрелов/{FireRate2}c";
        }
        public override string GetMainInfo()
        {
            return $"Название: {Name}, кол-во турелей: {Quantity}";
        }
    }
}
