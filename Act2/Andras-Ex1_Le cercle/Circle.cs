using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andras_Ex1_Le_cercle
{
    internal class Circle
    {
        private float _rayon;

        public Circle(float rayon)
        {
            _rayon = rayon;
        }

        public float Rayon
        {
            get { return _rayon; }
            set
            {
                _rayon = value;

            }
        }

        private float calculateAire()
        {
            return (float)Math.PI * _rayon * _rayon;
        }

        private float calculatePerimetre()
        {
            return 2f * (float)Math.PI * _rayon;
        }
        public string InfoCercle()
        {
            float aire = calculateAire();
            float perimetre = calculatePerimetre();
            return $"Ce cercle est un cercle\n de rayon : {_rayon}\n d'aire : {aire}\n de périmètre : {perimetre} \n";
        }

    }
}
