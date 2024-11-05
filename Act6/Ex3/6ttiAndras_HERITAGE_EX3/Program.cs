namespace _6ttiAndras_HERITAGE_EX3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\nQue voulez-vous créer ? (1: Carré, 2: Rectangle, 3: Quitter)");
                string choix = Console.ReadLine();

                if (choix == "3")
                {
                    break;
                }

                Console.Write("Entrez la couleur : ");
                string couleur = Console.ReadLine();

                if (choix == "1")
                {
                    CreerCarre(couleur);
                }
                else if (choix == "2")
                {
                    CreerRectangle(couleur);
                }
                else
                {
                    Console.WriteLine("Choix invalide. Veuillez réessayer.");
                }
            }

            Console.WriteLine("Programme terminé.");
        }

        static void CreerCarre(string couleur)
        {
            Console.Write("Entrez la longueur du côté : ");
            if (double.TryParse(Console.ReadLine(), out double cote))
            {
                try
                {
                    Carre carre = new Carre(couleur, "carré", cote);
                    Console.WriteLine(carre.Afficher());
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine($"Erreur : {e.Message}");
                }
            }
            else
            {
                Console.WriteLine("Valeur invalide pour le côté.");
            }
        }

        static void CreerRectangle(string couleur)
        {
            Console.Write("Entrez la longueur : ");
            if (double.TryParse(Console.ReadLine(), out double longueur))
            {
                Console.Write("Entrez la largeur : ");
                if (double.TryParse(Console.ReadLine(), out double largeur))
                {
                    try
                    {
                        Rectangle rectangle = new Rectangle(couleur, "rectangle", longueur, largeur);
                        Console.WriteLine(rectangle.Afficher());
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine($"Erreur : {e.Message}");
                    }
                }
                else
                {
                    Console.WriteLine("Valeur invalide pour la largeur.");
                }
            }
            else
            {
                Console.WriteLine("Valeur invalide pour la longueur.");
            }
        }
    }
}