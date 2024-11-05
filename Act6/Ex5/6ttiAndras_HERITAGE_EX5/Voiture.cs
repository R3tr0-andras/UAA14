using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6ttiAndras_HERITAGE_EX5
{
    class Voiture : VehiculeTerre
    {
        public Voiture(string marque, double carburant, double km) : base(marque, carburant, km) { }

        public override string AfficherInfo()
        {
            return $"Voiture : Marque={_marque}, Carburant={_carburant}, Km={_km}";
        }
    }
}
