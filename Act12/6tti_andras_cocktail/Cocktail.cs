using System;
using System.Collections.Generic;

namespace _6tti_andras_cocktail
{
    public class Cocktail
    {
        private string _name;
        private Dictionary<string, float> _data; 
        private bool _ice;

        public string Name => _name;
        public bool Ice => _ice;
        public Dictionary<string, float> Ingredients => _data;

        public Cocktail(string name, bool ice)
        {
            _name = name;
            _ice = ice;
            _data = new Dictionary<string, float>();
        }

        public void AjouterRecette(string bouteille, float quantite)
        {
            if (string.IsNullOrWhiteSpace(bouteille))
            {
                Console.WriteLine("Nom de bouteille invalide.");
                return;
            }

            if (quantite <= 0)
            {
                Console.WriteLine("La quantité doit être positive.");
                return;
            }

            if (_data.ContainsKey(bouteille))
            {
                _data[bouteille] += quantite;
            }
            else
            {
                _data.Add(bouteille, quantite);
            }
        }

        public void RetirerRecette(string bouteille)
        {
            if (string.IsNullOrWhiteSpace(bouteille))
            {
                Console.WriteLine("Nom de bouteille invalide.");
                return;
            }

            if (_data.Remove(bouteille))
            {
                Console.WriteLine($"{bouteille} retiré de la recette '{_name}'.");
            }
            else
            {
                Console.WriteLine($"{bouteille} n'est pas dans la recette '{_name}'.");
            }
        }

        public void AfficherRecette()
        {
            Console.WriteLine($"\n Cocktail: {_name}");
            Console.WriteLine("Ingrédients :");

            if (_data.Count == 0)
            {
                Console.WriteLine("Aucun ingrédient ajouté.");
                return;
            }

            foreach (var ingredient in _data)
            {
                Console.WriteLine($"- {ingredient.Key}: {ingredient.Value} ml");
            }

            Console.WriteLine(_ice ? "Servi avec glace." : "Servi sans glace.");
        }
    }
}
