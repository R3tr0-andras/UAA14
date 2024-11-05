namespace _6ttiAndras_HERITAGE_Ex2
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            bool recommencer = true;

            while (recommencer)
            {
                Animal[] tab = new Animal[5];
                tab[0] = new Lapin(10, "Bugs", 1001, 30, false, "2023-01-15"); // lapin
                tab[1] = new Chat("Whiskers", 2001, 25, false, "2022-05-20"); // chat
                tab[2] = new Chat("Mittens", 2002, 23, true, "2021-11-30"); // chat
                tab[3] = new Chien("Rex", 3001, 50, true, "2020-03-10"); // chien
                tab[4] = new Chien("Buddy", 3002, 45, false, "2019-09-05"); // chien

                bool continuer = true;
                while (continuer)
                {
                    Console.WriteLine("\nChoisissez un animal :");
                    for (int i = 0; i < tab.Length; i++)
                    {
                        Console.WriteLine($"{i + 1}. {tab[i].Name} ({tab[i].GetType().Name})");
                    }
                    Console.WriteLine("0. Quitter");

                    int choixAnimal;
                    if (!int.TryParse(Console.ReadLine(), out choixAnimal) || choixAnimal < 0 || choixAnimal > tab.Length)
                    {
                        Console.WriteLine("Choix invalide. Veuillez réessayer.");
                        continue;
                    }

                    if (choixAnimal == 0)
                    {
                        continuer = false;
                        Console.WriteLine("Fin de la session.");
                        break;
                    }

                    Animal animalChoisi = tab[choixAnimal - 1];
                    Console.WriteLine($"\nVous avez choisi {animalChoisi.Name}. Que voulez-vous faire ?");
                    Console.WriteLine("1. Manger");
                    Console.WriteLine("2. Dormir");

                    if (animalChoisi is Chat)
                    {
                        Console.WriteLine("3. Ronronner");
                        Console.WriteLine("4. Miauler");
                    }
                    else if (animalChoisi is Chien)
                    {
                        Console.WriteLine("3. Aboyer");
                    }
                    else if (animalChoisi is Lapin)
                    {
                        Console.WriteLine("3. Bondir");
                    }

                    int choixAction;
                    if (!int.TryParse(Console.ReadLine(), out choixAction) || choixAction < 1 || choixAction > 4)
                    {
                        Console.WriteLine("Choix invalide. Veuillez réessayer.");
                        continue;
                    }
                    Console.Clear();
                    switch (choixAction)
                    {
                        case 1:
                            Console.WriteLine(animalChoisi.Manger());
                            break;
                        case 2:
                            Console.WriteLine(animalChoisi.Dors());
                            break;
                        case 3:
                            if (animalChoisi is Chat chat)
                                Console.WriteLine(chat.Ronronner());
                            else if (animalChoisi is Chien chien)
                                Console.WriteLine(chien.Aboyer());
                            else if (animalChoisi is Lapin lapin)
                                Console.WriteLine(lapin.Bondir());
                            break;
                        case 4:
                            if (animalChoisi is Chat chatMiaule)
                                Console.WriteLine(chatMiaule.Miauler());
                            else
                                Console.WriteLine("Action non disponible pour cet animal.");
                            break;
                    }
                }

                Console.WriteLine("\nVoulez-vous recommencer le programme ? (O/N)");
                string reponse = Console.ReadLine().Trim().ToUpper();
                recommencer = (reponse == "O" || reponse == "OUI");
            }

            Console.WriteLine("Merci d'avoir utilisé le programme. Au revoir !");
        }
    }
}