using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6tti_andras_ClassesLieesEtHeritage
{
    public abstract class Humain
    {
        private string _name;
        private string _fName;
        private int _phone;
        private DateTime _date;

        public string Name { get { return _name; } }
        public string FName { get { return _fName; } }
        public int Phone { get { return _phone; } set { _phone = value; } }
        public DateTime Date { get { return _date; } set { _date = value; } }

        public Humain() 
        {
            _name = Name;
            _fName = FName;
            _phone = Phone;
            _date = Date;
        }

         void PrintProfil()
        {
            Console.WriteLine($"");
        }
    }
}
