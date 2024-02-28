using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using HvM.Equipement;

namespace HvM.Equipement
{
    public interface IInventaire
    {
        List<Equipements> InventaireList { get; set; }
        public void GenererInventaire(List<Equipements> liste) 
        {
            Random rnd = new Random();
            InventaireList = new List<Equipements>();
            switch (rnd.Next(0, 3))
            {
                case 0:
                    break;
                case 1:
                    InventaireList.Add(liste[rnd.Next(0,liste.Count)]);
                    break;
                case 2:
                    InventaireList.Add(liste[rnd.Next(0, liste.Count)]);
                    InventaireList.Add(liste[rnd.Next(0, liste.Count)]);
                    break;
            }
        }


        
        
        

    }
}
