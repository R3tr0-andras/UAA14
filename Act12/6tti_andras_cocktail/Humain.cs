using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6tti_andras_cocktail
{
    public class Humain
    {
        private string _name;
        private DateTime _date;
        private bool _isWorkingHere;
        public string Name { get { return _name; } }
        public DateTime Date { get { return _date; } }
        public bool IsWorkingHere { get {  return _isWorkingHere; } }

        public Humain(string name, DateTime date, bool isWorkingHere)
        {
            _name = name;
            _date = date;
            _isWorkingHere = IsWorkingHere;
        }
    }
}
