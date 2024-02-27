using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HvM.Classe.Monstre
{
    internal class Goblin : Monstre
    {
        
        public override int Force
        {
            get { return base.Force - 1; }
            set { base.Force = value; }
        }
        public override int Endurance
        {
            get { return base.Endurance; }
            set { base.Endurance = value; }
        }
        public void CoupDeMasse() 
        {
            Console.WriteLine("Le goblin donne un coup de masse");
        }


//Orc(+3 for, +2endu) Coup de hache Cri de guerre("Encore du travail")
    }
}
