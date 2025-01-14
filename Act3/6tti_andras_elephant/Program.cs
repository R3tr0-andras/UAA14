using System.Linq.Expressions;

namespace _6tti_andras_elephant
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans le programme des éléphants!");

            // Initialisation des 7 éléphants
            Elephant[] elephants = new Elephant[7]
            {
                new Elephant("Zazou", 50),
                new Elephant("Titi", 60),
                new Elephant("Dumbo", 75),
                new Elephant("Babar", 85),
                new Elephant("Mani", 40),
                new Elephant("Kiki", 55),
                new Elephant("Lola", 70)
            };

            bool running = true;
            while (running)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Afficher les caractéristiques d’un éléphant.");
                Console.WriteLine("2. Afficher les caractéristiques de tous les éléphants.");
                Console.WriteLine("3. Permuter deux éléphants.");
                Console.WriteLine("4. Envoyer un message entre deux éléphants.");
                Console.WriteLine("5. Trouver l’éléphant avec les plus grandes oreilles.");
                Console.WriteLine("6. Augmenter la taille des oreilles de tous les éléphants.");
                Console.WriteLine("7. Quitter.\n");

                Console.Write("Votre choix: ");
                string input = Console.ReadLine();

                if (byte.TryParse(input, out byte choix))
                {
                    switch (choix)
                    {
                        case 1:
                            AfficherUnElephant(elephants);
                            break;
                        case 2:
                            AfficherTousLesElephants(elephants);
                            break;
                        case 3:
                            PermuterElephants(elephants);
                            break;
                        case 4:
                            EnvoyerMessage(elephants);
                            break;
                        case 5:
                            TrouverPlusGrandesOreilles(elephants);
                            break;
                        case 6:
                            AugmenterTailleOreilles(elephants);
                            break;
                        case 7:
                            running = false;
                            Console.WriteLine("Au revoir !");
                            break;
                        default:
                            Console.WriteLine("Choix invalide. Veuillez choisir entre 1 et 7.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrée invalide. Veuillez entrer un nombre entre 1 et 7.");
                }
            }
        }

        static void AfficherUnElephant(Elephant[] elephants)
        {
            Console.Write("Entrez l’indice de l’éléphant (0 à 6): ");
            if (int.TryParse(Console.ReadLine(), out int index) && index >= 0 && index < elephants.Length)
            {
                Console.WriteLine(elephants[index].AfficheQuiJeSuis());
            }
            else
            {
                Console.WriteLine("Indice invalide. Veuillez entrer un nombre entre 0 et 6.");
            }
        }

        static void AfficherTousLesElephants(Elephant[] elephants)
        {
            Console.WriteLine("Liste des éléphants :");
            for (int i = 0; i < elephants.Length; i++)
            {
                Console.WriteLine($"Éléphant {i} : {elephants[i].AfficheQuiJeSuis()}");
            }
        }

        static void PermuterElephants(Elephant[] elephants)
        {
            Console.Write("Entrez l’indice du premier éléphant (0 à 6): ");
            if (int.TryParse(Console.ReadLine(), out int index1) && index1 >= 0 && index1 < elephants.Length)
            {
                Console.Write("Entrez l’indice du deuxième éléphant (0 à 6): ");
                if (int.TryParse(Console.ReadLine(), out int index2) && index2 >= 0 && index2 < elephants.Length)
                {
                    Elephant temp = elephants[index1];
                    elephants[index1] = elephants[index2];
                    elephants[index2] = temp;

                    Console.WriteLine("Les éléphants ont été permutés avec succès!");
                }
                else
                {
                    Console.WriteLine("Indice invalide pour le deuxième éléphant.");
                }
            }
            else
            {
                Console.WriteLine("Indice invalide pour le premier éléphant.");
            }
        }

        static void EnvoyerMessage(Elephant[] elephants)
        {
            Console.Write("Entrez l’indice de l’émetteur (0 à 6): ");
            if (int.TryParse(Console.ReadLine(), out int index1) && index1 >= 0 && index1 < elephants.Length)
            {
                Console.Write("Entrez l’indice du récepteur (0 à 6): ");
                if (int.TryParse(Console.ReadLine(), out int index2) && index2 >= 0 && index2 < elephants.Length)
                {
                    Console.Write("Entrez le message: ");
                    string message = Console.ReadLine();

                    elephants[index1].EnvoieMessage(message, elephants[index2]);
                }
                else
                {
                    Console.WriteLine("Indice invalide pour le récepteur.");
                }
            }
            else
            {
                Console.WriteLine("Indice invalide pour l’émetteur.");
            }
        }

        static void TrouverPlusGrandesOreilles(Elephant[] elephants)
        {
            Elephant plusGrand = elephants[0];
            for (int i = 1; i < elephants.Length; i++)
            {
                if (elephants[i].TailleOreilles > plusGrand.TailleOreilles)
                {
                    plusGrand = elephants[i];
                }
            }
            Console.WriteLine("L’éléphant avec les plus grandes oreilles est :");
            Console.WriteLine(plusGrand.AfficheQuiJeSuis());
        }

        static void AugmenterTailleOreilles(Elephant[] elephants)
        {
            Console.Write("De combien voulez-vous augmenter la taille des oreilles ? ");
            if (uint.TryParse(Console.ReadLine(), out uint augmentation))
            {
                for (int i = 0; i < elephants.Length; i++)
                {
                    elephants[i].TailleOreilles += augmentation;
                }
                Console.WriteLine($"Les tailles des oreilles de tous les éléphants ont été augmentées de {augmentation}.");
            }
            else
            {
                Console.WriteLine("Entrée invalide. Veuillez entrer un nombre entier positif.");
            }
        }
    }
}