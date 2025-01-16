using System;
using System.Collections.Generic;

namespace _6tti_andras_reflectionClasseLiees_Ex
{
    class Program
    {
        static Bibliotheque bibliotheque = new Bibliotheque();
        static List<Humain> utilisateurs = new List<Humain>();

        static void Main(string[] args)
        {
            bool continuer = true;
            while (continuer)
            {
                AfficherMenu();
                string choix = Console.ReadLine();
                TraiterChoix(choix);
                Console.WriteLine("\nAppuyez sur une touche pour continuer...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void AfficherMenu()
        {
            Console.WriteLine("=== Menu Principal ===");
            Console.WriteLine("1. Ajouter un livre");
            Console.WriteLine("2. Afficher l'inventaire de la bibliothèque");
            Console.WriteLine("3. Créer un utilisateur");
            Console.WriteLine("4. Emprunter un livre");
            Console.WriteLine("5. Rendre un livre");
            Console.WriteLine("6. Afficher les emprunts d'un utilisateur");
            Console.WriteLine("7. Dégrader l'état d'un livre");
            Console.WriteLine("8. Quitter");
            Console.Write("Votre choix : ");
        }

        static void TraiterChoix(string choix)
        {
            switch (choix)
            {
                case "1":
                    AjouterLivre();
                    break;
                case "2":
                    AfficherInventaire();
                    break;
                case "3":
                    CreerUtilisateur();
                    break;
                case "4":
                    EmprunterLivre();
                    break;
                case "5":
                    RendreLivre();
                    break;
                case "6":
                    AfficherEmpruntsUtilisateur();
                    break;
                case "7":
                    DegraderLivre();
                    break;
                case "8":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Choix invalide. Veuillez réessayer.");
                    break;
            }
        }

        static void AjouterLivre()
        {
            Console.Write("Titre du livre : ");
            string titre = Console.ReadLine();
            Console.Write("Nom de l'auteur : ");
            string auteur = Console.ReadLine();
            Console.Write("État du livre (0-5) : ");
            byte etat = byte.Parse(Console.ReadLine());

            Livre nouveauLivre = new Livre(titre, auteur, etat);
            bibliotheque.ajoute(nouveauLivre);
            Console.WriteLine("Livre ajouté avec succès.");
        }

        static void AfficherInventaire()
        {
            Console.WriteLine("Inventaire de la bibliothèque :");
            Console.WriteLine(bibliotheque.inventaire());
        }

        static void CreerUtilisateur()
        {
            Console.Write("Nom de l'utilisateur : ");
            string nom = Console.ReadLine();
            Humain nouvelUtilisateur = new Humain(nom);
            utilisateurs.Add(nouvelUtilisateur);
            Console.WriteLine("Utilisateur créé avec succès.");
        }

        static void EmprunterLivre()
        {
            if (utilisateurs.Count == 0 || bibliotheque.Livres.Count == 0)
            {
                Console.WriteLine("Pas d'utilisateurs ou de livres disponibles.");
                return;
            }

            Console.WriteLine("Choisissez un utilisateur :");
            for (int i = 0; i < utilisateurs.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {utilisateurs[i].Nom}");
            }
            int choixUtilisateur = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine("Choisissez un livre :");
            for (int i = 0; i < bibliotheque.Livres.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {bibliotheque.Livres[i].Titre}");
            }
            int choixLivre = int.Parse(Console.ReadLine()) - 1;

            Emprunt nouvelEmprunt = new Emprunt(bibliotheque.Livres[choixLivre], DateTime.Now, utilisateurs[choixUtilisateur]);
            utilisateurs[choixUtilisateur].Emprunter(nouvelEmprunt);
            Console.WriteLine("Livre emprunté avec succès.");
        }

        static void RendreLivre()
        {
            if (utilisateurs.Count == 0)
            {
                Console.WriteLine("Pas d'utilisateurs disponibles.");
                return;
            }

            Console.WriteLine("Choisissez un utilisateur :");
            for (int i = 0; i < utilisateurs.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {utilisateurs[i].Nom}");
            }
            int choixUtilisateur = int.Parse(Console.ReadLine()) - 1;

            if (utilisateurs[choixUtilisateur].Emprunts.Count == 0)
            {
                Console.WriteLine("Cet utilisateur n'a pas d'emprunts.");
                return;
            }

            Console.WriteLine("Choisissez un livre à rendre :");
            for (int i = 0; i < utilisateurs[choixUtilisateur].Emprunts.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {utilisateurs[choixUtilisateur].Emprunts[i].Livre.Titre}");
            }
            int choixLivre = int.Parse(Console.ReadLine()) - 1;

            utilisateurs[choixUtilisateur].RendreLivreParIndex(choixLivre);
            Console.WriteLine("Livre rendu avec succès.");
        }

        static void AfficherEmpruntsUtilisateur()
        {
            if (utilisateurs.Count == 0)
            {
                Console.WriteLine("Pas d'utilisateurs disponibles.");
                return;
            }

            Console.WriteLine("Choisissez un utilisateur :");
            for (int i = 0; i < utilisateurs.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {utilisateurs[i].Nom}");
            }
            int choixUtilisateur = int.Parse(Console.ReadLine()) - 1;

            Console.WriteLine($"Emprunts de {utilisateurs[choixUtilisateur].Nom} :");
            foreach (var emprunt in utilisateurs[choixUtilisateur].Emprunts)
            {
                Console.WriteLine(emprunt.Livre.Titre);
            }
        }

        static void DegraderLivre()
        {
            if (bibliotheque.Livres.Count == 0)
            {
                Console.WriteLine("Pas de livres disponibles.");
                return;
            }

            Console.WriteLine("Choisissez un livre à dégrader :");
            for (int i = 0; i < bibliotheque.Livres.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {bibliotheque.Livres[i].Titre}");
            }
            int choixLivre = int.Parse(Console.ReadLine()) - 1;

            Console.Write("Nouvel état du livre (0-5) : ");
            byte nouvelEtat = byte.Parse(Console.ReadLine());

            bibliotheque.Livres[choixLivre].degrade(nouvelEtat);
            Console.WriteLine("État du livre mis à jour.");
            Console.WriteLine(bibliotheque.Livres[choixLivre].description());
        }
    }
}