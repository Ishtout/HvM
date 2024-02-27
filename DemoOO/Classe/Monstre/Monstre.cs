using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HvM.Classe.Monstre
{
    public class Monstre
    {
        public string Nom { get; set; }

        private int _force;
        public virtual int Force
        {
            get { return _force; }
            set { _force = value; }
        }
        private int _endurance;
        public virtual int Endurance
        {
            get { return _endurance; }
            set { _endurance = value; }
        }

        public void Stats()
        {
            Random rnd = new Random();
            Nom = this.GetType().Name;
            Force = rnd.Next(10, 21);
            Endurance = rnd.Next(10, 21);
        }
        public void ShowMonsterProfile()
        {
            Console.WriteLine($"Nom : {Nom}");
            Console.WriteLine($"Force : {Force} ({_force})");
            Console.WriteLine($"Endu : {Endurance} ({_endurance})");
            
        }



    }
}
