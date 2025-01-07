namespace _6tti_andras_elephant
{
    internal class Elephant
    {
        private string _nom;
        private uint _tailleOreilles;

        public Elephant(string nom, uint tailleOreilles)
        {
            _nom = nom;
            _tailleOreilles = tailleOreilles;
        }

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public uint TailleOreilles
        {
            get { return _tailleOreilles; }
            set { _tailleOreilles = value; }
        }

        public string AfficheQuiJeSuis()
        {
            return $"Nom : {_nom}, Taille des oreilles : {_tailleOreilles}";
        }

        public void EcouteMessage(string message, Elephant quiDit)
        {
            Console.WriteLine($"{_nom} a entendu un message !");
            Console.WriteLine($"{quiDit._nom} a dit : {message}");
        }

        public void EnvoieMessage(string message, Elephant quiRecoit)
        {
            quiRecoit.EcouteMessage(message, this);
        }
    }
}