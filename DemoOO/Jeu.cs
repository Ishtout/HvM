using HvM.Classe.Monstre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HvM.Classe;


namespace HvM
{
    public class Jeu
    {
        List<Monstre> Monstres {  get; set; }
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
			monstre.ShowMonsterProfile();
				switch (monstre)
				{
					case Goblin G:
						G.CoupDeMasse();
						break;
					case Loup L:
						L.Morsure();
						L.Hurlement();
						break;
					case Orc O:
						O.CoupDeHache();
						O.CriDeGuerre();
						break;
				}
                Console.WriteLine();
                Console.WriteLine("--------------");
                Console.WriteLine();
            }

            
        }

    }
}
