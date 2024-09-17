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
        private string _idLampe;
        private Lampe _lampe;


        public Interrupteur(bool estEnclenche, string idLampe, Lampe lampe)
        {
            _estEnclenche = estEnclenche;
            _idLampe = idLampe;
            _lampe = lampe;
        }

        public bool Basculer()
        {
            _estEnclenche = !_estEnclenche;

            if (_estEnclenche)
            {
                _lampe.Allumer();
            }
            else
            {
                _lampe.Eteindre();
            }

            return _estEnclenche;
        }

        public string IdLampe => _idLampe;
        public Lampe Lampe => _lampe;
        public bool EstEnclenche => _estEnclenche;
    }

}