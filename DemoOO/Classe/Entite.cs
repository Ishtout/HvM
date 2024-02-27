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
        public virtual int Force
        {
            get { return _force; }
            set { _force = value; }
        }
        protected int _endurance;
        public virtual int Endurance
        {
            get { return _endurance; }
            set { _endurance = value; }
        }

        public abstract void Stats();

        public abstract void ShowCharacterProfile();
       
    }
}
