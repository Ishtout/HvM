using HvM.Equipement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HvM.Classe.Monstre
{
    public class Loup : Monstre, ICuir
    {

        public override int Force
        {
            get { return base.Force + 2; }
            set { base.Force = value; }
        }
        public override int Endurance
        {
            get { return base.Endurance + 1; }
            set { base.Endurance = value; }
        }

        public int cuir { get; set; }

        public void Morsure() 
        {
            Console.WriteLine("Le Loup Mord");
        }
        public void Hurlement() 
        {
            Console.WriteLine("Le Loup Hurle fort");
        }


        

    }
}
