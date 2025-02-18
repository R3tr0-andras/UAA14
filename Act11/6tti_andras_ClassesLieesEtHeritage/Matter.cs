using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6tti_andras_ClassesLieesEtHeritage
{
    internal class Matter
    {
        private string _name; //Nom de la matière
        public string Name { get { return _name; } }
        public Matter(string name)
        {
            _name = name;
        }

        // Méthode pour calculer la moyenne de l'étudiant sur une matière
        public int Calculate()
        {
            return 0;
        }
    }
}
