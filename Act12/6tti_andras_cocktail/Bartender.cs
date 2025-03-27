using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6tti_andras_cocktail
{
    public class Bartender : Humain
    {
        private Menu _menu;
        public Bartender(string name, DateTime date, bool isWorkingHere, Menu menu) : base(name, date, isWorkingHere)
        {
            _menu = menu;
        }
        public void Prepare(string cocktailName)
        {
            Console.WriteLine($"{Name} va préparer le cocktail '{cocktailName}'.");

            var cocktail = _menu.ObtenirCocktail(cocktailName);
            if (cocktail == null)
            {
                Console.WriteLine($"Désolé, le cocktail '{cocktailName}' n'est pas disponible dans le menu.");
                return;
            }

            var shaker = new Dictionary<string, float>();

            foreach (var ingredient in cocktail.Ingredients)
            {
                shaker[ingredient.Key] = ingredient.Value; 
            }

            Shake();

            Console.WriteLine("\nIngrédients dans le shaker :");
            foreach (var ingredient in shaker)
            {
                Console.WriteLine($"- {ingredient.Key}: {ingredient.Value} ml");
            }

            CleanShaker();

            Console.WriteLine($"Le cocktail '{cocktail.Name}' est prêt !");
        }

        private void Shake()
        {
            Console.WriteLine("Le shaker est secoué avec énergie !");
        }

        private void CleanShaker()
        {
            Console.WriteLine("Le shaker est maintenant propre.");
        }
    }
}
