using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Accelerators
{
    [Serializable]
    class LeftManevrators : TerminalInfoGetter
    {
        private string Name = "Левые маневраторы";
        private double Strenght { get; set; }
        private double ElectricityConsumption { get; set; }
        private double CountOfAccelerators { get; set; }
        public LeftManevrators() 
        {
            Strenght = 30000;
            ElectricityConsumption = 80;
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
            return $"Название: {Name}, кол-во двигателей: {CountOfAccelerators}";
        }
    }
    [Serializable]
    class RightManevrators : TerminalInfoGetter
    {
        private string Name = "Правые маневраторы";
        private double Strenght { get; set; }
        private double ElectricityConsumption { get; set; }
        private double CountOfAccelerators { get; set; }
        public RightManevrators()
        {
            Strenght = 30000;
            ElectricityConsumption = 80;
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
            return $"Название: {Name}, кол-во двигателей: {CountOfAccelerators}";
        }
    }
    [Serializable]
    class FrontManevrators : TerminalInfoGetter
    {
        private string Name = "Правые маневраторы";
        private double Strenght { get; set; }
        private double ElectricityConsumption { get; set; }
        private double CountOfAccelerators { get; set; }
        public FrontManevrators()
        {
            Strenght = 30000;
            ElectricityConsumption = 160;
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
    [Serializable]
    class BackManevrators : TerminalInfoGetter
    {
        private string Name = "Правые маневраторы";
        private double Strenght { get; set; }
        private double ElectricityConsumption { get; set; }
        private double CountOfAccelerators { get; set; }
        public BackManevrators()
        {
            Strenght = 30000;
            ElectricityConsumption = 120;
            CountOfAccelerators = 6;
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
