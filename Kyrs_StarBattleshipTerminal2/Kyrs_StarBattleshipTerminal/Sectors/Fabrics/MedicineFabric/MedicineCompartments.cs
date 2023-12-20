using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrs_StarBattleshipTerminal.Sectors.Fabrics.MedicineFabric
{
    [Serializable]
    internal class MedicineCompartments : TerminalInfoGetter
    {
        private string Name = "Медицинский отсек";
        private double Crew { get; set; }
        private int QuantityOfMedicins { get; set; } 
        private double ElectricityConsumption { get; set; }
        private double Strenght { get; set; }
        public MedicineCompartments()
        {
            Crew = 32;
            QuantityOfMedicins = 4000;
            ElectricityConsumption = 240;
            Strenght = 65500;
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
                $"    -кол-во медикаментов: {QuantityOfMedicins} штук\n" +
                $"    -персонал: {Crew} санитара";
        }
        public override string GetMainInfo()
        {
            return $"Название: {Name}, кол-во отсеков: 1";
        }
    }
}
