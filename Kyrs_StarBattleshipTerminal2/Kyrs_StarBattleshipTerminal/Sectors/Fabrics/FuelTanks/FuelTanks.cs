using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Kyrs_StarBattleshipTerminal.Sectors.Fabrics.FuelTanks
{
    [Serializable]
    class IonGaseTanks : TerminalInfoGetter
    {
        private string Name = "Баки ионизированного газа";
        private double Capacity { get; set; }
        private double ElectricityConsumption { get; set; }
        private double Strenght { get; set; }
        private int TanksCount { get; set; }
        public IonGaseTanks()
        {
            Capacity = 5000;
            Strenght = 17500;
            ElectricityConsumption= 100;
            TanksCount = 8;
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
                $"    -общая вместимость: {Capacity} литров\n" +
                $"    -кол-во баков: {TanksCount}";
        }
        public override string GetMainInfo()
        {
            return $"Название: {Name}, кол-во баков: {TanksCount}";
        }
    }
    [Serializable]
    class KerasinTanks : TerminalInfoGetter
    {
        private string Name = "Баки керасина";
        private double Capacity { get; set; }
        private double ElectricityConsumption { get; set; }
        private double Strenght { get; set; }
        private int TanksCount { get; set; }
        public KerasinTanks()
        {
            Capacity = 2000;
            Strenght = 17500;
            ElectricityConsumption = 100;
            TanksCount = 8;
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
                $"    -общая вместимость: {Capacity} литров\n" +
                $"    -кол-во баков: {TanksCount}";
        }
        public override string GetMainInfo()
        {
            return $"Название: {Name}, кол-во баков: {TanksCount}";
        }
    }
    [Serializable]
    class DarkMateryTanks : TerminalInfoGetter
    {
        private string Name = "Баки тёмной материи";
        private double Capacity { get; set; }
        private double ElectricityConsumption { get; set; }
        private double Strenght { get; set; }
        private int TanksCount { get; set; }
        public DarkMateryTanks()
        {
            Capacity = 2;
            Strenght = 17500;
            ElectricityConsumption = 200;
            TanksCount = 2;
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
                $"    -общая вместимость: {Capacity} кг\n" +
                $"    -кол-во баков: {TanksCount}";
        }
        public override string GetMainInfo()
        {
            return $"Название: {Name}, кол-во баков: {TanksCount}";
        }
    }
}
