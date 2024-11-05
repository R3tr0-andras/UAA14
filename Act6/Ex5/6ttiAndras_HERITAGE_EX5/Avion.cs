using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6ttiAndras_HERITAGE_EX5
{
    class Avion : Vehicule
    {
        public double _portee { get; set; }

        public Avion(string marque, double carburant, double portee) : base(marque, carburant)
        {
            _portee = portee;
        }

        public override string AfficherInfo()
        {
            return $"Avion : Marque={_marque}, Carburant={_carburant}, Portée={_portee}";
        }
    }
}
