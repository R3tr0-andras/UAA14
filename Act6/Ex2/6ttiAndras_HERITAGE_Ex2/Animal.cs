using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6ttiAndras_HERITAGE_Ex2
{
    internal abstract class Animal
    {
        protected string _name;
        protected int _puceNum;
        protected int _size;
        protected bool _isCompetition;
        protected string _birthDay;

        public Animal(string name, int puceNum, int size, bool isCompetition, string birthDay) 
        { 
            _name = name;
            _puceNum = puceNum;
            _size = size;
            _isCompetition = isCompetition;
            _birthDay = birthDay;
        }

        public string Name {  get { return _name; } set { _name = value; } }
        public int PuceNum { get { return _puceNum; } set { _puceNum = value; } }
        public int Size { get { return _size; } set { _size = value; } }
        public bool IsCompetition { get { return _isCompetition; } set { _isCompetition = value; } }

        public virtual string Manger()
        {
            return $"{_name} : mange.";
        }
        public virtual string Dors()
        {
            return $"{_name} : Dors.";
        }
    }
}