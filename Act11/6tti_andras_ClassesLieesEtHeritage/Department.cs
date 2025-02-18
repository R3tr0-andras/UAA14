using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6tti_andras_ClassesLieesEtHeritage
{
    internal class Department
    {
        private string _name; //Nom du département
        private List<Teacher> _teacherList; //Liste des profs dans ce département
        public string Name => _name;
        public List<Teacher> Teachers => _teacherList;
        public Department(string name, List<Teacher> teacherList)
        {
            _name = name;
            _teacherList = teacherList;
        }
    }
}