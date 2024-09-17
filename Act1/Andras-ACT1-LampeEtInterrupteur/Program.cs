using System.Diagnostics;
using System.Collections.Generic;

namespace Andras_ACT1_LampeEtInterrupteur
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Structure structure = new Structure();
            bool end = true;
            List<Lampe> luminaires = new List<Lampe>();
            List<Interrupteur> buttons = new List<Interrupteur>();
            string input = "";

            while (end)
            {
                Console.Clear();
                Console.WriteLine("1. Ajouter une Lampe");
                Console.WriteLine("2. Afficher les Lampes");
                Console.WriteLine("3. Afficher les Interrupteurs");
                Console.WriteLine("4. Utiliser un Interrupteur");
                Console.WriteLine("5. Quitter");
                Console.Write("Choisissez une option : ");
                input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        structure.AjouterLampe(luminaires, buttons);
                        break;
                    case "2":
                        structure.AfficherLampes(luminaires);
                        break;
                    case "3":
                        structure.AfficherInterrupteurs(buttons);
                        break;
                    case "4":
                        structure.UtiliserInterrupteur(buttons);
                        break;
                    case "5":
                        end = false;
                        break;
                    default:
                        Console.WriteLine("Option invalide. Veuillez réessayer.");
                        break;
                }
            }
        }
    }
}