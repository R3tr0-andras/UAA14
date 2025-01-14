using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6tti_andras_reflectionClasseLiees_Ex
{
    internal class Livre
    {
        private string _titre;
        private string _nomAuteur;
        private byte _etat;

        public string Titre { get { return _titre; } }
        public string NomAuteur { get { return _nomAuteur; } }
        public byte Etat { get { return _etat; } set { _etat = value; } }

        public Livre(string titre, string nomAuteur, byte etat)
        {
            _titre = titre;
            _nomAuteur = nomAuteur;
            _etat = etat;
        }

        public void degrade(byte etat)
        {
            _etat = etat;
        }

        public string description()
        {
            string temp = "";
            if (_etat == 5)
            {
                temp = "neuf";
            } else if (_etat == 4)
            {
                temp = "comme neuf";
            }
            else if (_etat == 3)
            {
                temp = "pas endomagé";
            }
            else if (_etat == 2)
            {
                temp = "un peu endomagé";
            }
            else if (_etat == 1)
            {
                temp = "endomagé";
            }
            else if (_etat == 0)
            {
                temp = "illisible";
            }
            return $"Le livre : {_titre}, de l'auteur : {_nomAuteur} est {temp}.";
        }
    }
}
