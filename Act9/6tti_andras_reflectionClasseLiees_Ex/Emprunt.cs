using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6tti_andras_reflectionClasseLiees_Ex
{
    internal class Emprunt
    {
        private Livre _livre;
        private DateTime _date;
        private Humain _humain;

        public Livre Livre { get { return _livre; } set { _livre = value; } }
        public DateTime Date { get { return _date; } set { _date = value; } }
        public Humain Humain { get { return _humain; } set { _humain = value; } }

        public Emprunt(Livre Livre, DateTime date, Humain humain)
        {
            _livre = Livre;
            _date = date;
            _humain = humain;
        }

        public object Rendre() 
        {
            return _livre;
        }
        
    }
}
