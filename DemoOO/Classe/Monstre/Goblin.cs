using HvM.Equipement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HvM.Classe.Monstre
{
    internal class Goblin : Monstre, IOr, IInventaire
    {
        public override int Force
        {
            get { return base.Force - 1; }
            set { base.Force = value; }
        }
        
        public int Or { get ; set ;}
        public List<Equipements> InventaireList {get ; set; }
        public void CoupDeMasse() 
        {
            Console.WriteLine("Le goblin donne un coup de masse");
        }
        public void GenererInventaire(List<Equipements> liste)
        {
            Random rnd = new Random();
            InventaireList = new List<Equipements>();
            switch (rnd.Next(0, 3))
            {
                case 0:
                    break;
                case 1:
                    InventaireList.Add(liste[rnd.Next(0, liste.Count)]);
                    break;
                case 2:
                    InventaireList.Add(liste[rnd.Next(0, liste.Count)]);
                    InventaireList.Add(liste[rnd.Next(0, liste.Count)]);
                    break;
            }
        }
        public override void Stats()
        {
            Random rnd = new Random();
            base.Stats();
            Or = rnd.Next(0, 7);
            GenererInventaire(Jeu.liste);
        }
        public void Loot()
        {
            foreach (var item in InventaireList)
            {
                Console.WriteLine(item.Nom);
            }
        }
        public override void ShowCharacterProfile()
        {
            base.ShowCharacterProfile();
            Console.WriteLine($"Or : {Or}");
        }

    }
}
