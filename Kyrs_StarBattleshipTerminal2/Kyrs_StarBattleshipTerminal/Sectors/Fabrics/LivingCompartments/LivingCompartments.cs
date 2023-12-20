using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrs_StarBattleshipTerminal.Sectors.Fabrics.LivingCompartments
{
    [Serializable]
    class Room1 : TerminalInfoGetter
    {
        private string Name = "Казарма 1";
        private double Rooms { get; set; }
        private double ElectricityConsumption { get; set; }
        private double Strenght { get; set; }
        public override void SetStrength(double new_strenght)
        {
            this.Strenght = new_strenght;
        }
        public Room1()
        {
            Rooms = 1;
            ElectricityConsumption = 250 / 4;
            Strenght = 25000 / 4;
        }
        public override string GetInfo()
        {
            return $"{Name}\nХарактеристики:\n" +
                $"    -прочность: {Strenght}\n" +
                $"    -потребление электричества: {ElectricityConsumption} киловатт-часов\n" +
                $"    -количество комнат: {Rooms}";
        }
        public override string GetMainInfo()
        {
            return $"Название: {Name}, кол-во казарм: 4";
        }
    }
    [Serializable]
    class Room2 : TerminalInfoGetter
    {
        private string Name = "Казарма 2";
        private double Rooms { get; set; }
        private double ElectricityConsumption { get; set; }
        private double Strenght { get; set; }
        public override void SetStrength(double new_strenght)
        {
            this.Strenght = new_strenght;
        }
        public Room2()
        {
            Rooms = 1;
            ElectricityConsumption = 250 / 4;
            Strenght = 25000 / 4;
        }
        public override string GetInfo()
        {
            return $"{Name}\nХарактеристики:\n" +
                $"    -прочность: {Strenght}\n" +
                $"    -потребление электричества: {ElectricityConsumption} киловатт-часов\n" +
                $"    -количество комнат: {Rooms}";
        }
        public override string GetMainInfo()
        {
            return $"Название: {Name}, кол-во казарм: 4";
        }
    }
    [Serializable]
    class Room3 : TerminalInfoGetter
    {
        private string Name = "Казарма 3";
        private double Rooms { get; set; }
        private double ElectricityConsumption { get; set; }
        private double Strenght { get; set; }
        public override void SetStrength(double new_strenght)
        {
            this.Strenght = new_strenght;
        }
        public Room3()
        {
            Rooms = 1;
            ElectricityConsumption = 250 / 4;
            Strenght = 25000 / 4;
        }
        public override string GetInfo()
        {
            return $"{Name}\nХарактеристики:\n" +
                $"    -прочность: {Strenght}\n" +
                $"    -потребление электричества: {ElectricityConsumption} киловатт-часов\n" +
                $"    -количество комнат: {Rooms}";
        }
        public override string GetMainInfo()
        {
            return $"Название: {Name}, кол-во казарм: 4";
        }
    }
    [Serializable]
    class Room4 : TerminalInfoGetter
    {
        private string Name = "Казарма 4";
        private double Rooms { get; set; }
        private double ElectricityConsumption { get; set; }
        private double Strenght { get; set; }
        public override void SetStrength(double new_strenght)
        {
            this.Strenght = new_strenght;
        }
        public Room4()
        {
            Rooms = 1;
            ElectricityConsumption = 250 / 4;
            Strenght = 25000 / 4;
        }
        public override string GetInfo()
        {
            return $"{Name}\nХарактеристики:\n" +
                $"    -прочность: {Strenght}\n" +
                $"    -потребление электричества: {ElectricityConsumption} киловатт-часов\n" +
                $"    -количество комнат: {Rooms}";
        }
        public override string GetMainInfo()
        {
            return $"Название: {Name}, кол-во казарм: 4";
        }
    }
}
