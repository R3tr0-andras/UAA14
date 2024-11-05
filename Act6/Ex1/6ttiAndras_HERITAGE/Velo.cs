using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6ttiAndras_HERITAGE
{
    internal class Velo : Vehicule
    {
        private string _type;
        private bool _elec;

        public string Type { get { return _type; } set { _type = value; } }
        public bool Elec { get { return _elec; } set { _elec = value; } }

        public Velo(string modele, string marque, string couleur, decimal prix, string type, bool elec) :
            base(modele, marque, couleur, prix)
        {
            _type = type;
            _elec = elec;
        }
        public override string Afficher()
        {
            return $"Voiture de Modèle {_modele}, de marque {_marque}, de couleur {_couleur} et de prix {_prix}." +
                $" De type ? {_type} et est électrique ? {_elec}";
        }
    }
}
