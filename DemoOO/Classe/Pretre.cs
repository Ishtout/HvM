using HvM.Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOO.Classe
{
    public class Pretre : Personnage
    {
        
        public override int Intelligence
        {
            get { return base.Intelligence + 2; }
            set { base.Intelligence = value; }
        }

        public override int Sagesse
        {
            get { return base.Sagesse + 4; }
            set { base.Sagesse = value; }
        }
        






    }
}
