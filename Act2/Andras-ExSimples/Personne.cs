using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andras_Ex4_Personne
{
    internal class Personne
    {
        private string _nom;
        private decimal _montant;

        public Personne(string nom, decimal montantInitial)
        {
            _nom = nom;
            _montant = montantInitial;
        }
        public string Nom
        {
            get { return _nom; }
        }
        public decimal Montant
        {
            get { return _montant; }
        }
        public void AjouterArgent(decimal montant)
        {
            if (montant <= 0)
            {
                Console.WriteLine("Le montant à ajouter doit être positif.");
            }
            else
            {
                _montant += montant;
                Console.WriteLine($"{_nom} a ajouté {montant:C} dans son porte-monnaie.");
            }
        }
        public bool RetirerArgent(decimal montant)
        {
            if (montant <= 0)
            {
                Console.WriteLine("Le montant à retirer doit être positif.");
                return false;
            }
            if (_montant >= montant)
            {
                _montant -= montant;
                Console.WriteLine($"{_nom} a retiré {montant:C} de son porte-monnaie.");
                return true;
            }
            else
            {
                Console.WriteLine($"{_nom} n'a pas assez d'argent pour retirer {montant:C}.");
                return false;
            }
        }
        public void TransfererArgent(Personne destinataire, decimal montant)
        {
            if (RetirerArgent(montant))
            {
                destinataire.AjouterArgent(montant);
                Console.WriteLine($"{_nom} a transféré {montant:C} à {destinataire.Nom}.");
            }
        }
    }
}
