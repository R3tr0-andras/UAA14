using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _6tti_andras_ClassesLieesEtHeritage
{
    internal class Lesson
    {
        private string _name; //Nom de la lesson
        public string Name { get { return _name; } }
        public Lesson(string name) 
        {
            _name = name;
        }
    }
}
