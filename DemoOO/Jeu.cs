using HvM.Classe.Monstre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HvM.Classe;
using HvM.Equipement;


namespace HvM
{
    public class Jeu
    {
        List<Monstre> Monstres {  get; set; }
				
		
		public static List<Equipements> equipement() 
		{
            List<Equipements> liste = new List<Equipements>();
			Arme epeeCourte = new Arme();
			epeeCourte.Nom = "Epee courte";
			epeeCourte.Prix = 20;
			epeeCourte.Face = 6;
			epeeCourte.NbDes = 1;
			liste.Add(epeeCourte);
            Arme epeeLongue = new Arme();
            epeeLongue.Nom = "Epee longue";
            epeeLongue.Prix = 40;
            epeeLongue.Face = 8;
            epeeLongue.NbDes = 1;
			liste.Add(epeeLongue);
			Armure armureDeCuir = new Armure();
			armureDeCuir.Nom = "Armure de Cuir";
            armureDeCuir.Prix = 30;
			armureDeCuir.retour = 2;
            liste.Add(armureDeCuir);
            Armure armureDePlaque = new Armure();
            armureDePlaque.Nom = "Armure de Plaque";
            armureDePlaque.Prix = 60;
            armureDePlaque.retour = 5;
			liste.Add(armureDePlaque);
			Consommable potion = new Consommable();
			potion.Nom = "Potion de soin";
			potion.Prix =  50;
			potion.Soin();
			potion.NbDes = 2;
			potion.Face = 4;
			liste.Add(potion);

			return liste;
        }
        public void jeu()
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

		foreach (Monstre monstre in Monstres)
		{
			monstre.ShowCharacterProfile();
				
                switch (monstre)
				{
					case Goblin G:
						G.CoupDeMasse();
						G.Loot();
						break;
					case Loup L:
						L.Morsure();
						L.Hurlement();
						break;
					case Orc O:
						O.CoupDeHache();
						O.CriDeGuerre();
						O.Loot();
						break;
				}
                Console.WriteLine();
                Console.WriteLine("--------------");
                Console.WriteLine();
            }
        }

    }
}
