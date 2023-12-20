using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Accelerators.ReactiveAccelerators
{
    [Serializable]
    class PrimaryAccelerators : TerminalInfoGetter
    {
        private string Name = "Первичные ускорители";
        private double Strenght { get; set; }
        private double ElectricityConsumption { get; set; }
        private double CountOfAccelerators { get; set; }
        public PrimaryAccelerators() 
        {
            Strenght = 30000;
            ElectricityConsumption = 320;
            CountOfAccelerators = 4;
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
                $"    -кол-во ускорителей: {CountOfAccelerators}";
        }
        public override string GetMainInfo()
        {
            return $"Название: {Name}, кол-во двигателей:{CountOfAccelerators}";
        }
    }
    [Serializable]
    class SecondaryAccelerators : TerminalInfoGetter
    {
        private string Name = "Вторичные ускорители";
        private double Strenght { get; set; }
        private double ElectricityConsumption { get; set; }
        private double CountOfAccelerators { get; set; }
        public SecondaryAccelerators()
        {
            Strenght = 30000;
            ElectricityConsumption = 240;
            CountOfAccelerators = 8;
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
                $"    -кол-во ускорителей: {CountOfAccelerators}";
        }
        public override string GetMainInfo()
        {
            return $"Название: {Name}, кол-во двигателей: {CountOfAccelerators}";
        }
    }
}
