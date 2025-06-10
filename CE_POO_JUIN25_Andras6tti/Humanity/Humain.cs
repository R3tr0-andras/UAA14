using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CE_POO_JUIN25_Andras6tti.Humanity
{
    public abstract class Humain
    {
        protected int _id;
        protected string _name;
        protected string _surname;

        public int Id { get { return _id; } set { _id = value; } }
        public string Name { get { return _surname; } }
        public string Surname { get { return _surname; } }

    }
}
