using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOO.Classe
{
    public class Guerrier
    {
        public string Nom { get; set; }

        private int _force;
        public int Force
        {
            get { return _force + 3; }
            set { _force = value; }
        }
        private int _endurance;
        public int Endurance
        {
            get { return _endurance + 3; }
            set { _endurance = value; }
        }
        private int _intelligence;
        public int Intelligence
        {
            get { return _intelligence; }
            set { _intelligence = value; }
        }

        private int _sagesse;
        public int Sagesse
        {
            get { return _sagesse; }
            set { _sagesse = value; }
        }
        public void Stats()
        {
            Random rnd = new Random();
            _force = rnd.Next(10, 20);
            _endurance = rnd.Next(10, 20);
            _sagesse = rnd.Next(10, 20);
            _intelligence = rnd.Next(10, 20);
        }
        
        







    }
}
