using System;
using System.Collections.Generic;
using System.Linq;

namespace _6tti_andras_cocktail
{
    public class Menu
    {
        private List<Cocktail> _listMenu;

        public IReadOnlyList<Cocktail> ListMenu => _listMenu;

        public Menu()
        {
            _listMenu = new List<Cocktail>();
        }

        public void AjouterCocktail(Cocktail cocktail)
        {
            if (cocktail == null)
            {
                Console.WriteLine("Cocktail invalide.");
                return;
            }

            if (_listMenu.Any(c => c.Name.Equals(cocktail.Name, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine($"Le cocktail '{cocktail.Name}' est déjà dans le menu !");
                return;
            }

            _listMenu.Add(cocktail);
            Console.WriteLine($"Cocktail '{cocktail.Name}' ajouté au menu.");
        }

        public void AfficherMenu()
        {
            Console.WriteLine("\n======= 📜 MENU DES COCKTAILS =======");

            if (_listMenu.Count == 0)
            {
                Console.WriteLine("Aucun cocktail disponible pour le moment.");
                return;
            }

            foreach (var cocktail in _listMenu)
            {
                Console.WriteLine($"- {cocktail.Name} ({(cocktail.Ice ? "avec glace" : "sans glace")})");
            }
            Console.WriteLine("====================================\n");
        }

        public Cocktail ObtenirCocktail(string name) // Why not j'ai pas envie de vérifier mais ça résous mon bug
        {
            return _listMenu.FirstOrDefault(c => c.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
