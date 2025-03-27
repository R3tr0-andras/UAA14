using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _6tti_andras_cocktail
{
    public static class Ini
    {
        public static Bar monBar = new Bar();
        public static Menu monMenu = new Menu();

        // 2 Humains
        public static Bartender Mael = new Bartender("Alex", new DateTime(1990, 5, 15), true, monMenu);
        public static Customer Andras = new Customer("Thomas", new DateTime(1995, 8, 25), false);

        // Cocktails
        public static Cocktail mojito = new Cocktail("Mojito", false);
        public static Cocktail caipirinha = new Cocktail("Caipirinha", true);
        public static Cocktail margarita = new Cocktail("Margarita", true);
        public static Cocktail bloodyMary = new Cocktail("Bloody Mary", false);
        public static Cocktail pinaColada = new Cocktail("Piña Colada", true);


        public static void CocktailInitialize()
        {
            // Ajouter des ingrédients à la recette du Mojito
            mojito.AjouterRecette("Rhum blanc", 50);
            mojito.AjouterRecette("Sucre", 10);
            mojito.AjouterRecette("Citron vert", 30);
            mojito.AjouterRecette("Feuilles de menthe", 5);

            // Ajouter des ingrédients à la recette de la Caipirinha
            caipirinha.AjouterRecette("Cachaça", 50);
            caipirinha.AjouterRecette("Citron vert", 30);
            caipirinha.AjouterRecette("Sucre", 15);

            // Ajouter des ingrédients à la recette de la Margarita
            margarita.AjouterRecette("Tequila", 50);
            margarita.AjouterRecette("Cointreau", 30);
            margarita.AjouterRecette("Citron vert", 20);
            margarita.AjouterRecette("Sel", 5);

            // Ajouter des ingrédients à la recette du bloodyMary
            bloodyMary.AjouterRecette("Vodka", 45);
            bloodyMary.AjouterRecette("Jus de tomate", 90);
            bloodyMary.AjouterRecette("Jus de citron", 15);
            bloodyMary.AjouterRecette("Tabasco", 5);
            bloodyMary.AjouterRecette("Poivre", 1);

            // Ajouter des ingrédients à la recette de la pinaColada
            pinaColada.AjouterRecette("Rhum blanc", 50);
            pinaColada.AjouterRecette("Crème de coco", 30);
            pinaColada.AjouterRecette("Jus d'ananas", 70);
            pinaColada.AjouterRecette("Crème fraîche", 10);
        }
        public static void CreationBar()
        {
            // Ajout de bouteilles au bar
            monBar.RéapprovisionnerBar("Whisky", 1.5f);
            monBar.RéapprovisionnerBar("Vodka", 2.0f);
            monBar.RéapprovisionnerBar("Rhum", 1.0f);
            monBar.RéapprovisionnerBar("Tequila", 1.5f);
            monBar.RéapprovisionnerBar("Gin", 1.0f);
            monBar.RéapprovisionnerBar("Cointreau", 0.75f);
            monBar.RéapprovisionnerBar("Triple sec", 0.5f);
            monBar.RéapprovisionnerBar("Sirop d'orgeat", 0.25f);
            monBar.RéapprovisionnerBar("Jus de citron vert", 1.0f);
            monBar.RéapprovisionnerBar("Jus d'orange", 1.0f);
            monBar.RéapprovisionnerBar("Jus de tomate", 1.0f);
            monBar.RéapprovisionnerBar("Grenadine", 0.5f);
            monBar.RéapprovisionnerBar("Crème de coco", 0.5f);
            monBar.RéapprovisionnerBar("Sirop de sucre de canne", 0.25f);
            monBar.RéapprovisionnerBar("Liqueur de café", 0.5f);
            monBar.RéapprovisionnerBar("Cranberry", 0.75f);
            monBar.RéapprovisionnerBar("Menthe", 0.2f);
            monBar.RéapprovisionnerBar("Feuilles de menthe", 0.2f);
            monBar.RéapprovisionnerBar("Tabasco", 0.1f);
            monBar.RéapprovisionnerBar("Angostura", 0.1f);  // Pour certains cocktails classiques
            monBar.RéapprovisionnerBar("Vermouth rouge", 0.5f);
            monBar.RéapprovisionnerBar("Vermouth blanc", 0.5f);
            monBar.RéapprovisionnerBar("Champagne", 1.0f);  // Pour les cocktails avec des bulles
            monBar.RéapprovisionnerBar("Prosecco", 1.0f);
            monBar.RéapprovisionnerBar("Bitter", 0.1f);
            monBar.RéapprovisionnerBar("Liqueur d'orange", 0.5f);
            monBar.RéapprovisionnerBar("Bière de gingembre", 1.0f);

            // Affichage du contenu du bar
            monBar.AfficherContenuBar();
        }
    }
}
