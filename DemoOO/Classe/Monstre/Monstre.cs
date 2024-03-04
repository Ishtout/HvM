using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HvM.Classe.Monstre
{
    public class Monstre : Entite
    {
        public override void Stats()
        {
            Random rnd = new Random();
            Force = rnd.Next(10, 21);
            Endurance = rnd.Next(10, 21);
            PointDeVie = 10 + Modificateur(Endurance);
            
        }
        public override void ShowCharacterProfile()
        {
            Console.WriteLine(GetType().Name);
            Console.WriteLine($"Force : {Force} ({_force})");
            Console.WriteLine($"Endu : {Endurance} ({_endurance})");
            Console.WriteLine($"Point de vie : {PointDeVie}");
        }
    }
}
