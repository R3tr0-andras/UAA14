using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6ttiAndras_HERITAGE_EX4
{
    public class Ouvrier : Employe
    {
        public DateTime DateEntree { get; set; }
        private const decimal SalaireFixe = 2500;

        public Ouvrier(string matricule, string nom, string prenom, DateTime dateNaissance, DateTime dateEntree)
            : base(matricule, nom, prenom, dateNaissance)
        {
            DateEntree = dateEntree;
        }

        public override decimal CalculerSalaire()
        {
            int anciennete = DateTime.Now.Year - DateEntree.Year;
            decimal salaire = SalaireFixe + (100 * anciennete);
            return Math.Min(salaire, SalaireFixe * 2);
        }

        public override void AfficherCaracteristiques()
        {
            base.AfficherCaracteristiques();
            Console.WriteLine($"Date d'entrée: {DateEntree.ToShortDateString()}, Salaire: {CalculerSalaire()} écus");
        }
    }

}
