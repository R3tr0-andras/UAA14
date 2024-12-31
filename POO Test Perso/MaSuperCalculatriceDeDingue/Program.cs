using System;
using System.Collections.Generic;
using MaSuperCalculatriceDeDingue;

namespace MaSuperCalculatriceDeDingue
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculatrice calculatrice = new Calculatrice();

            while (true)  
            {
                Console.Clear();  
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Bienvenue dans la Super Calculatrice de Dingue !");
                Console.ResetColor();  

                Console.WriteLine("Choisissez une opération :");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Soustraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Puissance");
                Console.WriteLine("6. Racine carrée");
                Console.WriteLine("7. Résoudre une équation linéaire");
                Console.WriteLine("8. Résoudre une équation du second degré");
                Console.WriteLine("9. Calculer la dérivée d'un polynôme");
                Console.WriteLine("10. Calculer la primitive d'un polynôme");
                Console.WriteLine("11. Quitter");
                Console.Write("Entrez votre choix : ");

                string choix = Console.ReadLine();

                try
                {
                    if (choix == "11")  
                    {
                        break;
                    }

                    switch (choix)
                    {
                        case "1":
                            EffectuerOperation(calculatrice, new Addition());
                            break;
                        case "2":
                            EffectuerOperation(calculatrice, new Soustraction());
                            break;
                        case "3":
                            EffectuerOperation(calculatrice, new Multiplication());
                            break;
                        case "4":
                            EffectuerOperation(calculatrice, new Division());
                            break;
                        case "5":
                            EffectuerOperation(calculatrice, new Puissance());
                            break;
                        case "6":
                            EffectuerOperation(calculatrice, new RacineCarree());
                            break;
                        case "7":
                            EffectuerOperation(calculatrice, new Equation());
                            break;
                        case "8":
                            EffectuerOperation(calculatrice, new EquationSecondDegre());
                            break;
                        case "9":
                            EffectuerOperation(calculatrice, new Derivee());
                            break;
                        case "10":
                            EffectuerOperation(calculatrice, new Primitive());
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Choix invalide.");
                            Console.ResetColor();
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Erreur : {ex.Message}");
                    Console.ResetColor();
                }

                Console.WriteLine("\nVoulez-vous effectuer une autre opération ? (O/N)");
                string reponse = Console.ReadLine().ToUpper();

                if (reponse != "O")
                {
                    break;  
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Merci d'avoir utilisé la Super Calculatrice de Dingue !");
            Console.ResetColor();
        }
        static void EffectuerOperation(Calculatrice calculatrice, Operation operation)
        {
            Console.WriteLine("Entrez les nombres séparés par un espace : ");
            string input = Console.ReadLine();
            string[] inputValues = input.Split(' ');

            List<double> nombres = new List<double>();
            foreach (var val in inputValues)
            {
                if (double.TryParse(val, out double nombre))
                {
                    nombres.Add(nombre);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"La valeur {val} n'est pas un nombre valide.");
                    Console.ResetColor();
                    return;
                }
            }

            double result = calculatrice.EffectuerOperation(operation, nombres);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Le résultat de l'opération est : {result}");
            Console.ResetColor();
        }
    }
}