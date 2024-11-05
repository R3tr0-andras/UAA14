﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6ttiAndras_HERITAGE_Ex2
{
    internal class Chien : Animal
    {
        public Chien(string name, int puceNum, int size, bool isCompetition, string birthDay) :
            base(name, puceNum, size, isCompetition, birthDay)
        {

        }
        public override string Manger()
        {
            return $"{_name} : mange.";
        }
        public override string Dors()
        {
            return $"{_name} : dors.";
        }

        public string Aboyer()
        {
            return $"{_name} : aboie.";
        }

    }
}
