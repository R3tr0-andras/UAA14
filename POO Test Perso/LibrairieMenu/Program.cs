namespace LibrairieMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Création d'un menu principal
            MenuManager mainMenu = new MenuManager("Menu Principal");

            // Ajout des options avec leurs actions
            mainMenu.AddOption("1", "Dire Bonjour", () => Console.WriteLine("Bonjour !"));
            mainMenu.AddOption("2", "Afficher l'heure", () => Console.WriteLine($"Heure actuelle : {DateTime.Now}"));
            mainMenu.AddOption("3", "Aller au sous-menu", ShowSubMenu);

            // Lancer le menu
            mainMenu.ShowMenu();
        }
        static void ShowSubMenu()
        {
            // Création d'un sous-menu
            MenuManager subMenu = new MenuManager("Sous-Menu");

            subMenu.AddOption("1", "Afficher un message", () => Console.WriteLine("Bienvenue dans le sous-menu !"));
            subMenu.AddOption("2", "Retour au menu principal", () => Console.WriteLine("Retour au menu principal..."));

            subMenu.ShowMenu();
        }

    }
}