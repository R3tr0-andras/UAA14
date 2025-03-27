using LibrairieMenu;

namespace _6tti_andras_cocktail
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Initialisation du bar et des cocktails
            Ini.CreationBar();
            Ini.CocktailInitialize();

            // Création du gestionnaire de menu
            MenuManager menu = new MenuManager("Cocktail Bar");

            // Ajout des options au menu
            menu.AddOption("1", "Afficher le contenu du bar", () => Ini.monBar.AfficherContenuBar());
            menu.AddOption("2", "Voir les cocktails disponibles", AfficherCocktails);
            menu.AddOption("3", "Commander un cocktail", CommanderCocktail);

            // Affichage du menu
            menu.ShowMenu();
        }

        static void AfficherCocktails()
        {
            Console.WriteLine("Cocktails disponibles :");
            Console.WriteLine("- Mojito");
            Console.WriteLine("- Caipirinha");
            Console.WriteLine("- Margarita");
            Console.WriteLine("- Bloody Mary");
            Console.WriteLine("- Piña Colada");
            Console.WriteLine("\nAppuyez sur Entrée pour revenir au menu...");
            Console.ReadLine();
        }

        static void CommanderCocktail()
        {
            Console.WriteLine("Entrez le nom du cocktail que vous souhaitez commander :");
            string choix = Console.ReadLine()?.Trim().ToLower();

            Cocktail cocktailChoisi = null;

            switch (choix)
            {
                case "mojito":
                    cocktailChoisi = Ini.mojito;
                    break;
                case "caipirinha":
                    cocktailChoisi = Ini.caipirinha;
                    break;
                case "margarita":
                    cocktailChoisi = Ini.margarita;
                    break;
                case "bloody mary":
                    cocktailChoisi = Ini.bloodyMary;
                    break;
                case "piña colada":
                    cocktailChoisi = Ini.pinaColada;
                    break;
                default:
                    cocktailChoisi = null;
                    break;
            }

            if (cocktailChoisi != null)
            {
                Console.WriteLine($"Vous avez commandé un {cocktailChoisi.Name} !");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Cocktail non disponible. Veuillez essayer à nouveau.");
                Console.ResetColor();
            }

            Console.WriteLine("\nAppuyez sur Entrée pour revenir au menu...");
            Console.ReadLine();
        }
    }
}