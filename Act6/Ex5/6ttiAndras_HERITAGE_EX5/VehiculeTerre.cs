using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6ttiAndras_HERITAGE_EX5
{
    internal abstract class VehiculeTerre : Vehicule
    {
        public double _km { get; set; }

        protected VehiculeTerre(string marque, double carburant, double km) : base(marque, carburant)
        {
            _km = km;
        }
    }
}
