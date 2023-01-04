using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genealogie
{
    public class Humain
    {
        public Humain(string nom, List<Humain> enfants)
        {
            Nom = nom;
            Enfants = enfants;
        }

        public string Nom { get; set; }

        public List<Humain> Enfants { get; set; }
    }
}
