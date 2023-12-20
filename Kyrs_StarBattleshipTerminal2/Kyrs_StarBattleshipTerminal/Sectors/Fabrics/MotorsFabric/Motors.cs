using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrs_StarBattleshipTerminal.Sectors.Fabrics.MotorsFabric
{
    [Serializable]
    class IonMotors : TerminalInfoGetter
    {
        private string Name = "Ионные двигатели";
        private double Power { get; set; }
        private double Consumption { get; set; }
        private int QuantityOfMotors { get; set; }
        private double ElectricityConsumption { get; set; }
        private double Strenght { get; set; }
        public IonMotors()
        {
            Power = 3.5;
            Consumption = 74;
            QuantityOfMotors = 4;
            ElectricityConsumption = 800;
            Strenght = 55000;
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
                $"    -мощность двигателя: {Power} кВт\n" +
                $"    -потребление: {Consumption} ксенона/мин\n" +
                $"    -кол-во двигателей: {QuantityOfMotors}";
        }
        public override string GetMainInfo()
        {
            return $"Название: {Name}, кол-во двигателей: {QuantityOfMotors}";
        }
    }
    [Serializable]
    class ReactiveMotors : TerminalInfoGetter
    {
        private string Name = "Реактивные двигатели";
        private double Power { get; set; }
        private double Consumption { get; set; }
        private int QuantityOfMotors { get; set; }
        private double ElectricityConsumption { get; set; }
        private double Strenght { get; set; }
        public ReactiveMotors()
        {
            Power = 6;
            Consumption = 300;
            QuantityOfMotors = 4;
            ElectricityConsumption = 640;
            Strenght = 50000;
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
                $"    -эквивалентный удельный импульс: {Power} км/с\n" +
                $"    -потребление: {Consumption} кг/мин\n" +
                $"    -кол-во двигателей: {QuantityOfMotors}";
        }
        public override string GetMainInfo()
        {
            return $"Название: {Name}, кол-во двигателей: {QuantityOfMotors}";
        }
    }
    [Serializable]
    class HyperMotors : TerminalInfoGetter
    {
        private string Name = "Сверхсветовой гипердвигатель";
        private double Power { get; set; }
        private double Consumption { get; set; }
        private int QuantityOfMotors { get; set; }
        private double ElectricityConsumption { get; set; }
        private double Strenght { get; set; }
        public HyperMotors()
        {
            Power = 10;
            Consumption = 0.01;
            QuantityOfMotors = 1;
            ElectricityConsumption = 1200;
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
                $"    -общая мощность: {Power} террават\n" +
                $"    -потребление: {Consumption} гр/с\n" +
                $"    -кол-во двигателей: {QuantityOfMotors}";
        }
        public override string GetMainInfo()
        {
            return $"Название: {Name}, кол-во гипердвигателей: {QuantityOfMotors}";
        }
    }
}
