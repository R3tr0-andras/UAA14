using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6ttiAndras_HERITAGE_Ex2
{
    internal class Lapin : Animal
    {
        private int _oreilSize;
        public Lapin(int oreilSize, string name, int puceNum, int size, bool isCompetition, string birthDay) :
            base(name, puceNum, size, isCompetition, birthDay)
        {
            _oreilSize = oreilSize;
        }
        public string Bondir()
        {
            return $"{_name} : Bondis.";
        }
    }
}
