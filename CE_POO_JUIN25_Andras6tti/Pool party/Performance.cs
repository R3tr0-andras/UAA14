using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE_POO_JUIN25_Andras6tti
{
    internal class Performance
    {
        private int _touchesDonnees;
        private int _touchesRecues;
        private int _nbVictoires;

        public int TD
        {
            get { return _touchesDonnees; }
            set { _touchesDonnees = value; }
        }

        public int TR
        {
            get { return _touchesRecues; }
            set { _touchesRecues = value; }
        }

        public int NBVIC
        {
            get { return _nbVictoires; }
            set { _nbVictoires = value; }
        }
        public Performance(int td, int tr, int nbVic)
        {
            _touchesDonnees = td;
            _touchesRecues = tr;
            _nbVictoires = nbVic;
        }
        public Performance()
        {
            _touchesDonnees = 0;
            _touchesRecues = 0;
            _nbVictoires = 0;
        }
        public int CalculerDifferentiel()
        {
            return _touchesDonnees - _touchesRecues;
        }
        public void ReinitialiserPerformances()
        {
            _touchesDonnees = 0;
            _touchesRecues = 0;
            _nbVictoires = 0;
        }

        public void AjouterTouchesDonnees(int touches)
        {
            _touchesDonnees += touches;
        }
        public void AjouterTouchesRecues(int touches)
        {
            _touchesRecues += touches;
        }
        public void AjouterVictoire()
        {
            _nbVictoires++;
        }
        public string AfficherPerformances()
        {
            return $"TD: {_touchesDonnees}, TR: {_touchesRecues}, Victoires: {_nbVictoires}, Différentiel: {CalculerDifferentiel()}";
        }
        public override string ToString()
        {
            return AfficherPerformances();
        }
    }
}