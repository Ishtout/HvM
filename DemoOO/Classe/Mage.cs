using HvM.Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOO.Classe
{
    public class Mage : Personnage
    {
        public override int Intelligence
        {
            get { return base.Intelligence + 4; }
            set { base.Intelligence = value; }
        }

        public override int Sagesse
        {
            get { return base.Sagesse + 2; }
            set { base.Sagesse = value; }
        }





    }
}
