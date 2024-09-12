using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        public bool RemplacerAmpoule
        {
            get { return _aUneAmpoule; }
            set { _aUneAmpoule = value; }
        }

        public bool BrancherDebrancher
        {
            get { return _aDuCourrant; }
            set { _aDuCourrant = value; }
        }

        public bool AllumerEteindre
        {
            get { return _estAllume; }
            set { _estAllume = value; }
        }

        public string InfoLampe(string idLampe, bool aUneAmpoule, bool aDuCourrant, bool estAllume, string couleurHexa)
        {
           return "couleur : " + couleurHexa + "est allume : " + estAllume + 
                "a une ampoule : " + aUneAmpoule + "a du courrant : " + aDuCourrant
                + "Id = " + idLampe;

        }
    }
}