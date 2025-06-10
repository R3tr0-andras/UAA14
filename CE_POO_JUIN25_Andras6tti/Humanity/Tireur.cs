using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE_POO_JUIN25_Andras6tti.Humanity
{
    internal class Tireur : Humain
    {
        private Performance _performances;

        public Performance Performances { get { return _performances; } }
        public string Nom { get { return _name; } }
        public string Prenom { get { return _surname; } }
        public Tireur(Performance performances, int id, string name, string surname)
        {
            _performances = performances;
            _id = id;
            _name = name;
            _surname = surname;
        }

        public string AfficheInfos()
        {
            return $"ID du joueur: " + " [ " + _id + " ]\n"
                    + "Nom du joueur: " + "[" + _name + "]\n"
                    + "Prénom du joueur: " + "[" + _surname + "]";
        }
    }
}
