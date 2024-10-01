namespace Andras_Ex3_SandwishAleatoires
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continuer = true;

            while (continuer)
            {
                Console.Write("Combien de sandwiches voulez-vous créer ? ");
                int nombreDeSandwiches;

                while (!int.TryParse(Console.ReadLine(), out nombreDeSandwiches) || nombreDeSandwiches <= 0)
                {
                    Console.WriteLine("Veuillez entrer un nombre valide supérieur à 0.");
                    Console.Write("Combien de sandwiches voulez-vous créer ? ");
                }

                SandwishMaker sandwishMaker = new SandwishMaker();

                for (int i = 0; i < nombreDeSandwiches; i++)
                {
                    string sandwishAleatoire = sandwishMaker.ComposerSandwish();
                    Console.WriteLine($"Sandwich {i + 1}: {sandwishAleatoire}");
                }

                // Demander à l'utilisateur s'il veut recommencer
                Console.Write("Voulez-vous recommencer ? (o/n) : ");
                string reponse = Console.ReadLine().ToLower();

                if (reponse != "o")
                {
                    continuer = false;
                }
            }

        }
    }
}
