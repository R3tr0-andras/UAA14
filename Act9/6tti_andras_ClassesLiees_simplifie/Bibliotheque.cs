using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6tti_andras_ClassesLiees_simplifie
{
    internal class Bibliotheque
    {
        private List<Livre> _livres;

        public List<Livre> Livres { get { return _livres; } set { _livres = value; } }

        public Bibliotheque()
        {
            _livres = new List<Livre>();
        }

        public void ajoute(Livre livre)
        {
            _livres.Add(livre);
        }

        public void supprime()
        {
           _livres.RemoveAll((livre) =>  livre.Etat == 0);
        }

        public string inventaire()
        {
            string temp = "";
            foreach (Livre livre1 in _livres)
            {
                temp = livre1.Titre + ", ";
            }
            return $"{temp}";
        }
    }
}
