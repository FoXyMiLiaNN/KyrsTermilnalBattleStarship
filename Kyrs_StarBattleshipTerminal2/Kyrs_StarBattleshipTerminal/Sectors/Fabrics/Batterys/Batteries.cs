using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Batterys
{
    [Serializable]
    internal class Batteries : TerminalInfoGetter
    {
        private string Name = "Аккумуляторы";
        private double Strenght { get; set; }
        private double MaxElectricityForOneBattary { get; set; }
        private int CountOfBattaries { get; set; }
        public Batteries() 
        {
            Strenght = 45000;
            MaxElectricityForOneBattary = 400;
            CountOfBattaries = 12;
        }
        public override void SetStrength(double new_strenght)
        {
            this.Strenght = new_strenght;
        }
        public override string GetInfo()
        {
            return $"{Name}\nХарактеристики:\n" +
                $"    -прочность: {Strenght}\n" +
                $"    -максимальное накопление электричества одной батареи: {MaxElectricityForOneBattary} киловатт-часов\n" +
                $"    -максимальное накопление всех батарей: {MaxElectricityForOneBattary * 12}\n" +
                $"    -кол-во ускорителей: {CountOfBattaries}";
        }
        public override string GetMainInfo()
        {
            return $"Название: {Name}, кол-во батарей: {CountOfBattaries}";
        }
    }
}
