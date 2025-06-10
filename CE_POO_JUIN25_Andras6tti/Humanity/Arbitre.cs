using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CE_POO_JUIN25_Andras6tti.Humanity
{
    internal class Arbitre : Humain
    {
        public Arbitre(int id, string name, string surname)
        {
            _id = id;
            _name = name;
            _surname = surname;
        }

        public string AfficheInfos()
        {
            return $"ID de l'arbitre: " + " [ " + _id + " ]\n"
                    + "Nom de l'arbitre: " + "[" + _name + "]\n"
                    + "Prénom de l'arbitre: " + "[" + _surname + "]";
        }
    }
}