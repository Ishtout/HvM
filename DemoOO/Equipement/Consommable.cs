using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HvM.Equipement
{
    public class Consommable : Equipements
    {
        public int Soin()
        {
            Random rnd = new Random();
            return NbDes * rnd.Next(1, Face + 1);
        }
        public override void ShowItemProfile()
        {
            Console.WriteLine($"Nom : {Nom}");
            Console.WriteLine($"Prix : {Prix} Po");
            Console.WriteLine($"Rend : {Soin()} Pv");
        }
    }
}
