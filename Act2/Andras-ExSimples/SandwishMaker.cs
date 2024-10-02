using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Andras_Ex3_SandwishAleatoires
{
    internal class SandwishMaker
    {
        private bool _chaud;
        private string[] _viande = { "Boeuf", "Poulet", "Porc", "Agneau", "Canard", "Dinde", "Veau", "Saucisse", "Bacon", "Jambon" };
        private string[] _pain = { "Baguette", "Pain de mie", "Pain complet", "Pain de seigle", "Pain aux céréales", "Pain brioché", "Pain pita", "Ciabatta", "Focaccia", "Pain au levain" };
        private string[] _crudite = { "Carotte", "Concombre", "Tomate", "Poivron", "Radis", "Chou-fleur", "Céleri", "Laitue", "Endive", "Oignon rouge" };

        public SandwishMaker() { }
        public string ComposerSandwish()
        {
            bool panini = Decider();
            string sandwish;
            if (panini)
            {
                sandwish = $"Panini avec ";
            } else
            {
                sandwish = $"Sandwish avec ";
            }
            sandwish += $"Viande : {_viande[Mixing()]}, Pain {_pain[Mixing()]}, Crudite : {_crudite[Mixing()]}";
            return sandwish;
        }
        public int Mixing()
        {
            Random alea = new Random();
            int aleaa = alea.Next(0, 9);
            return aleaa;
        }
        public bool Decider()
        {
            Random alea = new Random();
            return alea.Next(0, 2) == 1;
        }
    }
}
