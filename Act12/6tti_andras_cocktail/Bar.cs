using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6tti_andras_cocktail
{
    public class Bar
    {
        private List<Bottle> _bottles;
        public Bar() 
        {
            _bottles = new List<Bottle>();
        }

        public void AfficherContenuBar()
        {
            if (_bottles.Count == 0)
            {
                Console.WriteLine("Le bar est à sec Jonyle.");
            }
            else
            {
                Console.WriteLine("Contenu du bar :");
                foreach (var bottle in _bottles)
                {
                    bottle.AfficherRatio();
                }
            }
        }

        public void RéapprovisionnerBar(string name, float quantity)
        {
            var newBottle = new Bottle(name);
            newBottle.Ratio = quantity;
            _bottles.Add(newBottle);
        }
    }
}
