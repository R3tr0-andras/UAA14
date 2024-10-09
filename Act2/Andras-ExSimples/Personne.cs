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
            set { _montant = value; }
        }
        public void AjouterArgent(decimal montant)
        {
            _montant += montant;
        }
        public bool RetirerArgent(decimal montant)
        {
            if (montant <= 0)
            {
                return false;
            }
            if (_montant >= montant)
            {
                _montant -= montant;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void TransfererArgent(Personne destinataire, decimal montant)
        {
            if (RetirerArgent(montant))
            {
                destinataire.AjouterArgent(montant);
            }
        }
    }
}
