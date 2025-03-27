using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6tti_andras_cocktail
{
    public class Bottle
    {
        private string _name;
        private float _ratio;

        public string Name
        {
            get { return _name; }
        }

        public float Ratio
        {
            get { return _ratio; }
            set
            {
                if (value < 0 || value > 100)
                {
                    Console.WriteLine("Invalid ratio value. Ratio must be between 0 and 100.");
                }
                else
                {
                    _ratio = value;
                }
            }
        }
        public Bottle(string name)
        {
            _name = name;
            _ratio = 100; 
        }
        public Bottle(string name, float ratio)
        {
            _name = name;
            _ratio = ratio;
        }
        public void AfficherRatio()
        {
            Console.WriteLine($"Bouteille '{_name}' : Pourcentage de contenu = {_ratio}%");
        }
        public void ChangerRatio(float newRatio)
        {
            Ratio = newRatio;
        }
    }
}
