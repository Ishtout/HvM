using HvM.Classe.Monstre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HvM.Classe;
using HvM.Equipement;
using System.Diagnostics;
using HvM.Classe.Heros;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace HvM
{
    public class Jeu
    {
        public Personnage Heros { get; set; }
        List<Monstre> Monstres {  get; set; }
        public static List<Equipements> liste { get; set; }
        public static void InitialiserEquipements() 
		{
            liste = new List<Equipements>();
			Arme epeeCourte = new Arme();
			epeeCourte.Nom = "Epee courte";
			epeeCourte.Prix = 15;
			epeeCourte.Face = 6;
			epeeCourte.NbDes = 1;
			liste.Add(epeeCourte);
            Arme epeeLongue = new Arme();
            epeeLongue.Nom = "Epee longue";
            epeeLongue.Prix = 25;
            epeeLongue.Face = 8;
            epeeLongue.NbDes = 1;
			liste.Add(epeeLongue);
			Arme baton = new Arme();
			baton.Nom = "Bâton";
			baton.Prix = 10;
			baton.Face = 4;
			baton.NbDes = 1;
			liste.Add(baton);
			Armure armureDeCuir = new Armure();
			armureDeCuir.Nom = "Armure de Cuir";
            armureDeCuir.Prix = 20;
			armureDeCuir.Retour = 2;
            liste.Add(armureDeCuir);
            Armure armureDePlaque = new Armure();
            armureDePlaque.Nom = "Armure de Plaque";
            armureDePlaque.Prix = 50;
            armureDePlaque.Retour = 5;
			liste.Add(armureDePlaque);
			Consommable potion = new Consommable();
			potion.Nom = "Potion de soin";
			potion.Prix = 20;
			potion.Soin();
			potion.NbDes = 2;
			potion.Face = 4;
			liste.Add(potion);

			
        }
		public void AffichageBoutique(Personnage personnage)
		{
            bool fin = false;
			do
			{
                Console.WriteLine("Bienvenu au marchand Ambulant !");
                Console.WriteLine("Que souhaitez vous acheter ?");
				int cpt = 1;
                foreach (var item in liste)
				{
					Console.WriteLine($"{cpt} . Nom : {item.Nom} ");
					Console.WriteLine($" Prix : {item.Prix} Or");
					cpt++;
				}
                Console.WriteLine($"{cpt} . Quitter .");
				int choix = int.Parse(Console.ReadLine());
				switch (choix)
				{
					case 1:
                        Console.WriteLine($"Voici votre {liste[choix - 1].Nom}");
						personnage.InventaireList.Add(liste[choix-1]);
						personnage.Or -= liste[choix - 1].Prix;
                        break;
                    case 2:
                        Console.WriteLine($"Voici votre {liste[choix - 1].Nom}");
                        personnage.InventaireList.Add(liste[choix - 1]);
                        personnage.Or -= liste[choix - 1].Prix;
                        break;
                    case 3:
                        Console.WriteLine($"Voici votre {liste[choix - 1].Nom}");
                        personnage.InventaireList.Add(liste[choix - 1]);
                        personnage.Or -= liste[choix - 1].Prix;
                        break;
                    case 4:
                        Console.WriteLine($"Voici votre {liste[choix - 1].Nom}");
                        personnage.InventaireList.Add(liste[choix - 1]);
                        personnage.Or -= liste[choix - 1].Prix;
                        break;
                    case 5:
                        Console.WriteLine($"Voici votre {liste[choix - 1].Nom}");
                        personnage.InventaireList.Add(liste[choix - 1]);
                        personnage.Or -= liste[choix - 1].Prix;
                        break;
                    case 6:
                        Console.WriteLine($"Voici votre {liste[choix - 1].Nom}");
                        personnage.InventaireList.Add(liste[choix - 1]);
                        personnage.Or -= liste[choix - 1].Prix;
                        break;
                    case 7:
                        fin = true;
                        break;
                    default:
                        Console.WriteLine("Apprend a écrire.");
                        break;
				}
                Console.WriteLine($"Il vous reste {personnage.Or} or ");
            } while (!fin && personnage.Or > 0);
            Console.WriteLine("Fin des achats.");
            personnage.ShowCharacterProfile();
            personnage.AfficherInventaire();
        }
        public void GenérerMonstre()
		{
			
            Monstres = new List<Monstre>();
            Random rnd = new Random();

		    for (int i = 0; i< 10; i++)
		    {
			    Monstre m;
			    switch (rnd.Next(1, 7))
			    {
				    case 1 :
				    case 2 :
				    case 3 :
						    m = new Goblin();
						    m.Stats();
					    Monstres.Add(m);
					    break;
				    case 4 :
				    case 5 :
						    m = new Loup();
						    m.Stats();
					    Monstres.Add(m);
					    break;
				    case 6 :
						    m = new Orc();
						    m.Stats();
					    Monstres.Add(m);
					    break;
			    }
		    }

		    //foreach (Monstre monstre in Monstres)
		    //{
			   // monstre.ShowCharacterProfile();
				
      //              switch (monstre)
				  //  {
					 //   case Goblin G:
						//    G.CoupDeMasse();
						//    G.Loot();
						//    break;
					 //   case Loup L:
						//    L.Morsure();
						//    L.Hurlement();
						//    break;
					 //   case Orc O:
						//    O.CoupDeHache();
						//    O.CriDeGuerre();
						//    O.Loot();
						//    break;
				  //  }
      //              Console.WriteLine();
      //              Console.WriteLine("--------------");
      //              Console.WriteLine();
      //      }
        }

		
        public void CreeJoueur() 
		{
            Personnage joueur;
            int choix = 0;
            while (choix < 1 || choix > 3)
            {
                Console.WriteLine("Quelle classe voulez vous ?");
                Console.WriteLine("1.Guerrier");
                Console.WriteLine("2.Mage");
                Console.WriteLine("3.Pretre");

                choix = int.Parse(Console.ReadLine());
            }
            switch (choix)
            {
                case 1:
                    joueur = new Guerrier();
                    break;
                case 2:
                    joueur = new Mage();
                    break;
                case 3:
                    joueur = new Pretre();
                    break;
                default:
                    joueur = null;
                    break;
            }
            if (joueur != null)
            {
                joueur.Stats();
                joueur.ShowCharacterProfile();
                Heros = joueur;
            }
        }
        public void Combats(Personnage personnage, Monstre monstre) 
        {
            int cpt = 0;
            Random rnd = new Random();
            List<Arme> ArmesPerso = new List<Arme>();
            List<Armure> ArmurePerso = new List<Armure>();

            foreach (var item in personnage.InventaireList)
            {
                if (item is Arme a)
                {
                    ArmesPerso.Add(a);
                }
                else if (item is Armure b)
                {
                    ArmurePerso.Add(b);
                }
            }
            Console.WriteLine("Quelle arme voulez vous utilisé ? :");
            foreach (var item in ArmesPerso)
            {
                Console.WriteLine($"{cpt++} . {item.Nom}");
            }
            int choixArme = int.Parse(Console.ReadLine());
            Console.WriteLine("Quelle armure voulez vous utilisé ? :");
            foreach (var item in ArmurePerso)
            {
                Console.WriteLine($"{cpt++} . {item.Nom}");
            }
            int choixArmure = int.Parse(Console.ReadLine());
            int attaquePerso = ArmesPerso[choixArme].Degats() + personnage.Modificateur(personnage.Force);
            int attaqueMonstre;
            if (monstre is Goblin)
            {
                attaqueMonstre = rnd.Next(1, 5) + monstre.Modificateur(monstre.Force);
            }
            else if (monstre is Orc)
            {
                attaqueMonstre = rnd.Next(1, 9) + monstre.Modificateur(monstre.Force);
            }
            else
            {
                attaqueMonstre = rnd.Next(1, 7) + monstre.Modificateur(monstre.Force);
            }
            do
            {
                monstre.ShowCharacterProfile();
                monstre.PointDeVie -= attaquePerso;
                Console.WriteLine($"Vous avec infligés {attaquePerso} à {monstre.GetType().Name}");
                personnage.PointDeVie -= (attaqueMonstre - ArmurePerso[choixArmure-1].Reduction());
                Console.WriteLine($" {monstre.GetType().Name} vous a infligés {attaqueMonstre} de dégats.");
            } while (personnage.PointDeVie > 0 && monstre.PointDeVie > 0 );






            //3) Le monstre perds un nbr de PV = aux dégats infligé.
            //4) au tour du monstre de frapper => Goblin : 1D4+ modificateur de force 
            //=> Orc :1D8 + modificateur de force
            //=> Loup : 1D6 + Modificateur de force
        }
        public void LancerJeu() 
        {
            GenérerMonstre();
            CreeJoueur();
            AffichageBoutique(Heros);
            Combats(Heros,Monstres[0]);
        
        }
    }
}
