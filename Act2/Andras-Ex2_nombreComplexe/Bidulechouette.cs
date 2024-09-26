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
        private int _r;

        //partie immaginaire
        private int _i;

        public Complexe(int r, int i)
        {
            _r = r;
            _i = i;
        }

        public int R
        {
            get { return _r; }
            set { _r = value; }
        }

        public int I 
        { 
            get { return _i; } 
            set { _i = value; }
        }

        public string AfficheComplexe()
        {
            return ("");
        }²q

        public void CalculModule(int r, int i) 
        {
            
        }
    }
}
