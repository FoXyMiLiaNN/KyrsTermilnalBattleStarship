using Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Frame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kyrs_StarBattleshipTerminal.Sectors.Fabrics.Frame
{
    [Serializable]
    class Frame : TerminalInfoGetter
    {
        private string Name = "Корпус корабля";
        private double Strenght { get; set; }
        public Frame() 
        {
            Strenght = 165000;
        }
        public override string GetInfo()
        {
            return $"{Name}\nХарактеристики:\n" +
                $"    -прочность: {Strenght}\n";
        }
        public override string GetMainInfo()
        {
            return $"Название: {Name}, прочность: {Strenght} ";
        }
        public override void SetStrength(double new_strength)
        {
            this.Strenght = new_strength;
        }
    }
}
