using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HvM.Equipement
{
    public class Arme : Equipements
    {
        public int Degats()
        {
            Random rnd = new Random();
            return NbDes * rnd.Next(1, Face + 1);
        }
    }
}
