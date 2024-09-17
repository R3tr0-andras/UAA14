using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andras_ACT1_LampeEtInterrupteur
{
    internal class Lampe
    {
        private string _idLampe;
        private bool _aUneAmpoule;
        private bool _aDuCourrant;
        private bool _estAllume;
        private string _couleurHexa;

        public Lampe(string idLampe, bool aUneAmpoule, bool aDuCourrant, bool estAllume, string couleurHexa)
        {
            _idLampe = idLampe;
            _aUneAmpoule = aUneAmpoule;
            _aDuCourrant = aDuCourrant;
            _estAllume = estAllume;
            _couleurHexa = couleurHexa;
        }

        public string CouleurHexa
        {
            get { return _couleurHexa; }
            set { _couleurHexa = value; }
        }

        public string IdLampe
        {
            get => _idLampe;
            set => _idLampe = value;
        }
        public bool AUneAmpoule
        {
            get { return _aUneAmpoule; }
            set { _aUneAmpoule = value; }
        }

        public bool ADuCourrant
        {
            get { return _aDuCourrant; }
            set { _aDuCourrant = value; }
        }

        public bool EstAllume
        {
            get { return _estAllume; }
            set { _estAllume = value; }
        }
        public void Allumer()
        {
            _estAllume = true;
        }
        public void Eteindre()
        {
            _estAllume = false;
        }
        public string InfoLampe()
        {
            return $"Couleur : {_couleurHexa}, Est allumée : {_estAllume}, Ampoule : {_aUneAmpoule}, Courant : {_aDuCourrant}, ID = {_idLampe}";
        }

    }
}