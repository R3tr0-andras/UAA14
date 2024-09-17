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
        private float _aire;
        private float _perimetre;

        public Circle(float rayon)
        {
            _rayon = rayon;
            RecalculateAire();
            RecalculatePerimetre();
        }

        public float Rayon
        {
            get { return _rayon; }
            set
            {
                _rayon = value;
                RecalculateAire();
                RecalculatePerimetre();
            }
        }

        public float Aire
        {
            get { return _aire; }
            private set { _aire = value; }
        }

        public float Perimetre
        {
            get { return _perimetre; }
            private set { _perimetre = value; }
        }
        private void RecalculateAire()
        {
            Aire = (float)Math.PI * _rayon * _rayon;
        }

        private void RecalculatePerimetre()
        {
            Perimetre = 2f * (float)Math.PI * _rayon;
        }
        public string InfoCercle()
        {
            return $"Ce cercle est un cercle de rayon : {_rayon}, d'aire : {_aire} et de périmètre : {_perimetre}";
        }

    }
}
