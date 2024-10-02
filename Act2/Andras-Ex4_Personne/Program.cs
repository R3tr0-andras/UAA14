namespace Andras_Ex4_Personne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans notre gestionnaire de porte monnaie !");
            Console.WriteLine("----------------------------------------------------");

            bool continuer = true;

            while (continuer)
            {
                Personne benoit = new Personne("Benoît", 100);
                Personne beatrice = new Personne("Béatrice", 100);

                Console.WriteLine("\nInitialisation des porte-monnaie:");
                Console.WriteLine($"{benoit.Nom} a {benoit.Montant:C}.");
                Console.WriteLine($"{beatrice.Nom} a {beatrice.Montant:C}.");

                benoit.TransfererArgent(beatrice, 30);
                Console.WriteLine($"{benoit.Nom} a maintenant {benoit.Montant:C}.");
                Console.WriteLine($"{beatrice.Nom} a maintenant {beatrice.Montant:C}.");

                beatrice.TransfererArgent(benoit, 100);
                Console.WriteLine($"{beatrice.Nom} a maintenant {beatrice.Montant:C}.");
                Console.WriteLine($"{benoit.Nom} a maintenant {benoit.Montant:C}.");

                Console.WriteLine("\nVoulez-vous recommencer ? (o/n)");
                string ?reponse = Console.ReadLine();
                if (reponse.ToLower() != "o")
                {
                    continuer = false;
                }

                benoit = null; 
                beatrice = null;
            }
        }
    }
}