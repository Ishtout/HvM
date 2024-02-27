using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HvM.Classe.Monstre
{
    public class Orc : Monstre
    {

        public override int Force
        {
            get { return base.Force + 3; }
            set { base.Force = value; }
        }
        public override int Endurance
        {
            get { return base.Endurance + 2; }
            set { base.Endurance = value; }
        }
        public void CoupDeHache()
        {
            Console.WriteLine("L'Orc donne un coup de Hache");
        }
        public void CriDeGuerre() 
        {
            Console.WriteLine("L'orc crie : Encore du travail");
        }
    }
}
