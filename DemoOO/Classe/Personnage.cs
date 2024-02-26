using DemoOO.Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HvM.Classe
{
    public class Personnage
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
        private int _intelligence;
        public virtual int Intelligence
        {
            get { return _intelligence; }
            set { _intelligence = value; }
        }

        private int _sagesse;
        public virtual int Sagesse
        {
            get { return _sagesse; }
            set { _sagesse = value; }
        }
        public void Stats()
        {
            Random rnd = new Random();
            Force = rnd.Next(10, 21);
            Endurance = rnd.Next(10, 21);
            Sagesse = rnd.Next(10, 21);
            Intelligence = rnd.Next(10, 21);
        }
        public void ShowCharacterProfile()
        {
            Console.WriteLine(this.GetType().Name);
            Console.WriteLine($"Nom : {Nom}");
            Console.WriteLine($"Force : {Force} ({_force})");
            Console.WriteLine($"Endu : {Endurance} ({_endurance})");
            Console.WriteLine($"Intel : {Intelligence} ({_intelligence})");
            Console.WriteLine($"Sagesse : {Sagesse} ({_sagesse})");
        }


    }
}
