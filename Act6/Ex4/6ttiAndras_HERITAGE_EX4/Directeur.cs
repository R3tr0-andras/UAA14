using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6ttiAndras_HERITAGE_EX4
{
    public class Directeur : Employe
    {
        public static decimal ChiffreAffaires { get; set; }
        public decimal Pourcentage { get; set; }

        public Directeur(string matricule, string nom, string prenom, DateTime dateNaissance, decimal pourcentage)
            : base(matricule, nom, prenom, dateNaissance)
        {
            Pourcentage = pourcentage;
        }

        public override decimal CalculerSalaire()
        {
            return ChiffreAffaires * (Pourcentage / 100);
        }

        public override void AfficherCaracteristiques()
        {
            base.AfficherCaracteristiques();
            Console.WriteLine($"Pourcentage: {Pourcentage}%, Salaire annuel: {CalculerSalaire()} écus");
        }
    }
}
