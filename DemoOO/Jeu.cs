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
                Console.WriteLine($"Vous avez {personnage.Or} Or disponible");
                Console.WriteLine($"Vous avez {personnage.PointDeVie} Point de vie");
                Console.WriteLine("Que souhaitez vous faire ?");
                Console.WriteLine("1: Acheter");
                Console.WriteLine("2: Vendre");
                
                foreach (var item in personnage.InventaireList)
                {
                    if (item is Consommable)
                    {
                        Console.WriteLine("3: Utiliser une potion");
                    }
                }
                Console.WriteLine("4: Quitter");

                int choix = int.Parse(Console.ReadLine());
                switch (choix)
                {
                    case 1:
                        do
                        {
                            Console.WriteLine("Que souhaitez vous acheter ?");
                        int cpt = 1;
                        foreach (var item in liste)
                        {
                            Console.WriteLine($"{cpt} . {item.Nom} ");
                            Console.WriteLine($" Prix : {item.Prix} Or");
                            cpt++;
                        }
                        Console.WriteLine($"{cpt} . Quitter .");
                        choix = int.Parse(Console.ReadLine());
                        switch (choix)
                        {
                            case 1:
                            case 2:
                            case 3:
                            case 4:
                            case 5:
                            case 6:
                                Console.WriteLine($"Voici votre {liste[choix - 1].Nom}");
                                if (personnage.Or < liste[choix - 1].Prix)
                                {
                                    Console.WriteLine("Tu peux pas acheter.");
                                }
                                else
                                {
                                    personnage.InventaireList.Add(liste[choix - 1]);
                                    personnage.Or -= liste[choix - 1].Prix;
                                }
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
                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine("Que souhaitez vous Vendre ?");
                         int cpt = 1;
                        foreach (var item in personnage.InventaireList)
                        {
                            Console.WriteLine($"{cpt} : {item.Nom} ");
                            Console.WriteLine($" Prix : {item.Prix} Or");
                            cpt++;
                        }
                            Console.WriteLine($"{cpt} : Quitter");
                            choix = int.Parse(Console.ReadLine());
                            if (choix < cpt && choix >=0)
                            {
                                Console.WriteLine($"Merci pour la vente de {personnage.InventaireList[choix - 1].Nom}");
                                Console.WriteLine($"Au prix de {personnage.InventaireList[choix - 1].Prix / 2} Or");
                                personnage.Or += (personnage.InventaireList[choix - 1].Prix / 2);
                                personnage.InventaireList.Remove(personnage.InventaireList[choix - 1]);
                            }
                            else
                            {
                                fin = true;
                            }
                } while (!fin) ;
                        break;
                    case 3:
                        List<Consommable> PotionPerso = new List<Consommable>();
                        foreach (var item in personnage.InventaireList)
                        {
                            if (item is Consommable c)
                            {
                                PotionPerso.Add(c);
                            }
                        }
                        personnage.PointDeVie += PotionPerso[0].Soin();
                        if ((personnage.PointDeVie + PotionPerso[0].Soin()) > personnage.Pointdeviemax)
                        {
                            personnage.PointDeVie = personnage.Pointdeviemax;
                            personnage.InventaireList.Remove(PotionPerso[0]);
                        }
                        else
                        {
                            personnage.PointDeVie += PotionPerso[0].Soin();
                            personnage.InventaireList.Remove(PotionPerso[0]);
                        }
                        break;
                    case 4:
                        fin = true;
                        break;
                }
            } while (!fin && personnage.Or > 0);
            Console.WriteLine("Fin des achats/vente.");
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

            //    switch (monstre)
            //    {
            //        case Goblin G:
            //            G.GenererInventaire(liste);
            //            break;
            //        case Orc O:
            //            O.GenererInventaire(liste);
            //            break;
            //    }
            //}
        }
        public void RecupLoot(Personnage personnage,Monstre monstre)
        {
            if (monstre is Goblin G)
            {
                foreach (var item in G.InventaireList)
                {
                    personnage.InventaireList.Add(item);
                }
            }
            else if (monstre is Orc O)
            {
                foreach (var item in O.InventaireList)
                {
                    personnage.InventaireList.Add(item);
                }
            }
            
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
            Console.WriteLine($"Quelle arme voulez vous utilisé contre {monstre.GetType().Name}? :");
            foreach (var item in ArmesPerso)
            {
                Console.WriteLine($"{cpt++} . {item.Nom}");
            }
            int choixArme = int.Parse(Console.ReadLine());
            Console.WriteLine("Quelle armure voulez vous utilisé ? :");
            cpt = 1;
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
                if ((attaqueMonstre - ArmurePerso[choixArmure - 1].Reduction()) <= 0) 
                {
                    attaqueMonstre = 0;
                    personnage.PointDeVie -= attaqueMonstre;
                }
                else
                {
                    personnage.PointDeVie -= (attaqueMonstre - ArmurePerso[choixArmure-1].Reduction());
                }
                if (monstre.PointDeVie > 0)
                {
                    Console.WriteLine($" {monstre.GetType().Name} vous a infligés {attaqueMonstre} de dégats.");
                }
                else
                {
                    Console.WriteLine("Combat terminer");
                    RecupLoot(personnage, monstre);
                }
            } while (personnage.PointDeVie > 0 && monstre.PointDeVie > 0 );

        }
        public void LancerCombats() 
        {
            
            foreach (var item in Monstres)
            {
                Combats(Heros, item);
                AffichageBoutique(Heros);
            }
        }
        public void LancerJeu() 
        {
            GenérerMonstre();
            CreeJoueur();
            AffichageBoutique(Heros);
            LancerCombats();
        }


    }
}
