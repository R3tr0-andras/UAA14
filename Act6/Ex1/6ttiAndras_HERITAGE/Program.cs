using _6ttiAndras_HERITAGE;
using System.Reflection;

namespace _6ttiAndras_HERITAGE_EX1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Voiture One = new Voiture("Série 4","BMW", "Noire", 100000, "Essence", true);
            Console.WriteLine(One.Afficher());
            

            Velo Two = new Velo("Bmw", "Scott", "Rouge", 250, "Beau velo", false);
            Console.WriteLine(Two.Afficher());
            
        }
    }
}