using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6tti_andras_reflectionClasseLiees_Ex
{
    internal class Humain
    {
        private string _nom;
        private List<Emprunt> _emprunts;

        public string Nom
        {
            get { return _nom; }
        }
        public List<Emprunt> Emprunts
        {
            get { return this._emprunts; }
            set { this._emprunts = value; }
        }

        public Humain()
        {
            _nom = Nom;
            _emprunts = new List<Emprunt>();
        }
        public void Emprunter(Emprunt emprunt)
        {
            _emprunts.Add(emprunt);
        }

        public void RendreLivreParIndex(int index)
        {
            _emprunts[index].Rendre();
        }
    }
}
