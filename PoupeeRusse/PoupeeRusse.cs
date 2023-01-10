using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoupeeRusseNsP
{
    public class PoupeeRusse
    {
        public PoupeeRusse(string couleur)
        {
            Couleur = couleur;
        }

        public string Couleur { get; set; }
        public PoupeeRusse Fille { get; set; }
    }
}
