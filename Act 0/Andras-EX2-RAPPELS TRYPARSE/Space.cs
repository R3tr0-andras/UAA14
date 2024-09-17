using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace tryparseRAPPELS
{
    public struct Space
    {
        public double First()
        {
            bool fini = true;
            bool ok = false;

            double value = 0;

            while (fini)
            {
                if (double.TryParse(Console.ReadLine(), out value) && value % 2 == 0)
                {
                    ok = true;
                }

                if (ok)
                {
                    fini = false;
                } else
                {
                    Console.Clear();
                    Console.WriteLine("Merci de recommencer avec un nombre valide");
                }
            }

            Console.WriteLine("Ce nombre est bien divisible par 2");
            return value;
        }

        public void Second()
        {
            bool fini = true;

            while (fini)
            {
                Console.WriteLine("Veuillez choisir ce que vous souhaitez faire :");
                Console.WriteLine("1 : la couleur du texte");
                Console.WriteLine("2 : la couleur du fond");

                byte choix = byte.Parse(Console.ReadLine());
                if (choix == 1)
                {
                    Console.WriteLine("Par quel couleur souhaitez vous changer le texte ?");
                    Console.WriteLine("Nous avons :\n - Black\n - DarkBlue\n - DarkGreen\n" +
                        " - DarkCyan\n - DarkRed\n - DarkMagenta\n - DarkYellow\n" +
                        " - Gray\n - DarkGray\n - Blue\n - Green\n - Cyan\n - Red\n - Magenta\n - Yellow\n");

                    string color = Console.ReadLine();
                    ConsoleColor consoleColor;

                    if (Enum.TryParse(color, true, out consoleColor))
                    {
                        Console.ForegroundColor = consoleColor;
                        Console.Clear();
                        Console.WriteLine("La couleur d'arrière-plan a été changée !");

                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Couleur invalide !");
                    }
                } else if (choix == 2)
                {
                    Console.WriteLine("Par quel couleur souhaitez vous changer le fond ?");
                    Console.WriteLine("Nous avons :\n - Black\n - DarkBlue\n - DarkGreen\n" +
                        " - DarkCyan\n - DarkRed\n - DarkMagenta\n - DarkYellow\n" +
                        " - Gray\n - DarkGray\n - Blue\n - Green\n - Cyan\n - Red\n - Magenta\n - Yellow\n");

                    string color = Console.ReadLine();
                    ConsoleColor consoleColor;

                    if (Enum.TryParse(color, true, out consoleColor))
                    {
                        Console.BackgroundColor = consoleColor;
                        Console.Clear();
                        Console.WriteLine("La couleur d'arrière-plan a été changée !");
                        
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Couleur invalide !");
                    }
                }
                Console.WriteLine("Voulez-vous continuer à modifier ? (Oui/Non)");
                string? choixContinuerInput = Console.ReadLine();

                if (choixContinuerInput != null)
                {
                    choixContinuerInput = choixContinuerInput.ToLower();
                    if (choixContinuerInput == "non")
                    {
                        fini = false;
                    }
                    else if (choixContinuerInput == "oui")
                    {
                        Console.Clear();
                    }
                }
            }
        }
    }
}