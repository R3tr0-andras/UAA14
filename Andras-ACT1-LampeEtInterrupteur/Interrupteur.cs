using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andras_ACT1_LampeEtInterrupteur
{
    internal class Interrupteur
    {
        private bool _estEnclenche;
        private string _idInterrupteur;


        public Interrupteur(bool estEnclenche, string idInterrupteur)
        {
            _estEnclenche = estEnclenche;
            _idInterrupteur = idInterrupteur;
        }

        public bool Appuis
        {
            get { return _estEnclenche; }
            set { _estEnclenche = value; }
        }
    }

}