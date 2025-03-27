using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6tti_andras_cocktail
{
    public class Customer : Humain
    {
        public Customer(string name, DateTime birthDate, bool isWorkingHere)
            : base(name, birthDate, isWorkingHere)
        {
        }

        public void Order(Bartender bartender)
        {
            Console.WriteLine($"{Name}, que voulez-vous boire aujourd'hui ?");
            string cocktailName = Console.ReadLine();
            bartender.Prepare(cocktailName);
        }
    }
}

