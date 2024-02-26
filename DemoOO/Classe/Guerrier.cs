using HvM.Classe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoOO.Classe
{
    public class Guerrier : Personnage
    {

        public override int Force
        {
            get { return base.Force + 3; }
            set { base.Force = value; }
        }
        public override int Endurance
        {
            get { return base.Endurance + 3; }
            set { base.Endurance = value; }
        }
        








    }
}
