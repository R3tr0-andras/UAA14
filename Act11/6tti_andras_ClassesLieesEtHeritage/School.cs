using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6tti_andras_ClassesLieesEtHeritage
{
    internal class School
    {
        private string _name; //Nom de l'école
        private string _adress; //Adresse de l'école
        private string _webSite; //Lien du site internet
        private string _schoolCode; //?
        private List<Room> _roomList; //Liste des pièces de l'école
        private List<Department> _departmentList; //Liste des départements de l'école
        public string Name { get { return _name; } }
        public string Adress { get { return _adress; } }
        public string WebSite { get { return _webSite; } set { _webSite = value; } }
        public string SchoolCode {  get { return _schoolCode; } }
        public School(string name, string adress, string webSite, string schoolCode)
        {
            _name = name;
            _adress = adress;
            _webSite = webSite;
            _schoolCode = schoolCode;
            _roomList = new List<Room>();
            _departmentList = new List<Department>();
        }
    }
}
