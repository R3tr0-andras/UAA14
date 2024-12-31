using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaSuperCalculatriceDeDingue
{
    public abstract class Operation
    {
        public abstract double Calculer(IEnumerable<double> nombres);
    }
    public class Addition : Operation
    {
        public override double Calculer(IEnumerable<double> nombres)
        {
            return nombres.Sum();
        }
    }
    public class Soustraction : Operation
    {
        public override double Calculer(IEnumerable<double> nombres)
        {
            return nombres.Aggregate((a, b) => a - b);
        }
    }
    public class Multiplication : Operation
    {
        public override double Calculer(IEnumerable<double> nombres)
        {
            return nombres.Aggregate((a, b) => a * b);
        }
    }
    public class Division : Operation
    {
        public override double Calculer(IEnumerable<double> nombres)
        {
            return nombres.Aggregate((a, b) =>
            {
                if (b == 0)
                {
                    throw new DivideByZeroException("La division par zéro n'est pas permise.");
                }
                return a / b;
            });
        }
    }
    public class Puissance : Operation
    {
        public override double Calculer(IEnumerable<double> nombres)
        {
            return nombres.Aggregate((a, b) => Math.Pow(a, b));
        }
    }
    public class RacineCarree : Operation
    {
        public override double Calculer(IEnumerable<double> nombres)
        {
            if (nombres.Count() != 1)
            {
                throw new ArgumentException("La racine carrée nécessite un seul nombre.");
            }

            double nombre = nombres.First();
            if (nombre < 0)
            {
                throw new ArgumentException("La racine carrée d'un nombre négatif n'est pas permise.");
            }

            return Math.Sqrt(nombre);
        }
    }
    public class Equation : Operation
    {
        public override double Calculer(IEnumerable<double> nombres)
        {
            if (nombres.Count() != 2)
            {
                throw new ArgumentException("Une équation à une inconnue nécessite exactement deux valeurs : a et b pour ax + b = 0.");
            }

            double a = nombres.ElementAt(0);
            double b = nombres.ElementAt(1);

            if (a == 0)
            {
                throw new ArgumentException("Coefficient a ne peut pas être zéro dans une équation linéaire.");
            }

            return -b / a;
        }
    }
    public class EquationSecondDegre : Operation
    {
        public override double Calculer(IEnumerable<double> nombres)
        {
            if (nombres.Count() != 3)
            {
                throw new ArgumentException("Une équation du second degré nécessite exactement trois valeurs : a, b et c pour ax^2 + bx + c = 0.");
            }

            double a = nombres.ElementAt(0);
            double b = nombres.ElementAt(1);
            double c = nombres.ElementAt(2);

            double delta = b * b - 4 * a * c;
            Console.WriteLine($"Delta (Δ) = {delta}");

            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"Les solutions réelles sont : x1 = {x1}, x2 = {x2}");
                Console.WriteLine($"x = {x1} ou x = {x2}");
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                Console.WriteLine($"La solution réelle est : x = {x}");
            }
            else
            {
                Console.WriteLine("Le discriminant est négatif, il n'y a pas de solutions réelles.");
            }

            return 0;
        }
    }
    public class Derivee : Operation
    {
        public override double Calculer(IEnumerable<double> nombres)
        {
            List<double> resultats = new List<double>();
            int exposant = nombres.Count() - 1;

            for (int i = 0; i < nombres.Count(); i++)
            {
                double a = nombres.ElementAt(i);
                if (a != 0)
                {
                    resultats.Add(a * exposant);
                    exposant--;
                }
            }

            Console.WriteLine("La dérivée du polynôme est :");
            for (int i = 0; i < resultats.Count(); i++)
            {
                if (i == 0)
                    Console.Write(resultats[i] + "x^" + (nombres.Count() - i - 1));
                else
                    Console.Write(" + " + resultats[i] + "x^" + (nombres.Count() - i - 1));
            }
            Console.WriteLine();
            return 0;
        }
    }
    public class Primitive : Operation
    {
        public override double Calculer(IEnumerable<double> nombres)
        {
            List<double> resultats = new List<double>();
            int exposant = nombres.Count() - 1;

            for (int i = 0; i < nombres.Count(); i++)
            {
                double a = nombres.ElementAt(i);
                if (a != 0)
                {
                    resultats.Add(a / (exposant + 1));
                    exposant--;
                }
            }

            Console.WriteLine("La primitive du polynôme est :");
            for (int i = 0; i < resultats.Count(); i++)
            {
                if (i == 0)
                    Console.Write(resultats[i] + "x^" + (nombres.Count() - i));
                else
                    Console.Write(" + " + resultats[i] + "x^" + (nombres.Count() - i));
            }
            Console.WriteLine(" + C");
            return 0;
        }
    }
}