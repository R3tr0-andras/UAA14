namespace I5_6TTIUAA14_Andras
{
    internal class Joueur
    {
        private string _name;
        private byte _nbCartouchesEnPoche;
        private Fusil _fusilDuJoueur;

        public string Name
        { get { return _name; } }
        public byte nbCartouchesEnPoche
        { get { return _nbCartouchesEnPoche; } set { _nbCartouchesEnPoche = value; } }
        
        public Joueur(string name, Fusil fusil)
        {
            _name = name;
            _nbCartouchesEnPoche = 30;
            _fusilDuJoueur = fusil;
        }

        public string Tirer()
        {
            if(_fusilDuJoueur.Verifier())
            {
                _fusilDuJoueur.NbCartoucheDuFusil = (byte)(_fusilDuJoueur.NbCartoucheDuFusil - 1);  // Le programme me force à caster et je ne sait pas pourquoi
                return $"Le joueur tire une balle, il ne reste plus que {_fusilDuJoueur.NbCartoucheDuFusil} balles dans le chargeur.";
            } else
            {
                return $"Le joueur ne peut pas tirer sans balles.";
            }
          
        }
        public string Recharger()
        {
            bool temp = true;
            while (temp)
            {
                if (_fusilDuJoueur.NbCartoucheDuFusil == 16)
                {
                    temp = false;
                }
                else
                {
                    _fusilDuJoueur.NbCartoucheDuFusil = (byte)(_fusilDuJoueur.NbCartoucheDuFusil + 1);
                    _nbCartouchesEnPoche--;
                }
            }

            return $"Le joueur recharge son arme, il a maintenant {16} balles";
        }
        public string VerifierPoches()
        {
            return $"Le joueur possède {_nbCartouchesEnPoche} balles dans ses poches";
        }
        public string Reprendre()
        {
            _nbCartouchesEnPoche = (byte)(_nbCartouchesEnPoche + 30);// Le programme me force à caster et je ne sait pas pourquoi

            return $"Le joueur reprend {30} balles et possède {_nbCartouchesEnPoche} balles dans ses poches";
        }
    }
}