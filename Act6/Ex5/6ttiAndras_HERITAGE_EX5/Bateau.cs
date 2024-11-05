using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6ttiAndras_HERITAGE_EX5
{
    class Bateau : Vehicule
    {
        public double _tonnage { get; set; }

        public Bateau(string marque, double carburant, double tonnage) : base(marque, carburant)
        {
            _tonnage = tonnage;
        }

        public override string AfficherInfo()
        {
            return $"Bateau : Marque={_marque}, Carburant={_carburant}, Tonnage={_tonnage}";
        }
    }
}
