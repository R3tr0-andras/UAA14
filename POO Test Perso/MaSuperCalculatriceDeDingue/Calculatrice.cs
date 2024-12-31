using MaSuperCalculatriceDeDingue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaSuperCalculatriceDeDingue
{
    public class Calculatrice
    {
        public double EffectuerOperation(Operation operation, IEnumerable<double> nombres)
        {
            return operation.Calculer(nombres);
        }
    }
}