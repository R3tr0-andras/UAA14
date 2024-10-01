using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andras_Ex2_nombreComplexe
{
    internal class Bidulechouette
    {
        //partie réel
        private double _r;

        //partie immaginaire
        private double _i;

        public Bidulechouette(double r, double i)
        {
            _r = r;
            _i = i;
        }

        public double R
        {
            get { return _r; }
            set { _r = value; }
        }

        public double I 
        { 
            get { return _i; } 
            set { _i = value; }
        }

        public string AfficherModule()
        {
            double z = CalculModule(R, I);
            return ("Le module est :" + z);
        }

        public double CalculModule(double r, double i) 
        {
            double result;
            return result = Math.Sqrt(r * r + i * i);
        }

        public string AfficherComplexe()
        {
            string result;
            return result = $"Le complexe : ({R}, {I})";
        }
    }
}
