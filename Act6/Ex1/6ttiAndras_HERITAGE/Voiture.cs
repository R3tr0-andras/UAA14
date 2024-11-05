using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6ttiAndras_HERITAGE
{
    internal class Voiture : Vehicule
    {
        private string _motorisation;
        private bool _gps;

        public string Motorisation { get { return _motorisation; } set { _motorisation = value; } }
        public bool GPS { get { return _gps; } set { _gps = value; } }
        public Voiture(string modele, string marque, string couleur, decimal prix, string motorisation, bool gps) :
            base(modele, marque, couleur, prix)
        {
            _motorisation = motorisation;
            _gps = gps;
        }

        public override string Afficher()
        {
            return $"Voiture de Modèle {_modele}, de marque {_marque}, de couleur {_couleur} et de prix {_prix}." +
                $" Est motorisée ? {_motorisation} et possède le gps ? {_gps}";
        }
    }
}
