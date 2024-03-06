using HvM.Classe.Monstre;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HvM.Classe
{
    public abstract class Entite
    {
        protected int _force;
        protected int _endurance;
        protected int _pointDeVie;
        protected int _pointdeviemax;

        public virtual int Pointdeviemax 
        {
            get { return _pointdeviemax; }
            set { _pointdeviemax = value; } 
        }
        public virtual int PointDeVie
        {
            get { return  _pointDeVie ; }
            set { _pointDeVie = value;}
        }
        public virtual int Force
        {
            get { return _force ; }
            set { _force = value; }
        }
        public virtual int Endurance
        {
            get { return _endurance ; }
            set { _endurance = value; }
        }
        public int Modificateur(int stat)
        {
            if (stat < 10)
                return -1;
            else if (stat < 13)
                return 0;
            else if (stat < 16)
                return 1;
            else if (stat < 19)
                return 2;
            else if (stat < 22)
                return 3;
            else
            {
                return 4;
            }
        }
        public abstract void Stats();
        public abstract void ShowCharacterProfile();
       
    }
}
