using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6ttiAndras_HERITAGE_EX3
{
    internal class Carre : Parallelepipede
    {
        public Carre(string couleur, string nom, double cote) : base(couleur, nom, cote, cote)
        {
        }

        public override double CalculeSurface()
        {
            return _longueur * _longueur;
        }

        public override double CalculePerimetre()
        {
            return 4 * _longueur;
        }

        public override string Afficher()
        {
            return $"C'est un {_nom}, de côté {_longueur}, la surface : {CalculeSurface()}, le perimetre : {CalculePerimetre()}";
        }
    }
}
