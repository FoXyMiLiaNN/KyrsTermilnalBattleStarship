using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrs_StarBattleshipTerminal.Sectors.Fabrics.StorageCompartments
{
    [Serializable]
    class LargeStorage : TerminalInfoGetter
    {
        private string Name = "Большие хранилища";
        private double ElectricityConsumption { get; set; }
        private double Capacity { get; set; }
        private int QuantityOfStorages { get; set; }
        private double Strenght { get; set; }
        public LargeStorage() 
        {
            ElectricityConsumption = 240;
            Capacity = 500;
            QuantityOfStorages = 1;
            Strenght = 80000;
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
                $"    -вместимость одного хранилища: {Capacity} т\n" +
                $"    -количество хранилищ: {QuantityOfStorages}";
        }
        public override string GetMainInfo()
        {
            return $"Название: {Name}, кол-во хранилищ: {QuantityOfStorages}";
        }
    }
    [Serializable]
    class MiddleStorage : TerminalInfoGetter
    {
        private string Name = "Средние хранилища";
        private double ElectricityConsumption { get; set; }
        private double Capacity { get; set; }
        private int QuantityOfStorages { get; set; }
        private double Strenght { get; set; }
        public MiddleStorage()
        {
            ElectricityConsumption = 160;
            Capacity = 50;
            QuantityOfStorages = 2;
            Strenght = 65000;
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
                $"    -вместимость одного хранилища: {Capacity} т\n" +
                $"    -количество хранилищ: {QuantityOfStorages}";
        }
        public override string GetMainInfo()
        {
            return $"Название: {Name}, кол-во хранилищ: {QuantityOfStorages}";
        }
    }
    [Serializable]
    class SmallStorage : TerminalInfoGetter
    {
        private string Name = "Большие хранилища";
        private double ElectricityConsumption { get; set; }
        private double Capacity { get; set; }
        private int QuantityOfStorages { get; set; }
        private double Strenght { get; set; }
        public SmallStorage()
        {
            ElectricityConsumption = 80;
            Capacity = 800;
            QuantityOfStorages = 4;
            Strenght = 45000;
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
                $"    -вместимость одного хранилища: {Capacity} кг\n" +
                $"    -количество хранилищ: {QuantityOfStorages}";
        }
        public override string GetMainInfo()
        {
            return $"Название: {Name}, кол-во хранилищ: {QuantityOfStorages}";
        }
    }
}
