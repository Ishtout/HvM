using HvM.Classe.Monstre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HvM.Equipement
{
    public class Equipements
    {
        public string Nom {  get; set; }
        public int Prix { get; set; }
        public int NbDes { get; set; }
        public int Face { get; set; }


        public virtual void ShowItemProfile()
        {
            Console.WriteLine($"Nom : {Nom}");
            Console.WriteLine($"Prix : {Prix} Po");
        }

    }
}
