using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introPOO
{
    internal class Chien
    {
        private int _age;
        private string _race;
        private double _taille;
        private double _poid;
        private string _etat;
        private bool _puce;

        public Chien(int age, string race, double taille, double poid, string etat, bool puce)
        {
            _age = age;
            _race = race;
            _taille = taille;
            _poid = poid;
            _etat = etat;
            _puce = puce;
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Race
        {
            get { return _race; }
            set { _race = value; }
        }

        public double Taille
        {
            get { return _taille; }
            set { _taille = value; }
        }

        public double Poids
        {
            get { return _poid; }
            set { _poid = value; }
        }

        public string Etat
        {
            get { return _etat; }
            set { _etat = value; }
        }

        public bool Puce
        {
            get { return _puce; }
            set { _puce = value; }
        }
        public string Info()
        {
            return "Le chien est " + _etat;
        }

        public string Manger()
        {
            return "MIAM";
        }

        public string Boire()
        {
            return "MIUM";
        }

        public int Vieillir()
        {
            return _age += 1;
        }

        public string SeBlesser()
        {
            return "Aie";
        }

        public string FaireSesBesoin()
        {
            return "OUAF";
        }

        public string Mourir()
        {
            return "Blurg";
        }
    }
}
