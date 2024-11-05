using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6ttiAndras_HERITAGE_EX4
{
    public class Employe
    {
        public string Matricule { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public DateTime DateNaissance { get; set; }

        public Employe(string matricule, string nom, string prenom, DateTime dateNaissance)
        {
            Matricule = matricule;
            Nom = nom;
            Prenom = prenom;
            DateNaissance = dateNaissance;
        }

        public virtual void AfficherCaracteristiques()
        {
            Console.WriteLine($"Matricule: {Matricule}, Nom: {Nom}, Prénom: {Prenom}, Date de naissance: {DateNaissance.ToShortDateString()}");
        }

        public virtual decimal CalculerSalaire()
        {
            return 0;
        }
    }
}
