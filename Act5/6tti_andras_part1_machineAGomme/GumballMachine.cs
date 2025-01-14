using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6tti_andras_part1_machineAGomme
{
    class GumballMachine
    {
        private int _gumballs;
        private int _price;

        public int Price
        {
            get { return Price; }
        }

        public GumballMachine(int gumballs, int price)
        {
            _gumballs = gumballs;
            _price = price;
        }

        public string DispenseOneGumball(int price, int coinsInserted)
        {
            if (coinsInserted >= price)
            {
                _gumballs -= 1;
                return "Voici votre chewing-gum !";
            }
            else
            {
                return "Pas assez de pièces !";
            }
        }
    }

}
