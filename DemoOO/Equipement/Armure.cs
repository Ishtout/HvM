using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HvM.Equipement
{
    public class Armure : Equipements
    {
        public int retour {  get; set; }
        public int Reduction()
        {
            return /* attaque ennemie */ -retour;

        }
    }
}
