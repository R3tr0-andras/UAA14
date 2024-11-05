using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6ttiAndras_HERITAGE_EX3
{
    internal class Rectangle : Parallelepipede
    {
        public Rectangle(string couleur, string nom, double longueur, double largeur) : base(couleur, nom, longueur, largeur)
        {
        }
        public override double CalculeSurface()
        {
            return _longueur * _largeur;
        }

        public override double CalculePerimetre()
        {
            return 2 * (_longueur + _largeur);
        }
        public override string Afficher()
        {
            return $"C'est un {_nom}, de longueur {_longueur} et de largeur {_largeur}, la surface : {CalculeSurface()}, le perimetre : {CalculePerimetre()}";
        }
    }
}
