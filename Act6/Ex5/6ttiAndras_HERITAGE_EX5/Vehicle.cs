using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6ttiAndras_HERITAGE_EX5
{
    internal abstract class Vehicule
    {
        public string _marque { get; set; }
        public double _carburant { get; set; }

        protected Vehicule(string marque, double carburant)
        {
            _marque = marque;
            _carburant = carburant;
        }

        public abstract string AfficherInfo();
    }

}
