using HvM.Equipement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HvM.Classe.Heros
{
    public class Personnage : Entite, IOr, IInventaire
    {
        public int Or { get; set; }
        public string Nom { get; set; }
        private int _intelligence;
        public virtual int Intelligence
        {
            get { return _intelligence ; }
            set { _intelligence = value; }
        }
        private int _sagesse;
        public virtual int Sagesse
        {
            get { return _sagesse ; }
            set { _sagesse = value; }
        }
        public List<Equipements> InventaireList { get; set; }
        public override void Stats()
        {
            InventaireList = new List<Equipements>();
            Console.Write($"Choisissez votre nom pour votre {GetType().Name} : ");
            Nom = Console.ReadLine();

            Random rnd = new Random();
            Force = rnd.Next(10, 21);
            Endurance = rnd.Next(10, 21);
            Sagesse = rnd.Next(10, 21);
            Intelligence = rnd.Next(10, 21);
            Or = 100;
            PointDeVie = 10;
            

        }
        public override void ShowCharacterProfile()
        {
            Console.WriteLine(GetType().Name);
            Console.WriteLine($"Force : {Force} ({_force}) ({Modificateur(Force)})");
            Console.WriteLine($"Endu : {Endurance} ({_endurance}) ({Modificateur(Endurance)})");
            Console.WriteLine($"Intel : {Intelligence} ({_intelligence}) ({Modificateur(Intelligence)})");
            Console.WriteLine($"Sagesse : {Sagesse} ({_sagesse}) ({Modificateur(Sagesse)})");
            Console.WriteLine($"Or : {Or}");
            Console.WriteLine($"Point de vie : {PointDeVie}");
        }
        public void AfficherInventaire()
        {
            Console.WriteLine("Vous avez : ");
            foreach (var item in InventaireList)
            {
                Console.WriteLine($"{item.Nom}");
            }
        }

        
    }
}
