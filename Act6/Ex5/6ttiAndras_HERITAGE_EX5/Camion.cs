using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6ttiAndras_HERITAGE_EX5
{
    class Camion : VehiculeTerre
    {
        public double _poids { get; set; }

        public Camion(string marque, double carburant, double km, double poids) : base(marque, carburant, km)
        {
            _poids = poids;
        }

        public override string AfficherInfo()
        {
            return $"Camion : Marque={_marque}, Carburant={_carburant}, Km={_km}, Poids={_poids}";
        }
    }
}
