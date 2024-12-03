using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6ttiAndras_HERITAGE_EX3
{
    internal abstract class Parallelepipede
    {
        protected string _couleur;
        protected string _nom;
        protected double _longueur;
        protected double _largeur;

        public Parallelepipede(string couleur, string nom, double longueur, double largeur)
        {
            _couleur = couleur;
            _largeur = largeur;
            _longueur = longueur;
            _nom = nom;
        }

        public string Couleur {  get { return _couleur; } set { _couleur = value; } }
        public string Nom { get { return _nom; } set { _nom = value; } }

        public abstract double CalculeSurface();

        public abstract double CalculePerimetre();
        
        public virtual string Afficher()
        {
            return $"C'est un {_nom}, de longueur {_longueur} et de largeur {_largeur}, la surface : {CalculeSurface()}, le perimetre : {CalculePerimetre()}";
        }
    }
}
