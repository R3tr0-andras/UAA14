using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6ttiAndras_HERITAGE_EX4
{
    public class Cadre : Employe
    {
        public int Indice { get; set; }

        public Cadre(string matricule, string nom, string prenom, DateTime dateNaissance, int indice)
            : base(matricule, nom, prenom, dateNaissance)
        {
            Indice = indice;
        }

        public override decimal CalculerSalaire()
        {
            switch (Indice)
            {
                case 1: return 13000;
                case 2: return 15000;
                case 3: return 17000;
                case 4: return 20000;
                default: return 0;
            }
        }

        public override void AfficherCaracteristiques()
        {
            base.AfficherCaracteristiques();
            Console.WriteLine($"Indice: {Indice}, Salaire: {CalculerSalaire()} écus");
        }
    }
}
